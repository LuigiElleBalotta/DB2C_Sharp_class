using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Gossip_menu
	{
		int entry = 0; //Comment: 
		int OLD_entry = 0;

		int text_id = 0; //Comment: 
		int OLD_text_id = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Gossip_menu(int _entry, int _text_id)
		{
			entry = _entry;
			text_id = _text_id;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM gossip_menu WHERE entry = @entry AND text_id = @text_id;";
			MySqlParameter entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter text_idParameter = new MySqlParameter("@text_id", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			text_idParameter.Value = text_id;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(text_idParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE gossip_menu SET entry = @newentry, text_id = @newtext_id WHERE entry = @entry AND text_id = @text_id;";
			MySqlParameter OLD_entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_text_idParameter = new MySqlParameter("@text_id", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@newentry", MySqlDbType.VarChar, 0);
			MySqlParameter text_idParameter = new MySqlParameter("@newtext_id", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			text_idParameter.Value = text_id;
			OLD_entryParameter.Value = OLD_entry;
			OLD_text_idParameter.Value = OLD_text_id;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(text_idParameter);
			cmd.Parameters.Add(OLD_entryParameter);
			cmd.Parameters.Add(OLD_text_idParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_entry = entry;
			OLD_text_id = text_id;
		}
	}
}
