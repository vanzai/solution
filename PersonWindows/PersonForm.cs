using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonLibrary;

namespace PersonWindows
{
    public partial class Form1 : Form
    {
        PersonList _personList = new PersonList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh_();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonEditForm newForm = new PersonEditForm();

            newForm.ShowDialog();
            Refresh_();
        }
        void Refresh_()
        {
            _personList = PersonList.GetDefaultPersonList();
            personListBindingSource.DataSource = null;
            personListBindingSource.DataSource = _personList;
        }

        private void personInfoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            int perID = (int)personInfoDataGridView.SelectedRows[0].Cells[0].Value;

            foreach (PersonInfo person in _personList)
            {
                Console.WriteLine(person.PersonID);
                if (person.PersonID == perID)
                {
                    person.DeletePerson();
                }
            }
            Refresh_();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int perID = (int)personInfoDataGridView.SelectedRows[0].Cells[0].Value;

            PersonEditForm newForm = new PersonEditForm();

            foreach (PersonInfo person in _personList)
            {
                if (person.PersonID == perID)
                {
                    person.GetPerson(perID);
                    newForm._newPerson = person;
                    if (newForm.ShowDialog() == DialogResult.OK)
                    {
                        newForm._newPerson.UpdatePerson();
                    }
                }
            }
            Refresh_();
        }
    }
}
