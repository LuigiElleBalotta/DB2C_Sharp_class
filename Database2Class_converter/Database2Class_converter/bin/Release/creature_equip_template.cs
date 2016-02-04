using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Creature_equip_template
	{
		int CreatureID = 0; //Comment: 
		int OLD_CreatureID = 0;

		int ID = 1; //Comment: 
		int OLD_ID = 1;

		int ItemID1 = 0; //Comment: 
		int OLD_ItemID1 = 0;

		int ItemID2 = 0; //Comment: 
		int OLD_ItemID2 = 0;

		int ItemID3 = 0; //Comment: 
		int OLD_ItemID3 = 0;

		int VerifiedBuild = 0; //Comment: 
		int OLD_VerifiedBuild = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Creature_equip_template(int _CreatureID, int _ID, int _ItemID1, int _ItemID2, int _ItemID3, int _VerifiedBuild)
		{
			CreatureID = _CreatureID;
			ID = _ID;
			ItemID1 = _ItemID1;
			ItemID2 = _ItemID2;
			ItemID3 = _ItemID3;
			VerifiedBuild = _VerifiedBuild;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM creature_equip_template WHERE CreatureID = @CreatureID AND ID = @ID AND ItemID1 = @ItemID1 AND ItemID2 = @ItemID2 AND ItemID3 = @ItemID3 AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter creatureidParameter = new MySqlParameter("@CreatureID", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter itemid1Parameter = new MySqlParameter("@ItemID1", MySqlDbType.VarChar, 0);
			MySqlParameter itemid2Parameter = new MySqlParameter("@ItemID2", MySqlDbType.VarChar, 0);
			MySqlParameter itemid3Parameter = new MySqlParameter("@ItemID3", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			creatureidParameter.Value = CreatureID;
			idParameter.Value = ID;
			itemid1Parameter.Value = ItemID1;
			itemid2Parameter.Value = ItemID2;
			itemid3Parameter.Value = ItemID3;
			verifiedbuildParameter.Value = VerifiedBuild;
			cmd.Parameters.Add(creatureidParameter);
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(itemid1Parameter);
			cmd.Parameters.Add(itemid2Parameter);
			cmd.Parameters.Add(itemid3Parameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE creature_equip_template SET CreatureID = @newCreatureID, ID = @newID, ItemID1 = @newItemID1, ItemID2 = @newItemID2, ItemID3 = @newItemID3, VerifiedBuild = @newVerifiedBuild WHERE CreatureID = @CreatureID AND ID = @ID AND ItemID1 = @ItemID1 AND ItemID2 = @ItemID2 AND ItemID3 = @ItemID3 AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter OLD_creatureidParameter = new MySqlParameter("@CreatureID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_itemid1Parameter = new MySqlParameter("@ItemID1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_itemid2Parameter = new MySqlParameter("@ItemID2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_itemid3Parameter = new MySqlParameter("@ItemID3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			MySqlParameter creatureidParameter = new MySqlParameter("@newCreatureID", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newID", MySqlDbType.VarChar, 0);
			MySqlParameter itemid1Parameter = new MySqlParameter("@newItemID1", MySqlDbType.VarChar, 0);
			MySqlParameter itemid2Parameter = new MySqlParameter("@newItemID2", MySqlDbType.VarChar, 0);
			MySqlParameter itemid3Parameter = new MySqlParameter("@newItemID3", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@newVerifiedBuild", MySqlDbType.VarChar, 0);
			creatureidParameter.Value = CreatureID;
			idParameter.Value = ID;
			itemid1Parameter.Value = ItemID1;
			itemid2Parameter.Value = ItemID2;
			itemid3Parameter.Value = ItemID3;
			verifiedbuildParameter.Value = VerifiedBuild;
			OLD_creatureidParameter.Value = OLD_CreatureID;
			OLD_idParameter.Value = OLD_ID;
			OLD_itemid1Parameter.Value = OLD_ItemID1;
			OLD_itemid2Parameter.Value = OLD_ItemID2;
			OLD_itemid3Parameter.Value = OLD_ItemID3;
			OLD_verifiedbuildParameter.Value = OLD_VerifiedBuild;
			cmd.Parameters.Add(creatureidParameter);
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(itemid1Parameter);
			cmd.Parameters.Add(itemid2Parameter);
			cmd.Parameters.Add(itemid3Parameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.Parameters.Add(OLD_creatureidParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_itemid1Parameter);
			cmd.Parameters.Add(OLD_itemid2Parameter);
			cmd.Parameters.Add(OLD_itemid3Parameter);
			cmd.Parameters.Add(OLD_verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_CreatureID = CreatureID;
			OLD_ID = ID;
			OLD_ItemID1 = ItemID1;
			OLD_ItemID2 = ItemID2;
			OLD_ItemID3 = ItemID3;
			OLD_VerifiedBuild = VerifiedBuild;
		}
	}
}
