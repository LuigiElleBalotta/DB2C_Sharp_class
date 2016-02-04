using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Creature_model_info
	{
		int DisplayID = 0; //Comment: 
		int OLD_DisplayID = 0;

		float BoundingRadius = 0f; //Comment: 
		float OLD_BoundingRadius = 0f;

		float CombatReach = 0f; //Comment: 
		float OLD_CombatReach = 0f;

		int DisplayID_Other_Gender = 0; //Comment: 
		int OLD_DisplayID_Other_Gender = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Creature_model_info(int _DisplayID, float _BoundingRadius, float _CombatReach, int _DisplayID_Other_Gender)
		{
			DisplayID = _DisplayID;
			BoundingRadius = _BoundingRadius;
			CombatReach = _CombatReach;
			DisplayID_Other_Gender = _DisplayID_Other_Gender;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM creature_model_info WHERE DisplayID = @DisplayID AND BoundingRadius = @BoundingRadius AND CombatReach = @CombatReach AND DisplayID_Other_Gender = @DisplayID_Other_Gender;";
			MySqlParameter displayidParameter = new MySqlParameter("@DisplayID", MySqlDbType.VarChar, 0);
			MySqlParameter boundingradiusParameter = new MySqlParameter("@BoundingRadius", MySqlDbType.VarChar, 0);
			MySqlParameter combatreachParameter = new MySqlParameter("@CombatReach", MySqlDbType.VarChar, 0);
			MySqlParameter displayid_other_genderParameter = new MySqlParameter("@DisplayID_Other_Gender", MySqlDbType.VarChar, 0);
			displayidParameter.Value = DisplayID;
			boundingradiusParameter.Value = BoundingRadius;
			combatreachParameter.Value = CombatReach;
			displayid_other_genderParameter.Value = DisplayID_Other_Gender;
			cmd.Parameters.Add(displayidParameter);
			cmd.Parameters.Add(boundingradiusParameter);
			cmd.Parameters.Add(combatreachParameter);
			cmd.Parameters.Add(displayid_other_genderParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE creature_model_info SET DisplayID = @newDisplayID, BoundingRadius = @newBoundingRadius, CombatReach = @newCombatReach, DisplayID_Other_Gender = @newDisplayID_Other_Gender WHERE DisplayID = @DisplayID AND BoundingRadius = @BoundingRadius AND CombatReach = @CombatReach AND DisplayID_Other_Gender = @DisplayID_Other_Gender;";
			MySqlParameter OLD_displayidParameter = new MySqlParameter("@DisplayID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_boundingradiusParameter = new MySqlParameter("@BoundingRadius", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_combatreachParameter = new MySqlParameter("@CombatReach", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_displayid_other_genderParameter = new MySqlParameter("@DisplayID_Other_Gender", MySqlDbType.VarChar, 0);
			MySqlParameter displayidParameter = new MySqlParameter("@newDisplayID", MySqlDbType.VarChar, 0);
			MySqlParameter boundingradiusParameter = new MySqlParameter("@newBoundingRadius", MySqlDbType.VarChar, 0);
			MySqlParameter combatreachParameter = new MySqlParameter("@newCombatReach", MySqlDbType.VarChar, 0);
			MySqlParameter displayid_other_genderParameter = new MySqlParameter("@newDisplayID_Other_Gender", MySqlDbType.VarChar, 0);
			displayidParameter.Value = DisplayID;
			boundingradiusParameter.Value = BoundingRadius;
			combatreachParameter.Value = CombatReach;
			displayid_other_genderParameter.Value = DisplayID_Other_Gender;
			OLD_displayidParameter.Value = OLD_DisplayID;
			OLD_boundingradiusParameter.Value = OLD_BoundingRadius;
			OLD_combatreachParameter.Value = OLD_CombatReach;
			OLD_displayid_other_genderParameter.Value = OLD_DisplayID_Other_Gender;
			cmd.Parameters.Add(displayidParameter);
			cmd.Parameters.Add(boundingradiusParameter);
			cmd.Parameters.Add(combatreachParameter);
			cmd.Parameters.Add(displayid_other_genderParameter);
			cmd.Parameters.Add(OLD_displayidParameter);
			cmd.Parameters.Add(OLD_boundingradiusParameter);
			cmd.Parameters.Add(OLD_combatreachParameter);
			cmd.Parameters.Add(OLD_displayid_other_genderParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_DisplayID = DisplayID;
			OLD_BoundingRadius = BoundingRadius;
			OLD_CombatReach = CombatReach;
			OLD_DisplayID_Other_Gender = DisplayID_Other_Gender;
		}
	}
}
