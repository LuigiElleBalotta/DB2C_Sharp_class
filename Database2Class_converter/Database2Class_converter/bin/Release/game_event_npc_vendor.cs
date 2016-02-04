using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Game_event_npc_vendor
	{
		int eventEntry = 0; //Comment: Entry of the game event.
		int OLD_eventEntry = 0;

		int guid = 0; //Comment: 
		int OLD_guid = 0;

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

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Game_event_npc_vendor(int _eventEntry, int _guid, int _slot, int _item, int _maxcount, int _incrtime, int _ExtendedCost, int _type)
		{
			eventEntry = _eventEntry;
			guid = _guid;
			slot = _slot;
			item = _item;
			maxcount = _maxcount;
			incrtime = _incrtime;
			ExtendedCost = _ExtendedCost;
			type = _type;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM game_event_npc_vendor WHERE eventEntry = @eventEntry AND guid = @guid AND slot = @slot AND item = @item AND maxcount = @maxcount AND incrtime = @incrtime AND ExtendedCost = @ExtendedCost AND type = @type;";
			MySqlParameter evententryParameter = new MySqlParameter("@eventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter guidParameter = new MySqlParameter("@guid", MySqlDbType.VarChar, 0);
			MySqlParameter slotParameter = new MySqlParameter("@slot", MySqlDbType.VarChar, 0);
			MySqlParameter itemParameter = new MySqlParameter("@item", MySqlDbType.VarChar, 0);
			MySqlParameter maxcountParameter = new MySqlParameter("@maxcount", MySqlDbType.VarChar, 0);
			MySqlParameter incrtimeParameter = new MySqlParameter("@incrtime", MySqlDbType.VarChar, 0);
			MySqlParameter extendedcostParameter = new MySqlParameter("@ExtendedCost", MySqlDbType.VarChar, 0);
			MySqlParameter typeParameter = new MySqlParameter("@type", MySqlDbType.VarChar, 0);
			evententryParameter.Value = eventEntry;
			guidParameter.Value = guid;
			slotParameter.Value = slot;
			itemParameter.Value = item;
			maxcountParameter.Value = maxcount;
			incrtimeParameter.Value = incrtime;
			extendedcostParameter.Value = ExtendedCost;
			typeParameter.Value = type;
			cmd.Parameters.Add(evententryParameter);
			cmd.Parameters.Add(guidParameter);
			cmd.Parameters.Add(slotParameter);
			cmd.Parameters.Add(itemParameter);
			cmd.Parameters.Add(maxcountParameter);
			cmd.Parameters.Add(incrtimeParameter);
			cmd.Parameters.Add(extendedcostParameter);
			cmd.Parameters.Add(typeParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE game_event_npc_vendor SET eventEntry = @neweventEntry, guid = @newguid, slot = @newslot, item = @newitem, maxcount = @newmaxcount, incrtime = @newincrtime, ExtendedCost = @newExtendedCost, type = @newtype WHERE eventEntry = @eventEntry AND guid = @guid AND slot = @slot AND item = @item AND maxcount = @maxcount AND incrtime = @incrtime AND ExtendedCost = @ExtendedCost AND type = @type;";
			MySqlParameter OLD_evententryParameter = new MySqlParameter("@eventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_guidParameter = new MySqlParameter("@guid", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_slotParameter = new MySqlParameter("@slot", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_itemParameter = new MySqlParameter("@item", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_maxcountParameter = new MySqlParameter("@maxcount", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_incrtimeParameter = new MySqlParameter("@incrtime", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_extendedcostParameter = new MySqlParameter("@ExtendedCost", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_typeParameter = new MySqlParameter("@type", MySqlDbType.VarChar, 0);
			MySqlParameter evententryParameter = new MySqlParameter("@neweventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter guidParameter = new MySqlParameter("@newguid", MySqlDbType.VarChar, 0);
			MySqlParameter slotParameter = new MySqlParameter("@newslot", MySqlDbType.VarChar, 0);
			MySqlParameter itemParameter = new MySqlParameter("@newitem", MySqlDbType.VarChar, 0);
			MySqlParameter maxcountParameter = new MySqlParameter("@newmaxcount", MySqlDbType.VarChar, 0);
			MySqlParameter incrtimeParameter = new MySqlParameter("@newincrtime", MySqlDbType.VarChar, 0);
			MySqlParameter extendedcostParameter = new MySqlParameter("@newExtendedCost", MySqlDbType.VarChar, 0);
			MySqlParameter typeParameter = new MySqlParameter("@newtype", MySqlDbType.VarChar, 0);
			evententryParameter.Value = eventEntry;
			guidParameter.Value = guid;
			slotParameter.Value = slot;
			itemParameter.Value = item;
			maxcountParameter.Value = maxcount;
			incrtimeParameter.Value = incrtime;
			extendedcostParameter.Value = ExtendedCost;
			typeParameter.Value = type;
			OLD_evententryParameter.Value = OLD_eventEntry;
			OLD_guidParameter.Value = OLD_guid;
			OLD_slotParameter.Value = OLD_slot;
			OLD_itemParameter.Value = OLD_item;
			OLD_maxcountParameter.Value = OLD_maxcount;
			OLD_incrtimeParameter.Value = OLD_incrtime;
			OLD_extendedcostParameter.Value = OLD_ExtendedCost;
			OLD_typeParameter.Value = OLD_type;
			cmd.Parameters.Add(evententryParameter);
			cmd.Parameters.Add(guidParameter);
			cmd.Parameters.Add(slotParameter);
			cmd.Parameters.Add(itemParameter);
			cmd.Parameters.Add(maxcountParameter);
			cmd.Parameters.Add(incrtimeParameter);
			cmd.Parameters.Add(extendedcostParameter);
			cmd.Parameters.Add(typeParameter);
			cmd.Parameters.Add(OLD_evententryParameter);
			cmd.Parameters.Add(OLD_guidParameter);
			cmd.Parameters.Add(OLD_slotParameter);
			cmd.Parameters.Add(OLD_itemParameter);
			cmd.Parameters.Add(OLD_maxcountParameter);
			cmd.Parameters.Add(OLD_incrtimeParameter);
			cmd.Parameters.Add(OLD_extendedcostParameter);
			cmd.Parameters.Add(OLD_typeParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_eventEntry = eventEntry;
			OLD_guid = guid;
			OLD_slot = slot;
			OLD_item = item;
			OLD_maxcount = maxcount;
			OLD_incrtime = incrtime;
			OLD_ExtendedCost = ExtendedCost;
			OLD_type = type;
		}
	}
}
