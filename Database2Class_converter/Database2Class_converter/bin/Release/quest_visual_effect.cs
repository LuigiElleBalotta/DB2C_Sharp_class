using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Quest_visual_effect
	{
		int ID = 0; //Comment: 
		int OLD_ID = 0;

		int Index = 0; //Comment: 
		int OLD_Index = 0;

		int VisualEffect = 0; //Comment: 
		int OLD_VisualEffect = 0;

		int VerifiedBuild = 0; //Comment: 
		int OLD_VerifiedBuild = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Quest_visual_effect(int _ID, int _Index, int _VisualEffect, int _VerifiedBuild)
		{
			ID = _ID;
			Index = _Index;
			VisualEffect = _VisualEffect;
			VerifiedBuild = _VerifiedBuild;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM quest_visual_effect WHERE ID = @ID AND Index = @Index AND VisualEffect = @VisualEffect AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter indexParameter = new MySqlParameter("@Index", MySqlDbType.VarChar, 0);
			MySqlParameter visualeffectParameter = new MySqlParameter("@VisualEffect", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			indexParameter.Value = Index;
			visualeffectParameter.Value = VisualEffect;
			verifiedbuildParameter.Value = VerifiedBuild;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(indexParameter);
			cmd.Parameters.Add(visualeffectParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE quest_visual_effect SET ID = @newID, Index = @newIndex, VisualEffect = @newVisualEffect, VerifiedBuild = @newVerifiedBuild WHERE ID = @ID AND Index = @Index AND VisualEffect = @VisualEffect AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_indexParameter = new MySqlParameter("@Index", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_visualeffectParameter = new MySqlParameter("@VisualEffect", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newID", MySqlDbType.VarChar, 0);
			MySqlParameter indexParameter = new MySqlParameter("@newIndex", MySqlDbType.VarChar, 0);
			MySqlParameter visualeffectParameter = new MySqlParameter("@newVisualEffect", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@newVerifiedBuild", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			indexParameter.Value = Index;
			visualeffectParameter.Value = VisualEffect;
			verifiedbuildParameter.Value = VerifiedBuild;
			OLD_idParameter.Value = OLD_ID;
			OLD_indexParameter.Value = OLD_Index;
			OLD_visualeffectParameter.Value = OLD_VisualEffect;
			OLD_verifiedbuildParameter.Value = OLD_VerifiedBuild;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(indexParameter);
			cmd.Parameters.Add(visualeffectParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_indexParameter);
			cmd.Parameters.Add(OLD_visualeffectParameter);
			cmd.Parameters.Add(OLD_verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_ID = ID;
			OLD_Index = Index;
			OLD_VisualEffect = VisualEffect;
			OLD_VerifiedBuild = VerifiedBuild;
		}
	}
}
