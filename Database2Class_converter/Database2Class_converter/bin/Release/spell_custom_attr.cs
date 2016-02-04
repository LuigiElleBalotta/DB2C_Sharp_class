using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Spell_custom_attr
	{
		int entry = 0; //Comment: spell id
		int OLD_entry = 0;

		int attributes = 0; //Comment: SpellCustomAttributes
		int OLD_attributes = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Spell_custom_attr(int _entry, int _attributes)
		{
			entry = _entry;
			attributes = _attributes;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM spell_custom_attr WHERE entry = @entry AND attributes = @attributes;";
			MySqlParameter entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter attributesParameter = new MySqlParameter("@attributes", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			attributesParameter.Value = attributes;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(attributesParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE spell_custom_attr SET entry = @newentry, attributes = @newattributes WHERE entry = @entry AND attributes = @attributes;";
			MySqlParameter OLD_entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_attributesParameter = new MySqlParameter("@attributes", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@newentry", MySqlDbType.VarChar, 0);
			MySqlParameter attributesParameter = new MySqlParameter("@newattributes", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			attributesParameter.Value = attributes;
			OLD_entryParameter.Value = OLD_entry;
			OLD_attributesParameter.Value = OLD_attributes;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(attributesParameter);
			cmd.Parameters.Add(OLD_entryParameter);
			cmd.Parameters.Add(OLD_attributesParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_entry = entry;
			OLD_attributes = attributes;
		}
	}
}
