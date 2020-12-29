using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace PersonLibrary
{
    public class PersonList : List<PersonInfo>
    {
        public static PersonList GetDefaultPersonList()
        {
            PersonList myList = new PersonList();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source = DESKTOP-A7291VB\SQLEXPRESS;Initial Catalog = PersonDB; Integrated Security = True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetPersonList";

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                PersonInfo newPerson = new PersonInfo();
                newPerson.PersonID = (int)dr["Personid"];
                newPerson.PersonFirstName = dr["PersonFirstName"].ToString();
                newPerson.PersonSecondName = dr["PersonSecondName"].ToString();
                newPerson.PersonDateBirth = (DateTime)dr["PersonDateBirth"];
                newPerson.ProfessionName = dr["ProfessionName"].ToString();
                newPerson.ProfessionID = (int)dr["ProfessionID"];
                myList.Add(newPerson);

            }
            return myList;

        }
    }
}
