using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Trinity_string
	{
		int entry = 0; //Comment: 
		int OLD_entry = 0;

		string content_default = null; //Comment: 
		string OLD_content_default = null;

		string content_loc1 = null; //Comment: 
		string OLD_content_loc1 = null;

		string content_loc2 = null; //Comment: 
		string OLD_content_loc2 = null;

		string content_loc3 = null; //Comment: 
		string OLD_content_loc3 = null;

		string content_loc4 = null; //Comment: 
		string OLD_content_loc4 = null;

		string content_loc5 = null; //Comment: 
		string OLD_content_loc5 = null;

		string content_loc6 = null; //Comment: 
		string OLD_content_loc6 = null;

		string content_loc7 = null; //Comment: 
		string OLD_content_loc7 = null;

		string content_loc8 = null; //Comment: 
		string OLD_content_loc8 = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Trinity_string(int _entry, string _content_default, string _content_loc1, string _content_loc2, string _content_loc3, string _content_loc4, string _content_loc5, string _content_loc6, string _content_loc7, string _content_loc8)
		{
			entry = _entry;
			content_default = _content_default;
			content_loc1 = _content_loc1;
			content_loc2 = _content_loc2;
			content_loc3 = _content_loc3;
			content_loc4 = _content_loc4;
			content_loc5 = _content_loc5;
			content_loc6 = _content_loc6;
			content_loc7 = _content_loc7;
			content_loc8 = _content_loc8;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM trinity_string WHERE entry = @entry AND content_default = @content_default AND content_loc1 = @content_loc1 AND content_loc2 = @content_loc2 AND content_loc3 = @content_loc3 AND content_loc4 = @content_loc4 AND content_loc5 = @content_loc5 AND content_loc6 = @content_loc6 AND content_loc7 = @content_loc7 AND content_loc8 = @content_loc8;";
			MySqlParameter entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter content_defaultParameter = new MySqlParameter("@content_default", MySqlDbType.VarChar, 0);
			MySqlParameter content_loc1Parameter = new MySqlParameter("@content_loc1", MySqlDbType.VarChar, 0);
			MySqlParameter content_loc2Parameter = new MySqlParameter("@content_loc2", MySqlDbType.VarChar, 0);
			MySqlParameter content_loc3Parameter = new MySqlParameter("@content_loc3", MySqlDbType.VarChar, 0);
			MySqlParameter content_loc4Parameter = new MySqlParameter("@content_loc4", MySqlDbType.VarChar, 0);
			MySqlParameter content_loc5Parameter = new MySqlParameter("@content_loc5", MySqlDbType.VarChar, 0);
			MySqlParameter content_loc6Parameter = new MySqlParameter("@content_loc6", MySqlDbType.VarChar, 0);
			MySqlParameter content_loc7Parameter = new MySqlParameter("@content_loc7", MySqlDbType.VarChar, 0);
			MySqlParameter content_loc8Parameter = new MySqlParameter("@content_loc8", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			content_defaultParameter.Value = content_default;
			content_loc1Parameter.Value = content_loc1;
			content_loc2Parameter.Value = content_loc2;
			content_loc3Parameter.Value = content_loc3;
			content_loc4Parameter.Value = content_loc4;
			content_loc5Parameter.Value = content_loc5;
			content_loc6Parameter.Value = content_loc6;
			content_loc7Parameter.Value = content_loc7;
			content_loc8Parameter.Value = content_loc8;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(content_defaultParameter);
			cmd.Parameters.Add(content_loc1Parameter);
			cmd.Parameters.Add(content_loc2Parameter);
			cmd.Parameters.Add(content_loc3Parameter);
			cmd.Parameters.Add(content_loc4Parameter);
			cmd.Parameters.Add(content_loc5Parameter);
			cmd.Parameters.Add(content_loc6Parameter);
			cmd.Parameters.Add(content_loc7Parameter);
			cmd.Parameters.Add(content_loc8Parameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE trinity_string SET entry = @newentry, content_default = @newcontent_default, content_loc1 = @newcontent_loc1, content_loc2 = @newcontent_loc2, content_loc3 = @newcontent_loc3, content_loc4 = @newcontent_loc4, content_loc5 = @newcontent_loc5, content_loc6 = @newcontent_loc6, content_loc7 = @newcontent_loc7, content_loc8 = @newcontent_loc8 WHERE entry = @entry AND content_default = @content_default AND content_loc1 = @content_loc1 AND content_loc2 = @content_loc2 AND content_loc3 = @content_loc3 AND content_loc4 = @content_loc4 AND content_loc5 = @content_loc5 AND content_loc6 = @content_loc6 AND content_loc7 = @content_loc7 AND content_loc8 = @content_loc8;";
			MySqlParameter OLD_entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_content_defaultParameter = new MySqlParameter("@content_default", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_content_loc1Parameter = new MySqlParameter("@content_loc1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_content_loc2Parameter = new MySqlParameter("@content_loc2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_content_loc3Parameter = new MySqlParameter("@content_loc3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_content_loc4Parameter = new MySqlParameter("@content_loc4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_content_loc5Parameter = new MySqlParameter("@content_loc5", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_content_loc6Parameter = new MySqlParameter("@content_loc6", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_content_loc7Parameter = new MySqlParameter("@content_loc7", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_content_loc8Parameter = new MySqlParameter("@content_loc8", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@newentry", MySqlDbType.VarChar, 0);
			MySqlParameter content_defaultParameter = new MySqlParameter("@newcontent_default", MySqlDbType.VarChar, 0);
			MySqlParameter content_loc1Parameter = new MySqlParameter("@newcontent_loc1", MySqlDbType.VarChar, 0);
			MySqlParameter content_loc2Parameter = new MySqlParameter("@newcontent_loc2", MySqlDbType.VarChar, 0);
			MySqlParameter content_loc3Parameter = new MySqlParameter("@newcontent_loc3", MySqlDbType.VarChar, 0);
			MySqlParameter content_loc4Parameter = new MySqlParameter("@newcontent_loc4", MySqlDbType.VarChar, 0);
			MySqlParameter content_loc5Parameter = new MySqlParameter("@newcontent_loc5", MySqlDbType.VarChar, 0);
			MySqlParameter content_loc6Parameter = new MySqlParameter("@newcontent_loc6", MySqlDbType.VarChar, 0);
			MySqlParameter content_loc7Parameter = new MySqlParameter("@newcontent_loc7", MySqlDbType.VarChar, 0);
			MySqlParameter content_loc8Parameter = new MySqlParameter("@newcontent_loc8", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			content_defaultParameter.Value = content_default;
			content_loc1Parameter.Value = content_loc1;
			content_loc2Parameter.Value = content_loc2;
			content_loc3Parameter.Value = content_loc3;
			content_loc4Parameter.Value = content_loc4;
			content_loc5Parameter.Value = content_loc5;
			content_loc6Parameter.Value = content_loc6;
			content_loc7Parameter.Value = content_loc7;
			content_loc8Parameter.Value = content_loc8;
			OLD_entryParameter.Value = OLD_entry;
			OLD_content_defaultParameter.Value = OLD_content_default;
			OLD_content_loc1Parameter.Value = OLD_content_loc1;
			OLD_content_loc2Parameter.Value = OLD_content_loc2;
			OLD_content_loc3Parameter.Value = OLD_content_loc3;
			OLD_content_loc4Parameter.Value = OLD_content_loc4;
			OLD_content_loc5Parameter.Value = OLD_content_loc5;
			OLD_content_loc6Parameter.Value = OLD_content_loc6;
			OLD_content_loc7Parameter.Value = OLD_content_loc7;
			OLD_content_loc8Parameter.Value = OLD_content_loc8;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(content_defaultParameter);
			cmd.Parameters.Add(content_loc1Parameter);
			cmd.Parameters.Add(content_loc2Parameter);
			cmd.Parameters.Add(content_loc3Parameter);
			cmd.Parameters.Add(content_loc4Parameter);
			cmd.Parameters.Add(content_loc5Parameter);
			cmd.Parameters.Add(content_loc6Parameter);
			cmd.Parameters.Add(content_loc7Parameter);
			cmd.Parameters.Add(content_loc8Parameter);
			cmd.Parameters.Add(OLD_entryParameter);
			cmd.Parameters.Add(OLD_content_defaultParameter);
			cmd.Parameters.Add(OLD_content_loc1Parameter);
			cmd.Parameters.Add(OLD_content_loc2Parameter);
			cmd.Parameters.Add(OLD_content_loc3Parameter);
			cmd.Parameters.Add(OLD_content_loc4Parameter);
			cmd.Parameters.Add(OLD_content_loc5Parameter);
			cmd.Parameters.Add(OLD_content_loc6Parameter);
			cmd.Parameters.Add(OLD_content_loc7Parameter);
			cmd.Parameters.Add(OLD_content_loc8Parameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_entry = entry;
			OLD_content_default = content_default;
			OLD_content_loc1 = content_loc1;
			OLD_content_loc2 = content_loc2;
			OLD_content_loc3 = content_loc3;
			OLD_content_loc4 = content_loc4;
			OLD_content_loc5 = content_loc5;
			OLD_content_loc6 = content_loc6;
			OLD_content_loc7 = content_loc7;
			OLD_content_loc8 = content_loc8;
		}
	}
}
