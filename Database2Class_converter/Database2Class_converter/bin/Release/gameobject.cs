using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Gameobject
	{
		int guid = 0; //Comment: 
		int OLD_guid = 0;

		int id = 0; //Comment: Gameobject Identifier
		int OLD_id = 0;

		int map = 0; //Comment: Map Identifier
		int OLD_map = 0;

		int zoneId = 0; //Comment: Zone Identifier
		int OLD_zoneId = 0;

		int areaId = 0; //Comment: Area Identifier
		int OLD_areaId = 0;

		int spawnMask = 1; //Comment: 
		int OLD_spawnMask = 1;

		int PhaseId = 0; //Comment: 
		int OLD_PhaseId = 0;

		int PhaseGroup = 0; //Comment: 
		int OLD_PhaseGroup = 0;

		float position_x = 0f; //Comment: 
		float OLD_position_x = 0f;

		float position_y = 0f; //Comment: 
		float OLD_position_y = 0f;

		float position_z = 0f; //Comment: 
		float OLD_position_z = 0f;

		float orientation = 0f; //Comment: 
		float OLD_orientation = 0f;

		float rotation0 = 0f; //Comment: 
		float OLD_rotation0 = 0f;

		float rotation1 = 0f; //Comment: 
		float OLD_rotation1 = 0f;

		float rotation2 = 0f; //Comment: 
		float OLD_rotation2 = 0f;

		float rotation3 = 0f; //Comment: 
		float OLD_rotation3 = 0f;

		int spawntimesecs = 0; //Comment: 
		int OLD_spawntimesecs = 0;

		int animprogress = 0; //Comment: 
		int OLD_animprogress = 0;

		int state = 0; //Comment: 
		int OLD_state = 0;

		int VerifiedBuild = 0; //Comment: 
		int OLD_VerifiedBuild = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Gameobject(int _guid, int _id, int _map, int _zoneId, int _areaId, int _spawnMask, int _PhaseId, int _PhaseGroup, float _position_x, float _position_y, float _position_z, float _orientation, float _rotation0, float _rotation1, float _rotation2, float _rotation3, int _spawntimesecs, int _animprogress, int _state, int _VerifiedBuild)
		{
			guid = _guid;
			id = _id;
			map = _map;
			zoneId = _zoneId;
			areaId = _areaId;
			spawnMask = _spawnMask;
			PhaseId = _PhaseId;
			PhaseGroup = _PhaseGroup;
			position_x = _position_x;
			position_y = _position_y;
			position_z = _position_z;
			orientation = _orientation;
			rotation0 = _rotation0;
			rotation1 = _rotation1;
			rotation2 = _rotation2;
			rotation3 = _rotation3;
			spawntimesecs = _spawntimesecs;
			animprogress = _animprogress;
			state = _state;
			VerifiedBuild = _VerifiedBuild;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM gameobject WHERE guid = @guid AND id = @id AND map = @map AND zoneId = @zoneId AND areaId = @areaId AND spawnMask = @spawnMask AND PhaseId = @PhaseId AND PhaseGroup = @PhaseGroup AND position_x = @position_x AND position_y = @position_y AND position_z = @position_z AND orientation = @orientation AND rotation0 = @rotation0 AND rotation1 = @rotation1 AND rotation2 = @rotation2 AND rotation3 = @rotation3 AND spawntimesecs = @spawntimesecs AND animprogress = @animprogress AND state = @state AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter guidParameter = new MySqlParameter("@guid", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@id", MySqlDbType.VarChar, 0);
			MySqlParameter mapParameter = new MySqlParameter("@map", MySqlDbType.VarChar, 0);
			MySqlParameter zoneidParameter = new MySqlParameter("@zoneId", MySqlDbType.VarChar, 0);
			MySqlParameter areaidParameter = new MySqlParameter("@areaId", MySqlDbType.VarChar, 0);
			MySqlParameter spawnmaskParameter = new MySqlParameter("@spawnMask", MySqlDbType.VarChar, 0);
			MySqlParameter phaseidParameter = new MySqlParameter("@PhaseId", MySqlDbType.VarChar, 0);
			MySqlParameter phasegroupParameter = new MySqlParameter("@PhaseGroup", MySqlDbType.VarChar, 0);
			MySqlParameter position_xParameter = new MySqlParameter("@position_x", MySqlDbType.VarChar, 0);
			MySqlParameter position_yParameter = new MySqlParameter("@position_y", MySqlDbType.VarChar, 0);
			MySqlParameter position_zParameter = new MySqlParameter("@position_z", MySqlDbType.VarChar, 0);
			MySqlParameter orientationParameter = new MySqlParameter("@orientation", MySqlDbType.VarChar, 0);
			MySqlParameter rotation0Parameter = new MySqlParameter("@rotation0", MySqlDbType.VarChar, 0);
			MySqlParameter rotation1Parameter = new MySqlParameter("@rotation1", MySqlDbType.VarChar, 0);
			MySqlParameter rotation2Parameter = new MySqlParameter("@rotation2", MySqlDbType.VarChar, 0);
			MySqlParameter rotation3Parameter = new MySqlParameter("@rotation3", MySqlDbType.VarChar, 0);
			MySqlParameter spawntimesecsParameter = new MySqlParameter("@spawntimesecs", MySqlDbType.VarChar, 0);
			MySqlParameter animprogressParameter = new MySqlParameter("@animprogress", MySqlDbType.VarChar, 0);
			MySqlParameter stateParameter = new MySqlParameter("@state", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			guidParameter.Value = guid;
			idParameter.Value = id;
			mapParameter.Value = map;
			zoneidParameter.Value = zoneId;
			areaidParameter.Value = areaId;
			spawnmaskParameter.Value = spawnMask;
			phaseidParameter.Value = PhaseId;
			phasegroupParameter.Value = PhaseGroup;
			position_xParameter.Value = position_x;
			position_yParameter.Value = position_y;
			position_zParameter.Value = position_z;
			orientationParameter.Value = orientation;
			rotation0Parameter.Value = rotation0;
			rotation1Parameter.Value = rotation1;
			rotation2Parameter.Value = rotation2;
			rotation3Parameter.Value = rotation3;
			spawntimesecsParameter.Value = spawntimesecs;
			animprogressParameter.Value = animprogress;
			stateParameter.Value = state;
			verifiedbuildParameter.Value = VerifiedBuild;
			cmd.Parameters.Add(guidParameter);
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(mapParameter);
			cmd.Parameters.Add(zoneidParameter);
			cmd.Parameters.Add(areaidParameter);
			cmd.Parameters.Add(spawnmaskParameter);
			cmd.Parameters.Add(phaseidParameter);
			cmd.Parameters.Add(phasegroupParameter);
			cmd.Parameters.Add(position_xParameter);
			cmd.Parameters.Add(position_yParameter);
			cmd.Parameters.Add(position_zParameter);
			cmd.Parameters.Add(orientationParameter);
			cmd.Parameters.Add(rotation0Parameter);
			cmd.Parameters.Add(rotation1Parameter);
			cmd.Parameters.Add(rotation2Parameter);
			cmd.Parameters.Add(rotation3Parameter);
			cmd.Parameters.Add(spawntimesecsParameter);
			cmd.Parameters.Add(animprogressParameter);
			cmd.Parameters.Add(stateParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE gameobject SET guid = @newguid, id = @newid, map = @newmap, zoneId = @newzoneId, areaId = @newareaId, spawnMask = @newspawnMask, PhaseId = @newPhaseId, PhaseGroup = @newPhaseGroup, position_x = @newposition_x, position_y = @newposition_y, position_z = @newposition_z, orientation = @neworientation, rotation0 = @newrotation0, rotation1 = @newrotation1, rotation2 = @newrotation2, rotation3 = @newrotation3, spawntimesecs = @newspawntimesecs, animprogress = @newanimprogress, state = @newstate, VerifiedBuild = @newVerifiedBuild WHERE guid = @guid AND id = @id AND map = @map AND zoneId = @zoneId AND areaId = @areaId AND spawnMask = @spawnMask AND PhaseId = @PhaseId AND PhaseGroup = @PhaseGroup AND position_x = @position_x AND position_y = @position_y AND position_z = @position_z AND orientation = @orientation AND rotation0 = @rotation0 AND rotation1 = @rotation1 AND rotation2 = @rotation2 AND rotation3 = @rotation3 AND spawntimesecs = @spawntimesecs AND animprogress = @animprogress AND state = @state AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter OLD_guidParameter = new MySqlParameter("@guid", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_idParameter = new MySqlParameter("@id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_mapParameter = new MySqlParameter("@map", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_zoneidParameter = new MySqlParameter("@zoneId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_areaidParameter = new MySqlParameter("@areaId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spawnmaskParameter = new MySqlParameter("@spawnMask", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_phaseidParameter = new MySqlParameter("@PhaseId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_phasegroupParameter = new MySqlParameter("@PhaseGroup", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_position_xParameter = new MySqlParameter("@position_x", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_position_yParameter = new MySqlParameter("@position_y", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_position_zParameter = new MySqlParameter("@position_z", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_orientationParameter = new MySqlParameter("@orientation", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rotation0Parameter = new MySqlParameter("@rotation0", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rotation1Parameter = new MySqlParameter("@rotation1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rotation2Parameter = new MySqlParameter("@rotation2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rotation3Parameter = new MySqlParameter("@rotation3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spawntimesecsParameter = new MySqlParameter("@spawntimesecs", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_animprogressParameter = new MySqlParameter("@animprogress", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_stateParameter = new MySqlParameter("@state", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			MySqlParameter guidParameter = new MySqlParameter("@newguid", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newid", MySqlDbType.VarChar, 0);
			MySqlParameter mapParameter = new MySqlParameter("@newmap", MySqlDbType.VarChar, 0);
			MySqlParameter zoneidParameter = new MySqlParameter("@newzoneId", MySqlDbType.VarChar, 0);
			MySqlParameter areaidParameter = new MySqlParameter("@newareaId", MySqlDbType.VarChar, 0);
			MySqlParameter spawnmaskParameter = new MySqlParameter("@newspawnMask", MySqlDbType.VarChar, 0);
			MySqlParameter phaseidParameter = new MySqlParameter("@newPhaseId", MySqlDbType.VarChar, 0);
			MySqlParameter phasegroupParameter = new MySqlParameter("@newPhaseGroup", MySqlDbType.VarChar, 0);
			MySqlParameter position_xParameter = new MySqlParameter("@newposition_x", MySqlDbType.VarChar, 0);
			MySqlParameter position_yParameter = new MySqlParameter("@newposition_y", MySqlDbType.VarChar, 0);
			MySqlParameter position_zParameter = new MySqlParameter("@newposition_z", MySqlDbType.VarChar, 0);
			MySqlParameter orientationParameter = new MySqlParameter("@neworientation", MySqlDbType.VarChar, 0);
			MySqlParameter rotation0Parameter = new MySqlParameter("@newrotation0", MySqlDbType.VarChar, 0);
			MySqlParameter rotation1Parameter = new MySqlParameter("@newrotation1", MySqlDbType.VarChar, 0);
			MySqlParameter rotation2Parameter = new MySqlParameter("@newrotation2", MySqlDbType.VarChar, 0);
			MySqlParameter rotation3Parameter = new MySqlParameter("@newrotation3", MySqlDbType.VarChar, 0);
			MySqlParameter spawntimesecsParameter = new MySqlParameter("@newspawntimesecs", MySqlDbType.VarChar, 0);
			MySqlParameter animprogressParameter = new MySqlParameter("@newanimprogress", MySqlDbType.VarChar, 0);
			MySqlParameter stateParameter = new MySqlParameter("@newstate", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@newVerifiedBuild", MySqlDbType.VarChar, 0);
			guidParameter.Value = guid;
			idParameter.Value = id;
			mapParameter.Value = map;
			zoneidParameter.Value = zoneId;
			areaidParameter.Value = areaId;
			spawnmaskParameter.Value = spawnMask;
			phaseidParameter.Value = PhaseId;
			phasegroupParameter.Value = PhaseGroup;
			position_xParameter.Value = position_x;
			position_yParameter.Value = position_y;
			position_zParameter.Value = position_z;
			orientationParameter.Value = orientation;
			rotation0Parameter.Value = rotation0;
			rotation1Parameter.Value = rotation1;
			rotation2Parameter.Value = rotation2;
			rotation3Parameter.Value = rotation3;
			spawntimesecsParameter.Value = spawntimesecs;
			animprogressParameter.Value = animprogress;
			stateParameter.Value = state;
			verifiedbuildParameter.Value = VerifiedBuild;
			OLD_guidParameter.Value = OLD_guid;
			OLD_idParameter.Value = OLD_id;
			OLD_mapParameter.Value = OLD_map;
			OLD_zoneidParameter.Value = OLD_zoneId;
			OLD_areaidParameter.Value = OLD_areaId;
			OLD_spawnmaskParameter.Value = OLD_spawnMask;
			OLD_phaseidParameter.Value = OLD_PhaseId;
			OLD_phasegroupParameter.Value = OLD_PhaseGroup;
			OLD_position_xParameter.Value = OLD_position_x;
			OLD_position_yParameter.Value = OLD_position_y;
			OLD_position_zParameter.Value = OLD_position_z;
			OLD_orientationParameter.Value = OLD_orientation;
			OLD_rotation0Parameter.Value = OLD_rotation0;
			OLD_rotation1Parameter.Value = OLD_rotation1;
			OLD_rotation2Parameter.Value = OLD_rotation2;
			OLD_rotation3Parameter.Value = OLD_rotation3;
			OLD_spawntimesecsParameter.Value = OLD_spawntimesecs;
			OLD_animprogressParameter.Value = OLD_animprogress;
			OLD_stateParameter.Value = OLD_state;
			OLD_verifiedbuildParameter.Value = OLD_VerifiedBuild;
			cmd.Parameters.Add(guidParameter);
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(mapParameter);
			cmd.Parameters.Add(zoneidParameter);
			cmd.Parameters.Add(areaidParameter);
			cmd.Parameters.Add(spawnmaskParameter);
			cmd.Parameters.Add(phaseidParameter);
			cmd.Parameters.Add(phasegroupParameter);
			cmd.Parameters.Add(position_xParameter);
			cmd.Parameters.Add(position_yParameter);
			cmd.Parameters.Add(position_zParameter);
			cmd.Parameters.Add(orientationParameter);
			cmd.Parameters.Add(rotation0Parameter);
			cmd.Parameters.Add(rotation1Parameter);
			cmd.Parameters.Add(rotation2Parameter);
			cmd.Parameters.Add(rotation3Parameter);
			cmd.Parameters.Add(spawntimesecsParameter);
			cmd.Parameters.Add(animprogressParameter);
			cmd.Parameters.Add(stateParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.Parameters.Add(OLD_guidParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_mapParameter);
			cmd.Parameters.Add(OLD_zoneidParameter);
			cmd.Parameters.Add(OLD_areaidParameter);
			cmd.Parameters.Add(OLD_spawnmaskParameter);
			cmd.Parameters.Add(OLD_phaseidParameter);
			cmd.Parameters.Add(OLD_phasegroupParameter);
			cmd.Parameters.Add(OLD_position_xParameter);
			cmd.Parameters.Add(OLD_position_yParameter);
			cmd.Parameters.Add(OLD_position_zParameter);
			cmd.Parameters.Add(OLD_orientationParameter);
			cmd.Parameters.Add(OLD_rotation0Parameter);
			cmd.Parameters.Add(OLD_rotation1Parameter);
			cmd.Parameters.Add(OLD_rotation2Parameter);
			cmd.Parameters.Add(OLD_rotation3Parameter);
			cmd.Parameters.Add(OLD_spawntimesecsParameter);
			cmd.Parameters.Add(OLD_animprogressParameter);
			cmd.Parameters.Add(OLD_stateParameter);
			cmd.Parameters.Add(OLD_verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_guid = guid;
			OLD_id = id;
			OLD_map = map;
			OLD_zoneId = zoneId;
			OLD_areaId = areaId;
			OLD_spawnMask = spawnMask;
			OLD_PhaseId = PhaseId;
			OLD_PhaseGroup = PhaseGroup;
			OLD_position_x = position_x;
			OLD_position_y = position_y;
			OLD_position_z = position_z;
			OLD_orientation = orientation;
			OLD_rotation0 = rotation0;
			OLD_rotation1 = rotation1;
			OLD_rotation2 = rotation2;
			OLD_rotation3 = rotation3;
			OLD_spawntimesecs = spawntimesecs;
			OLD_animprogress = animprogress;
			OLD_state = state;
			OLD_VerifiedBuild = VerifiedBuild;
		}
	}
}
