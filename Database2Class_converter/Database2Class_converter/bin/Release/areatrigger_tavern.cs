using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Areatrigger_tavern
	{
		int id = 0; //Comment: Identifier
		int OLD_id = 0;

		string name = null; //Comment: 
		string OLD_name = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Areatrigger_tavern(int _id, string _name)
		{
			id = _id;
			name = _name;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM areatrigger_tavern WHERE id = @id AND name = @name;";
			MySqlParameter idParameter = new MySqlParameter("@id", MySqlDbType.VarChar, 0);
			MySqlParameter nameParameter = new MySqlParameter("@name", MySqlDbType.VarChar, 0);
			idParameter.Value = id;
			nameParameter.Value = name;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(nameParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE areatrigger_tavern SET id = @newid, name = @newname WHERE id = @id AND name = @name;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_nameParameter = new MySqlParameter("@name", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newid", MySqlDbType.VarChar, 0);
			MySqlParameter nameParameter = new MySqlParameter("@newname", MySqlDbType.VarChar, 0);
			idParameter.Value = id;
			nameParameter.Value = name;
			OLD_idParameter.Value = OLD_id;
			OLD_nameParameter.Value = OLD_name;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(nameParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_nameParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_id = id;
			OLD_name = name;
		}
	}
}
