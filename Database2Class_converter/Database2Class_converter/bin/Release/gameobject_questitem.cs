using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Gameobject_questitem
	{
		int GameObjectEntry = 0; //Comment: 
		int OLD_GameObjectEntry = 0;

		int Idx = 0; //Comment: 
		int OLD_Idx = 0;

		int ItemId = 0; //Comment: 
		int OLD_ItemId = 0;

		int VerifiedBuild = 0; //Comment: 
		int OLD_VerifiedBuild = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Gameobject_questitem(int _GameObjectEntry, int _Idx, int _ItemId, int _VerifiedBuild)
		{
			GameObjectEntry = _GameObjectEntry;
			Idx = _Idx;
			ItemId = _ItemId;
			VerifiedBuild = _VerifiedBuild;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM gameobject_questitem WHERE GameObjectEntry = @GameObjectEntry AND Idx = @Idx AND ItemId = @ItemId AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter gameobjectentryParameter = new MySqlParameter("@GameObjectEntry", MySqlDbType.VarChar, 0);
			MySqlParameter idxParameter = new MySqlParameter("@Idx", MySqlDbType.VarChar, 0);
			MySqlParameter itemidParameter = new MySqlParameter("@ItemId", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			gameobjectentryParameter.Value = GameObjectEntry;
			idxParameter.Value = Idx;
			itemidParameter.Value = ItemId;
			verifiedbuildParameter.Value = VerifiedBuild;
			cmd.Parameters.Add(gameobjectentryParameter);
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
			cmd.CommandText = "UPDATE gameobject_questitem SET GameObjectEntry = @newGameObjectEntry, Idx = @newIdx, ItemId = @newItemId, VerifiedBuild = @newVerifiedBuild WHERE GameObjectEntry = @GameObjectEntry AND Idx = @Idx AND ItemId = @ItemId AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter OLD_gameobjectentryParameter = new MySqlParameter("@GameObjectEntry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_idxParameter = new MySqlParameter("@Idx", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_itemidParameter = new MySqlParameter("@ItemId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			MySqlParameter gameobjectentryParameter = new MySqlParameter("@newGameObjectEntry", MySqlDbType.VarChar, 0);
			MySqlParameter idxParameter = new MySqlParameter("@newIdx", MySqlDbType.VarChar, 0);
			MySqlParameter itemidParameter = new MySqlParameter("@newItemId", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@newVerifiedBuild", MySqlDbType.VarChar, 0);
			gameobjectentryParameter.Value = GameObjectEntry;
			idxParameter.Value = Idx;
			itemidParameter.Value = ItemId;
			verifiedbuildParameter.Value = VerifiedBuild;
			OLD_gameobjectentryParameter.Value = OLD_GameObjectEntry;
			OLD_idxParameter.Value = OLD_Idx;
			OLD_itemidParameter.Value = OLD_ItemId;
			OLD_verifiedbuildParameter.Value = OLD_VerifiedBuild;
			cmd.Parameters.Add(gameobjectentryParameter);
			cmd.Parameters.Add(idxParameter);
			cmd.Parameters.Add(itemidParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.Parameters.Add(OLD_gameobjectentryParameter);
			cmd.Parameters.Add(OLD_idxParameter);
			cmd.Parameters.Add(OLD_itemidParameter);
			cmd.Parameters.Add(OLD_verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_GameObjectEntry = GameObjectEntry;
			OLD_Idx = Idx;
			OLD_ItemId = ItemId;
			OLD_VerifiedBuild = VerifiedBuild;
		}
	}
}
