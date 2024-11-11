using System.Data;
using System.Configuration;
using MVCProject.Models.Task_4;
using Microsoft.Data.SqlClient;


namespace Data_Layer
{
	//public class DBContext1 : DbContext
	//{
	//	public DBContext1(DbContextOptions options) : base(options) { }

	//	//public DbSet<DB_Model1>
	//}

	public class Accessing_DB
	{
		string conString = ConfigurationManager.

		// Get data

		public List<DB_Model1> GetData()
		{
			List<DB_Model1> dB_Model_list = new List<DB_Model1>();

			using (Microsoft.Data.SqlClient.SqlConnection con = new SqlConnection(conString))
			{
				SqlCommand command = con.CreateCommand();
				command.CommandType = CommandType.StoredProcedure;
				command.CommandText = "sp_getalldata";
				SqlDataAdapter adapter = new SqlDataAdapter(command);
				DataTable dbtable = new DataTable();

				con.Open();
				adapter.Fill(dbtable);
				con.Close();

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

				return dB_Model_list;
			}
		}
	}
}
