using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Updates_include
	{
		string path = null; //Comment: directory to include. $ means relative to the source directory.
		string OLD_path = null;

		string state = "RELEASED"; //Comment: defines if the directory contains released or archived updates.
		string OLD_state = "RELEASED";

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Updates_include(string _path, string _state)
		{
			path = _path;
			state = _state;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM updates_include WHERE path = @path AND state = @state;";
			MySqlParameter pathParameter = new MySqlParameter("@path", MySqlDbType.VarChar, 0);
			MySqlParameter stateParameter = new MySqlParameter("@state", MySqlDbType.VarChar, 0);
			pathParameter.Value = path;
			stateParameter.Value = state;
			cmd.Parameters.Add(pathParameter);
			cmd.Parameters.Add(stateParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE updates_include SET path = @newpath, state = @newstate WHERE path = @path AND state = @state;";
			MySqlParameter OLD_pathParameter = new MySqlParameter("@path", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_stateParameter = new MySqlParameter("@state", MySqlDbType.VarChar, 0);
			MySqlParameter pathParameter = new MySqlParameter("@newpath", MySqlDbType.VarChar, 0);
			MySqlParameter stateParameter = new MySqlParameter("@newstate", MySqlDbType.VarChar, 0);
			pathParameter.Value = path;
			stateParameter.Value = state;
			OLD_pathParameter.Value = OLD_path;
			OLD_stateParameter.Value = OLD_state;
			cmd.Parameters.Add(pathParameter);
			cmd.Parameters.Add(stateParameter);
			cmd.Parameters.Add(OLD_pathParameter);
			cmd.Parameters.Add(OLD_stateParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_path = path;
			OLD_state = state;
		}
	}
}
