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
    public partial class PersonEditForm : Form
    {
        public PersonInfo _newPerson = new PersonInfo();
        public PersonEditForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_newPerson.PersonID > 0)
            {
                _newPerson.UpdatePerson();
            }
            else 
            {
                _newPerson.InsertNewPerson();
            }

        }

        private void PersonEditForm_Load(object sender, EventArgs e)
        {
            ProfessionList _professionList = ProfessionList.GetDefaultProfessionList();
            professionlistbildingSource.DataSource = _professionList;

            personInfoBindingSource.DataSource = _newPerson;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
