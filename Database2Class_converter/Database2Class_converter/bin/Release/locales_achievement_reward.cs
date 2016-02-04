using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Locales_achievement_reward
	{
		int entry = 0; //Comment: 
		int OLD_entry = 0;

		string subject_loc1 = null; //Comment: 
		string OLD_subject_loc1 = null;

		string subject_loc2 = null; //Comment: 
		string OLD_subject_loc2 = null;

		string subject_loc3 = null; //Comment: 
		string OLD_subject_loc3 = null;

		string subject_loc4 = null; //Comment: 
		string OLD_subject_loc4 = null;

		string subject_loc5 = null; //Comment: 
		string OLD_subject_loc5 = null;

		string subject_loc6 = null; //Comment: 
		string OLD_subject_loc6 = null;

		string subject_loc7 = null; //Comment: 
		string OLD_subject_loc7 = null;

		string subject_loc8 = null; //Comment: 
		string OLD_subject_loc8 = null;

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

		public Locales_achievement_reward(int _entry, string _subject_loc1, string _subject_loc2, string _subject_loc3, string _subject_loc4, string _subject_loc5, string _subject_loc6, string _subject_loc7, string _subject_loc8, string _text_loc1, string _text_loc2, string _text_loc3, string _text_loc4, string _text_loc5, string _text_loc6, string _text_loc7, string _text_loc8)
		{
			entry = _entry;
			subject_loc1 = _subject_loc1;
			subject_loc2 = _subject_loc2;
			subject_loc3 = _subject_loc3;
			subject_loc4 = _subject_loc4;
			subject_loc5 = _subject_loc5;
			subject_loc6 = _subject_loc6;
			subject_loc7 = _subject_loc7;
			subject_loc8 = _subject_loc8;
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
			cmd.CommandText = "DELETE FROM locales_achievement_reward WHERE entry = @entry AND subject_loc1 = @subject_loc1 AND subject_loc2 = @subject_loc2 AND subject_loc3 = @subject_loc3 AND subject_loc4 = @subject_loc4 AND subject_loc5 = @subject_loc5 AND subject_loc6 = @subject_loc6 AND subject_loc7 = @subject_loc7 AND subject_loc8 = @subject_loc8 AND text_loc1 = @text_loc1 AND text_loc2 = @text_loc2 AND text_loc3 = @text_loc3 AND text_loc4 = @text_loc4 AND text_loc5 = @text_loc5 AND text_loc6 = @text_loc6 AND text_loc7 = @text_loc7 AND text_loc8 = @text_loc8;";
			MySqlParameter entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter subject_loc1Parameter = new MySqlParameter("@subject_loc1", MySqlDbType.VarChar, 0);
			MySqlParameter subject_loc2Parameter = new MySqlParameter("@subject_loc2", MySqlDbType.VarChar, 0);
			MySqlParameter subject_loc3Parameter = new MySqlParameter("@subject_loc3", MySqlDbType.VarChar, 0);
			MySqlParameter subject_loc4Parameter = new MySqlParameter("@subject_loc4", MySqlDbType.VarChar, 0);
			MySqlParameter subject_loc5Parameter = new MySqlParameter("@subject_loc5", MySqlDbType.VarChar, 0);
			MySqlParameter subject_loc6Parameter = new MySqlParameter("@subject_loc6", MySqlDbType.VarChar, 0);
			MySqlParameter subject_loc7Parameter = new MySqlParameter("@subject_loc7", MySqlDbType.VarChar, 0);
			MySqlParameter subject_loc8Parameter = new MySqlParameter("@subject_loc8", MySqlDbType.VarChar, 0);
			MySqlParameter text_loc1Parameter = new MySqlParameter("@text_loc1", MySqlDbType.VarChar, 0);
			MySqlParameter text_loc2Parameter = new MySqlParameter("@text_loc2", MySqlDbType.VarChar, 0);
			MySqlParameter text_loc3Parameter = new MySqlParameter("@text_loc3", MySqlDbType.VarChar, 0);
			MySqlParameter text_loc4Parameter = new MySqlParameter("@text_loc4", MySqlDbType.VarChar, 0);
			MySqlParameter text_loc5Parameter = new MySqlParameter("@text_loc5", MySqlDbType.VarChar, 0);
			MySqlParameter text_loc6Parameter = new MySqlParameter("@text_loc6", MySqlDbType.VarChar, 0);
			MySqlParameter text_loc7Parameter = new MySqlParameter("@text_loc7", MySqlDbType.VarChar, 0);
			MySqlParameter text_loc8Parameter = new MySqlParameter("@text_loc8", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			subject_loc1Parameter.Value = subject_loc1;
			subject_loc2Parameter.Value = subject_loc2;
			subject_loc3Parameter.Value = subject_loc3;
			subject_loc4Parameter.Value = subject_loc4;
			subject_loc5Parameter.Value = subject_loc5;
			subject_loc6Parameter.Value = subject_loc6;
			subject_loc7Parameter.Value = subject_loc7;
			subject_loc8Parameter.Value = subject_loc8;
			text_loc1Parameter.Value = text_loc1;
			text_loc2Parameter.Value = text_loc2;
			text_loc3Parameter.Value = text_loc3;
			text_loc4Parameter.Value = text_loc4;
			text_loc5Parameter.Value = text_loc5;
			text_loc6Parameter.Value = text_loc6;
			text_loc7Parameter.Value = text_loc7;
			text_loc8Parameter.Value = text_loc8;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(subject_loc1Parameter);
			cmd.Parameters.Add(subject_loc2Parameter);
			cmd.Parameters.Add(subject_loc3Parameter);
			cmd.Parameters.Add(subject_loc4Parameter);
			cmd.Parameters.Add(subject_loc5Parameter);
			cmd.Parameters.Add(subject_loc6Parameter);
			cmd.Parameters.Add(subject_loc7Parameter);
			cmd.Parameters.Add(subject_loc8Parameter);
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
			cmd.CommandText = "UPDATE locales_achievement_reward SET entry = @newentry, subject_loc1 = @newsubject_loc1, subject_loc2 = @newsubject_loc2, subject_loc3 = @newsubject_loc3, subject_loc4 = @newsubject_loc4, subject_loc5 = @newsubject_loc5, subject_loc6 = @newsubject_loc6, subject_loc7 = @newsubject_loc7, subject_loc8 = @newsubject_loc8, text_loc1 = @newtext_loc1, text_loc2 = @newtext_loc2, text_loc3 = @newtext_loc3, text_loc4 = @newtext_loc4, text_loc5 = @newtext_loc5, text_loc6 = @newtext_loc6, text_loc7 = @newtext_loc7, text_loc8 = @newtext_loc8 WHERE entry = @entry AND subject_loc1 = @subject_loc1 AND subject_loc2 = @subject_loc2 AND subject_loc3 = @subject_loc3 AND subject_loc4 = @subject_loc4 AND subject_loc5 = @subject_loc5 AND subject_loc6 = @subject_loc6 AND subject_loc7 = @subject_loc7 AND subject_loc8 = @subject_loc8 AND text_loc1 = @text_loc1 AND text_loc2 = @text_loc2 AND text_loc3 = @text_loc3 AND text_loc4 = @text_loc4 AND text_loc5 = @text_loc5 AND text_loc6 = @text_loc6 AND text_loc7 = @text_loc7 AND text_loc8 = @text_loc8;";
			MySqlParameter OLD_entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_subject_loc1Parameter = new MySqlParameter("@subject_loc1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_subject_loc2Parameter = new MySqlParameter("@subject_loc2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_subject_loc3Parameter = new MySqlParameter("@subject_loc3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_subject_loc4Parameter = new MySqlParameter("@subject_loc4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_subject_loc5Parameter = new MySqlParameter("@subject_loc5", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_subject_loc6Parameter = new MySqlParameter("@subject_loc6", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_subject_loc7Parameter = new MySqlParameter("@subject_loc7", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_subject_loc8Parameter = new MySqlParameter("@subject_loc8", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_text_loc1Parameter = new MySqlParameter("@text_loc1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_text_loc2Parameter = new MySqlParameter("@text_loc2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_text_loc3Parameter = new MySqlParameter("@text_loc3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_text_loc4Parameter = new MySqlParameter("@text_loc4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_text_loc5Parameter = new MySqlParameter("@text_loc5", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_text_loc6Parameter = new MySqlParameter("@text_loc6", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_text_loc7Parameter = new MySqlParameter("@text_loc7", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_text_loc8Parameter = new MySqlParameter("@text_loc8", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@newentry", MySqlDbType.VarChar, 0);
			MySqlParameter subject_loc1Parameter = new MySqlParameter("@newsubject_loc1", MySqlDbType.VarChar, 0);
			MySqlParameter subject_loc2Parameter = new MySqlParameter("@newsubject_loc2", MySqlDbType.VarChar, 0);
			MySqlParameter subject_loc3Parameter = new MySqlParameter("@newsubject_loc3", MySqlDbType.VarChar, 0);
			MySqlParameter subject_loc4Parameter = new MySqlParameter("@newsubject_loc4", MySqlDbType.VarChar, 0);
			MySqlParameter subject_loc5Parameter = new MySqlParameter("@newsubject_loc5", MySqlDbType.VarChar, 0);
			MySqlParameter subject_loc6Parameter = new MySqlParameter("@newsubject_loc6", MySqlDbType.VarChar, 0);
			MySqlParameter subject_loc7Parameter = new MySqlParameter("@newsubject_loc7", MySqlDbType.VarChar, 0);
			MySqlParameter subject_loc8Parameter = new MySqlParameter("@newsubject_loc8", MySqlDbType.VarChar, 0);
			MySqlParameter text_loc1Parameter = new MySqlParameter("@newtext_loc1", MySqlDbType.VarChar, 0);
			MySqlParameter text_loc2Parameter = new MySqlParameter("@newtext_loc2", MySqlDbType.VarChar, 0);
			MySqlParameter text_loc3Parameter = new MySqlParameter("@newtext_loc3", MySqlDbType.VarChar, 0);
			MySqlParameter text_loc4Parameter = new MySqlParameter("@newtext_loc4", MySqlDbType.VarChar, 0);
			MySqlParameter text_loc5Parameter = new MySqlParameter("@newtext_loc5", MySqlDbType.VarChar, 0);
			MySqlParameter text_loc6Parameter = new MySqlParameter("@newtext_loc6", MySqlDbType.VarChar, 0);
			MySqlParameter text_loc7Parameter = new MySqlParameter("@newtext_loc7", MySqlDbType.VarChar, 0);
			MySqlParameter text_loc8Parameter = new MySqlParameter("@newtext_loc8", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			subject_loc1Parameter.Value = subject_loc1;
			subject_loc2Parameter.Value = subject_loc2;
			subject_loc3Parameter.Value = subject_loc3;
			subject_loc4Parameter.Value = subject_loc4;
			subject_loc5Parameter.Value = subject_loc5;
			subject_loc6Parameter.Value = subject_loc6;
			subject_loc7Parameter.Value = subject_loc7;
			subject_loc8Parameter.Value = subject_loc8;
			text_loc1Parameter.Value = text_loc1;
			text_loc2Parameter.Value = text_loc2;
			text_loc3Parameter.Value = text_loc3;
			text_loc4Parameter.Value = text_loc4;
			text_loc5Parameter.Value = text_loc5;
			text_loc6Parameter.Value = text_loc6;
			text_loc7Parameter.Value = text_loc7;
			text_loc8Parameter.Value = text_loc8;
			OLD_entryParameter.Value = OLD_entry;
			OLD_subject_loc1Parameter.Value = OLD_subject_loc1;
			OLD_subject_loc2Parameter.Value = OLD_subject_loc2;
			OLD_subject_loc3Parameter.Value = OLD_subject_loc3;
			OLD_subject_loc4Parameter.Value = OLD_subject_loc4;
			OLD_subject_loc5Parameter.Value = OLD_subject_loc5;
			OLD_subject_loc6Parameter.Value = OLD_subject_loc6;
			OLD_subject_loc7Parameter.Value = OLD_subject_loc7;
			OLD_subject_loc8Parameter.Value = OLD_subject_loc8;
			OLD_text_loc1Parameter.Value = OLD_text_loc1;
			OLD_text_loc2Parameter.Value = OLD_text_loc2;
			OLD_text_loc3Parameter.Value = OLD_text_loc3;
			OLD_text_loc4Parameter.Value = OLD_text_loc4;
			OLD_text_loc5Parameter.Value = OLD_text_loc5;
			OLD_text_loc6Parameter.Value = OLD_text_loc6;
			OLD_text_loc7Parameter.Value = OLD_text_loc7;
			OLD_text_loc8Parameter.Value = OLD_text_loc8;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(subject_loc1Parameter);
			cmd.Parameters.Add(subject_loc2Parameter);
			cmd.Parameters.Add(subject_loc3Parameter);
			cmd.Parameters.Add(subject_loc4Parameter);
			cmd.Parameters.Add(subject_loc5Parameter);
			cmd.Parameters.Add(subject_loc6Parameter);
			cmd.Parameters.Add(subject_loc7Parameter);
			cmd.Parameters.Add(subject_loc8Parameter);
			cmd.Parameters.Add(text_loc1Parameter);
			cmd.Parameters.Add(text_loc2Parameter);
			cmd.Parameters.Add(text_loc3Parameter);
			cmd.Parameters.Add(text_loc4Parameter);
			cmd.Parameters.Add(text_loc5Parameter);
			cmd.Parameters.Add(text_loc6Parameter);
			cmd.Parameters.Add(text_loc7Parameter);
			cmd.Parameters.Add(text_loc8Parameter);
			cmd.Parameters.Add(OLD_entryParameter);
			cmd.Parameters.Add(OLD_subject_loc1Parameter);
			cmd.Parameters.Add(OLD_subject_loc2Parameter);
			cmd.Parameters.Add(OLD_subject_loc3Parameter);
			cmd.Parameters.Add(OLD_subject_loc4Parameter);
			cmd.Parameters.Add(OLD_subject_loc5Parameter);
			cmd.Parameters.Add(OLD_subject_loc6Parameter);
			cmd.Parameters.Add(OLD_subject_loc7Parameter);
			cmd.Parameters.Add(OLD_subject_loc8Parameter);
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
			OLD_subject_loc1 = subject_loc1;
			OLD_subject_loc2 = subject_loc2;
			OLD_subject_loc3 = subject_loc3;
			OLD_subject_loc4 = subject_loc4;
			OLD_subject_loc5 = subject_loc5;
			OLD_subject_loc6 = subject_loc6;
			OLD_subject_loc7 = subject_loc7;
			OLD_subject_loc8 = subject_loc8;
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
