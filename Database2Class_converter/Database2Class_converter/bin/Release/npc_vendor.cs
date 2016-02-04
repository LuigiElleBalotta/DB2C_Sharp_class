using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Npc_vendor
	{
		int entry = 0; //Comment: 
		int OLD_entry = 0;

		int slot = 0; //Comment: 
		int OLD_slot = 0;

		int item = 0; //Comment: 
		int OLD_item = 0;

		int maxcount = 0; //Comment: 
		int OLD_maxcount = 0;

		int incrtime = 0; //Comment: 
		int OLD_incrtime = 0;

		int ExtendedCost = 0; //Comment: 
		int OLD_ExtendedCost = 0;

		int type = 1; //Comment: 
		int OLD_type = 1;

		int PlayerConditionID = 0; //Comment: 
		int OLD_PlayerConditionID = 0;

		int IgnoreFiltering = 0; //Comment: 
		int OLD_IgnoreFiltering = 0;

		int VerifiedBuild = 0; //Comment: 
		int OLD_VerifiedBuild = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Npc_vendor(int _entry, int _slot, int _item, int _maxcount, int _incrtime, int _ExtendedCost, int _type, int _PlayerConditionID, int _IgnoreFiltering, int _VerifiedBuild)
		{
			entry = _entry;
			slot = _slot;
			item = _item;
			maxcount = _maxcount;
			incrtime = _incrtime;
			ExtendedCost = _ExtendedCost;
			type = _type;
			PlayerConditionID = _PlayerConditionID;
			IgnoreFiltering = _IgnoreFiltering;
			VerifiedBuild = _VerifiedBuild;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM npc_vendor WHERE entry = @entry AND slot = @slot AND item = @item AND maxcount = @maxcount AND incrtime = @incrtime AND ExtendedCost = @ExtendedCost AND type = @type AND PlayerConditionID = @PlayerConditionID AND IgnoreFiltering = @IgnoreFiltering AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter slotParameter = new MySqlParameter("@slot", MySqlDbType.VarChar, 0);
			MySqlParameter itemParameter = new MySqlParameter("@item", MySqlDbType.VarChar, 0);
			MySqlParameter maxcountParameter = new MySqlParameter("@maxcount", MySqlDbType.VarChar, 0);
			MySqlParameter incrtimeParameter = new MySqlParameter("@incrtime", MySqlDbType.VarChar, 0);
			MySqlParameter extendedcostParameter = new MySqlParameter("@ExtendedCost", MySqlDbType.VarChar, 0);
			MySqlParameter typeParameter = new MySqlParameter("@type", MySqlDbType.VarChar, 0);
			MySqlParameter playerconditionidParameter = new MySqlParameter("@PlayerConditionID", MySqlDbType.VarChar, 0);
			MySqlParameter ignorefilteringParameter = new MySqlParameter("@IgnoreFiltering", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			slotParameter.Value = slot;
			itemParameter.Value = item;
			maxcountParameter.Value = maxcount;
			incrtimeParameter.Value = incrtime;
			extendedcostParameter.Value = ExtendedCost;
			typeParameter.Value = type;
			playerconditionidParameter.Value = PlayerConditionID;
			ignorefilteringParameter.Value = IgnoreFiltering;
			verifiedbuildParameter.Value = VerifiedBuild;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(slotParameter);
			cmd.Parameters.Add(itemParameter);
			cmd.Parameters.Add(maxcountParameter);
			cmd.Parameters.Add(incrtimeParameter);
			cmd.Parameters.Add(extendedcostParameter);
			cmd.Parameters.Add(typeParameter);
			cmd.Parameters.Add(playerconditionidParameter);
			cmd.Parameters.Add(ignorefilteringParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE npc_vendor SET entry = @newentry, slot = @newslot, item = @newitem, maxcount = @newmaxcount, incrtime = @newincrtime, ExtendedCost = @newExtendedCost, type = @newtype, PlayerConditionID = @newPlayerConditionID, IgnoreFiltering = @newIgnoreFiltering, VerifiedBuild = @newVerifiedBuild WHERE entry = @entry AND slot = @slot AND item = @item AND maxcount = @maxcount AND incrtime = @incrtime AND ExtendedCost = @ExtendedCost AND type = @type AND PlayerConditionID = @PlayerConditionID AND IgnoreFiltering = @IgnoreFiltering AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter OLD_entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_slotParameter = new MySqlParameter("@slot", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_itemParameter = new MySqlParameter("@item", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_maxcountParameter = new MySqlParameter("@maxcount", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_incrtimeParameter = new MySqlParameter("@incrtime", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_extendedcostParameter = new MySqlParameter("@ExtendedCost", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_typeParameter = new MySqlParameter("@type", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_playerconditionidParameter = new MySqlParameter("@PlayerConditionID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_ignorefilteringParameter = new MySqlParameter("@IgnoreFiltering", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@newentry", MySqlDbType.VarChar, 0);
			MySqlParameter slotParameter = new MySqlParameter("@newslot", MySqlDbType.VarChar, 0);
			MySqlParameter itemParameter = new MySqlParameter("@newitem", MySqlDbType.VarChar, 0);
			MySqlParameter maxcountParameter = new MySqlParameter("@newmaxcount", MySqlDbType.VarChar, 0);
			MySqlParameter incrtimeParameter = new MySqlParameter("@newincrtime", MySqlDbType.VarChar, 0);
			MySqlParameter extendedcostParameter = new MySqlParameter("@newExtendedCost", MySqlDbType.VarChar, 0);
			MySqlParameter typeParameter = new MySqlParameter("@newtype", MySqlDbType.VarChar, 0);
			MySqlParameter playerconditionidParameter = new MySqlParameter("@newPlayerConditionID", MySqlDbType.VarChar, 0);
			MySqlParameter ignorefilteringParameter = new MySqlParameter("@newIgnoreFiltering", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@newVerifiedBuild", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			slotParameter.Value = slot;
			itemParameter.Value = item;
			maxcountParameter.Value = maxcount;
			incrtimeParameter.Value = incrtime;
			extendedcostParameter.Value = ExtendedCost;
			typeParameter.Value = type;
			playerconditionidParameter.Value = PlayerConditionID;
			ignorefilteringParameter.Value = IgnoreFiltering;
			verifiedbuildParameter.Value = VerifiedBuild;
			OLD_entryParameter.Value = OLD_entry;
			OLD_slotParameter.Value = OLD_slot;
			OLD_itemParameter.Value = OLD_item;
			OLD_maxcountParameter.Value = OLD_maxcount;
			OLD_incrtimeParameter.Value = OLD_incrtime;
			OLD_extendedcostParameter.Value = OLD_ExtendedCost;
			OLD_typeParameter.Value = OLD_type;
			OLD_playerconditionidParameter.Value = OLD_PlayerConditionID;
			OLD_ignorefilteringParameter.Value = OLD_IgnoreFiltering;
			OLD_verifiedbuildParameter.Value = OLD_VerifiedBuild;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(slotParameter);
			cmd.Parameters.Add(itemParameter);
			cmd.Parameters.Add(maxcountParameter);
			cmd.Parameters.Add(incrtimeParameter);
			cmd.Parameters.Add(extendedcostParameter);
			cmd.Parameters.Add(typeParameter);
			cmd.Parameters.Add(playerconditionidParameter);
			cmd.Parameters.Add(ignorefilteringParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.Parameters.Add(OLD_entryParameter);
			cmd.Parameters.Add(OLD_slotParameter);
			cmd.Parameters.Add(OLD_itemParameter);
			cmd.Parameters.Add(OLD_maxcountParameter);
			cmd.Parameters.Add(OLD_incrtimeParameter);
			cmd.Parameters.Add(OLD_extendedcostParameter);
			cmd.Parameters.Add(OLD_typeParameter);
			cmd.Parameters.Add(OLD_playerconditionidParameter);
			cmd.Parameters.Add(OLD_ignorefilteringParameter);
			cmd.Parameters.Add(OLD_verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_entry = entry;
			OLD_slot = slot;
			OLD_item = item;
			OLD_maxcount = maxcount;
			OLD_incrtime = incrtime;
			OLD_ExtendedCost = ExtendedCost;
			OLD_type = type;
			OLD_PlayerConditionID = PlayerConditionID;
			OLD_IgnoreFiltering = IgnoreFiltering;
			OLD_VerifiedBuild = VerifiedBuild;
		}
	}
}
