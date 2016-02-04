using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Quest_template_locale
	{
		int ID = 0; //Comment: 
		int OLD_ID = 0;

		string locale = null; //Comment: 
		string OLD_locale = null;

		string LogTitle = null; //Comment: 
		string OLD_LogTitle = null;

		string LogDescription = null; //Comment: 
		string OLD_LogDescription = null;

		string QuestDescription = null; //Comment: 
		string OLD_QuestDescription = null;

		string AreaDescription = null; //Comment: 
		string OLD_AreaDescription = null;

		string PortraitGiverText = null; //Comment: 
		string OLD_PortraitGiverText = null;

		string PortraitGiverName = null; //Comment: 
		string OLD_PortraitGiverName = null;

		string PortraitTurnInText = null; //Comment: 
		string OLD_PortraitTurnInText = null;

		string PortraitTurnInName = null; //Comment: 
		string OLD_PortraitTurnInName = null;

		string QuestCompletionLog = null; //Comment: 
		string OLD_QuestCompletionLog = null;

		int VerifiedBuild = 0; //Comment: 
		int OLD_VerifiedBuild = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Quest_template_locale(int _ID, string _locale, string _LogTitle, string _LogDescription, string _QuestDescription, string _AreaDescription, string _PortraitGiverText, string _PortraitGiverName, string _PortraitTurnInText, string _PortraitTurnInName, string _QuestCompletionLog, int _VerifiedBuild)
		{
			ID = _ID;
			locale = _locale;
			LogTitle = _LogTitle;
			LogDescription = _LogDescription;
			QuestDescription = _QuestDescription;
			AreaDescription = _AreaDescription;
			PortraitGiverText = _PortraitGiverText;
			PortraitGiverName = _PortraitGiverName;
			PortraitTurnInText = _PortraitTurnInText;
			PortraitTurnInName = _PortraitTurnInName;
			QuestCompletionLog = _QuestCompletionLog;
			VerifiedBuild = _VerifiedBuild;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM quest_template_locale WHERE ID = @ID AND locale = @locale AND LogTitle = @LogTitle AND LogDescription = @LogDescription AND QuestDescription = @QuestDescription AND AreaDescription = @AreaDescription AND PortraitGiverText = @PortraitGiverText AND PortraitGiverName = @PortraitGiverName AND PortraitTurnInText = @PortraitTurnInText AND PortraitTurnInName = @PortraitTurnInName AND QuestCompletionLog = @QuestCompletionLog AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter localeParameter = new MySqlParameter("@locale", MySqlDbType.VarChar, 0);
			MySqlParameter logtitleParameter = new MySqlParameter("@LogTitle", MySqlDbType.VarChar, 0);
			MySqlParameter logdescriptionParameter = new MySqlParameter("@LogDescription", MySqlDbType.VarChar, 0);
			MySqlParameter questdescriptionParameter = new MySqlParameter("@QuestDescription", MySqlDbType.VarChar, 0);
			MySqlParameter areadescriptionParameter = new MySqlParameter("@AreaDescription", MySqlDbType.VarChar, 0);
			MySqlParameter portraitgivertextParameter = new MySqlParameter("@PortraitGiverText", MySqlDbType.VarChar, 0);
			MySqlParameter portraitgivernameParameter = new MySqlParameter("@PortraitGiverName", MySqlDbType.VarChar, 0);
			MySqlParameter portraitturnintextParameter = new MySqlParameter("@PortraitTurnInText", MySqlDbType.VarChar, 0);
			MySqlParameter portraitturninnameParameter = new MySqlParameter("@PortraitTurnInName", MySqlDbType.VarChar, 0);
			MySqlParameter questcompletionlogParameter = new MySqlParameter("@QuestCompletionLog", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			localeParameter.Value = locale;
			logtitleParameter.Value = LogTitle;
			logdescriptionParameter.Value = LogDescription;
			questdescriptionParameter.Value = QuestDescription;
			areadescriptionParameter.Value = AreaDescription;
			portraitgivertextParameter.Value = PortraitGiverText;
			portraitgivernameParameter.Value = PortraitGiverName;
			portraitturnintextParameter.Value = PortraitTurnInText;
			portraitturninnameParameter.Value = PortraitTurnInName;
			questcompletionlogParameter.Value = QuestCompletionLog;
			verifiedbuildParameter.Value = VerifiedBuild;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(localeParameter);
			cmd.Parameters.Add(logtitleParameter);
			cmd.Parameters.Add(logdescriptionParameter);
			cmd.Parameters.Add(questdescriptionParameter);
			cmd.Parameters.Add(areadescriptionParameter);
			cmd.Parameters.Add(portraitgivertextParameter);
			cmd.Parameters.Add(portraitgivernameParameter);
			cmd.Parameters.Add(portraitturnintextParameter);
			cmd.Parameters.Add(portraitturninnameParameter);
			cmd.Parameters.Add(questcompletionlogParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE quest_template_locale SET ID = @newID, locale = @newlocale, LogTitle = @newLogTitle, LogDescription = @newLogDescription, QuestDescription = @newQuestDescription, AreaDescription = @newAreaDescription, PortraitGiverText = @newPortraitGiverText, PortraitGiverName = @newPortraitGiverName, PortraitTurnInText = @newPortraitTurnInText, PortraitTurnInName = @newPortraitTurnInName, QuestCompletionLog = @newQuestCompletionLog, VerifiedBuild = @newVerifiedBuild WHERE ID = @ID AND locale = @locale AND LogTitle = @LogTitle AND LogDescription = @LogDescription AND QuestDescription = @QuestDescription AND AreaDescription = @AreaDescription AND PortraitGiverText = @PortraitGiverText AND PortraitGiverName = @PortraitGiverName AND PortraitTurnInText = @PortraitTurnInText AND PortraitTurnInName = @PortraitTurnInName AND QuestCompletionLog = @QuestCompletionLog AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_localeParameter = new MySqlParameter("@locale", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_logtitleParameter = new MySqlParameter("@LogTitle", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_logdescriptionParameter = new MySqlParameter("@LogDescription", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_questdescriptionParameter = new MySqlParameter("@QuestDescription", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_areadescriptionParameter = new MySqlParameter("@AreaDescription", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_portraitgivertextParameter = new MySqlParameter("@PortraitGiverText", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_portraitgivernameParameter = new MySqlParameter("@PortraitGiverName", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_portraitturnintextParameter = new MySqlParameter("@PortraitTurnInText", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_portraitturninnameParameter = new MySqlParameter("@PortraitTurnInName", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_questcompletionlogParameter = new MySqlParameter("@QuestCompletionLog", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newID", MySqlDbType.VarChar, 0);
			MySqlParameter localeParameter = new MySqlParameter("@newlocale", MySqlDbType.VarChar, 0);
			MySqlParameter logtitleParameter = new MySqlParameter("@newLogTitle", MySqlDbType.VarChar, 0);
			MySqlParameter logdescriptionParameter = new MySqlParameter("@newLogDescription", MySqlDbType.VarChar, 0);
			MySqlParameter questdescriptionParameter = new MySqlParameter("@newQuestDescription", MySqlDbType.VarChar, 0);
			MySqlParameter areadescriptionParameter = new MySqlParameter("@newAreaDescription", MySqlDbType.VarChar, 0);
			MySqlParameter portraitgivertextParameter = new MySqlParameter("@newPortraitGiverText", MySqlDbType.VarChar, 0);
			MySqlParameter portraitgivernameParameter = new MySqlParameter("@newPortraitGiverName", MySqlDbType.VarChar, 0);
			MySqlParameter portraitturnintextParameter = new MySqlParameter("@newPortraitTurnInText", MySqlDbType.VarChar, 0);
			MySqlParameter portraitturninnameParameter = new MySqlParameter("@newPortraitTurnInName", MySqlDbType.VarChar, 0);
			MySqlParameter questcompletionlogParameter = new MySqlParameter("@newQuestCompletionLog", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@newVerifiedBuild", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			localeParameter.Value = locale;
			logtitleParameter.Value = LogTitle;
			logdescriptionParameter.Value = LogDescription;
			questdescriptionParameter.Value = QuestDescription;
			areadescriptionParameter.Value = AreaDescription;
			portraitgivertextParameter.Value = PortraitGiverText;
			portraitgivernameParameter.Value = PortraitGiverName;
			portraitturnintextParameter.Value = PortraitTurnInText;
			portraitturninnameParameter.Value = PortraitTurnInName;
			questcompletionlogParameter.Value = QuestCompletionLog;
			verifiedbuildParameter.Value = VerifiedBuild;
			OLD_idParameter.Value = OLD_ID;
			OLD_localeParameter.Value = OLD_locale;
			OLD_logtitleParameter.Value = OLD_LogTitle;
			OLD_logdescriptionParameter.Value = OLD_LogDescription;
			OLD_questdescriptionParameter.Value = OLD_QuestDescription;
			OLD_areadescriptionParameter.Value = OLD_AreaDescription;
			OLD_portraitgivertextParameter.Value = OLD_PortraitGiverText;
			OLD_portraitgivernameParameter.Value = OLD_PortraitGiverName;
			OLD_portraitturnintextParameter.Value = OLD_PortraitTurnInText;
			OLD_portraitturninnameParameter.Value = OLD_PortraitTurnInName;
			OLD_questcompletionlogParameter.Value = OLD_QuestCompletionLog;
			OLD_verifiedbuildParameter.Value = OLD_VerifiedBuild;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(localeParameter);
			cmd.Parameters.Add(logtitleParameter);
			cmd.Parameters.Add(logdescriptionParameter);
			cmd.Parameters.Add(questdescriptionParameter);
			cmd.Parameters.Add(areadescriptionParameter);
			cmd.Parameters.Add(portraitgivertextParameter);
			cmd.Parameters.Add(portraitgivernameParameter);
			cmd.Parameters.Add(portraitturnintextParameter);
			cmd.Parameters.Add(portraitturninnameParameter);
			cmd.Parameters.Add(questcompletionlogParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_localeParameter);
			cmd.Parameters.Add(OLD_logtitleParameter);
			cmd.Parameters.Add(OLD_logdescriptionParameter);
			cmd.Parameters.Add(OLD_questdescriptionParameter);
			cmd.Parameters.Add(OLD_areadescriptionParameter);
			cmd.Parameters.Add(OLD_portraitgivertextParameter);
			cmd.Parameters.Add(OLD_portraitgivernameParameter);
			cmd.Parameters.Add(OLD_portraitturnintextParameter);
			cmd.Parameters.Add(OLD_portraitturninnameParameter);
			cmd.Parameters.Add(OLD_questcompletionlogParameter);
			cmd.Parameters.Add(OLD_verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_ID = ID;
			OLD_locale = locale;
			OLD_LogTitle = LogTitle;
			OLD_LogDescription = LogDescription;
			OLD_QuestDescription = QuestDescription;
			OLD_AreaDescription = AreaDescription;
			OLD_PortraitGiverText = PortraitGiverText;
			OLD_PortraitGiverName = PortraitGiverName;
			OLD_PortraitTurnInText = PortraitTurnInText;
			OLD_PortraitTurnInName = PortraitTurnInName;
			OLD_QuestCompletionLog = QuestCompletionLog;
			OLD_VerifiedBuild = VerifiedBuild;
		}
	}
}
