using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Battlemaster_entry
	{
		int entry = 0; //Comment: Entry of a creature
		int OLD_entry = 0;

		int bg_template = 0; //Comment: Battleground template id
		int OLD_bg_template = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Battlemaster_entry(int _entry, int _bg_template)
		{
			entry = _entry;
			bg_template = _bg_template;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM battlemaster_entry WHERE entry = @entry AND bg_template = @bg_template;";
			MySqlParameter entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter bg_templateParameter = new MySqlParameter("@bg_template", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			bg_templateParameter.Value = bg_template;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(bg_templateParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE battlemaster_entry SET entry = @newentry, bg_template = @newbg_template WHERE entry = @entry AND bg_template = @bg_template;";
			MySqlParameter OLD_entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_bg_templateParameter = new MySqlParameter("@bg_template", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@newentry", MySqlDbType.VarChar, 0);
			MySqlParameter bg_templateParameter = new MySqlParameter("@newbg_template", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			bg_templateParameter.Value = bg_template;
			OLD_entryParameter.Value = OLD_entry;
			OLD_bg_templateParameter.Value = OLD_bg_template;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(bg_templateParameter);
			cmd.Parameters.Add(OLD_entryParameter);
			cmd.Parameters.Add(OLD_bg_templateParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_entry = entry;
			OLD_bg_template = bg_template;
		}
	}
}
