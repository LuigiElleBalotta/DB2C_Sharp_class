using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Quest_request_items
	{
		int ID = 0; //Comment: 
		int OLD_ID = 0;

		int EmoteOnComplete = 0; //Comment: 
		int OLD_EmoteOnComplete = 0;

		int EmoteOnIncomplete = 0; //Comment: 
		int OLD_EmoteOnIncomplete = 0;

		int EmoteOnCompleteDelay = 0; //Comment: 
		int OLD_EmoteOnCompleteDelay = 0;

		int EmoteOnIncompleteDelay = 0; //Comment: 
		int OLD_EmoteOnIncompleteDelay = 0;

		string CompletionText = null; //Comment: 
		string OLD_CompletionText = null;

		int VerifiedBuild = 0; //Comment: 
		int OLD_VerifiedBuild = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Quest_request_items(int _ID, int _EmoteOnComplete, int _EmoteOnIncomplete, int _EmoteOnCompleteDelay, int _EmoteOnIncompleteDelay, string _CompletionText, int _VerifiedBuild)
		{
			ID = _ID;
			EmoteOnComplete = _EmoteOnComplete;
			EmoteOnIncomplete = _EmoteOnIncomplete;
			EmoteOnCompleteDelay = _EmoteOnCompleteDelay;
			EmoteOnIncompleteDelay = _EmoteOnIncompleteDelay;
			CompletionText = _CompletionText;
			VerifiedBuild = _VerifiedBuild;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM quest_request_items WHERE ID = @ID AND EmoteOnComplete = @EmoteOnComplete AND EmoteOnIncomplete = @EmoteOnIncomplete AND EmoteOnCompleteDelay = @EmoteOnCompleteDelay AND EmoteOnIncompleteDelay = @EmoteOnIncompleteDelay AND CompletionText = @CompletionText AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter emoteoncompleteParameter = new MySqlParameter("@EmoteOnComplete", MySqlDbType.VarChar, 0);
			MySqlParameter emoteonincompleteParameter = new MySqlParameter("@EmoteOnIncomplete", MySqlDbType.VarChar, 0);
			MySqlParameter emoteoncompletedelayParameter = new MySqlParameter("@EmoteOnCompleteDelay", MySqlDbType.VarChar, 0);
			MySqlParameter emoteonincompletedelayParameter = new MySqlParameter("@EmoteOnIncompleteDelay", MySqlDbType.VarChar, 0);
			MySqlParameter completiontextParameter = new MySqlParameter("@CompletionText", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			emoteoncompleteParameter.Value = EmoteOnComplete;
			emoteonincompleteParameter.Value = EmoteOnIncomplete;
			emoteoncompletedelayParameter.Value = EmoteOnCompleteDelay;
			emoteonincompletedelayParameter.Value = EmoteOnIncompleteDelay;
			completiontextParameter.Value = CompletionText;
			verifiedbuildParameter.Value = VerifiedBuild;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(emoteoncompleteParameter);
			cmd.Parameters.Add(emoteonincompleteParameter);
			cmd.Parameters.Add(emoteoncompletedelayParameter);
			cmd.Parameters.Add(emoteonincompletedelayParameter);
			cmd.Parameters.Add(completiontextParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE quest_request_items SET ID = @newID, EmoteOnComplete = @newEmoteOnComplete, EmoteOnIncomplete = @newEmoteOnIncomplete, EmoteOnCompleteDelay = @newEmoteOnCompleteDelay, EmoteOnIncompleteDelay = @newEmoteOnIncompleteDelay, CompletionText = @newCompletionText, VerifiedBuild = @newVerifiedBuild WHERE ID = @ID AND EmoteOnComplete = @EmoteOnComplete AND EmoteOnIncomplete = @EmoteOnIncomplete AND EmoteOnCompleteDelay = @EmoteOnCompleteDelay AND EmoteOnIncompleteDelay = @EmoteOnIncompleteDelay AND CompletionText = @CompletionText AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_emoteoncompleteParameter = new MySqlParameter("@EmoteOnComplete", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_emoteonincompleteParameter = new MySqlParameter("@EmoteOnIncomplete", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_emoteoncompletedelayParameter = new MySqlParameter("@EmoteOnCompleteDelay", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_emoteonincompletedelayParameter = new MySqlParameter("@EmoteOnIncompleteDelay", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_completiontextParameter = new MySqlParameter("@CompletionText", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newID", MySqlDbType.VarChar, 0);
			MySqlParameter emoteoncompleteParameter = new MySqlParameter("@newEmoteOnComplete", MySqlDbType.VarChar, 0);
			MySqlParameter emoteonincompleteParameter = new MySqlParameter("@newEmoteOnIncomplete", MySqlDbType.VarChar, 0);
			MySqlParameter emoteoncompletedelayParameter = new MySqlParameter("@newEmoteOnCompleteDelay", MySqlDbType.VarChar, 0);
			MySqlParameter emoteonincompletedelayParameter = new MySqlParameter("@newEmoteOnIncompleteDelay", MySqlDbType.VarChar, 0);
			MySqlParameter completiontextParameter = new MySqlParameter("@newCompletionText", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@newVerifiedBuild", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			emoteoncompleteParameter.Value = EmoteOnComplete;
			emoteonincompleteParameter.Value = EmoteOnIncomplete;
			emoteoncompletedelayParameter.Value = EmoteOnCompleteDelay;
			emoteonincompletedelayParameter.Value = EmoteOnIncompleteDelay;
			completiontextParameter.Value = CompletionText;
			verifiedbuildParameter.Value = VerifiedBuild;
			OLD_idParameter.Value = OLD_ID;
			OLD_emoteoncompleteParameter.Value = OLD_EmoteOnComplete;
			OLD_emoteonincompleteParameter.Value = OLD_EmoteOnIncomplete;
			OLD_emoteoncompletedelayParameter.Value = OLD_EmoteOnCompleteDelay;
			OLD_emoteonincompletedelayParameter.Value = OLD_EmoteOnIncompleteDelay;
			OLD_completiontextParameter.Value = OLD_CompletionText;
			OLD_verifiedbuildParameter.Value = OLD_VerifiedBuild;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(emoteoncompleteParameter);
			cmd.Parameters.Add(emoteonincompleteParameter);
			cmd.Parameters.Add(emoteoncompletedelayParameter);
			cmd.Parameters.Add(emoteonincompletedelayParameter);
			cmd.Parameters.Add(completiontextParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_emoteoncompleteParameter);
			cmd.Parameters.Add(OLD_emoteonincompleteParameter);
			cmd.Parameters.Add(OLD_emoteoncompletedelayParameter);
			cmd.Parameters.Add(OLD_emoteonincompletedelayParameter);
			cmd.Parameters.Add(OLD_completiontextParameter);
			cmd.Parameters.Add(OLD_verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_ID = ID;
			OLD_EmoteOnComplete = EmoteOnComplete;
			OLD_EmoteOnIncomplete = EmoteOnIncomplete;
			OLD_EmoteOnCompleteDelay = EmoteOnCompleteDelay;
			OLD_EmoteOnIncompleteDelay = EmoteOnIncompleteDelay;
			OLD_CompletionText = CompletionText;
			OLD_VerifiedBuild = VerifiedBuild;
		}
	}
}
