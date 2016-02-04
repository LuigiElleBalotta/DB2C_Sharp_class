using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Spell_script_names
	{
		int spell_id = 0; //Comment: 
		int OLD_spell_id = 0;

		char ScriptName = Char.MinValue; //Comment: 
		char OLD_ScriptName = Char.MinValue;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Spell_script_names(int _spell_id, char _ScriptName)
		{
			spell_id = _spell_id;
			ScriptName = _ScriptName;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM spell_script_names WHERE spell_id = @spell_id AND ScriptName = @ScriptName;";
			MySqlParameter spell_idParameter = new MySqlParameter("@spell_id", MySqlDbType.VarChar, 0);
			MySqlParameter scriptnameParameter = new MySqlParameter("@ScriptName", MySqlDbType.VarChar, 0);
			spell_idParameter.Value = spell_id;
			scriptnameParameter.Value = ScriptName;
			cmd.Parameters.Add(spell_idParameter);
			cmd.Parameters.Add(scriptnameParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE spell_script_names SET spell_id = @newspell_id, ScriptName = @newScriptName WHERE spell_id = @spell_id AND ScriptName = @ScriptName;";
			MySqlParameter OLD_spell_idParameter = new MySqlParameter("@spell_id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_scriptnameParameter = new MySqlParameter("@ScriptName", MySqlDbType.VarChar, 0);
			MySqlParameter spell_idParameter = new MySqlParameter("@newspell_id", MySqlDbType.VarChar, 0);
			MySqlParameter scriptnameParameter = new MySqlParameter("@newScriptName", MySqlDbType.VarChar, 0);
			spell_idParameter.Value = spell_id;
			scriptnameParameter.Value = ScriptName;
			OLD_spell_idParameter.Value = OLD_spell_id;
			OLD_scriptnameParameter.Value = OLD_ScriptName;
			cmd.Parameters.Add(spell_idParameter);
			cmd.Parameters.Add(scriptnameParameter);
			cmd.Parameters.Add(OLD_spell_idParameter);
			cmd.Parameters.Add(OLD_scriptnameParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_spell_id = spell_id;
			OLD_ScriptName = ScriptName;
		}
	}
}
