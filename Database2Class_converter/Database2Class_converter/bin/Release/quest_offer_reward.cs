using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Quest_offer_reward
	{
		int ID = 0; //Comment: 
		int OLD_ID = 0;

		int Emote1 = 0; //Comment: 
		int OLD_Emote1 = 0;

		int Emote2 = 0; //Comment: 
		int OLD_Emote2 = 0;

		int Emote3 = 0; //Comment: 
		int OLD_Emote3 = 0;

		int Emote4 = 0; //Comment: 
		int OLD_Emote4 = 0;

		int EmoteDelay1 = 0; //Comment: 
		int OLD_EmoteDelay1 = 0;

		int EmoteDelay2 = 0; //Comment: 
		int OLD_EmoteDelay2 = 0;

		int EmoteDelay3 = 0; //Comment: 
		int OLD_EmoteDelay3 = 0;

		int EmoteDelay4 = 0; //Comment: 
		int OLD_EmoteDelay4 = 0;

		string RewardText = null; //Comment: 
		string OLD_RewardText = null;

		int VerifiedBuild = 0; //Comment: 
		int OLD_VerifiedBuild = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Quest_offer_reward(int _ID, int _Emote1, int _Emote2, int _Emote3, int _Emote4, int _EmoteDelay1, int _EmoteDelay2, int _EmoteDelay3, int _EmoteDelay4, string _RewardText, int _VerifiedBuild)
		{
			ID = _ID;
			Emote1 = _Emote1;
			Emote2 = _Emote2;
			Emote3 = _Emote3;
			Emote4 = _Emote4;
			EmoteDelay1 = _EmoteDelay1;
			EmoteDelay2 = _EmoteDelay2;
			EmoteDelay3 = _EmoteDelay3;
			EmoteDelay4 = _EmoteDelay4;
			RewardText = _RewardText;
			VerifiedBuild = _VerifiedBuild;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM quest_offer_reward WHERE ID = @ID AND Emote1 = @Emote1 AND Emote2 = @Emote2 AND Emote3 = @Emote3 AND Emote4 = @Emote4 AND EmoteDelay1 = @EmoteDelay1 AND EmoteDelay2 = @EmoteDelay2 AND EmoteDelay3 = @EmoteDelay3 AND EmoteDelay4 = @EmoteDelay4 AND RewardText = @RewardText AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter emote1Parameter = new MySqlParameter("@Emote1", MySqlDbType.VarChar, 0);
			MySqlParameter emote2Parameter = new MySqlParameter("@Emote2", MySqlDbType.VarChar, 0);
			MySqlParameter emote3Parameter = new MySqlParameter("@Emote3", MySqlDbType.VarChar, 0);
			MySqlParameter emote4Parameter = new MySqlParameter("@Emote4", MySqlDbType.VarChar, 0);
			MySqlParameter emotedelay1Parameter = new MySqlParameter("@EmoteDelay1", MySqlDbType.VarChar, 0);
			MySqlParameter emotedelay2Parameter = new MySqlParameter("@EmoteDelay2", MySqlDbType.VarChar, 0);
			MySqlParameter emotedelay3Parameter = new MySqlParameter("@EmoteDelay3", MySqlDbType.VarChar, 0);
			MySqlParameter emotedelay4Parameter = new MySqlParameter("@EmoteDelay4", MySqlDbType.VarChar, 0);
			MySqlParameter rewardtextParameter = new MySqlParameter("@RewardText", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			emote1Parameter.Value = Emote1;
			emote2Parameter.Value = Emote2;
			emote3Parameter.Value = Emote3;
			emote4Parameter.Value = Emote4;
			emotedelay1Parameter.Value = EmoteDelay1;
			emotedelay2Parameter.Value = EmoteDelay2;
			emotedelay3Parameter.Value = EmoteDelay3;
			emotedelay4Parameter.Value = EmoteDelay4;
			rewardtextParameter.Value = RewardText;
			verifiedbuildParameter.Value = VerifiedBuild;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(emote1Parameter);
			cmd.Parameters.Add(emote2Parameter);
			cmd.Parameters.Add(emote3Parameter);
			cmd.Parameters.Add(emote4Parameter);
			cmd.Parameters.Add(emotedelay1Parameter);
			cmd.Parameters.Add(emotedelay2Parameter);
			cmd.Parameters.Add(emotedelay3Parameter);
			cmd.Parameters.Add(emotedelay4Parameter);
			cmd.Parameters.Add(rewardtextParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE quest_offer_reward SET ID = @newID, Emote1 = @newEmote1, Emote2 = @newEmote2, Emote3 = @newEmote3, Emote4 = @newEmote4, EmoteDelay1 = @newEmoteDelay1, EmoteDelay2 = @newEmoteDelay2, EmoteDelay3 = @newEmoteDelay3, EmoteDelay4 = @newEmoteDelay4, RewardText = @newRewardText, VerifiedBuild = @newVerifiedBuild WHERE ID = @ID AND Emote1 = @Emote1 AND Emote2 = @Emote2 AND Emote3 = @Emote3 AND Emote4 = @Emote4 AND EmoteDelay1 = @EmoteDelay1 AND EmoteDelay2 = @EmoteDelay2 AND EmoteDelay3 = @EmoteDelay3 AND EmoteDelay4 = @EmoteDelay4 AND RewardText = @RewardText AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_emote1Parameter = new MySqlParameter("@Emote1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_emote2Parameter = new MySqlParameter("@Emote2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_emote3Parameter = new MySqlParameter("@Emote3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_emote4Parameter = new MySqlParameter("@Emote4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_emotedelay1Parameter = new MySqlParameter("@EmoteDelay1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_emotedelay2Parameter = new MySqlParameter("@EmoteDelay2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_emotedelay3Parameter = new MySqlParameter("@EmoteDelay3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_emotedelay4Parameter = new MySqlParameter("@EmoteDelay4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardtextParameter = new MySqlParameter("@RewardText", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newID", MySqlDbType.VarChar, 0);
			MySqlParameter emote1Parameter = new MySqlParameter("@newEmote1", MySqlDbType.VarChar, 0);
			MySqlParameter emote2Parameter = new MySqlParameter("@newEmote2", MySqlDbType.VarChar, 0);
			MySqlParameter emote3Parameter = new MySqlParameter("@newEmote3", MySqlDbType.VarChar, 0);
			MySqlParameter emote4Parameter = new MySqlParameter("@newEmote4", MySqlDbType.VarChar, 0);
			MySqlParameter emotedelay1Parameter = new MySqlParameter("@newEmoteDelay1", MySqlDbType.VarChar, 0);
			MySqlParameter emotedelay2Parameter = new MySqlParameter("@newEmoteDelay2", MySqlDbType.VarChar, 0);
			MySqlParameter emotedelay3Parameter = new MySqlParameter("@newEmoteDelay3", MySqlDbType.VarChar, 0);
			MySqlParameter emotedelay4Parameter = new MySqlParameter("@newEmoteDelay4", MySqlDbType.VarChar, 0);
			MySqlParameter rewardtextParameter = new MySqlParameter("@newRewardText", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@newVerifiedBuild", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			emote1Parameter.Value = Emote1;
			emote2Parameter.Value = Emote2;
			emote3Parameter.Value = Emote3;
			emote4Parameter.Value = Emote4;
			emotedelay1Parameter.Value = EmoteDelay1;
			emotedelay2Parameter.Value = EmoteDelay2;
			emotedelay3Parameter.Value = EmoteDelay3;
			emotedelay4Parameter.Value = EmoteDelay4;
			rewardtextParameter.Value = RewardText;
			verifiedbuildParameter.Value = VerifiedBuild;
			OLD_idParameter.Value = OLD_ID;
			OLD_emote1Parameter.Value = OLD_Emote1;
			OLD_emote2Parameter.Value = OLD_Emote2;
			OLD_emote3Parameter.Value = OLD_Emote3;
			OLD_emote4Parameter.Value = OLD_Emote4;
			OLD_emotedelay1Parameter.Value = OLD_EmoteDelay1;
			OLD_emotedelay2Parameter.Value = OLD_EmoteDelay2;
			OLD_emotedelay3Parameter.Value = OLD_EmoteDelay3;
			OLD_emotedelay4Parameter.Value = OLD_EmoteDelay4;
			OLD_rewardtextParameter.Value = OLD_RewardText;
			OLD_verifiedbuildParameter.Value = OLD_VerifiedBuild;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(emote1Parameter);
			cmd.Parameters.Add(emote2Parameter);
			cmd.Parameters.Add(emote3Parameter);
			cmd.Parameters.Add(emote4Parameter);
			cmd.Parameters.Add(emotedelay1Parameter);
			cmd.Parameters.Add(emotedelay2Parameter);
			cmd.Parameters.Add(emotedelay3Parameter);
			cmd.Parameters.Add(emotedelay4Parameter);
			cmd.Parameters.Add(rewardtextParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_emote1Parameter);
			cmd.Parameters.Add(OLD_emote2Parameter);
			cmd.Parameters.Add(OLD_emote3Parameter);
			cmd.Parameters.Add(OLD_emote4Parameter);
			cmd.Parameters.Add(OLD_emotedelay1Parameter);
			cmd.Parameters.Add(OLD_emotedelay2Parameter);
			cmd.Parameters.Add(OLD_emotedelay3Parameter);
			cmd.Parameters.Add(OLD_emotedelay4Parameter);
			cmd.Parameters.Add(OLD_rewardtextParameter);
			cmd.Parameters.Add(OLD_verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_ID = ID;
			OLD_Emote1 = Emote1;
			OLD_Emote2 = Emote2;
			OLD_Emote3 = Emote3;
			OLD_Emote4 = Emote4;
			OLD_EmoteDelay1 = EmoteDelay1;
			OLD_EmoteDelay2 = EmoteDelay2;
			OLD_EmoteDelay3 = EmoteDelay3;
			OLD_EmoteDelay4 = EmoteDelay4;
			OLD_RewardText = RewardText;
			OLD_VerifiedBuild = VerifiedBuild;
		}
	}
}
