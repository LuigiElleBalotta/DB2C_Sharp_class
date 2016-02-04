using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Areatrigger_teleport
	{
		int ID = 0; //Comment: 
		int OLD_ID = 0;

		int PortLocID = 0; //Comment: 
		int OLD_PortLocID = 0;

		string Name = null; //Comment: 
		string OLD_Name = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Areatrigger_teleport(int _ID, int _PortLocID, string _Name)
		{
			ID = _ID;
			PortLocID = _PortLocID;
			Name = _Name;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM areatrigger_teleport WHERE ID = @ID AND PortLocID = @PortLocID AND Name = @Name;";
			MySqlParameter idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter portlocidParameter = new MySqlParameter("@PortLocID", MySqlDbType.VarChar, 0);
			MySqlParameter nameParameter = new MySqlParameter("@Name", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			portlocidParameter.Value = PortLocID;
			nameParameter.Value = Name;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(portlocidParameter);
			cmd.Parameters.Add(nameParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE areatrigger_teleport SET ID = @newID, PortLocID = @newPortLocID, Name = @newName WHERE ID = @ID AND PortLocID = @PortLocID AND Name = @Name;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_portlocidParameter = new MySqlParameter("@PortLocID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_nameParameter = new MySqlParameter("@Name", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newID", MySqlDbType.VarChar, 0);
			MySqlParameter portlocidParameter = new MySqlParameter("@newPortLocID", MySqlDbType.VarChar, 0);
			MySqlParameter nameParameter = new MySqlParameter("@newName", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			portlocidParameter.Value = PortLocID;
			nameParameter.Value = Name;
			OLD_idParameter.Value = OLD_ID;
			OLD_portlocidParameter.Value = OLD_PortLocID;
			OLD_nameParameter.Value = OLD_Name;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(portlocidParameter);
			cmd.Parameters.Add(nameParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_portlocidParameter);
			cmd.Parameters.Add(OLD_nameParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_ID = ID;
			OLD_PortLocID = PortLocID;
			OLD_Name = Name;
		}
	}
}
