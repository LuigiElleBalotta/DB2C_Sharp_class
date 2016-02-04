using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Spell_target_position
	{
		int ID = 0; //Comment: 
		int OLD_ID = 0;

		int EffectIndex = 0; //Comment: 
		int OLD_EffectIndex = 0;

		int MapID = 0; //Comment: 
		int OLD_MapID = 0;

		float PositionX = 0f; //Comment: 
		float OLD_PositionX = 0f;

		float PositionY = 0f; //Comment: 
		float OLD_PositionY = 0f;

		float PositionZ = 0f; //Comment: 
		float OLD_PositionZ = 0f;

		int VerifiedBuild = 0; //Comment: 
		int OLD_VerifiedBuild = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Spell_target_position(int _ID, int _EffectIndex, int _MapID, float _PositionX, float _PositionY, float _PositionZ, int _VerifiedBuild)
		{
			ID = _ID;
			EffectIndex = _EffectIndex;
			MapID = _MapID;
			PositionX = _PositionX;
			PositionY = _PositionY;
			PositionZ = _PositionZ;
			VerifiedBuild = _VerifiedBuild;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM spell_target_position WHERE ID = @ID AND EffectIndex = @EffectIndex AND MapID = @MapID AND PositionX = @PositionX AND PositionY = @PositionY AND PositionZ = @PositionZ AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter effectindexParameter = new MySqlParameter("@EffectIndex", MySqlDbType.VarChar, 0);
			MySqlParameter mapidParameter = new MySqlParameter("@MapID", MySqlDbType.VarChar, 0);
			MySqlParameter positionxParameter = new MySqlParameter("@PositionX", MySqlDbType.VarChar, 0);
			MySqlParameter positionyParameter = new MySqlParameter("@PositionY", MySqlDbType.VarChar, 0);
			MySqlParameter positionzParameter = new MySqlParameter("@PositionZ", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			effectindexParameter.Value = EffectIndex;
			mapidParameter.Value = MapID;
			positionxParameter.Value = PositionX;
			positionyParameter.Value = PositionY;
			positionzParameter.Value = PositionZ;
			verifiedbuildParameter.Value = VerifiedBuild;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(effectindexParameter);
			cmd.Parameters.Add(mapidParameter);
			cmd.Parameters.Add(positionxParameter);
			cmd.Parameters.Add(positionyParameter);
			cmd.Parameters.Add(positionzParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE spell_target_position SET ID = @newID, EffectIndex = @newEffectIndex, MapID = @newMapID, PositionX = @newPositionX, PositionY = @newPositionY, PositionZ = @newPositionZ, VerifiedBuild = @newVerifiedBuild WHERE ID = @ID AND EffectIndex = @EffectIndex AND MapID = @MapID AND PositionX = @PositionX AND PositionY = @PositionY AND PositionZ = @PositionZ AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_effectindexParameter = new MySqlParameter("@EffectIndex", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_mapidParameter = new MySqlParameter("@MapID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_positionxParameter = new MySqlParameter("@PositionX", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_positionyParameter = new MySqlParameter("@PositionY", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_positionzParameter = new MySqlParameter("@PositionZ", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newID", MySqlDbType.VarChar, 0);
			MySqlParameter effectindexParameter = new MySqlParameter("@newEffectIndex", MySqlDbType.VarChar, 0);
			MySqlParameter mapidParameter = new MySqlParameter("@newMapID", MySqlDbType.VarChar, 0);
			MySqlParameter positionxParameter = new MySqlParameter("@newPositionX", MySqlDbType.VarChar, 0);
			MySqlParameter positionyParameter = new MySqlParameter("@newPositionY", MySqlDbType.VarChar, 0);
			MySqlParameter positionzParameter = new MySqlParameter("@newPositionZ", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@newVerifiedBuild", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			effectindexParameter.Value = EffectIndex;
			mapidParameter.Value = MapID;
			positionxParameter.Value = PositionX;
			positionyParameter.Value = PositionY;
			positionzParameter.Value = PositionZ;
			verifiedbuildParameter.Value = VerifiedBuild;
			OLD_idParameter.Value = OLD_ID;
			OLD_effectindexParameter.Value = OLD_EffectIndex;
			OLD_mapidParameter.Value = OLD_MapID;
			OLD_positionxParameter.Value = OLD_PositionX;
			OLD_positionyParameter.Value = OLD_PositionY;
			OLD_positionzParameter.Value = OLD_PositionZ;
			OLD_verifiedbuildParameter.Value = OLD_VerifiedBuild;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(effectindexParameter);
			cmd.Parameters.Add(mapidParameter);
			cmd.Parameters.Add(positionxParameter);
			cmd.Parameters.Add(positionyParameter);
			cmd.Parameters.Add(positionzParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_effectindexParameter);
			cmd.Parameters.Add(OLD_mapidParameter);
			cmd.Parameters.Add(OLD_positionxParameter);
			cmd.Parameters.Add(OLD_positionyParameter);
			cmd.Parameters.Add(OLD_positionzParameter);
			cmd.Parameters.Add(OLD_verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_ID = ID;
			OLD_EffectIndex = EffectIndex;
			OLD_MapID = MapID;
			OLD_PositionX = PositionX;
			OLD_PositionY = PositionY;
			OLD_PositionZ = PositionZ;
			OLD_VerifiedBuild = VerifiedBuild;
		}
	}
}
