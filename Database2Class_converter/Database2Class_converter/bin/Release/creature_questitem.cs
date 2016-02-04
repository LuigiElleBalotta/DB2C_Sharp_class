using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Creature_questitem
	{
		int CreatureEntry = 0; //Comment: 
		int OLD_CreatureEntry = 0;

		int Idx = 0; //Comment: 
		int OLD_Idx = 0;

		int ItemId = 0; //Comment: 
		int OLD_ItemId = 0;

		int VerifiedBuild = 0; //Comment: 
		int OLD_VerifiedBuild = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Creature_questitem(int _CreatureEntry, int _Idx, int _ItemId, int _VerifiedBuild)
		{
			CreatureEntry = _CreatureEntry;
			Idx = _Idx;
			ItemId = _ItemId;
			VerifiedBuild = _VerifiedBuild;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM creature_questitem WHERE CreatureEntry = @CreatureEntry AND Idx = @Idx AND ItemId = @ItemId AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter creatureentryParameter = new MySqlParameter("@CreatureEntry", MySqlDbType.VarChar, 0);
			MySqlParameter idxParameter = new MySqlParameter("@Idx", MySqlDbType.VarChar, 0);
			MySqlParameter itemidParameter = new MySqlParameter("@ItemId", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			creatureentryParameter.Value = CreatureEntry;
			idxParameter.Value = Idx;
			itemidParameter.Value = ItemId;
			verifiedbuildParameter.Value = VerifiedBuild;
			cmd.Parameters.Add(creatureentryParameter);
			cmd.Parameters.Add(idxParameter);
			cmd.Parameters.Add(itemidParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE creature_questitem SET CreatureEntry = @newCreatureEntry, Idx = @newIdx, ItemId = @newItemId, VerifiedBuild = @newVerifiedBuild WHERE CreatureEntry = @CreatureEntry AND Idx = @Idx AND ItemId = @ItemId AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter OLD_creatureentryParameter = new MySqlParameter("@CreatureEntry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_idxParameter = new MySqlParameter("@Idx", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_itemidParameter = new MySqlParameter("@ItemId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			MySqlParameter creatureentryParameter = new MySqlParameter("@newCreatureEntry", MySqlDbType.VarChar, 0);
			MySqlParameter idxParameter = new MySqlParameter("@newIdx", MySqlDbType.VarChar, 0);
			MySqlParameter itemidParameter = new MySqlParameter("@newItemId", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@newVerifiedBuild", MySqlDbType.VarChar, 0);
			creatureentryParameter.Value = CreatureEntry;
			idxParameter.Value = Idx;
			itemidParameter.Value = ItemId;
			verifiedbuildParameter.Value = VerifiedBuild;
			OLD_creatureentryParameter.Value = OLD_CreatureEntry;
			OLD_idxParameter.Value = OLD_Idx;
			OLD_itemidParameter.Value = OLD_ItemId;
			OLD_verifiedbuildParameter.Value = OLD_VerifiedBuild;
			cmd.Parameters.Add(creatureentryParameter);
			cmd.Parameters.Add(idxParameter);
			cmd.Parameters.Add(itemidParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.Parameters.Add(OLD_creatureentryParameter);
			cmd.Parameters.Add(OLD_idxParameter);
			cmd.Parameters.Add(OLD_itemidParameter);
			cmd.Parameters.Add(OLD_verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_CreatureEntry = CreatureEntry;
			OLD_Idx = Idx;
			OLD_ItemId = ItemId;
			OLD_VerifiedBuild = VerifiedBuild;
		}
	}
}
