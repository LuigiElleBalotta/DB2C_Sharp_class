using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Spell_learn_spell
	{
		int entry = 0; //Comment: 
		int OLD_entry = 0;

		int SpellID = 0; //Comment: 
		int OLD_SpellID = 0;

		int Active = 1; //Comment: 
		int OLD_Active = 1;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Spell_learn_spell(int _entry, int _SpellID, int _Active)
		{
			entry = _entry;
			SpellID = _SpellID;
			Active = _Active;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM spell_learn_spell WHERE entry = @entry AND SpellID = @SpellID AND Active = @Active;";
			MySqlParameter entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter spellidParameter = new MySqlParameter("@SpellID", MySqlDbType.VarChar, 0);
			MySqlParameter activeParameter = new MySqlParameter("@Active", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			spellidParameter.Value = SpellID;
			activeParameter.Value = Active;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(spellidParameter);
			cmd.Parameters.Add(activeParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE spell_learn_spell SET entry = @newentry, SpellID = @newSpellID, Active = @newActive WHERE entry = @entry AND SpellID = @SpellID AND Active = @Active;";
			MySqlParameter OLD_entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spellidParameter = new MySqlParameter("@SpellID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_activeParameter = new MySqlParameter("@Active", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@newentry", MySqlDbType.VarChar, 0);
			MySqlParameter spellidParameter = new MySqlParameter("@newSpellID", MySqlDbType.VarChar, 0);
			MySqlParameter activeParameter = new MySqlParameter("@newActive", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			spellidParameter.Value = SpellID;
			activeParameter.Value = Active;
			OLD_entryParameter.Value = OLD_entry;
			OLD_spellidParameter.Value = OLD_SpellID;
			OLD_activeParameter.Value = OLD_Active;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(spellidParameter);
			cmd.Parameters.Add(activeParameter);
			cmd.Parameters.Add(OLD_entryParameter);
			cmd.Parameters.Add(OLD_spellidParameter);
			cmd.Parameters.Add(OLD_activeParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_entry = entry;
			OLD_SpellID = SpellID;
			OLD_Active = Active;
		}
	}
}
