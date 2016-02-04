using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Locales_gossip_menu_option
	{
		int menu_id = 0; //Comment: 
		int OLD_menu_id = 0;

		int id = 0; //Comment: 
		int OLD_id = 0;

		string option_text_loc1 = null; //Comment: 
		string OLD_option_text_loc1 = null;

		string option_text_loc2 = null; //Comment: 
		string OLD_option_text_loc2 = null;

		string option_text_loc3 = null; //Comment: 
		string OLD_option_text_loc3 = null;

		string option_text_loc4 = null; //Comment: 
		string OLD_option_text_loc4 = null;

		string option_text_loc5 = null; //Comment: 
		string OLD_option_text_loc5 = null;

		string option_text_loc6 = null; //Comment: 
		string OLD_option_text_loc6 = null;

		string option_text_loc7 = null; //Comment: 
		string OLD_option_text_loc7 = null;

		string option_text_loc8 = null; //Comment: 
		string OLD_option_text_loc8 = null;

		string box_text_loc1 = null; //Comment: 
		string OLD_box_text_loc1 = null;

		string box_text_loc2 = null; //Comment: 
		string OLD_box_text_loc2 = null;

		string box_text_loc3 = null; //Comment: 
		string OLD_box_text_loc3 = null;

		string box_text_loc4 = null; //Comment: 
		string OLD_box_text_loc4 = null;

		string box_text_loc5 = null; //Comment: 
		string OLD_box_text_loc5 = null;

		string box_text_loc6 = null; //Comment: 
		string OLD_box_text_loc6 = null;

		string box_text_loc7 = null; //Comment: 
		string OLD_box_text_loc7 = null;

		string box_text_loc8 = null; //Comment: 
		string OLD_box_text_loc8 = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Locales_gossip_menu_option(int _menu_id, int _id, string _option_text_loc1, string _option_text_loc2, string _option_text_loc3, string _option_text_loc4, string _option_text_loc5, string _option_text_loc6, string _option_text_loc7, string _option_text_loc8, string _box_text_loc1, string _box_text_loc2, string _box_text_loc3, string _box_text_loc4, string _box_text_loc5, string _box_text_loc6, string _box_text_loc7, string _box_text_loc8)
		{
			menu_id = _menu_id;
			id = _id;
			option_text_loc1 = _option_text_loc1;
			option_text_loc2 = _option_text_loc2;
			option_text_loc3 = _option_text_loc3;
			option_text_loc4 = _option_text_loc4;
			option_text_loc5 = _option_text_loc5;
			option_text_loc6 = _option_text_loc6;
			option_text_loc7 = _option_text_loc7;
			option_text_loc8 = _option_text_loc8;
			box_text_loc1 = _box_text_loc1;
			box_text_loc2 = _box_text_loc2;
			box_text_loc3 = _box_text_loc3;
			box_text_loc4 = _box_text_loc4;
			box_text_loc5 = _box_text_loc5;
			box_text_loc6 = _box_text_loc6;
			box_text_loc7 = _box_text_loc7;
			box_text_loc8 = _box_text_loc8;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM locales_gossip_menu_option WHERE menu_id = @menu_id AND id = @id AND option_text_loc1 = @option_text_loc1 AND option_text_loc2 = @option_text_loc2 AND option_text_loc3 = @option_text_loc3 AND option_text_loc4 = @option_text_loc4 AND option_text_loc5 = @option_text_loc5 AND option_text_loc6 = @option_text_loc6 AND option_text_loc7 = @option_text_loc7 AND option_text_loc8 = @option_text_loc8 AND box_text_loc1 = @box_text_loc1 AND box_text_loc2 = @box_text_loc2 AND box_text_loc3 = @box_text_loc3 AND box_text_loc4 = @box_text_loc4 AND box_text_loc5 = @box_text_loc5 AND box_text_loc6 = @box_text_loc6 AND box_text_loc7 = @box_text_loc7 AND box_text_loc8 = @box_text_loc8;";
			MySqlParameter menu_idParameter = new MySqlParameter("@menu_id", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@id", MySqlDbType.VarChar, 0);
			MySqlParameter option_text_loc1Parameter = new MySqlParameter("@option_text_loc1", MySqlDbType.VarChar, 0);
			MySqlParameter option_text_loc2Parameter = new MySqlParameter("@option_text_loc2", MySqlDbType.VarChar, 0);
			MySqlParameter option_text_loc3Parameter = new MySqlParameter("@option_text_loc3", MySqlDbType.VarChar, 0);
			MySqlParameter option_text_loc4Parameter = new MySqlParameter("@option_text_loc4", MySqlDbType.VarChar, 0);
			MySqlParameter option_text_loc5Parameter = new MySqlParameter("@option_text_loc5", MySqlDbType.VarChar, 0);
			MySqlParameter option_text_loc6Parameter = new MySqlParameter("@option_text_loc6", MySqlDbType.VarChar, 0);
			MySqlParameter option_text_loc7Parameter = new MySqlParameter("@option_text_loc7", MySqlDbType.VarChar, 0);
			MySqlParameter option_text_loc8Parameter = new MySqlParameter("@option_text_loc8", MySqlDbType.VarChar, 0);
			MySqlParameter box_text_loc1Parameter = new MySqlParameter("@box_text_loc1", MySqlDbType.VarChar, 0);
			MySqlParameter box_text_loc2Parameter = new MySqlParameter("@box_text_loc2", MySqlDbType.VarChar, 0);
			MySqlParameter box_text_loc3Parameter = new MySqlParameter("@box_text_loc3", MySqlDbType.VarChar, 0);
			MySqlParameter box_text_loc4Parameter = new MySqlParameter("@box_text_loc4", MySqlDbType.VarChar, 0);
			MySqlParameter box_text_loc5Parameter = new MySqlParameter("@box_text_loc5", MySqlDbType.VarChar, 0);
			MySqlParameter box_text_loc6Parameter = new MySqlParameter("@box_text_loc6", MySqlDbType.VarChar, 0);
			MySqlParameter box_text_loc7Parameter = new MySqlParameter("@box_text_loc7", MySqlDbType.VarChar, 0);
			MySqlParameter box_text_loc8Parameter = new MySqlParameter("@box_text_loc8", MySqlDbType.VarChar, 0);
			menu_idParameter.Value = menu_id;
			idParameter.Value = id;
			option_text_loc1Parameter.Value = option_text_loc1;
			option_text_loc2Parameter.Value = option_text_loc2;
			option_text_loc3Parameter.Value = option_text_loc3;
			option_text_loc4Parameter.Value = option_text_loc4;
			option_text_loc5Parameter.Value = option_text_loc5;
			option_text_loc6Parameter.Value = option_text_loc6;
			option_text_loc7Parameter.Value = option_text_loc7;
			option_text_loc8Parameter.Value = option_text_loc8;
			box_text_loc1Parameter.Value = box_text_loc1;
			box_text_loc2Parameter.Value = box_text_loc2;
			box_text_loc3Parameter.Value = box_text_loc3;
			box_text_loc4Parameter.Value = box_text_loc4;
			box_text_loc5Parameter.Value = box_text_loc5;
			box_text_loc6Parameter.Value = box_text_loc6;
			box_text_loc7Parameter.Value = box_text_loc7;
			box_text_loc8Parameter.Value = box_text_loc8;
			cmd.Parameters.Add(menu_idParameter);
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(option_text_loc1Parameter);
			cmd.Parameters.Add(option_text_loc2Parameter);
			cmd.Parameters.Add(option_text_loc3Parameter);
			cmd.Parameters.Add(option_text_loc4Parameter);
			cmd.Parameters.Add(option_text_loc5Parameter);
			cmd.Parameters.Add(option_text_loc6Parameter);
			cmd.Parameters.Add(option_text_loc7Parameter);
			cmd.Parameters.Add(option_text_loc8Parameter);
			cmd.Parameters.Add(box_text_loc1Parameter);
			cmd.Parameters.Add(box_text_loc2Parameter);
			cmd.Parameters.Add(box_text_loc3Parameter);
			cmd.Parameters.Add(box_text_loc4Parameter);
			cmd.Parameters.Add(box_text_loc5Parameter);
			cmd.Parameters.Add(box_text_loc6Parameter);
			cmd.Parameters.Add(box_text_loc7Parameter);
			cmd.Parameters.Add(box_text_loc8Parameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE locales_gossip_menu_option SET menu_id = @newmenu_id, id = @newid, option_text_loc1 = @newoption_text_loc1, option_text_loc2 = @newoption_text_loc2, option_text_loc3 = @newoption_text_loc3, option_text_loc4 = @newoption_text_loc4, option_text_loc5 = @newoption_text_loc5, option_text_loc6 = @newoption_text_loc6, option_text_loc7 = @newoption_text_loc7, option_text_loc8 = @newoption_text_loc8, box_text_loc1 = @newbox_text_loc1, box_text_loc2 = @newbox_text_loc2, box_text_loc3 = @newbox_text_loc3, box_text_loc4 = @newbox_text_loc4, box_text_loc5 = @newbox_text_loc5, box_text_loc6 = @newbox_text_loc6, box_text_loc7 = @newbox_text_loc7, box_text_loc8 = @newbox_text_loc8 WHERE menu_id = @menu_id AND id = @id AND option_text_loc1 = @option_text_loc1 AND option_text_loc2 = @option_text_loc2 AND option_text_loc3 = @option_text_loc3 AND option_text_loc4 = @option_text_loc4 AND option_text_loc5 = @option_text_loc5 AND option_text_loc6 = @option_text_loc6 AND option_text_loc7 = @option_text_loc7 AND option_text_loc8 = @option_text_loc8 AND box_text_loc1 = @box_text_loc1 AND box_text_loc2 = @box_text_loc2 AND box_text_loc3 = @box_text_loc3 AND box_text_loc4 = @box_text_loc4 AND box_text_loc5 = @box_text_loc5 AND box_text_loc6 = @box_text_loc6 AND box_text_loc7 = @box_text_loc7 AND box_text_loc8 = @box_text_loc8;";
			MySqlParameter OLD_menu_idParameter = new MySqlParameter("@menu_id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_idParameter = new MySqlParameter("@id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_option_text_loc1Parameter = new MySqlParameter("@option_text_loc1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_option_text_loc2Parameter = new MySqlParameter("@option_text_loc2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_option_text_loc3Parameter = new MySqlParameter("@option_text_loc3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_option_text_loc4Parameter = new MySqlParameter("@option_text_loc4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_option_text_loc5Parameter = new MySqlParameter("@option_text_loc5", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_option_text_loc6Parameter = new MySqlParameter("@option_text_loc6", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_option_text_loc7Parameter = new MySqlParameter("@option_text_loc7", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_option_text_loc8Parameter = new MySqlParameter("@option_text_loc8", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_box_text_loc1Parameter = new MySqlParameter("@box_text_loc1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_box_text_loc2Parameter = new MySqlParameter("@box_text_loc2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_box_text_loc3Parameter = new MySqlParameter("@box_text_loc3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_box_text_loc4Parameter = new MySqlParameter("@box_text_loc4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_box_text_loc5Parameter = new MySqlParameter("@box_text_loc5", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_box_text_loc6Parameter = new MySqlParameter("@box_text_loc6", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_box_text_loc7Parameter = new MySqlParameter("@box_text_loc7", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_box_text_loc8Parameter = new MySqlParameter("@box_text_loc8", MySqlDbType.VarChar, 0);
			MySqlParameter menu_idParameter = new MySqlParameter("@newmenu_id", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newid", MySqlDbType.VarChar, 0);
			MySqlParameter option_text_loc1Parameter = new MySqlParameter("@newoption_text_loc1", MySqlDbType.VarChar, 0);
			MySqlParameter option_text_loc2Parameter = new MySqlParameter("@newoption_text_loc2", MySqlDbType.VarChar, 0);
			MySqlParameter option_text_loc3Parameter = new MySqlParameter("@newoption_text_loc3", MySqlDbType.VarChar, 0);
			MySqlParameter option_text_loc4Parameter = new MySqlParameter("@newoption_text_loc4", MySqlDbType.VarChar, 0);
			MySqlParameter option_text_loc5Parameter = new MySqlParameter("@newoption_text_loc5", MySqlDbType.VarChar, 0);
			MySqlParameter option_text_loc6Parameter = new MySqlParameter("@newoption_text_loc6", MySqlDbType.VarChar, 0);
			MySqlParameter option_text_loc7Parameter = new MySqlParameter("@newoption_text_loc7", MySqlDbType.VarChar, 0);
			MySqlParameter option_text_loc8Parameter = new MySqlParameter("@newoption_text_loc8", MySqlDbType.VarChar, 0);
			MySqlParameter box_text_loc1Parameter = new MySqlParameter("@newbox_text_loc1", MySqlDbType.VarChar, 0);
			MySqlParameter box_text_loc2Parameter = new MySqlParameter("@newbox_text_loc2", MySqlDbType.VarChar, 0);
			MySqlParameter box_text_loc3Parameter = new MySqlParameter("@newbox_text_loc3", MySqlDbType.VarChar, 0);
			MySqlParameter box_text_loc4Parameter = new MySqlParameter("@newbox_text_loc4", MySqlDbType.VarChar, 0);
			MySqlParameter box_text_loc5Parameter = new MySqlParameter("@newbox_text_loc5", MySqlDbType.VarChar, 0);
			MySqlParameter box_text_loc6Parameter = new MySqlParameter("@newbox_text_loc6", MySqlDbType.VarChar, 0);
			MySqlParameter box_text_loc7Parameter = new MySqlParameter("@newbox_text_loc7", MySqlDbType.VarChar, 0);
			MySqlParameter box_text_loc8Parameter = new MySqlParameter("@newbox_text_loc8", MySqlDbType.VarChar, 0);
			menu_idParameter.Value = menu_id;
			idParameter.Value = id;
			option_text_loc1Parameter.Value = option_text_loc1;
			option_text_loc2Parameter.Value = option_text_loc2;
			option_text_loc3Parameter.Value = option_text_loc3;
			option_text_loc4Parameter.Value = option_text_loc4;
			option_text_loc5Parameter.Value = option_text_loc5;
			option_text_loc6Parameter.Value = option_text_loc6;
			option_text_loc7Parameter.Value = option_text_loc7;
			option_text_loc8Parameter.Value = option_text_loc8;
			box_text_loc1Parameter.Value = box_text_loc1;
			box_text_loc2Parameter.Value = box_text_loc2;
			box_text_loc3Parameter.Value = box_text_loc3;
			box_text_loc4Parameter.Value = box_text_loc4;
			box_text_loc5Parameter.Value = box_text_loc5;
			box_text_loc6Parameter.Value = box_text_loc6;
			box_text_loc7Parameter.Value = box_text_loc7;
			box_text_loc8Parameter.Value = box_text_loc8;
			OLD_menu_idParameter.Value = OLD_menu_id;
			OLD_idParameter.Value = OLD_id;
			OLD_option_text_loc1Parameter.Value = OLD_option_text_loc1;
			OLD_option_text_loc2Parameter.Value = OLD_option_text_loc2;
			OLD_option_text_loc3Parameter.Value = OLD_option_text_loc3;
			OLD_option_text_loc4Parameter.Value = OLD_option_text_loc4;
			OLD_option_text_loc5Parameter.Value = OLD_option_text_loc5;
			OLD_option_text_loc6Parameter.Value = OLD_option_text_loc6;
			OLD_option_text_loc7Parameter.Value = OLD_option_text_loc7;
			OLD_option_text_loc8Parameter.Value = OLD_option_text_loc8;
			OLD_box_text_loc1Parameter.Value = OLD_box_text_loc1;
			OLD_box_text_loc2Parameter.Value = OLD_box_text_loc2;
			OLD_box_text_loc3Parameter.Value = OLD_box_text_loc3;
			OLD_box_text_loc4Parameter.Value = OLD_box_text_loc4;
			OLD_box_text_loc5Parameter.Value = OLD_box_text_loc5;
			OLD_box_text_loc6Parameter.Value = OLD_box_text_loc6;
			OLD_box_text_loc7Parameter.Value = OLD_box_text_loc7;
			OLD_box_text_loc8Parameter.Value = OLD_box_text_loc8;
			cmd.Parameters.Add(menu_idParameter);
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(option_text_loc1Parameter);
			cmd.Parameters.Add(option_text_loc2Parameter);
			cmd.Parameters.Add(option_text_loc3Parameter);
			cmd.Parameters.Add(option_text_loc4Parameter);
			cmd.Parameters.Add(option_text_loc5Parameter);
			cmd.Parameters.Add(option_text_loc6Parameter);
			cmd.Parameters.Add(option_text_loc7Parameter);
			cmd.Parameters.Add(option_text_loc8Parameter);
			cmd.Parameters.Add(box_text_loc1Parameter);
			cmd.Parameters.Add(box_text_loc2Parameter);
			cmd.Parameters.Add(box_text_loc3Parameter);
			cmd.Parameters.Add(box_text_loc4Parameter);
			cmd.Parameters.Add(box_text_loc5Parameter);
			cmd.Parameters.Add(box_text_loc6Parameter);
			cmd.Parameters.Add(box_text_loc7Parameter);
			cmd.Parameters.Add(box_text_loc8Parameter);
			cmd.Parameters.Add(OLD_menu_idParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_option_text_loc1Parameter);
			cmd.Parameters.Add(OLD_option_text_loc2Parameter);
			cmd.Parameters.Add(OLD_option_text_loc3Parameter);
			cmd.Parameters.Add(OLD_option_text_loc4Parameter);
			cmd.Parameters.Add(OLD_option_text_loc5Parameter);
			cmd.Parameters.Add(OLD_option_text_loc6Parameter);
			cmd.Parameters.Add(OLD_option_text_loc7Parameter);
			cmd.Parameters.Add(OLD_option_text_loc8Parameter);
			cmd.Parameters.Add(OLD_box_text_loc1Parameter);
			cmd.Parameters.Add(OLD_box_text_loc2Parameter);
			cmd.Parameters.Add(OLD_box_text_loc3Parameter);
			cmd.Parameters.Add(OLD_box_text_loc4Parameter);
			cmd.Parameters.Add(OLD_box_text_loc5Parameter);
			cmd.Parameters.Add(OLD_box_text_loc6Parameter);
			cmd.Parameters.Add(OLD_box_text_loc7Parameter);
			cmd.Parameters.Add(OLD_box_text_loc8Parameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_menu_id = menu_id;
			OLD_id = id;
			OLD_option_text_loc1 = option_text_loc1;
			OLD_option_text_loc2 = option_text_loc2;
			OLD_option_text_loc3 = option_text_loc3;
			OLD_option_text_loc4 = option_text_loc4;
			OLD_option_text_loc5 = option_text_loc5;
			OLD_option_text_loc6 = option_text_loc6;
			OLD_option_text_loc7 = option_text_loc7;
			OLD_option_text_loc8 = option_text_loc8;
			OLD_box_text_loc1 = box_text_loc1;
			OLD_box_text_loc2 = box_text_loc2;
			OLD_box_text_loc3 = box_text_loc3;
			OLD_box_text_loc4 = box_text_loc4;
			OLD_box_text_loc5 = box_text_loc5;
			OLD_box_text_loc6 = box_text_loc6;
			OLD_box_text_loc7 = box_text_loc7;
			OLD_box_text_loc8 = box_text_loc8;
		}
	}
}
