using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Instance_template
	{
		int map = 0; //Comment: 
		int OLD_map = 0;

		int parent = 0; //Comment: 
		int OLD_parent = 0;

		string script = null; //Comment: 
		string OLD_script = null;

		int allowMount = 0; //Comment: 
		int OLD_allowMount = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Instance_template(int _map, int _parent, string _script, int _allowMount)
		{
			map = _map;
			parent = _parent;
			script = _script;
			allowMount = _allowMount;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM instance_template WHERE map = @map AND parent = @parent AND script = @script AND allowMount = @allowMount;";
			MySqlParameter mapParameter = new MySqlParameter("@map", MySqlDbType.VarChar, 0);
			MySqlParameter parentParameter = new MySqlParameter("@parent", MySqlDbType.VarChar, 0);
			MySqlParameter scriptParameter = new MySqlParameter("@script", MySqlDbType.VarChar, 0);
			MySqlParameter allowmountParameter = new MySqlParameter("@allowMount", MySqlDbType.VarChar, 0);
			mapParameter.Value = map;
			parentParameter.Value = parent;
			scriptParameter.Value = script;
			allowmountParameter.Value = allowMount;
			cmd.Parameters.Add(mapParameter);
			cmd.Parameters.Add(parentParameter);
			cmd.Parameters.Add(scriptParameter);
			cmd.Parameters.Add(allowmountParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE instance_template SET map = @newmap, parent = @newparent, script = @newscript, allowMount = @newallowMount WHERE map = @map AND parent = @parent AND script = @script AND allowMount = @allowMount;";
			MySqlParameter OLD_mapParameter = new MySqlParameter("@map", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_parentParameter = new MySqlParameter("@parent", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_scriptParameter = new MySqlParameter("@script", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_allowmountParameter = new MySqlParameter("@allowMount", MySqlDbType.VarChar, 0);
			MySqlParameter mapParameter = new MySqlParameter("@newmap", MySqlDbType.VarChar, 0);
			MySqlParameter parentParameter = new MySqlParameter("@newparent", MySqlDbType.VarChar, 0);
			MySqlParameter scriptParameter = new MySqlParameter("@newscript", MySqlDbType.VarChar, 0);
			MySqlParameter allowmountParameter = new MySqlParameter("@newallowMount", MySqlDbType.VarChar, 0);
			mapParameter.Value = map;
			parentParameter.Value = parent;
			scriptParameter.Value = script;
			allowmountParameter.Value = allowMount;
			OLD_mapParameter.Value = OLD_map;
			OLD_parentParameter.Value = OLD_parent;
			OLD_scriptParameter.Value = OLD_script;
			OLD_allowmountParameter.Value = OLD_allowMount;
			cmd.Parameters.Add(mapParameter);
			cmd.Parameters.Add(parentParameter);
			cmd.Parameters.Add(scriptParameter);
			cmd.Parameters.Add(allowmountParameter);
			cmd.Parameters.Add(OLD_mapParameter);
			cmd.Parameters.Add(OLD_parentParameter);
			cmd.Parameters.Add(OLD_scriptParameter);
			cmd.Parameters.Add(OLD_allowmountParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_map = map;
			OLD_parent = parent;
			OLD_script = script;
			OLD_allowMount = allowMount;
		}
	}
}
