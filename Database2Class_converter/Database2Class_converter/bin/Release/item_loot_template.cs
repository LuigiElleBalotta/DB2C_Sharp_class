using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Item_loot_template
	{
		int Entry = 0; //Comment: 
		int OLD_Entry = 0;

		int Item = 0; //Comment: 
		int OLD_Item = 0;

		int Reference = 0; //Comment: 
		int OLD_Reference = 0;

		float Chance = 100f; //Comment: 
		float OLD_Chance = 100f;

		int QuestRequired = 0; //Comment: 
		int OLD_QuestRequired = 0;

		int LootMode = 1; //Comment: 
		int OLD_LootMode = 1;

		int GroupId = 0; //Comment: 
		int OLD_GroupId = 0;

		int MinCount = 1; //Comment: 
		int OLD_MinCount = 1;

		int MaxCount = 1; //Comment: 
		int OLD_MaxCount = 1;

		string Comment = null; //Comment: 
		string OLD_Comment = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Item_loot_template(int _Entry, int _Item, int _Reference, float _Chance, int _QuestRequired, int _LootMode, int _GroupId, int _MinCount, int _MaxCount, string _Comment)
		{
			Entry = _Entry;
			Item = _Item;
			Reference = _Reference;
			Chance = _Chance;
			QuestRequired = _QuestRequired;
			LootMode = _LootMode;
			GroupId = _GroupId;
			MinCount = _MinCount;
			MaxCount = _MaxCount;
			Comment = _Comment;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM item_loot_template WHERE Entry = @Entry AND Item = @Item AND Reference = @Reference AND Chance = @Chance AND QuestRequired = @QuestRequired AND LootMode = @LootMode AND GroupId = @GroupId AND MinCount = @MinCount AND MaxCount = @MaxCount AND Comment = @Comment;";
			MySqlParameter entryParameter = new MySqlParameter("@Entry", MySqlDbType.VarChar, 0);
			MySqlParameter itemParameter = new MySqlParameter("@Item", MySqlDbType.VarChar, 0);
			MySqlParameter referenceParameter = new MySqlParameter("@Reference", MySqlDbType.VarChar, 0);
			MySqlParameter chanceParameter = new MySqlParameter("@Chance", MySqlDbType.VarChar, 0);
			MySqlParameter questrequiredParameter = new MySqlParameter("@QuestRequired", MySqlDbType.VarChar, 0);
			MySqlParameter lootmodeParameter = new MySqlParameter("@LootMode", MySqlDbType.VarChar, 0);
			MySqlParameter groupidParameter = new MySqlParameter("@GroupId", MySqlDbType.VarChar, 0);
			MySqlParameter mincountParameter = new MySqlParameter("@MinCount", MySqlDbType.VarChar, 0);
			MySqlParameter maxcountParameter = new MySqlParameter("@MaxCount", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@Comment", MySqlDbType.VarChar, 0);
			entryParameter.Value = Entry;
			itemParameter.Value = Item;
			referenceParameter.Value = Reference;
			chanceParameter.Value = Chance;
			questrequiredParameter.Value = QuestRequired;
			lootmodeParameter.Value = LootMode;
			groupidParameter.Value = GroupId;
			mincountParameter.Value = MinCount;
			maxcountParameter.Value = MaxCount;
			commentParameter.Value = Comment;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(itemParameter);
			cmd.Parameters.Add(referenceParameter);
			cmd.Parameters.Add(chanceParameter);
			cmd.Parameters.Add(questrequiredParameter);
			cmd.Parameters.Add(lootmodeParameter);
			cmd.Parameters.Add(groupidParameter);
			cmd.Parameters.Add(mincountParameter);
			cmd.Parameters.Add(maxcountParameter);
			cmd.Parameters.Add(commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE item_loot_template SET Entry = @newEntry, Item = @newItem, Reference = @newReference, Chance = @newChance, QuestRequired = @newQuestRequired, LootMode = @newLootMode, GroupId = @newGroupId, MinCount = @newMinCount, MaxCount = @newMaxCount, Comment = @newComment WHERE Entry = @Entry AND Item = @Item AND Reference = @Reference AND Chance = @Chance AND QuestRequired = @QuestRequired AND LootMode = @LootMode AND GroupId = @GroupId AND MinCount = @MinCount AND MaxCount = @MaxCount AND Comment = @Comment;";
			MySqlParameter OLD_entryParameter = new MySqlParameter("@Entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_itemParameter = new MySqlParameter("@Item", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_referenceParameter = new MySqlParameter("@Reference", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_chanceParameter = new MySqlParameter("@Chance", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_questrequiredParameter = new MySqlParameter("@QuestRequired", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_lootmodeParameter = new MySqlParameter("@LootMode", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_groupidParameter = new MySqlParameter("@GroupId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_mincountParameter = new MySqlParameter("@MinCount", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_maxcountParameter = new MySqlParameter("@MaxCount", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_commentParameter = new MySqlParameter("@Comment", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@newEntry", MySqlDbType.VarChar, 0);
			MySqlParameter itemParameter = new MySqlParameter("@newItem", MySqlDbType.VarChar, 0);
			MySqlParameter referenceParameter = new MySqlParameter("@newReference", MySqlDbType.VarChar, 0);
			MySqlParameter chanceParameter = new MySqlParameter("@newChance", MySqlDbType.VarChar, 0);
			MySqlParameter questrequiredParameter = new MySqlParameter("@newQuestRequired", MySqlDbType.VarChar, 0);
			MySqlParameter lootmodeParameter = new MySqlParameter("@newLootMode", MySqlDbType.VarChar, 0);
			MySqlParameter groupidParameter = new MySqlParameter("@newGroupId", MySqlDbType.VarChar, 0);
			MySqlParameter mincountParameter = new MySqlParameter("@newMinCount", MySqlDbType.VarChar, 0);
			MySqlParameter maxcountParameter = new MySqlParameter("@newMaxCount", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@newComment", MySqlDbType.VarChar, 0);
			entryParameter.Value = Entry;
			itemParameter.Value = Item;
			referenceParameter.Value = Reference;
			chanceParameter.Value = Chance;
			questrequiredParameter.Value = QuestRequired;
			lootmodeParameter.Value = LootMode;
			groupidParameter.Value = GroupId;
			mincountParameter.Value = MinCount;
			maxcountParameter.Value = MaxCount;
			commentParameter.Value = Comment;
			OLD_entryParameter.Value = OLD_Entry;
			OLD_itemParameter.Value = OLD_Item;
			OLD_referenceParameter.Value = OLD_Reference;
			OLD_chanceParameter.Value = OLD_Chance;
			OLD_questrequiredParameter.Value = OLD_QuestRequired;
			OLD_lootmodeParameter.Value = OLD_LootMode;
			OLD_groupidParameter.Value = OLD_GroupId;
			OLD_mincountParameter.Value = OLD_MinCount;
			OLD_maxcountParameter.Value = OLD_MaxCount;
			OLD_commentParameter.Value = OLD_Comment;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(itemParameter);
			cmd.Parameters.Add(referenceParameter);
			cmd.Parameters.Add(chanceParameter);
			cmd.Parameters.Add(questrequiredParameter);
			cmd.Parameters.Add(lootmodeParameter);
			cmd.Parameters.Add(groupidParameter);
			cmd.Parameters.Add(mincountParameter);
			cmd.Parameters.Add(maxcountParameter);
			cmd.Parameters.Add(commentParameter);
			cmd.Parameters.Add(OLD_entryParameter);
			cmd.Parameters.Add(OLD_itemParameter);
			cmd.Parameters.Add(OLD_referenceParameter);
			cmd.Parameters.Add(OLD_chanceParameter);
			cmd.Parameters.Add(OLD_questrequiredParameter);
			cmd.Parameters.Add(OLD_lootmodeParameter);
			cmd.Parameters.Add(OLD_groupidParameter);
			cmd.Parameters.Add(OLD_mincountParameter);
			cmd.Parameters.Add(OLD_maxcountParameter);
			cmd.Parameters.Add(OLD_commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_Entry = Entry;
			OLD_Item = Item;
			OLD_Reference = Reference;
			OLD_Chance = Chance;
			OLD_QuestRequired = QuestRequired;
			OLD_LootMode = LootMode;
			OLD_GroupId = GroupId;
			OLD_MinCount = MinCount;
			OLD_MaxCount = MaxCount;
			OLD_Comment = Comment;
		}
	}
}
