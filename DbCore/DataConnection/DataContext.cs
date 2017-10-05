using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Core.Entity;

namespace Core.DataConnection
{
    public class DataContext
    {

        private SqlConnection con;
        //To Handle connection related activities
        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            con = new SqlConnection(constr);

        }
        //To Add Employee details
        public bool AddForm(Form obj)
        {

            connection();
            SqlCommand com = new SqlCommand("Insert_Form", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@UnitId", obj.UnitId);
            com.Parameters.AddWithValue("@Name", obj.Name);
            com.Parameters.AddWithValue("@Discription", obj.Discription);

            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
