using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Achievement_reward
	{
		int entry = 0; //Comment: 
		int OLD_entry = 0;

		int title_A = 0; //Comment: 
		int OLD_title_A = 0;

		int title_H = 0; //Comment: 
		int OLD_title_H = 0;

		int item = 0; //Comment: 
		int OLD_item = 0;

		int sender = 0; //Comment: 
		int OLD_sender = 0;

		string subject = null; //Comment: 
		string OLD_subject = null;

		string text = null; //Comment: 
		string OLD_text = null;

		int mailTemplate = 0; //Comment: 
		int OLD_mailTemplate = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Achievement_reward(int _entry, int _title_A, int _title_H, int _item, int _sender, string _subject, string _text, int _mailTemplate)
		{
			entry = _entry;
			title_A = _title_A;
			title_H = _title_H;
			item = _item;
			sender = _sender;
			subject = _subject;
			text = _text;
			mailTemplate = _mailTemplate;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM achievement_reward WHERE entry = @entry AND title_A = @title_A AND title_H = @title_H AND item = @item AND sender = @sender AND subject = @subject AND text = @text AND mailTemplate = @mailTemplate;";
			MySqlParameter entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter title_aParameter = new MySqlParameter("@title_A", MySqlDbType.VarChar, 0);
			MySqlParameter title_hParameter = new MySqlParameter("@title_H", MySqlDbType.VarChar, 0);
			MySqlParameter itemParameter = new MySqlParameter("@item", MySqlDbType.VarChar, 0);
			MySqlParameter senderParameter = new MySqlParameter("@sender", MySqlDbType.VarChar, 0);
			MySqlParameter subjectParameter = new MySqlParameter("@subject", MySqlDbType.VarChar, 0);
			MySqlParameter textParameter = new MySqlParameter("@text", MySqlDbType.VarChar, 0);
			MySqlParameter mailtemplateParameter = new MySqlParameter("@mailTemplate", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			title_aParameter.Value = title_A;
			title_hParameter.Value = title_H;
			itemParameter.Value = item;
			senderParameter.Value = sender;
			subjectParameter.Value = subject;
			textParameter.Value = text;
			mailtemplateParameter.Value = mailTemplate;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(title_aParameter);
			cmd.Parameters.Add(title_hParameter);
			cmd.Parameters.Add(itemParameter);
			cmd.Parameters.Add(senderParameter);
			cmd.Parameters.Add(subjectParameter);
			cmd.Parameters.Add(textParameter);
			cmd.Parameters.Add(mailtemplateParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE achievement_reward SET entry = @newentry, title_A = @newtitle_A, title_H = @newtitle_H, item = @newitem, sender = @newsender, subject = @newsubject, text = @newtext, mailTemplate = @newmailTemplate WHERE entry = @entry AND title_A = @title_A AND title_H = @title_H AND item = @item AND sender = @sender AND subject = @subject AND text = @text AND mailTemplate = @mailTemplate;";
			MySqlParameter OLD_entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_title_aParameter = new MySqlParameter("@title_A", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_title_hParameter = new MySqlParameter("@title_H", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_itemParameter = new MySqlParameter("@item", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_senderParameter = new MySqlParameter("@sender", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_subjectParameter = new MySqlParameter("@subject", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_textParameter = new MySqlParameter("@text", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_mailtemplateParameter = new MySqlParameter("@mailTemplate", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@newentry", MySqlDbType.VarChar, 0);
			MySqlParameter title_aParameter = new MySqlParameter("@newtitle_A", MySqlDbType.VarChar, 0);
			MySqlParameter title_hParameter = new MySqlParameter("@newtitle_H", MySqlDbType.VarChar, 0);
			MySqlParameter itemParameter = new MySqlParameter("@newitem", MySqlDbType.VarChar, 0);
			MySqlParameter senderParameter = new MySqlParameter("@newsender", MySqlDbType.VarChar, 0);
			MySqlParameter subjectParameter = new MySqlParameter("@newsubject", MySqlDbType.VarChar, 0);
			MySqlParameter textParameter = new MySqlParameter("@newtext", MySqlDbType.VarChar, 0);
			MySqlParameter mailtemplateParameter = new MySqlParameter("@newmailTemplate", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			title_aParameter.Value = title_A;
			title_hParameter.Value = title_H;
			itemParameter.Value = item;
			senderParameter.Value = sender;
			subjectParameter.Value = subject;
			textParameter.Value = text;
			mailtemplateParameter.Value = mailTemplate;
			OLD_entryParameter.Value = OLD_entry;
			OLD_title_aParameter.Value = OLD_title_A;
			OLD_title_hParameter.Value = OLD_title_H;
			OLD_itemParameter.Value = OLD_item;
			OLD_senderParameter.Value = OLD_sender;
			OLD_subjectParameter.Value = OLD_subject;
			OLD_textParameter.Value = OLD_text;
			OLD_mailtemplateParameter.Value = OLD_mailTemplate;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(title_aParameter);
			cmd.Parameters.Add(title_hParameter);
			cmd.Parameters.Add(itemParameter);
			cmd.Parameters.Add(senderParameter);
			cmd.Parameters.Add(subjectParameter);
			cmd.Parameters.Add(textParameter);
			cmd.Parameters.Add(mailtemplateParameter);
			cmd.Parameters.Add(OLD_entryParameter);
			cmd.Parameters.Add(OLD_title_aParameter);
			cmd.Parameters.Add(OLD_title_hParameter);
			cmd.Parameters.Add(OLD_itemParameter);
			cmd.Parameters.Add(OLD_senderParameter);
			cmd.Parameters.Add(OLD_subjectParameter);
			cmd.Parameters.Add(OLD_textParameter);
			cmd.Parameters.Add(OLD_mailtemplateParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_entry = entry;
			OLD_title_A = title_A;
			OLD_title_H = title_H;
			OLD_item = item;
			OLD_sender = sender;
			OLD_subject = subject;
			OLD_text = text;
			OLD_mailTemplate = mailTemplate;
		}
	}
}
