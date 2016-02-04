using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Locales_creature_text
	{
		int entry = 0; //Comment: 
		int OLD_entry = 0;

		int groupid = 0; //Comment: 
		int OLD_groupid = 0;

		int id = 0; //Comment: 
		int OLD_id = 0;

		string text_loc1 = null; //Comment: 
		string OLD_text_loc1 = null;

		string text_loc2 = null; //Comment: 
		string OLD_text_loc2 = null;

		string text_loc3 = null; //Comment: 
		string OLD_text_loc3 = null;

		string text_loc4 = null; //Comment: 
		string OLD_text_loc4 = null;

		string text_loc5 = null; //Comment: 
		string OLD_text_loc5 = null;

		string text_loc6 = null; //Comment: 
		string OLD_text_loc6 = null;

		string text_loc7 = null; //Comment: 
		string OLD_text_loc7 = null;

		string text_loc8 = null; //Comment: 
		string OLD_text_loc8 = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Locales_creature_text(int _entry, int _groupid, int _id, string _text_loc1, string _text_loc2, string _text_loc3, string _text_loc4, string _text_loc5, string _text_loc6, string _text_loc7, string _text_loc8)
		{
			entry = _entry;
			groupid = _groupid;
			id = _id;
			text_loc1 = _text_loc1;
			text_loc2 = _text_loc2;
			text_loc3 = _text_loc3;
			text_loc4 = _text_loc4;
			text_loc5 = _text_loc5;
			text_loc6 = _text_loc6;
			text_loc7 = _text_loc7;
			text_loc8 = _text_loc8;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM locales_creature_text WHERE entry = @entry AND groupid = @groupid AND id = @id AND text_loc1 = @text_loc1 AND text_loc2 = @text_loc2 AND text_loc3 = @text_loc3 AND text_loc4 = @text_loc4 AND text_loc5 = @text_loc5 AND text_loc6 = @text_loc6 AND text_loc7 = @text_loc7 AND text_loc8 = @text_loc8;";
			MySqlParameter entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter groupidParameter = new MySqlParameter("@groupid", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@id", MySqlDbType.VarChar, 0);
			MySqlParameter text_loc1Parameter = new MySqlParameter("@text_loc1", MySqlDbType.VarChar, 0);
			MySqlParameter text_loc2Parameter = new MySqlParameter("@text_loc2", MySqlDbType.VarChar, 0);
			MySqlParameter text_loc3Parameter = new MySqlParameter("@text_loc3", MySqlDbType.VarChar, 0);
			MySqlParameter text_loc4Parameter = new MySqlParameter("@text_loc4", MySqlDbType.VarChar, 0);
			MySqlParameter text_loc5Parameter = new MySqlParameter("@text_loc5", MySqlDbType.VarChar, 0);
			MySqlParameter text_loc6Parameter = new MySqlParameter("@text_loc6", MySqlDbType.VarChar, 0);
			MySqlParameter text_loc7Parameter = new MySqlParameter("@text_loc7", MySqlDbType.VarChar, 0);
			MySqlParameter text_loc8Parameter = new MySqlParameter("@text_loc8", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			groupidParameter.Value = groupid;
			idParameter.Value = id;
			text_loc1Parameter.Value = text_loc1;
			text_loc2Parameter.Value = text_loc2;
			text_loc3Parameter.Value = text_loc3;
			text_loc4Parameter.Value = text_loc4;
			text_loc5Parameter.Value = text_loc5;
			text_loc6Parameter.Value = text_loc6;
			text_loc7Parameter.Value = text_loc7;
			text_loc8Parameter.Value = text_loc8;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(groupidParameter);
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(text_loc1Parameter);
			cmd.Parameters.Add(text_loc2Parameter);
			cmd.Parameters.Add(text_loc3Parameter);
			cmd.Parameters.Add(text_loc4Parameter);
			cmd.Parameters.Add(text_loc5Parameter);
			cmd.Parameters.Add(text_loc6Parameter);
			cmd.Parameters.Add(text_loc7Parameter);
			cmd.Parameters.Add(text_loc8Parameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE locales_creature_text SET entry = @newentry, groupid = @newgroupid, id = @newid, text_loc1 = @newtext_loc1, text_loc2 = @newtext_loc2, text_loc3 = @newtext_loc3, text_loc4 = @newtext_loc4, text_loc5 = @newtext_loc5, text_loc6 = @newtext_loc6, text_loc7 = @newtext_loc7, text_loc8 = @newtext_loc8 WHERE entry = @entry AND groupid = @groupid AND id = @id AND text_loc1 = @text_loc1 AND text_loc2 = @text_loc2 AND text_loc3 = @text_loc3 AND text_loc4 = @text_loc4 AND text_loc5 = @text_loc5 AND text_loc6 = @text_loc6 AND text_loc7 = @text_loc7 AND text_loc8 = @text_loc8;";
			MySqlParameter OLD_entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_groupidParameter = new MySqlParameter("@groupid", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_idParameter = new MySqlParameter("@id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_text_loc1Parameter = new MySqlParameter("@text_loc1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_text_loc2Parameter = new MySqlParameter("@text_loc2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_text_loc3Parameter = new MySqlParameter("@text_loc3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_text_loc4Parameter = new MySqlParameter("@text_loc4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_text_loc5Parameter = new MySqlParameter("@text_loc5", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_text_loc6Parameter = new MySqlParameter("@text_loc6", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_text_loc7Parameter = new MySqlParameter("@text_loc7", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_text_loc8Parameter = new MySqlParameter("@text_loc8", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@newentry", MySqlDbType.VarChar, 0);
			MySqlParameter groupidParameter = new MySqlParameter("@newgroupid", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newid", MySqlDbType.VarChar, 0);
			MySqlParameter text_loc1Parameter = new MySqlParameter("@newtext_loc1", MySqlDbType.VarChar, 0);
			MySqlParameter text_loc2Parameter = new MySqlParameter("@newtext_loc2", MySqlDbType.VarChar, 0);
			MySqlParameter text_loc3Parameter = new MySqlParameter("@newtext_loc3", MySqlDbType.VarChar, 0);
			MySqlParameter text_loc4Parameter = new MySqlParameter("@newtext_loc4", MySqlDbType.VarChar, 0);
			MySqlParameter text_loc5Parameter = new MySqlParameter("@newtext_loc5", MySqlDbType.VarChar, 0);
			MySqlParameter text_loc6Parameter = new MySqlParameter("@newtext_loc6", MySqlDbType.VarChar, 0);
			MySqlParameter text_loc7Parameter = new MySqlParameter("@newtext_loc7", MySqlDbType.VarChar, 0);
			MySqlParameter text_loc8Parameter = new MySqlParameter("@newtext_loc8", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			groupidParameter.Value = groupid;
			idParameter.Value = id;
			text_loc1Parameter.Value = text_loc1;
			text_loc2Parameter.Value = text_loc2;
			text_loc3Parameter.Value = text_loc3;
			text_loc4Parameter.Value = text_loc4;
			text_loc5Parameter.Value = text_loc5;
			text_loc6Parameter.Value = text_loc6;
			text_loc7Parameter.Value = text_loc7;
			text_loc8Parameter.Value = text_loc8;
			OLD_entryParameter.Value = OLD_entry;
			OLD_groupidParameter.Value = OLD_groupid;
			OLD_idParameter.Value = OLD_id;
			OLD_text_loc1Parameter.Value = OLD_text_loc1;
			OLD_text_loc2Parameter.Value = OLD_text_loc2;
			OLD_text_loc3Parameter.Value = OLD_text_loc3;
			OLD_text_loc4Parameter.Value = OLD_text_loc4;
			OLD_text_loc5Parameter.Value = OLD_text_loc5;
			OLD_text_loc6Parameter.Value = OLD_text_loc6;
			OLD_text_loc7Parameter.Value = OLD_text_loc7;
			OLD_text_loc8Parameter.Value = OLD_text_loc8;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(groupidParameter);
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(text_loc1Parameter);
			cmd.Parameters.Add(text_loc2Parameter);
			cmd.Parameters.Add(text_loc3Parameter);
			cmd.Parameters.Add(text_loc4Parameter);
			cmd.Parameters.Add(text_loc5Parameter);
			cmd.Parameters.Add(text_loc6Parameter);
			cmd.Parameters.Add(text_loc7Parameter);
			cmd.Parameters.Add(text_loc8Parameter);
			cmd.Parameters.Add(OLD_entryParameter);
			cmd.Parameters.Add(OLD_groupidParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_text_loc1Parameter);
			cmd.Parameters.Add(OLD_text_loc2Parameter);
			cmd.Parameters.Add(OLD_text_loc3Parameter);
			cmd.Parameters.Add(OLD_text_loc4Parameter);
			cmd.Parameters.Add(OLD_text_loc5Parameter);
			cmd.Parameters.Add(OLD_text_loc6Parameter);
			cmd.Parameters.Add(OLD_text_loc7Parameter);
			cmd.Parameters.Add(OLD_text_loc8Parameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_entry = entry;
			OLD_groupid = groupid;
			OLD_id = id;
			OLD_text_loc1 = text_loc1;
			OLD_text_loc2 = text_loc2;
			OLD_text_loc3 = text_loc3;
			OLD_text_loc4 = text_loc4;
			OLD_text_loc5 = text_loc5;
			OLD_text_loc6 = text_loc6;
			OLD_text_loc7 = text_loc7;
			OLD_text_loc8 = text_loc8;
		}
	}
}
