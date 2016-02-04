using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Mail_level_reward
	{
		int level = 0; //Comment: 
		int OLD_level = 0;

		int raceMask = 0; //Comment: 
		int OLD_raceMask = 0;

		int mailTemplateId = 0; //Comment: 
		int OLD_mailTemplateId = 0;

		int senderEntry = 0; //Comment: 
		int OLD_senderEntry = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Mail_level_reward(int _level, int _raceMask, int _mailTemplateId, int _senderEntry)
		{
			level = _level;
			raceMask = _raceMask;
			mailTemplateId = _mailTemplateId;
			senderEntry = _senderEntry;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM mail_level_reward WHERE level = @level AND raceMask = @raceMask AND mailTemplateId = @mailTemplateId AND senderEntry = @senderEntry;";
			MySqlParameter levelParameter = new MySqlParameter("@level", MySqlDbType.VarChar, 0);
			MySqlParameter racemaskParameter = new MySqlParameter("@raceMask", MySqlDbType.VarChar, 0);
			MySqlParameter mailtemplateidParameter = new MySqlParameter("@mailTemplateId", MySqlDbType.VarChar, 0);
			MySqlParameter senderentryParameter = new MySqlParameter("@senderEntry", MySqlDbType.VarChar, 0);
			levelParameter.Value = level;
			racemaskParameter.Value = raceMask;
			mailtemplateidParameter.Value = mailTemplateId;
			senderentryParameter.Value = senderEntry;
			cmd.Parameters.Add(levelParameter);
			cmd.Parameters.Add(racemaskParameter);
			cmd.Parameters.Add(mailtemplateidParameter);
			cmd.Parameters.Add(senderentryParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE mail_level_reward SET level = @newlevel, raceMask = @newraceMask, mailTemplateId = @newmailTemplateId, senderEntry = @newsenderEntry WHERE level = @level AND raceMask = @raceMask AND mailTemplateId = @mailTemplateId AND senderEntry = @senderEntry;";
			MySqlParameter OLD_levelParameter = new MySqlParameter("@level", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_racemaskParameter = new MySqlParameter("@raceMask", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_mailtemplateidParameter = new MySqlParameter("@mailTemplateId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_senderentryParameter = new MySqlParameter("@senderEntry", MySqlDbType.VarChar, 0);
			MySqlParameter levelParameter = new MySqlParameter("@newlevel", MySqlDbType.VarChar, 0);
			MySqlParameter racemaskParameter = new MySqlParameter("@newraceMask", MySqlDbType.VarChar, 0);
			MySqlParameter mailtemplateidParameter = new MySqlParameter("@newmailTemplateId", MySqlDbType.VarChar, 0);
			MySqlParameter senderentryParameter = new MySqlParameter("@newsenderEntry", MySqlDbType.VarChar, 0);
			levelParameter.Value = level;
			racemaskParameter.Value = raceMask;
			mailtemplateidParameter.Value = mailTemplateId;
			senderentryParameter.Value = senderEntry;
			OLD_levelParameter.Value = OLD_level;
			OLD_racemaskParameter.Value = OLD_raceMask;
			OLD_mailtemplateidParameter.Value = OLD_mailTemplateId;
			OLD_senderentryParameter.Value = OLD_senderEntry;
			cmd.Parameters.Add(levelParameter);
			cmd.Parameters.Add(racemaskParameter);
			cmd.Parameters.Add(mailtemplateidParameter);
			cmd.Parameters.Add(senderentryParameter);
			cmd.Parameters.Add(OLD_levelParameter);
			cmd.Parameters.Add(OLD_racemaskParameter);
			cmd.Parameters.Add(OLD_mailtemplateidParameter);
			cmd.Parameters.Add(OLD_senderentryParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_level = level;
			OLD_raceMask = raceMask;
			OLD_mailTemplateId = mailTemplateId;
			OLD_senderEntry = senderEntry;
		}
	}
}
