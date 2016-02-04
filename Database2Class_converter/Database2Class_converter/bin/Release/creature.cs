using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Creature
	{
		int guid = 0; //Comment: 
		int OLD_guid = 0;

		int id = 0; //Comment: Creature Identifier
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

		int modelid = 0; //Comment: 
		int OLD_modelid = 0;

		int equipment_id = 0; //Comment: 
		int OLD_equipment_id = 0;

		float position_x = 0f; //Comment: 
		float OLD_position_x = 0f;

		float position_y = 0f; //Comment: 
		float OLD_position_y = 0f;

		float position_z = 0f; //Comment: 
		float OLD_position_z = 0f;

		float orientation = 0f; //Comment: 
		float OLD_orientation = 0f;

		int spawntimesecs = 120; //Comment: 
		int OLD_spawntimesecs = 120;

		float spawndist = 0f; //Comment: 
		float OLD_spawndist = 0f;

		int currentwaypoint = 0; //Comment: 
		int OLD_currentwaypoint = 0;

		int curhealth = 1; //Comment: 
		int OLD_curhealth = 1;

		int curmana = 0; //Comment: 
		int OLD_curmana = 0;

		int MovementType = 0; //Comment: 
		int OLD_MovementType = 0;

		int npcflag = 0; //Comment: 
		int OLD_npcflag = 0;

		int unit_flags = 0; //Comment: 
		int OLD_unit_flags = 0;

		int dynamicflags = 0; //Comment: 
		int OLD_dynamicflags = 0;

		int VerifiedBuild = 0; //Comment: 
		int OLD_VerifiedBuild = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Creature(int _guid, int _id, int _map, int _zoneId, int _areaId, int _spawnMask, int _PhaseId, int _PhaseGroup, int _modelid, int _equipment_id, float _position_x, float _position_y, float _position_z, float _orientation, int _spawntimesecs, float _spawndist, int _currentwaypoint, int _curhealth, int _curmana, int _MovementType, int _npcflag, int _unit_flags, int _dynamicflags, int _VerifiedBuild)
		{
			guid = _guid;
			id = _id;
			map = _map;
			zoneId = _zoneId;
			areaId = _areaId;
			spawnMask = _spawnMask;
			PhaseId = _PhaseId;
			PhaseGroup = _PhaseGroup;
			modelid = _modelid;
			equipment_id = _equipment_id;
			position_x = _position_x;
			position_y = _position_y;
			position_z = _position_z;
			orientation = _orientation;
			spawntimesecs = _spawntimesecs;
			spawndist = _spawndist;
			currentwaypoint = _currentwaypoint;
			curhealth = _curhealth;
			curmana = _curmana;
			MovementType = _MovementType;
			npcflag = _npcflag;
			unit_flags = _unit_flags;
			dynamicflags = _dynamicflags;
			VerifiedBuild = _VerifiedBuild;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM creature WHERE guid = @guid AND id = @id AND map = @map AND zoneId = @zoneId AND areaId = @areaId AND spawnMask = @spawnMask AND PhaseId = @PhaseId AND PhaseGroup = @PhaseGroup AND modelid = @modelid AND equipment_id = @equipment_id AND position_x = @position_x AND position_y = @position_y AND position_z = @position_z AND orientation = @orientation AND spawntimesecs = @spawntimesecs AND spawndist = @spawndist AND currentwaypoint = @currentwaypoint AND curhealth = @curhealth AND curmana = @curmana AND MovementType = @MovementType AND npcflag = @npcflag AND unit_flags = @unit_flags AND dynamicflags = @dynamicflags AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter guidParameter = new MySqlParameter("@guid", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@id", MySqlDbType.VarChar, 0);
			MySqlParameter mapParameter = new MySqlParameter("@map", MySqlDbType.VarChar, 0);
			MySqlParameter zoneidParameter = new MySqlParameter("@zoneId", MySqlDbType.VarChar, 0);
			MySqlParameter areaidParameter = new MySqlParameter("@areaId", MySqlDbType.VarChar, 0);
			MySqlParameter spawnmaskParameter = new MySqlParameter("@spawnMask", MySqlDbType.VarChar, 0);
			MySqlParameter phaseidParameter = new MySqlParameter("@PhaseId", MySqlDbType.VarChar, 0);
			MySqlParameter phasegroupParameter = new MySqlParameter("@PhaseGroup", MySqlDbType.VarChar, 0);
			MySqlParameter modelidParameter = new MySqlParameter("@modelid", MySqlDbType.VarChar, 0);
			MySqlParameter equipment_idParameter = new MySqlParameter("@equipment_id", MySqlDbType.VarChar, 0);
			MySqlParameter position_xParameter = new MySqlParameter("@position_x", MySqlDbType.VarChar, 0);
			MySqlParameter position_yParameter = new MySqlParameter("@position_y", MySqlDbType.VarChar, 0);
			MySqlParameter position_zParameter = new MySqlParameter("@position_z", MySqlDbType.VarChar, 0);
			MySqlParameter orientationParameter = new MySqlParameter("@orientation", MySqlDbType.VarChar, 0);
			MySqlParameter spawntimesecsParameter = new MySqlParameter("@spawntimesecs", MySqlDbType.VarChar, 0);
			MySqlParameter spawndistParameter = new MySqlParameter("@spawndist", MySqlDbType.VarChar, 0);
			MySqlParameter currentwaypointParameter = new MySqlParameter("@currentwaypoint", MySqlDbType.VarChar, 0);
			MySqlParameter curhealthParameter = new MySqlParameter("@curhealth", MySqlDbType.VarChar, 0);
			MySqlParameter curmanaParameter = new MySqlParameter("@curmana", MySqlDbType.VarChar, 0);
			MySqlParameter movementtypeParameter = new MySqlParameter("@MovementType", MySqlDbType.VarChar, 0);
			MySqlParameter npcflagParameter = new MySqlParameter("@npcflag", MySqlDbType.VarChar, 0);
			MySqlParameter unit_flagsParameter = new MySqlParameter("@unit_flags", MySqlDbType.VarChar, 0);
			MySqlParameter dynamicflagsParameter = new MySqlParameter("@dynamicflags", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			guidParameter.Value = guid;
			idParameter.Value = id;
			mapParameter.Value = map;
			zoneidParameter.Value = zoneId;
			areaidParameter.Value = areaId;
			spawnmaskParameter.Value = spawnMask;
			phaseidParameter.Value = PhaseId;
			phasegroupParameter.Value = PhaseGroup;
			modelidParameter.Value = modelid;
			equipment_idParameter.Value = equipment_id;
			position_xParameter.Value = position_x;
			position_yParameter.Value = position_y;
			position_zParameter.Value = position_z;
			orientationParameter.Value = orientation;
			spawntimesecsParameter.Value = spawntimesecs;
			spawndistParameter.Value = spawndist;
			currentwaypointParameter.Value = currentwaypoint;
			curhealthParameter.Value = curhealth;
			curmanaParameter.Value = curmana;
			movementtypeParameter.Value = MovementType;
			npcflagParameter.Value = npcflag;
			unit_flagsParameter.Value = unit_flags;
			dynamicflagsParameter.Value = dynamicflags;
			verifiedbuildParameter.Value = VerifiedBuild;
			cmd.Parameters.Add(guidParameter);
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(mapParameter);
			cmd.Parameters.Add(zoneidParameter);
			cmd.Parameters.Add(areaidParameter);
			cmd.Parameters.Add(spawnmaskParameter);
			cmd.Parameters.Add(phaseidParameter);
			cmd.Parameters.Add(phasegroupParameter);
			cmd.Parameters.Add(modelidParameter);
			cmd.Parameters.Add(equipment_idParameter);
			cmd.Parameters.Add(position_xParameter);
			cmd.Parameters.Add(position_yParameter);
			cmd.Parameters.Add(position_zParameter);
			cmd.Parameters.Add(orientationParameter);
			cmd.Parameters.Add(spawntimesecsParameter);
			cmd.Parameters.Add(spawndistParameter);
			cmd.Parameters.Add(currentwaypointParameter);
			cmd.Parameters.Add(curhealthParameter);
			cmd.Parameters.Add(curmanaParameter);
			cmd.Parameters.Add(movementtypeParameter);
			cmd.Parameters.Add(npcflagParameter);
			cmd.Parameters.Add(unit_flagsParameter);
			cmd.Parameters.Add(dynamicflagsParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE creature SET guid = @newguid, id = @newid, map = @newmap, zoneId = @newzoneId, areaId = @newareaId, spawnMask = @newspawnMask, PhaseId = @newPhaseId, PhaseGroup = @newPhaseGroup, modelid = @newmodelid, equipment_id = @newequipment_id, position_x = @newposition_x, position_y = @newposition_y, position_z = @newposition_z, orientation = @neworientation, spawntimesecs = @newspawntimesecs, spawndist = @newspawndist, currentwaypoint = @newcurrentwaypoint, curhealth = @newcurhealth, curmana = @newcurmana, MovementType = @newMovementType, npcflag = @newnpcflag, unit_flags = @newunit_flags, dynamicflags = @newdynamicflags, VerifiedBuild = @newVerifiedBuild WHERE guid = @guid AND id = @id AND map = @map AND zoneId = @zoneId AND areaId = @areaId AND spawnMask = @spawnMask AND PhaseId = @PhaseId AND PhaseGroup = @PhaseGroup AND modelid = @modelid AND equipment_id = @equipment_id AND position_x = @position_x AND position_y = @position_y AND position_z = @position_z AND orientation = @orientation AND spawntimesecs = @spawntimesecs AND spawndist = @spawndist AND currentwaypoint = @currentwaypoint AND curhealth = @curhealth AND curmana = @curmana AND MovementType = @MovementType AND npcflag = @npcflag AND unit_flags = @unit_flags AND dynamicflags = @dynamicflags AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter OLD_guidParameter = new MySqlParameter("@guid", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_idParameter = new MySqlParameter("@id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_mapParameter = new MySqlParameter("@map", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_zoneidParameter = new MySqlParameter("@zoneId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_areaidParameter = new MySqlParameter("@areaId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spawnmaskParameter = new MySqlParameter("@spawnMask", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_phaseidParameter = new MySqlParameter("@PhaseId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_phasegroupParameter = new MySqlParameter("@PhaseGroup", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_modelidParameter = new MySqlParameter("@modelid", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_equipment_idParameter = new MySqlParameter("@equipment_id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_position_xParameter = new MySqlParameter("@position_x", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_position_yParameter = new MySqlParameter("@position_y", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_position_zParameter = new MySqlParameter("@position_z", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_orientationParameter = new MySqlParameter("@orientation", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spawntimesecsParameter = new MySqlParameter("@spawntimesecs", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spawndistParameter = new MySqlParameter("@spawndist", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_currentwaypointParameter = new MySqlParameter("@currentwaypoint", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_curhealthParameter = new MySqlParameter("@curhealth", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_curmanaParameter = new MySqlParameter("@curmana", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_movementtypeParameter = new MySqlParameter("@MovementType", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_npcflagParameter = new MySqlParameter("@npcflag", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_unit_flagsParameter = new MySqlParameter("@unit_flags", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_dynamicflagsParameter = new MySqlParameter("@dynamicflags", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			MySqlParameter guidParameter = new MySqlParameter("@newguid", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newid", MySqlDbType.VarChar, 0);
			MySqlParameter mapParameter = new MySqlParameter("@newmap", MySqlDbType.VarChar, 0);
			MySqlParameter zoneidParameter = new MySqlParameter("@newzoneId", MySqlDbType.VarChar, 0);
			MySqlParameter areaidParameter = new MySqlParameter("@newareaId", MySqlDbType.VarChar, 0);
			MySqlParameter spawnmaskParameter = new MySqlParameter("@newspawnMask", MySqlDbType.VarChar, 0);
			MySqlParameter phaseidParameter = new MySqlParameter("@newPhaseId", MySqlDbType.VarChar, 0);
			MySqlParameter phasegroupParameter = new MySqlParameter("@newPhaseGroup", MySqlDbType.VarChar, 0);
			MySqlParameter modelidParameter = new MySqlParameter("@newmodelid", MySqlDbType.VarChar, 0);
			MySqlParameter equipment_idParameter = new MySqlParameter("@newequipment_id", MySqlDbType.VarChar, 0);
			MySqlParameter position_xParameter = new MySqlParameter("@newposition_x", MySqlDbType.VarChar, 0);
			MySqlParameter position_yParameter = new MySqlParameter("@newposition_y", MySqlDbType.VarChar, 0);
			MySqlParameter position_zParameter = new MySqlParameter("@newposition_z", MySqlDbType.VarChar, 0);
			MySqlParameter orientationParameter = new MySqlParameter("@neworientation", MySqlDbType.VarChar, 0);
			MySqlParameter spawntimesecsParameter = new MySqlParameter("@newspawntimesecs", MySqlDbType.VarChar, 0);
			MySqlParameter spawndistParameter = new MySqlParameter("@newspawndist", MySqlDbType.VarChar, 0);
			MySqlParameter currentwaypointParameter = new MySqlParameter("@newcurrentwaypoint", MySqlDbType.VarChar, 0);
			MySqlParameter curhealthParameter = new MySqlParameter("@newcurhealth", MySqlDbType.VarChar, 0);
			MySqlParameter curmanaParameter = new MySqlParameter("@newcurmana", MySqlDbType.VarChar, 0);
			MySqlParameter movementtypeParameter = new MySqlParameter("@newMovementType", MySqlDbType.VarChar, 0);
			MySqlParameter npcflagParameter = new MySqlParameter("@newnpcflag", MySqlDbType.VarChar, 0);
			MySqlParameter unit_flagsParameter = new MySqlParameter("@newunit_flags", MySqlDbType.VarChar, 0);
			MySqlParameter dynamicflagsParameter = new MySqlParameter("@newdynamicflags", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@newVerifiedBuild", MySqlDbType.VarChar, 0);
			guidParameter.Value = guid;
			idParameter.Value = id;
			mapParameter.Value = map;
			zoneidParameter.Value = zoneId;
			areaidParameter.Value = areaId;
			spawnmaskParameter.Value = spawnMask;
			phaseidParameter.Value = PhaseId;
			phasegroupParameter.Value = PhaseGroup;
			modelidParameter.Value = modelid;
			equipment_idParameter.Value = equipment_id;
			position_xParameter.Value = position_x;
			position_yParameter.Value = position_y;
			position_zParameter.Value = position_z;
			orientationParameter.Value = orientation;
			spawntimesecsParameter.Value = spawntimesecs;
			spawndistParameter.Value = spawndist;
			currentwaypointParameter.Value = currentwaypoint;
			curhealthParameter.Value = curhealth;
			curmanaParameter.Value = curmana;
			movementtypeParameter.Value = MovementType;
			npcflagParameter.Value = npcflag;
			unit_flagsParameter.Value = unit_flags;
			dynamicflagsParameter.Value = dynamicflags;
			verifiedbuildParameter.Value = VerifiedBuild;
			OLD_guidParameter.Value = OLD_guid;
			OLD_idParameter.Value = OLD_id;
			OLD_mapParameter.Value = OLD_map;
			OLD_zoneidParameter.Value = OLD_zoneId;
			OLD_areaidParameter.Value = OLD_areaId;
			OLD_spawnmaskParameter.Value = OLD_spawnMask;
			OLD_phaseidParameter.Value = OLD_PhaseId;
			OLD_phasegroupParameter.Value = OLD_PhaseGroup;
			OLD_modelidParameter.Value = OLD_modelid;
			OLD_equipment_idParameter.Value = OLD_equipment_id;
			OLD_position_xParameter.Value = OLD_position_x;
			OLD_position_yParameter.Value = OLD_position_y;
			OLD_position_zParameter.Value = OLD_position_z;
			OLD_orientationParameter.Value = OLD_orientation;
			OLD_spawntimesecsParameter.Value = OLD_spawntimesecs;
			OLD_spawndistParameter.Value = OLD_spawndist;
			OLD_currentwaypointParameter.Value = OLD_currentwaypoint;
			OLD_curhealthParameter.Value = OLD_curhealth;
			OLD_curmanaParameter.Value = OLD_curmana;
			OLD_movementtypeParameter.Value = OLD_MovementType;
			OLD_npcflagParameter.Value = OLD_npcflag;
			OLD_unit_flagsParameter.Value = OLD_unit_flags;
			OLD_dynamicflagsParameter.Value = OLD_dynamicflags;
			OLD_verifiedbuildParameter.Value = OLD_VerifiedBuild;
			cmd.Parameters.Add(guidParameter);
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(mapParameter);
			cmd.Parameters.Add(zoneidParameter);
			cmd.Parameters.Add(areaidParameter);
			cmd.Parameters.Add(spawnmaskParameter);
			cmd.Parameters.Add(phaseidParameter);
			cmd.Parameters.Add(phasegroupParameter);
			cmd.Parameters.Add(modelidParameter);
			cmd.Parameters.Add(equipment_idParameter);
			cmd.Parameters.Add(position_xParameter);
			cmd.Parameters.Add(position_yParameter);
			cmd.Parameters.Add(position_zParameter);
			cmd.Parameters.Add(orientationParameter);
			cmd.Parameters.Add(spawntimesecsParameter);
			cmd.Parameters.Add(spawndistParameter);
			cmd.Parameters.Add(currentwaypointParameter);
			cmd.Parameters.Add(curhealthParameter);
			cmd.Parameters.Add(curmanaParameter);
			cmd.Parameters.Add(movementtypeParameter);
			cmd.Parameters.Add(npcflagParameter);
			cmd.Parameters.Add(unit_flagsParameter);
			cmd.Parameters.Add(dynamicflagsParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.Parameters.Add(OLD_guidParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_mapParameter);
			cmd.Parameters.Add(OLD_zoneidParameter);
			cmd.Parameters.Add(OLD_areaidParameter);
			cmd.Parameters.Add(OLD_spawnmaskParameter);
			cmd.Parameters.Add(OLD_phaseidParameter);
			cmd.Parameters.Add(OLD_phasegroupParameter);
			cmd.Parameters.Add(OLD_modelidParameter);
			cmd.Parameters.Add(OLD_equipment_idParameter);
			cmd.Parameters.Add(OLD_position_xParameter);
			cmd.Parameters.Add(OLD_position_yParameter);
			cmd.Parameters.Add(OLD_position_zParameter);
			cmd.Parameters.Add(OLD_orientationParameter);
			cmd.Parameters.Add(OLD_spawntimesecsParameter);
			cmd.Parameters.Add(OLD_spawndistParameter);
			cmd.Parameters.Add(OLD_currentwaypointParameter);
			cmd.Parameters.Add(OLD_curhealthParameter);
			cmd.Parameters.Add(OLD_curmanaParameter);
			cmd.Parameters.Add(OLD_movementtypeParameter);
			cmd.Parameters.Add(OLD_npcflagParameter);
			cmd.Parameters.Add(OLD_unit_flagsParameter);
			cmd.Parameters.Add(OLD_dynamicflagsParameter);
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
			OLD_modelid = modelid;
			OLD_equipment_id = equipment_id;
			OLD_position_x = position_x;
			OLD_position_y = position_y;
			OLD_position_z = position_z;
			OLD_orientation = orientation;
			OLD_spawntimesecs = spawntimesecs;
			OLD_spawndist = spawndist;
			OLD_currentwaypoint = currentwaypoint;
			OLD_curhealth = curhealth;
			OLD_curmana = curmana;
			OLD_MovementType = MovementType;
			OLD_npcflag = npcflag;
			OLD_unit_flags = unit_flags;
			OLD_dynamicflags = dynamicflags;
			OLD_VerifiedBuild = VerifiedBuild;
		}
	}
}
