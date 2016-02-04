using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Guild_rewards_req_achievements
	{
		int ItemID = 0; //Comment: 
		int OLD_ItemID = 0;

		int AchievementRequired = 0; //Comment: 
		int OLD_AchievementRequired = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Guild_rewards_req_achievements(int _ItemID, int _AchievementRequired)
		{
			ItemID = _ItemID;
			AchievementRequired = _AchievementRequired;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM guild_rewards_req_achievements WHERE ItemID = @ItemID AND AchievementRequired = @AchievementRequired;";
			MySqlParameter itemidParameter = new MySqlParameter("@ItemID", MySqlDbType.VarChar, 0);
			MySqlParameter achievementrequiredParameter = new MySqlParameter("@AchievementRequired", MySqlDbType.VarChar, 0);
			itemidParameter.Value = ItemID;
			achievementrequiredParameter.Value = AchievementRequired;
			cmd.Parameters.Add(itemidParameter);
			cmd.Parameters.Add(achievementrequiredParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE guild_rewards_req_achievements SET ItemID = @newItemID, AchievementRequired = @newAchievementRequired WHERE ItemID = @ItemID AND AchievementRequired = @AchievementRequired;";
			MySqlParameter OLD_itemidParameter = new MySqlParameter("@ItemID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_achievementrequiredParameter = new MySqlParameter("@AchievementRequired", MySqlDbType.VarChar, 0);
			MySqlParameter itemidParameter = new MySqlParameter("@newItemID", MySqlDbType.VarChar, 0);
			MySqlParameter achievementrequiredParameter = new MySqlParameter("@newAchievementRequired", MySqlDbType.VarChar, 0);
			itemidParameter.Value = ItemID;
			achievementrequiredParameter.Value = AchievementRequired;
			OLD_itemidParameter.Value = OLD_ItemID;
			OLD_achievementrequiredParameter.Value = OLD_AchievementRequired;
			cmd.Parameters.Add(itemidParameter);
			cmd.Parameters.Add(achievementrequiredParameter);
			cmd.Parameters.Add(OLD_itemidParameter);
			cmd.Parameters.Add(OLD_achievementrequiredParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_ItemID = ItemID;
			OLD_AchievementRequired = AchievementRequired;
		}
	}
}
