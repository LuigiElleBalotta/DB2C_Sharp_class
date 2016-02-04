using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Guild_rewards
	{
		int ItemID = 0; //Comment: 
		int OLD_ItemID = 0;

		int MinGuildRep = 0; //Comment: 
		int OLD_MinGuildRep = 0;

		int RaceMask = 0; //Comment: 
		int OLD_RaceMask = 0;

		int Cost = 0; //Comment: 
		int OLD_Cost = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Guild_rewards(int _ItemID, int _MinGuildRep, int _RaceMask, int _Cost)
		{
			ItemID = _ItemID;
			MinGuildRep = _MinGuildRep;
			RaceMask = _RaceMask;
			Cost = _Cost;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM guild_rewards WHERE ItemID = @ItemID AND MinGuildRep = @MinGuildRep AND RaceMask = @RaceMask AND Cost = @Cost;";
			MySqlParameter itemidParameter = new MySqlParameter("@ItemID", MySqlDbType.VarChar, 0);
			MySqlParameter minguildrepParameter = new MySqlParameter("@MinGuildRep", MySqlDbType.VarChar, 0);
			MySqlParameter racemaskParameter = new MySqlParameter("@RaceMask", MySqlDbType.VarChar, 0);
			MySqlParameter costParameter = new MySqlParameter("@Cost", MySqlDbType.VarChar, 0);
			itemidParameter.Value = ItemID;
			minguildrepParameter.Value = MinGuildRep;
			racemaskParameter.Value = RaceMask;
			costParameter.Value = Cost;
			cmd.Parameters.Add(itemidParameter);
			cmd.Parameters.Add(minguildrepParameter);
			cmd.Parameters.Add(racemaskParameter);
			cmd.Parameters.Add(costParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE guild_rewards SET ItemID = @newItemID, MinGuildRep = @newMinGuildRep, RaceMask = @newRaceMask, Cost = @newCost WHERE ItemID = @ItemID AND MinGuildRep = @MinGuildRep AND RaceMask = @RaceMask AND Cost = @Cost;";
			MySqlParameter OLD_itemidParameter = new MySqlParameter("@ItemID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_minguildrepParameter = new MySqlParameter("@MinGuildRep", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_racemaskParameter = new MySqlParameter("@RaceMask", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_costParameter = new MySqlParameter("@Cost", MySqlDbType.VarChar, 0);
			MySqlParameter itemidParameter = new MySqlParameter("@newItemID", MySqlDbType.VarChar, 0);
			MySqlParameter minguildrepParameter = new MySqlParameter("@newMinGuildRep", MySqlDbType.VarChar, 0);
			MySqlParameter racemaskParameter = new MySqlParameter("@newRaceMask", MySqlDbType.VarChar, 0);
			MySqlParameter costParameter = new MySqlParameter("@newCost", MySqlDbType.VarChar, 0);
			itemidParameter.Value = ItemID;
			minguildrepParameter.Value = MinGuildRep;
			racemaskParameter.Value = RaceMask;
			costParameter.Value = Cost;
			OLD_itemidParameter.Value = OLD_ItemID;
			OLD_minguildrepParameter.Value = OLD_MinGuildRep;
			OLD_racemaskParameter.Value = OLD_RaceMask;
			OLD_costParameter.Value = OLD_Cost;
			cmd.Parameters.Add(itemidParameter);
			cmd.Parameters.Add(minguildrepParameter);
			cmd.Parameters.Add(racemaskParameter);
			cmd.Parameters.Add(costParameter);
			cmd.Parameters.Add(OLD_itemidParameter);
			cmd.Parameters.Add(OLD_minguildrepParameter);
			cmd.Parameters.Add(OLD_racemaskParameter);
			cmd.Parameters.Add(OLD_costParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_ItemID = ItemID;
			OLD_MinGuildRep = MinGuildRep;
			OLD_RaceMask = RaceMask;
			OLD_Cost = Cost;
		}
	}
}
