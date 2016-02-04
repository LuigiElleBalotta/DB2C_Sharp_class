using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Spell_linked_spell
	{
		int spell_trigger = 0; //Comment: 
		int OLD_spell_trigger = 0;

		int spell_effect = 0; //Comment: 
		int OLD_spell_effect = 0;

		int type = 0; //Comment: 
		int OLD_type = 0;

		string comment = null; //Comment: 
		string OLD_comment = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Spell_linked_spell(int _spell_trigger, int _spell_effect, int _type, string _comment)
		{
			spell_trigger = _spell_trigger;
			spell_effect = _spell_effect;
			type = _type;
			comment = _comment;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM spell_linked_spell WHERE spell_trigger = @spell_trigger AND spell_effect = @spell_effect AND type = @type AND comment = @comment;";
			MySqlParameter spell_triggerParameter = new MySqlParameter("@spell_trigger", MySqlDbType.VarChar, 0);
			MySqlParameter spell_effectParameter = new MySqlParameter("@spell_effect", MySqlDbType.VarChar, 0);
			MySqlParameter typeParameter = new MySqlParameter("@type", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@comment", MySqlDbType.VarChar, 0);
			spell_triggerParameter.Value = spell_trigger;
			spell_effectParameter.Value = spell_effect;
			typeParameter.Value = type;
			commentParameter.Value = comment;
			cmd.Parameters.Add(spell_triggerParameter);
			cmd.Parameters.Add(spell_effectParameter);
			cmd.Parameters.Add(typeParameter);
			cmd.Parameters.Add(commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE spell_linked_spell SET spell_trigger = @newspell_trigger, spell_effect = @newspell_effect, type = @newtype, comment = @newcomment WHERE spell_trigger = @spell_trigger AND spell_effect = @spell_effect AND type = @type AND comment = @comment;";
			MySqlParameter OLD_spell_triggerParameter = new MySqlParameter("@spell_trigger", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spell_effectParameter = new MySqlParameter("@spell_effect", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_typeParameter = new MySqlParameter("@type", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_commentParameter = new MySqlParameter("@comment", MySqlDbType.VarChar, 0);
			MySqlParameter spell_triggerParameter = new MySqlParameter("@newspell_trigger", MySqlDbType.VarChar, 0);
			MySqlParameter spell_effectParameter = new MySqlParameter("@newspell_effect", MySqlDbType.VarChar, 0);
			MySqlParameter typeParameter = new MySqlParameter("@newtype", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@newcomment", MySqlDbType.VarChar, 0);
			spell_triggerParameter.Value = spell_trigger;
			spell_effectParameter.Value = spell_effect;
			typeParameter.Value = type;
			commentParameter.Value = comment;
			OLD_spell_triggerParameter.Value = OLD_spell_trigger;
			OLD_spell_effectParameter.Value = OLD_spell_effect;
			OLD_typeParameter.Value = OLD_type;
			OLD_commentParameter.Value = OLD_comment;
			cmd.Parameters.Add(spell_triggerParameter);
			cmd.Parameters.Add(spell_effectParameter);
			cmd.Parameters.Add(typeParameter);
			cmd.Parameters.Add(commentParameter);
			cmd.Parameters.Add(OLD_spell_triggerParameter);
			cmd.Parameters.Add(OLD_spell_effectParameter);
			cmd.Parameters.Add(OLD_typeParameter);
			cmd.Parameters.Add(OLD_commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_spell_trigger = spell_trigger;
			OLD_spell_effect = spell_effect;
			OLD_type = type;
			OLD_comment = comment;
		}
	}
}
