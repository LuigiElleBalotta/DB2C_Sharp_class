using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Quest_poi
	{
		int QuestID = 0; //Comment: 
		int OLD_QuestID = 0;

		int BlobIndex = 0; //Comment: 
		int OLD_BlobIndex = 0;

		int Idx1 = 0; //Comment: 
		int OLD_Idx1 = 0;

		int ObjectiveIndex = 0; //Comment: 
		int OLD_ObjectiveIndex = 0;

		int QuestObjectiveID = 0; //Comment: 
		int OLD_QuestObjectiveID = 0;

		int QuestObjectID = 0; //Comment: 
		int OLD_QuestObjectID = 0;

		int MapID = 0; //Comment: 
		int OLD_MapID = 0;

		int WorldMapAreaId = 0; //Comment: 
		int OLD_WorldMapAreaId = 0;

		int Floor = 0; //Comment: 
		int OLD_Floor = 0;

		int Priority = 0; //Comment: 
		int OLD_Priority = 0;

		int Flags = 0; //Comment: 
		int OLD_Flags = 0;

		int WorldEffectID = 0; //Comment: 
		int OLD_WorldEffectID = 0;

		int PlayerConditionID = 0; //Comment: 
		int OLD_PlayerConditionID = 0;

		int WoDUnk1 = 0; //Comment: 
		int OLD_WoDUnk1 = 0;

		int VerifiedBuild = 0; //Comment: 
		int OLD_VerifiedBuild = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Quest_poi(int _QuestID, int _BlobIndex, int _Idx1, int _ObjectiveIndex, int _QuestObjectiveID, int _QuestObjectID, int _MapID, int _WorldMapAreaId, int _Floor, int _Priority, int _Flags, int _WorldEffectID, int _PlayerConditionID, int _WoDUnk1, int _VerifiedBuild)
		{
			QuestID = _QuestID;
			BlobIndex = _BlobIndex;
			Idx1 = _Idx1;
			ObjectiveIndex = _ObjectiveIndex;
			QuestObjectiveID = _QuestObjectiveID;
			QuestObjectID = _QuestObjectID;
			MapID = _MapID;
			WorldMapAreaId = _WorldMapAreaId;
			Floor = _Floor;
			Priority = _Priority;
			Flags = _Flags;
			WorldEffectID = _WorldEffectID;
			PlayerConditionID = _PlayerConditionID;
			WoDUnk1 = _WoDUnk1;
			VerifiedBuild = _VerifiedBuild;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM quest_poi WHERE QuestID = @QuestID AND BlobIndex = @BlobIndex AND Idx1 = @Idx1 AND ObjectiveIndex = @ObjectiveIndex AND QuestObjectiveID = @QuestObjectiveID AND QuestObjectID = @QuestObjectID AND MapID = @MapID AND WorldMapAreaId = @WorldMapAreaId AND Floor = @Floor AND Priority = @Priority AND Flags = @Flags AND WorldEffectID = @WorldEffectID AND PlayerConditionID = @PlayerConditionID AND WoDUnk1 = @WoDUnk1 AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter questidParameter = new MySqlParameter("@QuestID", MySqlDbType.VarChar, 0);
			MySqlParameter blobindexParameter = new MySqlParameter("@BlobIndex", MySqlDbType.VarChar, 0);
			MySqlParameter idx1Parameter = new MySqlParameter("@Idx1", MySqlDbType.VarChar, 0);
			MySqlParameter objectiveindexParameter = new MySqlParameter("@ObjectiveIndex", MySqlDbType.VarChar, 0);
			MySqlParameter questobjectiveidParameter = new MySqlParameter("@QuestObjectiveID", MySqlDbType.VarChar, 0);
			MySqlParameter questobjectidParameter = new MySqlParameter("@QuestObjectID", MySqlDbType.VarChar, 0);
			MySqlParameter mapidParameter = new MySqlParameter("@MapID", MySqlDbType.VarChar, 0);
			MySqlParameter worldmapareaidParameter = new MySqlParameter("@WorldMapAreaId", MySqlDbType.VarChar, 0);
			MySqlParameter floorParameter = new MySqlParameter("@Floor", MySqlDbType.VarChar, 0);
			MySqlParameter priorityParameter = new MySqlParameter("@Priority", MySqlDbType.VarChar, 0);
			MySqlParameter flagsParameter = new MySqlParameter("@Flags", MySqlDbType.VarChar, 0);
			MySqlParameter worldeffectidParameter = new MySqlParameter("@WorldEffectID", MySqlDbType.VarChar, 0);
			MySqlParameter playerconditionidParameter = new MySqlParameter("@PlayerConditionID", MySqlDbType.VarChar, 0);
			MySqlParameter wodunk1Parameter = new MySqlParameter("@WoDUnk1", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			questidParameter.Value = QuestID;
			blobindexParameter.Value = BlobIndex;
			idx1Parameter.Value = Idx1;
			objectiveindexParameter.Value = ObjectiveIndex;
			questobjectiveidParameter.Value = QuestObjectiveID;
			questobjectidParameter.Value = QuestObjectID;
			mapidParameter.Value = MapID;
			worldmapareaidParameter.Value = WorldMapAreaId;
			floorParameter.Value = Floor;
			priorityParameter.Value = Priority;
			flagsParameter.Value = Flags;
			worldeffectidParameter.Value = WorldEffectID;
			playerconditionidParameter.Value = PlayerConditionID;
			wodunk1Parameter.Value = WoDUnk1;
			verifiedbuildParameter.Value = VerifiedBuild;
			cmd.Parameters.Add(questidParameter);
			cmd.Parameters.Add(blobindexParameter);
			cmd.Parameters.Add(idx1Parameter);
			cmd.Parameters.Add(objectiveindexParameter);
			cmd.Parameters.Add(questobjectiveidParameter);
			cmd.Parameters.Add(questobjectidParameter);
			cmd.Parameters.Add(mapidParameter);
			cmd.Parameters.Add(worldmapareaidParameter);
			cmd.Parameters.Add(floorParameter);
			cmd.Parameters.Add(priorityParameter);
			cmd.Parameters.Add(flagsParameter);
			cmd.Parameters.Add(worldeffectidParameter);
			cmd.Parameters.Add(playerconditionidParameter);
			cmd.Parameters.Add(wodunk1Parameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE quest_poi SET QuestID = @newQuestID, BlobIndex = @newBlobIndex, Idx1 = @newIdx1, ObjectiveIndex = @newObjectiveIndex, QuestObjectiveID = @newQuestObjectiveID, QuestObjectID = @newQuestObjectID, MapID = @newMapID, WorldMapAreaId = @newWorldMapAreaId, Floor = @newFloor, Priority = @newPriority, Flags = @newFlags, WorldEffectID = @newWorldEffectID, PlayerConditionID = @newPlayerConditionID, WoDUnk1 = @newWoDUnk1, VerifiedBuild = @newVerifiedBuild WHERE QuestID = @QuestID AND BlobIndex = @BlobIndex AND Idx1 = @Idx1 AND ObjectiveIndex = @ObjectiveIndex AND QuestObjectiveID = @QuestObjectiveID AND QuestObjectID = @QuestObjectID AND MapID = @MapID AND WorldMapAreaId = @WorldMapAreaId AND Floor = @Floor AND Priority = @Priority AND Flags = @Flags AND WorldEffectID = @WorldEffectID AND PlayerConditionID = @PlayerConditionID AND WoDUnk1 = @WoDUnk1 AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter OLD_questidParameter = new MySqlParameter("@QuestID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_blobindexParameter = new MySqlParameter("@BlobIndex", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_idx1Parameter = new MySqlParameter("@Idx1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_objectiveindexParameter = new MySqlParameter("@ObjectiveIndex", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_questobjectiveidParameter = new MySqlParameter("@QuestObjectiveID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_questobjectidParameter = new MySqlParameter("@QuestObjectID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_mapidParameter = new MySqlParameter("@MapID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_worldmapareaidParameter = new MySqlParameter("@WorldMapAreaId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_floorParameter = new MySqlParameter("@Floor", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_priorityParameter = new MySqlParameter("@Priority", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_flagsParameter = new MySqlParameter("@Flags", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_worldeffectidParameter = new MySqlParameter("@WorldEffectID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_playerconditionidParameter = new MySqlParameter("@PlayerConditionID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_wodunk1Parameter = new MySqlParameter("@WoDUnk1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			MySqlParameter questidParameter = new MySqlParameter("@newQuestID", MySqlDbType.VarChar, 0);
			MySqlParameter blobindexParameter = new MySqlParameter("@newBlobIndex", MySqlDbType.VarChar, 0);
			MySqlParameter idx1Parameter = new MySqlParameter("@newIdx1", MySqlDbType.VarChar, 0);
			MySqlParameter objectiveindexParameter = new MySqlParameter("@newObjectiveIndex", MySqlDbType.VarChar, 0);
			MySqlParameter questobjectiveidParameter = new MySqlParameter("@newQuestObjectiveID", MySqlDbType.VarChar, 0);
			MySqlParameter questobjectidParameter = new MySqlParameter("@newQuestObjectID", MySqlDbType.VarChar, 0);
			MySqlParameter mapidParameter = new MySqlParameter("@newMapID", MySqlDbType.VarChar, 0);
			MySqlParameter worldmapareaidParameter = new MySqlParameter("@newWorldMapAreaId", MySqlDbType.VarChar, 0);
			MySqlParameter floorParameter = new MySqlParameter("@newFloor", MySqlDbType.VarChar, 0);
			MySqlParameter priorityParameter = new MySqlParameter("@newPriority", MySqlDbType.VarChar, 0);
			MySqlParameter flagsParameter = new MySqlParameter("@newFlags", MySqlDbType.VarChar, 0);
			MySqlParameter worldeffectidParameter = new MySqlParameter("@newWorldEffectID", MySqlDbType.VarChar, 0);
			MySqlParameter playerconditionidParameter = new MySqlParameter("@newPlayerConditionID", MySqlDbType.VarChar, 0);
			MySqlParameter wodunk1Parameter = new MySqlParameter("@newWoDUnk1", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@newVerifiedBuild", MySqlDbType.VarChar, 0);
			questidParameter.Value = QuestID;
			blobindexParameter.Value = BlobIndex;
			idx1Parameter.Value = Idx1;
			objectiveindexParameter.Value = ObjectiveIndex;
			questobjectiveidParameter.Value = QuestObjectiveID;
			questobjectidParameter.Value = QuestObjectID;
			mapidParameter.Value = MapID;
			worldmapareaidParameter.Value = WorldMapAreaId;
			floorParameter.Value = Floor;
			priorityParameter.Value = Priority;
			flagsParameter.Value = Flags;
			worldeffectidParameter.Value = WorldEffectID;
			playerconditionidParameter.Value = PlayerConditionID;
			wodunk1Parameter.Value = WoDUnk1;
			verifiedbuildParameter.Value = VerifiedBuild;
			OLD_questidParameter.Value = OLD_QuestID;
			OLD_blobindexParameter.Value = OLD_BlobIndex;
			OLD_idx1Parameter.Value = OLD_Idx1;
			OLD_objectiveindexParameter.Value = OLD_ObjectiveIndex;
			OLD_questobjectiveidParameter.Value = OLD_QuestObjectiveID;
			OLD_questobjectidParameter.Value = OLD_QuestObjectID;
			OLD_mapidParameter.Value = OLD_MapID;
			OLD_worldmapareaidParameter.Value = OLD_WorldMapAreaId;
			OLD_floorParameter.Value = OLD_Floor;
			OLD_priorityParameter.Value = OLD_Priority;
			OLD_flagsParameter.Value = OLD_Flags;
			OLD_worldeffectidParameter.Value = OLD_WorldEffectID;
			OLD_playerconditionidParameter.Value = OLD_PlayerConditionID;
			OLD_wodunk1Parameter.Value = OLD_WoDUnk1;
			OLD_verifiedbuildParameter.Value = OLD_VerifiedBuild;
			cmd.Parameters.Add(questidParameter);
			cmd.Parameters.Add(blobindexParameter);
			cmd.Parameters.Add(idx1Parameter);
			cmd.Parameters.Add(objectiveindexParameter);
			cmd.Parameters.Add(questobjectiveidParameter);
			cmd.Parameters.Add(questobjectidParameter);
			cmd.Parameters.Add(mapidParameter);
			cmd.Parameters.Add(worldmapareaidParameter);
			cmd.Parameters.Add(floorParameter);
			cmd.Parameters.Add(priorityParameter);
			cmd.Parameters.Add(flagsParameter);
			cmd.Parameters.Add(worldeffectidParameter);
			cmd.Parameters.Add(playerconditionidParameter);
			cmd.Parameters.Add(wodunk1Parameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.Parameters.Add(OLD_questidParameter);
			cmd.Parameters.Add(OLD_blobindexParameter);
			cmd.Parameters.Add(OLD_idx1Parameter);
			cmd.Parameters.Add(OLD_objectiveindexParameter);
			cmd.Parameters.Add(OLD_questobjectiveidParameter);
			cmd.Parameters.Add(OLD_questobjectidParameter);
			cmd.Parameters.Add(OLD_mapidParameter);
			cmd.Parameters.Add(OLD_worldmapareaidParameter);
			cmd.Parameters.Add(OLD_floorParameter);
			cmd.Parameters.Add(OLD_priorityParameter);
			cmd.Parameters.Add(OLD_flagsParameter);
			cmd.Parameters.Add(OLD_worldeffectidParameter);
			cmd.Parameters.Add(OLD_playerconditionidParameter);
			cmd.Parameters.Add(OLD_wodunk1Parameter);
			cmd.Parameters.Add(OLD_verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_QuestID = QuestID;
			OLD_BlobIndex = BlobIndex;
			OLD_Idx1 = Idx1;
			OLD_ObjectiveIndex = ObjectiveIndex;
			OLD_QuestObjectiveID = QuestObjectiveID;
			OLD_QuestObjectID = QuestObjectID;
			OLD_MapID = MapID;
			OLD_WorldMapAreaId = WorldMapAreaId;
			OLD_Floor = Floor;
			OLD_Priority = Priority;
			OLD_Flags = Flags;
			OLD_WorldEffectID = WorldEffectID;
			OLD_PlayerConditionID = PlayerConditionID;
			OLD_WoDUnk1 = WoDUnk1;
			OLD_VerifiedBuild = VerifiedBuild;
		}
	}
}
