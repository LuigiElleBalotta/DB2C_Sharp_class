using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Item_enchantment_template
	{
		int entry = 0; //Comment: 
		int OLD_entry = 0;

		int ench = 0; //Comment: 
		int OLD_ench = 0;

		float chance = 0f; //Comment: 
		float OLD_chance = 0f;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Item_enchantment_template(int _entry, int _ench, float _chance)
		{
			entry = _entry;
			ench = _ench;
			chance = _chance;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM item_enchantment_template WHERE entry = @entry AND ench = @ench AND chance = @chance;";
			MySqlParameter entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter enchParameter = new MySqlParameter("@ench", MySqlDbType.VarChar, 0);
			MySqlParameter chanceParameter = new MySqlParameter("@chance", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			enchParameter.Value = ench;
			chanceParameter.Value = chance;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(enchParameter);
			cmd.Parameters.Add(chanceParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE item_enchantment_template SET entry = @newentry, ench = @newench, chance = @newchance WHERE entry = @entry AND ench = @ench AND chance = @chance;";
			MySqlParameter OLD_entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_enchParameter = new MySqlParameter("@ench", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_chanceParameter = new MySqlParameter("@chance", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@newentry", MySqlDbType.VarChar, 0);
			MySqlParameter enchParameter = new MySqlParameter("@newench", MySqlDbType.VarChar, 0);
			MySqlParameter chanceParameter = new MySqlParameter("@newchance", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			enchParameter.Value = ench;
			chanceParameter.Value = chance;
			OLD_entryParameter.Value = OLD_entry;
			OLD_enchParameter.Value = OLD_ench;
			OLD_chanceParameter.Value = OLD_chance;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(enchParameter);
			cmd.Parameters.Add(chanceParameter);
			cmd.Parameters.Add(OLD_entryParameter);
			cmd.Parameters.Add(OLD_enchParameter);
			cmd.Parameters.Add(OLD_chanceParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_entry = entry;
			OLD_ench = ench;
			OLD_chance = chance;
		}
	}
}
