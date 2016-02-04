using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Playercreateinfo_item
	{
		int race = 0; //Comment: 
		int OLD_race = 0;

		int class_var = 0; //Comment: 
		int OLD_class_var = 0;

		int itemid = 0; //Comment: 
		int OLD_itemid = 0;

		int amount = 1; //Comment: 
		int OLD_amount = 1;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Playercreateinfo_item(int _race, int _class_var, int _itemid, int _amount)
		{
			race = _race;
			class_var = _class_var;
			itemid = _itemid;
			amount = _amount;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM playercreateinfo_item WHERE race = @race AND class_var = @class_var AND itemid = @itemid AND amount = @amount;";
			MySqlParameter raceParameter = new MySqlParameter("@race", MySqlDbType.VarChar, 0);
			MySqlParameter class_varParameter = new MySqlParameter("@class_var", MySqlDbType.VarChar, 0);
			MySqlParameter itemidParameter = new MySqlParameter("@itemid", MySqlDbType.VarChar, 0);
			MySqlParameter amountParameter = new MySqlParameter("@amount", MySqlDbType.VarChar, 0);
			raceParameter.Value = race;
			class_varParameter.Value = class_var;
			itemidParameter.Value = itemid;
			amountParameter.Value = amount;
			cmd.Parameters.Add(raceParameter);
			cmd.Parameters.Add(class_varParameter);
			cmd.Parameters.Add(itemidParameter);
			cmd.Parameters.Add(amountParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE playercreateinfo_item SET race = @newrace, class_var = @newclass_var, itemid = @newitemid, amount = @newamount WHERE race = @race AND class_var = @class_var AND itemid = @itemid AND amount = @amount;";
			MySqlParameter OLD_raceParameter = new MySqlParameter("@race", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_class_varParameter = new MySqlParameter("@class_var", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_itemidParameter = new MySqlParameter("@itemid", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_amountParameter = new MySqlParameter("@amount", MySqlDbType.VarChar, 0);
			MySqlParameter raceParameter = new MySqlParameter("@newrace", MySqlDbType.VarChar, 0);
			MySqlParameter class_varParameter = new MySqlParameter("@newclass_var", MySqlDbType.VarChar, 0);
			MySqlParameter itemidParameter = new MySqlParameter("@newitemid", MySqlDbType.VarChar, 0);
			MySqlParameter amountParameter = new MySqlParameter("@newamount", MySqlDbType.VarChar, 0);
			raceParameter.Value = race;
			class_varParameter.Value = class_var;
			itemidParameter.Value = itemid;
			amountParameter.Value = amount;
			OLD_raceParameter.Value = OLD_race;
			OLD_class_varParameter.Value = OLD_class_var;
			OLD_itemidParameter.Value = OLD_itemid;
			OLD_amountParameter.Value = OLD_amount;
			cmd.Parameters.Add(raceParameter);
			cmd.Parameters.Add(class_varParameter);
			cmd.Parameters.Add(itemidParameter);
			cmd.Parameters.Add(amountParameter);
			cmd.Parameters.Add(OLD_raceParameter);
			cmd.Parameters.Add(OLD_class_varParameter);
			cmd.Parameters.Add(OLD_itemidParameter);
			cmd.Parameters.Add(OLD_amountParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_race = race;
			OLD_class_var = class_var;
			OLD_itemid = itemid;
			OLD_amount = amount;
		}
	}
}
