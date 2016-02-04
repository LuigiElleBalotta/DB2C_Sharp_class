using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Npc_text
	{
		int ID = 0; //Comment: 
		int OLD_ID = 0;

		float Probability0 = 0f; //Comment: 
		float OLD_Probability0 = 0f;

		float Probability1 = 0f; //Comment: 
		float OLD_Probability1 = 0f;

		float Probability2 = 0f; //Comment: 
		float OLD_Probability2 = 0f;

		float Probability3 = 0f; //Comment: 
		float OLD_Probability3 = 0f;

		float Probability4 = 0f; //Comment: 
		float OLD_Probability4 = 0f;

		float Probability5 = 0f; //Comment: 
		float OLD_Probability5 = 0f;

		float Probability6 = 0f; //Comment: 
		float OLD_Probability6 = 0f;

		float Probability7 = 0f; //Comment: 
		float OLD_Probability7 = 0f;

		int BroadcastTextID0 = 0; //Comment: 
		int OLD_BroadcastTextID0 = 0;

		int BroadcastTextID1 = 0; //Comment: 
		int OLD_BroadcastTextID1 = 0;

		int BroadcastTextID2 = 0; //Comment: 
		int OLD_BroadcastTextID2 = 0;

		int BroadcastTextID3 = 0; //Comment: 
		int OLD_BroadcastTextID3 = 0;

		int BroadcastTextID4 = 0; //Comment: 
		int OLD_BroadcastTextID4 = 0;

		int BroadcastTextID5 = 0; //Comment: 
		int OLD_BroadcastTextID5 = 0;

		int BroadcastTextID6 = 0; //Comment: 
		int OLD_BroadcastTextID6 = 0;

		int BroadcastTextID7 = 0; //Comment: 
		int OLD_BroadcastTextID7 = 0;

		int VerifiedBuild = 0; //Comment: 
		int OLD_VerifiedBuild = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Npc_text(int _ID, float _Probability0, float _Probability1, float _Probability2, float _Probability3, float _Probability4, float _Probability5, float _Probability6, float _Probability7, int _BroadcastTextID0, int _BroadcastTextID1, int _BroadcastTextID2, int _BroadcastTextID3, int _BroadcastTextID4, int _BroadcastTextID5, int _BroadcastTextID6, int _BroadcastTextID7, int _VerifiedBuild)
		{
			ID = _ID;
			Probability0 = _Probability0;
			Probability1 = _Probability1;
			Probability2 = _Probability2;
			Probability3 = _Probability3;
			Probability4 = _Probability4;
			Probability5 = _Probability5;
			Probability6 = _Probability6;
			Probability7 = _Probability7;
			BroadcastTextID0 = _BroadcastTextID0;
			BroadcastTextID1 = _BroadcastTextID1;
			BroadcastTextID2 = _BroadcastTextID2;
			BroadcastTextID3 = _BroadcastTextID3;
			BroadcastTextID4 = _BroadcastTextID4;
			BroadcastTextID5 = _BroadcastTextID5;
			BroadcastTextID6 = _BroadcastTextID6;
			BroadcastTextID7 = _BroadcastTextID7;
			VerifiedBuild = _VerifiedBuild;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM npc_text WHERE ID = @ID AND Probability0 = @Probability0 AND Probability1 = @Probability1 AND Probability2 = @Probability2 AND Probability3 = @Probability3 AND Probability4 = @Probability4 AND Probability5 = @Probability5 AND Probability6 = @Probability6 AND Probability7 = @Probability7 AND BroadcastTextID0 = @BroadcastTextID0 AND BroadcastTextID1 = @BroadcastTextID1 AND BroadcastTextID2 = @BroadcastTextID2 AND BroadcastTextID3 = @BroadcastTextID3 AND BroadcastTextID4 = @BroadcastTextID4 AND BroadcastTextID5 = @BroadcastTextID5 AND BroadcastTextID6 = @BroadcastTextID6 AND BroadcastTextID7 = @BroadcastTextID7 AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter probability0Parameter = new MySqlParameter("@Probability0", MySqlDbType.VarChar, 0);
			MySqlParameter probability1Parameter = new MySqlParameter("@Probability1", MySqlDbType.VarChar, 0);
			MySqlParameter probability2Parameter = new MySqlParameter("@Probability2", MySqlDbType.VarChar, 0);
			MySqlParameter probability3Parameter = new MySqlParameter("@Probability3", MySqlDbType.VarChar, 0);
			MySqlParameter probability4Parameter = new MySqlParameter("@Probability4", MySqlDbType.VarChar, 0);
			MySqlParameter probability5Parameter = new MySqlParameter("@Probability5", MySqlDbType.VarChar, 0);
			MySqlParameter probability6Parameter = new MySqlParameter("@Probability6", MySqlDbType.VarChar, 0);
			MySqlParameter probability7Parameter = new MySqlParameter("@Probability7", MySqlDbType.VarChar, 0);
			MySqlParameter broadcasttextid0Parameter = new MySqlParameter("@BroadcastTextID0", MySqlDbType.VarChar, 0);
			MySqlParameter broadcasttextid1Parameter = new MySqlParameter("@BroadcastTextID1", MySqlDbType.VarChar, 0);
			MySqlParameter broadcasttextid2Parameter = new MySqlParameter("@BroadcastTextID2", MySqlDbType.VarChar, 0);
			MySqlParameter broadcasttextid3Parameter = new MySqlParameter("@BroadcastTextID3", MySqlDbType.VarChar, 0);
			MySqlParameter broadcasttextid4Parameter = new MySqlParameter("@BroadcastTextID4", MySqlDbType.VarChar, 0);
			MySqlParameter broadcasttextid5Parameter = new MySqlParameter("@BroadcastTextID5", MySqlDbType.VarChar, 0);
			MySqlParameter broadcasttextid6Parameter = new MySqlParameter("@BroadcastTextID6", MySqlDbType.VarChar, 0);
			MySqlParameter broadcasttextid7Parameter = new MySqlParameter("@BroadcastTextID7", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			probability0Parameter.Value = Probability0;
			probability1Parameter.Value = Probability1;
			probability2Parameter.Value = Probability2;
			probability3Parameter.Value = Probability3;
			probability4Parameter.Value = Probability4;
			probability5Parameter.Value = Probability5;
			probability6Parameter.Value = Probability6;
			probability7Parameter.Value = Probability7;
			broadcasttextid0Parameter.Value = BroadcastTextID0;
			broadcasttextid1Parameter.Value = BroadcastTextID1;
			broadcasttextid2Parameter.Value = BroadcastTextID2;
			broadcasttextid3Parameter.Value = BroadcastTextID3;
			broadcasttextid4Parameter.Value = BroadcastTextID4;
			broadcasttextid5Parameter.Value = BroadcastTextID5;
			broadcasttextid6Parameter.Value = BroadcastTextID6;
			broadcasttextid7Parameter.Value = BroadcastTextID7;
			verifiedbuildParameter.Value = VerifiedBuild;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(probability0Parameter);
			cmd.Parameters.Add(probability1Parameter);
			cmd.Parameters.Add(probability2Parameter);
			cmd.Parameters.Add(probability3Parameter);
			cmd.Parameters.Add(probability4Parameter);
			cmd.Parameters.Add(probability5Parameter);
			cmd.Parameters.Add(probability6Parameter);
			cmd.Parameters.Add(probability7Parameter);
			cmd.Parameters.Add(broadcasttextid0Parameter);
			cmd.Parameters.Add(broadcasttextid1Parameter);
			cmd.Parameters.Add(broadcasttextid2Parameter);
			cmd.Parameters.Add(broadcasttextid3Parameter);
			cmd.Parameters.Add(broadcasttextid4Parameter);
			cmd.Parameters.Add(broadcasttextid5Parameter);
			cmd.Parameters.Add(broadcasttextid6Parameter);
			cmd.Parameters.Add(broadcasttextid7Parameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE npc_text SET ID = @newID, Probability0 = @newProbability0, Probability1 = @newProbability1, Probability2 = @newProbability2, Probability3 = @newProbability3, Probability4 = @newProbability4, Probability5 = @newProbability5, Probability6 = @newProbability6, Probability7 = @newProbability7, BroadcastTextID0 = @newBroadcastTextID0, BroadcastTextID1 = @newBroadcastTextID1, BroadcastTextID2 = @newBroadcastTextID2, BroadcastTextID3 = @newBroadcastTextID3, BroadcastTextID4 = @newBroadcastTextID4, BroadcastTextID5 = @newBroadcastTextID5, BroadcastTextID6 = @newBroadcastTextID6, BroadcastTextID7 = @newBroadcastTextID7, VerifiedBuild = @newVerifiedBuild WHERE ID = @ID AND Probability0 = @Probability0 AND Probability1 = @Probability1 AND Probability2 = @Probability2 AND Probability3 = @Probability3 AND Probability4 = @Probability4 AND Probability5 = @Probability5 AND Probability6 = @Probability6 AND Probability7 = @Probability7 AND BroadcastTextID0 = @BroadcastTextID0 AND BroadcastTextID1 = @BroadcastTextID1 AND BroadcastTextID2 = @BroadcastTextID2 AND BroadcastTextID3 = @BroadcastTextID3 AND BroadcastTextID4 = @BroadcastTextID4 AND BroadcastTextID5 = @BroadcastTextID5 AND BroadcastTextID6 = @BroadcastTextID6 AND BroadcastTextID7 = @BroadcastTextID7 AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_probability0Parameter = new MySqlParameter("@Probability0", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_probability1Parameter = new MySqlParameter("@Probability1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_probability2Parameter = new MySqlParameter("@Probability2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_probability3Parameter = new MySqlParameter("@Probability3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_probability4Parameter = new MySqlParameter("@Probability4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_probability5Parameter = new MySqlParameter("@Probability5", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_probability6Parameter = new MySqlParameter("@Probability6", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_probability7Parameter = new MySqlParameter("@Probability7", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_broadcasttextid0Parameter = new MySqlParameter("@BroadcastTextID0", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_broadcasttextid1Parameter = new MySqlParameter("@BroadcastTextID1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_broadcasttextid2Parameter = new MySqlParameter("@BroadcastTextID2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_broadcasttextid3Parameter = new MySqlParameter("@BroadcastTextID3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_broadcasttextid4Parameter = new MySqlParameter("@BroadcastTextID4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_broadcasttextid5Parameter = new MySqlParameter("@BroadcastTextID5", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_broadcasttextid6Parameter = new MySqlParameter("@BroadcastTextID6", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_broadcasttextid7Parameter = new MySqlParameter("@BroadcastTextID7", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newID", MySqlDbType.VarChar, 0);
			MySqlParameter probability0Parameter = new MySqlParameter("@newProbability0", MySqlDbType.VarChar, 0);
			MySqlParameter probability1Parameter = new MySqlParameter("@newProbability1", MySqlDbType.VarChar, 0);
			MySqlParameter probability2Parameter = new MySqlParameter("@newProbability2", MySqlDbType.VarChar, 0);
			MySqlParameter probability3Parameter = new MySqlParameter("@newProbability3", MySqlDbType.VarChar, 0);
			MySqlParameter probability4Parameter = new MySqlParameter("@newProbability4", MySqlDbType.VarChar, 0);
			MySqlParameter probability5Parameter = new MySqlParameter("@newProbability5", MySqlDbType.VarChar, 0);
			MySqlParameter probability6Parameter = new MySqlParameter("@newProbability6", MySqlDbType.VarChar, 0);
			MySqlParameter probability7Parameter = new MySqlParameter("@newProbability7", MySqlDbType.VarChar, 0);
			MySqlParameter broadcasttextid0Parameter = new MySqlParameter("@newBroadcastTextID0", MySqlDbType.VarChar, 0);
			MySqlParameter broadcasttextid1Parameter = new MySqlParameter("@newBroadcastTextID1", MySqlDbType.VarChar, 0);
			MySqlParameter broadcasttextid2Parameter = new MySqlParameter("@newBroadcastTextID2", MySqlDbType.VarChar, 0);
			MySqlParameter broadcasttextid3Parameter = new MySqlParameter("@newBroadcastTextID3", MySqlDbType.VarChar, 0);
			MySqlParameter broadcasttextid4Parameter = new MySqlParameter("@newBroadcastTextID4", MySqlDbType.VarChar, 0);
			MySqlParameter broadcasttextid5Parameter = new MySqlParameter("@newBroadcastTextID5", MySqlDbType.VarChar, 0);
			MySqlParameter broadcasttextid6Parameter = new MySqlParameter("@newBroadcastTextID6", MySqlDbType.VarChar, 0);
			MySqlParameter broadcasttextid7Parameter = new MySqlParameter("@newBroadcastTextID7", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@newVerifiedBuild", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			probability0Parameter.Value = Probability0;
			probability1Parameter.Value = Probability1;
			probability2Parameter.Value = Probability2;
			probability3Parameter.Value = Probability3;
			probability4Parameter.Value = Probability4;
			probability5Parameter.Value = Probability5;
			probability6Parameter.Value = Probability6;
			probability7Parameter.Value = Probability7;
			broadcasttextid0Parameter.Value = BroadcastTextID0;
			broadcasttextid1Parameter.Value = BroadcastTextID1;
			broadcasttextid2Parameter.Value = BroadcastTextID2;
			broadcasttextid3Parameter.Value = BroadcastTextID3;
			broadcasttextid4Parameter.Value = BroadcastTextID4;
			broadcasttextid5Parameter.Value = BroadcastTextID5;
			broadcasttextid6Parameter.Value = BroadcastTextID6;
			broadcasttextid7Parameter.Value = BroadcastTextID7;
			verifiedbuildParameter.Value = VerifiedBuild;
			OLD_idParameter.Value = OLD_ID;
			OLD_probability0Parameter.Value = OLD_Probability0;
			OLD_probability1Parameter.Value = OLD_Probability1;
			OLD_probability2Parameter.Value = OLD_Probability2;
			OLD_probability3Parameter.Value = OLD_Probability3;
			OLD_probability4Parameter.Value = OLD_Probability4;
			OLD_probability5Parameter.Value = OLD_Probability5;
			OLD_probability6Parameter.Value = OLD_Probability6;
			OLD_probability7Parameter.Value = OLD_Probability7;
			OLD_broadcasttextid0Parameter.Value = OLD_BroadcastTextID0;
			OLD_broadcasttextid1Parameter.Value = OLD_BroadcastTextID1;
			OLD_broadcasttextid2Parameter.Value = OLD_BroadcastTextID2;
			OLD_broadcasttextid3Parameter.Value = OLD_BroadcastTextID3;
			OLD_broadcasttextid4Parameter.Value = OLD_BroadcastTextID4;
			OLD_broadcasttextid5Parameter.Value = OLD_BroadcastTextID5;
			OLD_broadcasttextid6Parameter.Value = OLD_BroadcastTextID6;
			OLD_broadcasttextid7Parameter.Value = OLD_BroadcastTextID7;
			OLD_verifiedbuildParameter.Value = OLD_VerifiedBuild;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(probability0Parameter);
			cmd.Parameters.Add(probability1Parameter);
			cmd.Parameters.Add(probability2Parameter);
			cmd.Parameters.Add(probability3Parameter);
			cmd.Parameters.Add(probability4Parameter);
			cmd.Parameters.Add(probability5Parameter);
			cmd.Parameters.Add(probability6Parameter);
			cmd.Parameters.Add(probability7Parameter);
			cmd.Parameters.Add(broadcasttextid0Parameter);
			cmd.Parameters.Add(broadcasttextid1Parameter);
			cmd.Parameters.Add(broadcasttextid2Parameter);
			cmd.Parameters.Add(broadcasttextid3Parameter);
			cmd.Parameters.Add(broadcasttextid4Parameter);
			cmd.Parameters.Add(broadcasttextid5Parameter);
			cmd.Parameters.Add(broadcasttextid6Parameter);
			cmd.Parameters.Add(broadcasttextid7Parameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_probability0Parameter);
			cmd.Parameters.Add(OLD_probability1Parameter);
			cmd.Parameters.Add(OLD_probability2Parameter);
			cmd.Parameters.Add(OLD_probability3Parameter);
			cmd.Parameters.Add(OLD_probability4Parameter);
			cmd.Parameters.Add(OLD_probability5Parameter);
			cmd.Parameters.Add(OLD_probability6Parameter);
			cmd.Parameters.Add(OLD_probability7Parameter);
			cmd.Parameters.Add(OLD_broadcasttextid0Parameter);
			cmd.Parameters.Add(OLD_broadcasttextid1Parameter);
			cmd.Parameters.Add(OLD_broadcasttextid2Parameter);
			cmd.Parameters.Add(OLD_broadcasttextid3Parameter);
			cmd.Parameters.Add(OLD_broadcasttextid4Parameter);
			cmd.Parameters.Add(OLD_broadcasttextid5Parameter);
			cmd.Parameters.Add(OLD_broadcasttextid6Parameter);
			cmd.Parameters.Add(OLD_broadcasttextid7Parameter);
			cmd.Parameters.Add(OLD_verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_ID = ID;
			OLD_Probability0 = Probability0;
			OLD_Probability1 = Probability1;
			OLD_Probability2 = Probability2;
			OLD_Probability3 = Probability3;
			OLD_Probability4 = Probability4;
			OLD_Probability5 = Probability5;
			OLD_Probability6 = Probability6;
			OLD_Probability7 = Probability7;
			OLD_BroadcastTextID0 = BroadcastTextID0;
			OLD_BroadcastTextID1 = BroadcastTextID1;
			OLD_BroadcastTextID2 = BroadcastTextID2;
			OLD_BroadcastTextID3 = BroadcastTextID3;
			OLD_BroadcastTextID4 = BroadcastTextID4;
			OLD_BroadcastTextID5 = BroadcastTextID5;
			OLD_BroadcastTextID6 = BroadcastTextID6;
			OLD_BroadcastTextID7 = BroadcastTextID7;
			OLD_VerifiedBuild = VerifiedBuild;
		}
	}
}
