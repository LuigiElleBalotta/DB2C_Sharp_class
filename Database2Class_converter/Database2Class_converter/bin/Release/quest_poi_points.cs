using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Quest_poi_points
	{
		int QuestID = 0; //Comment: 
		int OLD_QuestID = 0;

		int Idx1 = 0; //Comment: 
		int OLD_Idx1 = 0;

		int Idx2 = 0; //Comment: 
		int OLD_Idx2 = 0;

		int X = 0; //Comment: 
		int OLD_X = 0;

		int Y = 0; //Comment: 
		int OLD_Y = 0;

		int VerifiedBuild = 0; //Comment: 
		int OLD_VerifiedBuild = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Quest_poi_points(int _QuestID, int _Idx1, int _Idx2, int _X, int _Y, int _VerifiedBuild)
		{
			QuestID = _QuestID;
			Idx1 = _Idx1;
			Idx2 = _Idx2;
			X = _X;
			Y = _Y;
			VerifiedBuild = _VerifiedBuild;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM quest_poi_points WHERE QuestID = @QuestID AND Idx1 = @Idx1 AND Idx2 = @Idx2 AND X = @X AND Y = @Y AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter questidParameter = new MySqlParameter("@QuestID", MySqlDbType.VarChar, 0);
			MySqlParameter idx1Parameter = new MySqlParameter("@Idx1", MySqlDbType.VarChar, 0);
			MySqlParameter idx2Parameter = new MySqlParameter("@Idx2", MySqlDbType.VarChar, 0);
			MySqlParameter xParameter = new MySqlParameter("@X", MySqlDbType.VarChar, 0);
			MySqlParameter yParameter = new MySqlParameter("@Y", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			questidParameter.Value = QuestID;
			idx1Parameter.Value = Idx1;
			idx2Parameter.Value = Idx2;
			xParameter.Value = X;
			yParameter.Value = Y;
			verifiedbuildParameter.Value = VerifiedBuild;
			cmd.Parameters.Add(questidParameter);
			cmd.Parameters.Add(idx1Parameter);
			cmd.Parameters.Add(idx2Parameter);
			cmd.Parameters.Add(xParameter);
			cmd.Parameters.Add(yParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE quest_poi_points SET QuestID = @newQuestID, Idx1 = @newIdx1, Idx2 = @newIdx2, X = @newX, Y = @newY, VerifiedBuild = @newVerifiedBuild WHERE QuestID = @QuestID AND Idx1 = @Idx1 AND Idx2 = @Idx2 AND X = @X AND Y = @Y AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter OLD_questidParameter = new MySqlParameter("@QuestID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_idx1Parameter = new MySqlParameter("@Idx1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_idx2Parameter = new MySqlParameter("@Idx2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_xParameter = new MySqlParameter("@X", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_yParameter = new MySqlParameter("@Y", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			MySqlParameter questidParameter = new MySqlParameter("@newQuestID", MySqlDbType.VarChar, 0);
			MySqlParameter idx1Parameter = new MySqlParameter("@newIdx1", MySqlDbType.VarChar, 0);
			MySqlParameter idx2Parameter = new MySqlParameter("@newIdx2", MySqlDbType.VarChar, 0);
			MySqlParameter xParameter = new MySqlParameter("@newX", MySqlDbType.VarChar, 0);
			MySqlParameter yParameter = new MySqlParameter("@newY", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@newVerifiedBuild", MySqlDbType.VarChar, 0);
			questidParameter.Value = QuestID;
			idx1Parameter.Value = Idx1;
			idx2Parameter.Value = Idx2;
			xParameter.Value = X;
			yParameter.Value = Y;
			verifiedbuildParameter.Value = VerifiedBuild;
			OLD_questidParameter.Value = OLD_QuestID;
			OLD_idx1Parameter.Value = OLD_Idx1;
			OLD_idx2Parameter.Value = OLD_Idx2;
			OLD_xParameter.Value = OLD_X;
			OLD_yParameter.Value = OLD_Y;
			OLD_verifiedbuildParameter.Value = OLD_VerifiedBuild;
			cmd.Parameters.Add(questidParameter);
			cmd.Parameters.Add(idx1Parameter);
			cmd.Parameters.Add(idx2Parameter);
			cmd.Parameters.Add(xParameter);
			cmd.Parameters.Add(yParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.Parameters.Add(OLD_questidParameter);
			cmd.Parameters.Add(OLD_idx1Parameter);
			cmd.Parameters.Add(OLD_idx2Parameter);
			cmd.Parameters.Add(OLD_xParameter);
			cmd.Parameters.Add(OLD_yParameter);
			cmd.Parameters.Add(OLD_verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_QuestID = QuestID;
			OLD_Idx1 = Idx1;
			OLD_Idx2 = Idx2;
			OLD_X = X;
			OLD_Y = Y;
			OLD_VerifiedBuild = VerifiedBuild;
		}
	}
}
