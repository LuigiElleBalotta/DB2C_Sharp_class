using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Areatrigger_scripts
	{
		int entry = 0; //Comment: 
		int OLD_entry = 0;

		char ScriptName = Char.MinValue; //Comment: 
		char OLD_ScriptName = Char.MinValue;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Areatrigger_scripts(int _entry, char _ScriptName)
		{
			entry = _entry;
			ScriptName = _ScriptName;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM areatrigger_scripts WHERE entry = @entry AND ScriptName = @ScriptName;";
			MySqlParameter entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter scriptnameParameter = new MySqlParameter("@ScriptName", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			scriptnameParameter.Value = ScriptName;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(scriptnameParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE areatrigger_scripts SET entry = @newentry, ScriptName = @newScriptName WHERE entry = @entry AND ScriptName = @ScriptName;";
			MySqlParameter OLD_entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_scriptnameParameter = new MySqlParameter("@ScriptName", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@newentry", MySqlDbType.VarChar, 0);
			MySqlParameter scriptnameParameter = new MySqlParameter("@newScriptName", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			scriptnameParameter.Value = ScriptName;
			OLD_entryParameter.Value = OLD_entry;
			OLD_scriptnameParameter.Value = OLD_ScriptName;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(scriptnameParameter);
			cmd.Parameters.Add(OLD_entryParameter);
			cmd.Parameters.Add(OLD_scriptnameParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_entry = entry;
			OLD_ScriptName = ScriptName;
		}
	}
}
