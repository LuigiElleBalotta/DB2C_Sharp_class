using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Quest_objectives_locale
	{
		int ID = 0; //Comment: 
		int OLD_ID = 0;

		string locale = null; //Comment: 
		string OLD_locale = null;

		int QuestId = 0; //Comment: 
		int OLD_QuestId = 0;

		int StorageIndex = 0; //Comment: 
		int OLD_StorageIndex = 0;

		string Description = null; //Comment: 
		string OLD_Description = null;

		int VerifiedBuild = 0; //Comment: 
		int OLD_VerifiedBuild = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Quest_objectives_locale(int _ID, string _locale, int _QuestId, int _StorageIndex, string _Description, int _VerifiedBuild)
		{
			ID = _ID;
			locale = _locale;
			QuestId = _QuestId;
			StorageIndex = _StorageIndex;
			Description = _Description;
			VerifiedBuild = _VerifiedBuild;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM quest_objectives_locale WHERE ID = @ID AND locale = @locale AND QuestId = @QuestId AND StorageIndex = @StorageIndex AND Description = @Description AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter localeParameter = new MySqlParameter("@locale", MySqlDbType.VarChar, 0);
			MySqlParameter questidParameter = new MySqlParameter("@QuestId", MySqlDbType.VarChar, 0);
			MySqlParameter storageindexParameter = new MySqlParameter("@StorageIndex", MySqlDbType.VarChar, 0);
			MySqlParameter descriptionParameter = new MySqlParameter("@Description", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			localeParameter.Value = locale;
			questidParameter.Value = QuestId;
			storageindexParameter.Value = StorageIndex;
			descriptionParameter.Value = Description;
			verifiedbuildParameter.Value = VerifiedBuild;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(localeParameter);
			cmd.Parameters.Add(questidParameter);
			cmd.Parameters.Add(storageindexParameter);
			cmd.Parameters.Add(descriptionParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE quest_objectives_locale SET ID = @newID, locale = @newlocale, QuestId = @newQuestId, StorageIndex = @newStorageIndex, Description = @newDescription, VerifiedBuild = @newVerifiedBuild WHERE ID = @ID AND locale = @locale AND QuestId = @QuestId AND StorageIndex = @StorageIndex AND Description = @Description AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_localeParameter = new MySqlParameter("@locale", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_questidParameter = new MySqlParameter("@QuestId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_storageindexParameter = new MySqlParameter("@StorageIndex", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_descriptionParameter = new MySqlParameter("@Description", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newID", MySqlDbType.VarChar, 0);
			MySqlParameter localeParameter = new MySqlParameter("@newlocale", MySqlDbType.VarChar, 0);
			MySqlParameter questidParameter = new MySqlParameter("@newQuestId", MySqlDbType.VarChar, 0);
			MySqlParameter storageindexParameter = new MySqlParameter("@newStorageIndex", MySqlDbType.VarChar, 0);
			MySqlParameter descriptionParameter = new MySqlParameter("@newDescription", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@newVerifiedBuild", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			localeParameter.Value = locale;
			questidParameter.Value = QuestId;
			storageindexParameter.Value = StorageIndex;
			descriptionParameter.Value = Description;
			verifiedbuildParameter.Value = VerifiedBuild;
			OLD_idParameter.Value = OLD_ID;
			OLD_localeParameter.Value = OLD_locale;
			OLD_questidParameter.Value = OLD_QuestId;
			OLD_storageindexParameter.Value = OLD_StorageIndex;
			OLD_descriptionParameter.Value = OLD_Description;
			OLD_verifiedbuildParameter.Value = OLD_VerifiedBuild;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(localeParameter);
			cmd.Parameters.Add(questidParameter);
			cmd.Parameters.Add(storageindexParameter);
			cmd.Parameters.Add(descriptionParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_localeParameter);
			cmd.Parameters.Add(OLD_questidParameter);
			cmd.Parameters.Add(OLD_storageindexParameter);
			cmd.Parameters.Add(OLD_descriptionParameter);
			cmd.Parameters.Add(OLD_verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_ID = ID;
			OLD_locale = locale;
			OLD_QuestId = QuestId;
			OLD_StorageIndex = StorageIndex;
			OLD_Description = Description;
			OLD_VerifiedBuild = VerifiedBuild;
		}
	}
}
