using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace PersonLibrary
{
    public class ProfessionList: List<ProfessionInfo>
    {
        public static ProfessionList GetDefaultProfessionList()
        {
            ProfessionList myList = new ProfessionList();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source = DESKTOP-A7291VB\SQLEXPRESS;Initial Catalog = PersonDB; Integrated Security = True";
            cn.Open();
            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetProfessionList";

            SqlDataReader dr = cm.ExecuteReader();
            
            while (dr.Read())
            {
                ProfessionInfo newProfession = new ProfessionInfo();
                newProfession.ProfessionID = (int)dr["ProfessionID"];
                newProfession.ProfessionName = dr["ProfessionName"].ToString();
                myList.Add(newProfession);

            }
            return myList;
        }
    }
}