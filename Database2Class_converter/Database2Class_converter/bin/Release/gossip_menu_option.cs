using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Gossip_menu_option
	{
		int menu_id = 0; //Comment: 
		int OLD_menu_id = 0;

		int id = 0; //Comment: 
		int OLD_id = 0;

		int option_icon = 0; //Comment: 
		int OLD_option_icon = 0;

		string option_text = null; //Comment: 
		string OLD_option_text = null;

		int OptionBroadcastTextID = 0; //Comment: 
		int OLD_OptionBroadcastTextID = 0;

		int option_id = 0; //Comment: 
		int OLD_option_id = 0;

		int npc_option_npcflag = 0; //Comment: 
		int OLD_npc_option_npcflag = 0;

		int action_menu_id = 0; //Comment: 
		int OLD_action_menu_id = 0;

		int action_poi_id = 0; //Comment: 
		int OLD_action_poi_id = 0;

		int box_coded = 0; //Comment: 
		int OLD_box_coded = 0;

		int box_money = 0; //Comment: 
		int OLD_box_money = 0;

		string box_text = null; //Comment: 
		string OLD_box_text = null;

		int BoxBroadcastTextID = 0; //Comment: 
		int OLD_BoxBroadcastTextID = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Gossip_menu_option(int _menu_id, int _id, int _option_icon, string _option_text, int _OptionBroadcastTextID, int _option_id, int _npc_option_npcflag, int _action_menu_id, int _action_poi_id, int _box_coded, int _box_money, string _box_text, int _BoxBroadcastTextID)
		{
			menu_id = _menu_id;
			id = _id;
			option_icon = _option_icon;
			option_text = _option_text;
			OptionBroadcastTextID = _OptionBroadcastTextID;
			option_id = _option_id;
			npc_option_npcflag = _npc_option_npcflag;
			action_menu_id = _action_menu_id;
			action_poi_id = _action_poi_id;
			box_coded = _box_coded;
			box_money = _box_money;
			box_text = _box_text;
			BoxBroadcastTextID = _BoxBroadcastTextID;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM gossip_menu_option WHERE menu_id = @menu_id AND id = @id AND option_icon = @option_icon AND option_text = @option_text AND OptionBroadcastTextID = @OptionBroadcastTextID AND option_id = @option_id AND npc_option_npcflag = @npc_option_npcflag AND action_menu_id = @action_menu_id AND action_poi_id = @action_poi_id AND box_coded = @box_coded AND box_money = @box_money AND box_text = @box_text AND BoxBroadcastTextID = @BoxBroadcastTextID;";
			MySqlParameter menu_idParameter = new MySqlParameter("@menu_id", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@id", MySqlDbType.VarChar, 0);
			MySqlParameter option_iconParameter = new MySqlParameter("@option_icon", MySqlDbType.VarChar, 0);
			MySqlParameter option_textParameter = new MySqlParameter("@option_text", MySqlDbType.VarChar, 0);
			MySqlParameter optionbroadcasttextidParameter = new MySqlParameter("@OptionBroadcastTextID", MySqlDbType.VarChar, 0);
			MySqlParameter option_idParameter = new MySqlParameter("@option_id", MySqlDbType.VarChar, 0);
			MySqlParameter npc_option_npcflagParameter = new MySqlParameter("@npc_option_npcflag", MySqlDbType.VarChar, 0);
			MySqlParameter action_menu_idParameter = new MySqlParameter("@action_menu_id", MySqlDbType.VarChar, 0);
			MySqlParameter action_poi_idParameter = new MySqlParameter("@action_poi_id", MySqlDbType.VarChar, 0);
			MySqlParameter box_codedParameter = new MySqlParameter("@box_coded", MySqlDbType.VarChar, 0);
			MySqlParameter box_moneyParameter = new MySqlParameter("@box_money", MySqlDbType.VarChar, 0);
			MySqlParameter box_textParameter = new MySqlParameter("@box_text", MySqlDbType.VarChar, 0);
			MySqlParameter boxbroadcasttextidParameter = new MySqlParameter("@BoxBroadcastTextID", MySqlDbType.VarChar, 0);
			menu_idParameter.Value = menu_id;
			idParameter.Value = id;
			option_iconParameter.Value = option_icon;
			option_textParameter.Value = option_text;
			optionbroadcasttextidParameter.Value = OptionBroadcastTextID;
			option_idParameter.Value = option_id;
			npc_option_npcflagParameter.Value = npc_option_npcflag;
			action_menu_idParameter.Value = action_menu_id;
			action_poi_idParameter.Value = action_poi_id;
			box_codedParameter.Value = box_coded;
			box_moneyParameter.Value = box_money;
			box_textParameter.Value = box_text;
			boxbroadcasttextidParameter.Value = BoxBroadcastTextID;
			cmd.Parameters.Add(menu_idParameter);
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(option_iconParameter);
			cmd.Parameters.Add(option_textParameter);
			cmd.Parameters.Add(optionbroadcasttextidParameter);
			cmd.Parameters.Add(option_idParameter);
			cmd.Parameters.Add(npc_option_npcflagParameter);
			cmd.Parameters.Add(action_menu_idParameter);
			cmd.Parameters.Add(action_poi_idParameter);
			cmd.Parameters.Add(box_codedParameter);
			cmd.Parameters.Add(box_moneyParameter);
			cmd.Parameters.Add(box_textParameter);
			cmd.Parameters.Add(boxbroadcasttextidParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE gossip_menu_option SET menu_id = @newmenu_id, id = @newid, option_icon = @newoption_icon, option_text = @newoption_text, OptionBroadcastTextID = @newOptionBroadcastTextID, option_id = @newoption_id, npc_option_npcflag = @newnpc_option_npcflag, action_menu_id = @newaction_menu_id, action_poi_id = @newaction_poi_id, box_coded = @newbox_coded, box_money = @newbox_money, box_text = @newbox_text, BoxBroadcastTextID = @newBoxBroadcastTextID WHERE menu_id = @menu_id AND id = @id AND option_icon = @option_icon AND option_text = @option_text AND OptionBroadcastTextID = @OptionBroadcastTextID AND option_id = @option_id AND npc_option_npcflag = @npc_option_npcflag AND action_menu_id = @action_menu_id AND action_poi_id = @action_poi_id AND box_coded = @box_coded AND box_money = @box_money AND box_text = @box_text AND BoxBroadcastTextID = @BoxBroadcastTextID;";
			MySqlParameter OLD_menu_idParameter = new MySqlParameter("@menu_id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_idParameter = new MySqlParameter("@id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_option_iconParameter = new MySqlParameter("@option_icon", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_option_textParameter = new MySqlParameter("@option_text", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_optionbroadcasttextidParameter = new MySqlParameter("@OptionBroadcastTextID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_option_idParameter = new MySqlParameter("@option_id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_npc_option_npcflagParameter = new MySqlParameter("@npc_option_npcflag", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_action_menu_idParameter = new MySqlParameter("@action_menu_id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_action_poi_idParameter = new MySqlParameter("@action_poi_id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_box_codedParameter = new MySqlParameter("@box_coded", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_box_moneyParameter = new MySqlParameter("@box_money", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_box_textParameter = new MySqlParameter("@box_text", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_boxbroadcasttextidParameter = new MySqlParameter("@BoxBroadcastTextID", MySqlDbType.VarChar, 0);
			MySqlParameter menu_idParameter = new MySqlParameter("@newmenu_id", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newid", MySqlDbType.VarChar, 0);
			MySqlParameter option_iconParameter = new MySqlParameter("@newoption_icon", MySqlDbType.VarChar, 0);
			MySqlParameter option_textParameter = new MySqlParameter("@newoption_text", MySqlDbType.VarChar, 0);
			MySqlParameter optionbroadcasttextidParameter = new MySqlParameter("@newOptionBroadcastTextID", MySqlDbType.VarChar, 0);
			MySqlParameter option_idParameter = new MySqlParameter("@newoption_id", MySqlDbType.VarChar, 0);
			MySqlParameter npc_option_npcflagParameter = new MySqlParameter("@newnpc_option_npcflag", MySqlDbType.VarChar, 0);
			MySqlParameter action_menu_idParameter = new MySqlParameter("@newaction_menu_id", MySqlDbType.VarChar, 0);
			MySqlParameter action_poi_idParameter = new MySqlParameter("@newaction_poi_id", MySqlDbType.VarChar, 0);
			MySqlParameter box_codedParameter = new MySqlParameter("@newbox_coded", MySqlDbType.VarChar, 0);
			MySqlParameter box_moneyParameter = new MySqlParameter("@newbox_money", MySqlDbType.VarChar, 0);
			MySqlParameter box_textParameter = new MySqlParameter("@newbox_text", MySqlDbType.VarChar, 0);
			MySqlParameter boxbroadcasttextidParameter = new MySqlParameter("@newBoxBroadcastTextID", MySqlDbType.VarChar, 0);
			menu_idParameter.Value = menu_id;
			idParameter.Value = id;
			option_iconParameter.Value = option_icon;
			option_textParameter.Value = option_text;
			optionbroadcasttextidParameter.Value = OptionBroadcastTextID;
			option_idParameter.Value = option_id;
			npc_option_npcflagParameter.Value = npc_option_npcflag;
			action_menu_idParameter.Value = action_menu_id;
			action_poi_idParameter.Value = action_poi_id;
			box_codedParameter.Value = box_coded;
			box_moneyParameter.Value = box_money;
			box_textParameter.Value = box_text;
			boxbroadcasttextidParameter.Value = BoxBroadcastTextID;
			OLD_menu_idParameter.Value = OLD_menu_id;
			OLD_idParameter.Value = OLD_id;
			OLD_option_iconParameter.Value = OLD_option_icon;
			OLD_option_textParameter.Value = OLD_option_text;
			OLD_optionbroadcasttextidParameter.Value = OLD_OptionBroadcastTextID;
			OLD_option_idParameter.Value = OLD_option_id;
			OLD_npc_option_npcflagParameter.Value = OLD_npc_option_npcflag;
			OLD_action_menu_idParameter.Value = OLD_action_menu_id;
			OLD_action_poi_idParameter.Value = OLD_action_poi_id;
			OLD_box_codedParameter.Value = OLD_box_coded;
			OLD_box_moneyParameter.Value = OLD_box_money;
			OLD_box_textParameter.Value = OLD_box_text;
			OLD_boxbroadcasttextidParameter.Value = OLD_BoxBroadcastTextID;
			cmd.Parameters.Add(menu_idParameter);
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(option_iconParameter);
			cmd.Parameters.Add(option_textParameter);
			cmd.Parameters.Add(optionbroadcasttextidParameter);
			cmd.Parameters.Add(option_idParameter);
			cmd.Parameters.Add(npc_option_npcflagParameter);
			cmd.Parameters.Add(action_menu_idParameter);
			cmd.Parameters.Add(action_poi_idParameter);
			cmd.Parameters.Add(box_codedParameter);
			cmd.Parameters.Add(box_moneyParameter);
			cmd.Parameters.Add(box_textParameter);
			cmd.Parameters.Add(boxbroadcasttextidParameter);
			cmd.Parameters.Add(OLD_menu_idParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_option_iconParameter);
			cmd.Parameters.Add(OLD_option_textParameter);
			cmd.Parameters.Add(OLD_optionbroadcasttextidParameter);
			cmd.Parameters.Add(OLD_option_idParameter);
			cmd.Parameters.Add(OLD_npc_option_npcflagParameter);
			cmd.Parameters.Add(OLD_action_menu_idParameter);
			cmd.Parameters.Add(OLD_action_poi_idParameter);
			cmd.Parameters.Add(OLD_box_codedParameter);
			cmd.Parameters.Add(OLD_box_moneyParameter);
			cmd.Parameters.Add(OLD_box_textParameter);
			cmd.Parameters.Add(OLD_boxbroadcasttextidParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_menu_id = menu_id;
			OLD_id = id;
			OLD_option_icon = option_icon;
			OLD_option_text = option_text;
			OLD_OptionBroadcastTextID = OptionBroadcastTextID;
			OLD_option_id = option_id;
			OLD_npc_option_npcflag = npc_option_npcflag;
			OLD_action_menu_id = action_menu_id;
			OLD_action_poi_id = action_poi_id;
			OLD_box_coded = box_coded;
			OLD_box_money = box_money;
			OLD_box_text = box_text;
			OLD_BoxBroadcastTextID = BoxBroadcastTextID;
		}
	}
}
