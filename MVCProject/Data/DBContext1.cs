using System.Data;
using System.Configuration;
using MVCProject.Models.Task_4;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;

namespace MVCProject.Models.service
{
    public class Accessing_DB
    {
        ////public string conString = "Server=LEGION\\SQLEXPRESS; Database=MVCPROJECT;Integrated Security=True;Encrypt=False; TrustServerCertificate=True;";
        ////public string conString = ConfigurationManager.getconstr();
        ////string conStrin = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        ////private string conString = ConnectionStringSettings.ToString();
        //public string conString { get; set; }
        ////public IConfiguration _con { get; set; }

        ////public Accessing_DB() { }

        //public Accessing_DB(string con) 
        //{
        //    //this._con = con;
        //    conString = con;
        //}

        public string conString;

        public Accessing_DB(IConfiguration configuration)
        {
            conString = configuration.GetConnectionString("DefaultConnection");
        }

        

        // Get data
        public List<DB_Model1> GetData()
        {
            var dB_Model_list = new List<DB_Model1>();

            try
            {
                using (var con = new SqlConnection(conString))
                using (var command = new SqlCommand("GETALLDATA", con))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    con.Open();

                    using (var adapter = new SqlDataAdapter(command))
                    {
                        var dbtable = new DataTable();
                        adapter.Fill(dbtable);

                        foreach (DataRow dr in dbtable.Rows)
                        {
                            dB_Model_list.Add(new DB_Model1
                            {
                                ID = Convert.ToInt32(dr["ID"]),
                                Name = Convert.ToString(dr["Name"]),
                                Age = Convert.ToInt32(dr["Age"]),
                                city = Convert.ToString(dr["city"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                // e.g., Console.WriteLine(ex.Message);
            }

            return dB_Model_list;
        }
    }
}
