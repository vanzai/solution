using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PersonLibrary
{
    public class PersonInfo
    {
        private int _personID = 0;
        private string _personFirstName = "";
        private DateTime _personDateBirth = DateTime.Today;
        private string _personSecondName = "";
        private int _professionID = 0;
        private string _professionName = "";

        public string ProfessionName
        {
            get
            {
                return _professionName;
            }
            set
            {
                _professionName = value;
            }
        }

        public int ProfessionID
        {
            get
            {
                return _professionID;
            }
            set
            {
                _professionID = value;
            }
        }

        public string PersonFirstName
        {
            get
            {
                return _personFirstName;
            }
            set
            {
                _personFirstName = value;
            }
        }

        public DateTime PersonDateBirth
        {
            get
            {
                return _personDateBirth;
            }
            set
            {
                _personDateBirth = value;
            }
        }

        public int PersonAge
        {
            get
            {
                return DateTime.Today.Year - _personDateBirth.Year;
            }
            set
            {

            }
        }

        public int PersonID
        {
            get
            {
                return _personID;
            }
            set
            {
                _personID = value;
            }
        }

        public string PersonFullName
        {
            get
            {
                return _personFirstName + " " + _personSecondName;
            }
            set
            {
            }
        }

        public string PersonSecondName
        {
            get
            {
                return _personSecondName;
            }
            set
            {
                _personSecondName = value;
            }
        }

        public void InsertNewPerson()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source = DESKTOP-A7291VB\SQLEXPRESS;Initial Catalog = PersonDB; Integrated Security = True";
            cn.Open();
            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "InsertPerson";

            cm.Parameters.Add(new SqlParameter("@PersonFirstName", _personFirstName));
            cm.Parameters.Add(new SqlParameter("@PersonSecondName", _personSecondName));
            cm.Parameters.Add(new SqlParameter("@PersonDateBirth", _personDateBirth));
            cm.Parameters.Add(new SqlParameter("@ProfessionID", _professionID));

            cm.ExecuteNonQuery();
        }

        public void DeletePerson()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source = DESKTOP-A7291VB\SQLEXPRESS;Initial Catalog = PersonDB; Integrated Security = True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "DeletePerson";

            cm.Parameters.Add(new SqlParameter("@PersonID", _personID));

            cm.ExecuteNonQuery();
        }

        public void UpdatePerson()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source = DESKTOP-A7291VB\SQLEXPRESS;Initial Catalog = PersonDB; Integrated Security = True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "UpdatePerson";



            cm.Parameters.Add(new SqlParameter("@PersonID", _personID));
            cm.Parameters.Add(new SqlParameter("@PersonFirstName", _personFirstName));
            cm.Parameters.Add(new SqlParameter("@PersonSecondName", _personSecondName));
            cm.Parameters.Add(new SqlParameter("@PersonDateBirth", _personDateBirth));
            cm.Parameters.Add(new SqlParameter("@ProfessionID", _professionID));

            cm.ExecuteNonQuery();
        }

        public void GetPerson(int personID)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source = DESKTOP-A7291VB\SQLEXPRESS;Initial Catalog = PersonDB; Integrated Security = True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetPerson";

            cm.Parameters.Add(new SqlParameter("@PersonID", _personID));

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                _personFirstName = dr["PersonFirstName"].ToString();
                _personSecondName = dr["PersonSecondName"].ToString();
                _personDateBirth = (DateTime)dr["PersonDateBirth"];
                _personID = (int)dr["Personid"];
                _professionID = (int)dr["ProfessionID"];
                _professionName = dr["ProfessionName"].ToString();
            }


        }

    }
}
