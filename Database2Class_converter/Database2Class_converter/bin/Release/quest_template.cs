using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Quest_template
	{
		int ID = 0; //Comment: 
		int OLD_ID = 0;

		int QuestType = 2; //Comment: 
		int OLD_QuestType = 2;

		int QuestLevel = -1; //Comment: 
		int OLD_QuestLevel = -1;

		int QuestPackageID = 0; //Comment: 
		int OLD_QuestPackageID = 0;

		int MinLevel = 0; //Comment: 
		int OLD_MinLevel = 0;

		int QuestSortID = 0; //Comment: 
		int OLD_QuestSortID = 0;

		int QuestInfoID = 0; //Comment: 
		int OLD_QuestInfoID = 0;

		int SuggestedGroupNum = 0; //Comment: 
		int OLD_SuggestedGroupNum = 0;

		int RewardNextQuest = 0; //Comment: 
		int OLD_RewardNextQuest = 0;

		int RewardXPDifficulty = 0; //Comment: 
		int OLD_RewardXPDifficulty = 0;

		float RewardXPMultiplier = 1f; //Comment: 
		float OLD_RewardXPMultiplier = 1f;

		int RewardMoney = 0; //Comment: 
		int OLD_RewardMoney = 0;

		int RewardMoneyDifficulty = 0; //Comment: 
		int OLD_RewardMoneyDifficulty = 0;

		float RewardMoneyMultiplier = 1f; //Comment: 
		float OLD_RewardMoneyMultiplier = 1f;

		int RewardBonusMoney = 0; //Comment: 
		int OLD_RewardBonusMoney = 0;

		int RewardDisplaySpell = 0; //Comment: 
		int OLD_RewardDisplaySpell = 0;

		int RewardSpell = 0; //Comment: 
		int OLD_RewardSpell = 0;

		int RewardHonor = 0; //Comment: 
		int OLD_RewardHonor = 0;

		int RewardKillHonor = 0; //Comment: 
		int OLD_RewardKillHonor = 0;

		int StartItem = 0; //Comment: 
		int OLD_StartItem = 0;

		int Flags = 0; //Comment: 
		int OLD_Flags = 0;

		int FlagsEx = 0; //Comment: 
		int OLD_FlagsEx = 0;

		int RewardItem1 = 0; //Comment: 
		int OLD_RewardItem1 = 0;

		int RewardAmount1 = 0; //Comment: 
		int OLD_RewardAmount1 = 0;

		int RewardItem2 = 0; //Comment: 
		int OLD_RewardItem2 = 0;

		int RewardAmount2 = 0; //Comment: 
		int OLD_RewardAmount2 = 0;

		int RewardItem3 = 0; //Comment: 
		int OLD_RewardItem3 = 0;

		int RewardAmount3 = 0; //Comment: 
		int OLD_RewardAmount3 = 0;

		int RewardItem4 = 0; //Comment: 
		int OLD_RewardItem4 = 0;

		int RewardAmount4 = 0; //Comment: 
		int OLD_RewardAmount4 = 0;

		int ItemDrop1 = 0; //Comment: 
		int OLD_ItemDrop1 = 0;

		int ItemDropQuantity1 = 0; //Comment: 
		int OLD_ItemDropQuantity1 = 0;

		int ItemDrop2 = 0; //Comment: 
		int OLD_ItemDrop2 = 0;

		int ItemDropQuantity2 = 0; //Comment: 
		int OLD_ItemDropQuantity2 = 0;

		int ItemDrop3 = 0; //Comment: 
		int OLD_ItemDrop3 = 0;

		int ItemDropQuantity3 = 0; //Comment: 
		int OLD_ItemDropQuantity3 = 0;

		int ItemDrop4 = 0; //Comment: 
		int OLD_ItemDrop4 = 0;

		int ItemDropQuantity4 = 0; //Comment: 
		int OLD_ItemDropQuantity4 = 0;

		int RewardChoiceItemID1 = 0; //Comment: 
		int OLD_RewardChoiceItemID1 = 0;

		int RewardChoiceItemQuantity1 = 0; //Comment: 
		int OLD_RewardChoiceItemQuantity1 = 0;

		int RewardChoiceItemDisplayID1 = 0; //Comment: 
		int OLD_RewardChoiceItemDisplayID1 = 0;

		int RewardChoiceItemID2 = 0; //Comment: 
		int OLD_RewardChoiceItemID2 = 0;

		int RewardChoiceItemQuantity2 = 0; //Comment: 
		int OLD_RewardChoiceItemQuantity2 = 0;

		int RewardChoiceItemDisplayID2 = 0; //Comment: 
		int OLD_RewardChoiceItemDisplayID2 = 0;

		int RewardChoiceItemID3 = 0; //Comment: 
		int OLD_RewardChoiceItemID3 = 0;

		int RewardChoiceItemQuantity3 = 0; //Comment: 
		int OLD_RewardChoiceItemQuantity3 = 0;

		int RewardChoiceItemDisplayID3 = 0; //Comment: 
		int OLD_RewardChoiceItemDisplayID3 = 0;

		int RewardChoiceItemID4 = 0; //Comment: 
		int OLD_RewardChoiceItemID4 = 0;

		int RewardChoiceItemQuantity4 = 0; //Comment: 
		int OLD_RewardChoiceItemQuantity4 = 0;

		int RewardChoiceItemDisplayID4 = 0; //Comment: 
		int OLD_RewardChoiceItemDisplayID4 = 0;

		int RewardChoiceItemID5 = 0; //Comment: 
		int OLD_RewardChoiceItemID5 = 0;

		int RewardChoiceItemQuantity5 = 0; //Comment: 
		int OLD_RewardChoiceItemQuantity5 = 0;

		int RewardChoiceItemDisplayID5 = 0; //Comment: 
		int OLD_RewardChoiceItemDisplayID5 = 0;

		int RewardChoiceItemID6 = 0; //Comment: 
		int OLD_RewardChoiceItemID6 = 0;

		int RewardChoiceItemQuantity6 = 0; //Comment: 
		int OLD_RewardChoiceItemQuantity6 = 0;

		int RewardChoiceItemDisplayID6 = 0; //Comment: 
		int OLD_RewardChoiceItemDisplayID6 = 0;

		int POIContinent = 0; //Comment: 
		int OLD_POIContinent = 0;

		float POIx = 0f; //Comment: 
		float OLD_POIx = 0f;

		float POIy = 0f; //Comment: 
		float OLD_POIy = 0f;

		int POIPriority = 0; //Comment: 
		int OLD_POIPriority = 0;

		int RewardTitle = 0; //Comment: 
		int OLD_RewardTitle = 0;

		int RewardTalents = 0; //Comment: 
		int OLD_RewardTalents = 0;

		int RewardArenaPoints = 0; //Comment: 
		int OLD_RewardArenaPoints = 0;

		int RewardSkillLineID = 0; //Comment: 
		int OLD_RewardSkillLineID = 0;

		int RewardNumSkillUps = 0; //Comment: 
		int OLD_RewardNumSkillUps = 0;

		int PortraitGiver = 0; //Comment: 
		int OLD_PortraitGiver = 0;

		int PortraitTurnIn = 0; //Comment: 
		int OLD_PortraitTurnIn = 0;

		int RewardFactionID1 = 0; //Comment: 
		int OLD_RewardFactionID1 = 0;

		int RewardFactionValue1 = 0; //Comment: 
		int OLD_RewardFactionValue1 = 0;

		int RewardFactionOverride1 = 0; //Comment: 
		int OLD_RewardFactionOverride1 = 0;

		int RewardFactionID2 = 0; //Comment: 
		int OLD_RewardFactionID2 = 0;

		int RewardFactionValue2 = 0; //Comment: 
		int OLD_RewardFactionValue2 = 0;

		int RewardFactionOverride2 = 0; //Comment: 
		int OLD_RewardFactionOverride2 = 0;

		int RewardFactionID3 = 0; //Comment: 
		int OLD_RewardFactionID3 = 0;

		int RewardFactionValue3 = 0; //Comment: 
		int OLD_RewardFactionValue3 = 0;

		int RewardFactionOverride3 = 0; //Comment: 
		int OLD_RewardFactionOverride3 = 0;

		int RewardFactionID4 = 0; //Comment: 
		int OLD_RewardFactionID4 = 0;

		int RewardFactionValue4 = 0; //Comment: 
		int OLD_RewardFactionValue4 = 0;

		int RewardFactionOverride4 = 0; //Comment: 
		int OLD_RewardFactionOverride4 = 0;

		int RewardFactionID5 = 0; //Comment: 
		int OLD_RewardFactionID5 = 0;

		int RewardFactionValue5 = 0; //Comment: 
		int OLD_RewardFactionValue5 = 0;

		int RewardFactionOverride5 = 0; //Comment: 
		int OLD_RewardFactionOverride5 = 0;

		int RewardFactionFlags = 0; //Comment: 
		int OLD_RewardFactionFlags = 0;

		int RewardCurrencyID1 = 0; //Comment: 
		int OLD_RewardCurrencyID1 = 0;

		int RewardCurrencyQty1 = 0; //Comment: 
		int OLD_RewardCurrencyQty1 = 0;

		int RewardCurrencyID2 = 0; //Comment: 
		int OLD_RewardCurrencyID2 = 0;

		int RewardCurrencyQty2 = 0; //Comment: 
		int OLD_RewardCurrencyQty2 = 0;

		int RewardCurrencyID3 = 0; //Comment: 
		int OLD_RewardCurrencyID3 = 0;

		int RewardCurrencyQty3 = 0; //Comment: 
		int OLD_RewardCurrencyQty3 = 0;

		int RewardCurrencyID4 = 0; //Comment: 
		int OLD_RewardCurrencyID4 = 0;

		int RewardCurrencyQty4 = 0; //Comment: 
		int OLD_RewardCurrencyQty4 = 0;

		int AcceptedSoundKitID = 0; //Comment: 
		int OLD_AcceptedSoundKitID = 0;

		int CompleteSoundKitID = 0; //Comment: 
		int OLD_CompleteSoundKitID = 0;

		int AreaGroupID = 0; //Comment: 
		int OLD_AreaGroupID = 0;

		int TimeAllowed = 0; //Comment: 
		int OLD_TimeAllowed = 0;

		int AllowableRaces = -1; //Comment: 
		int OLD_AllowableRaces = -1;

		string LogTitle = null; //Comment: 
		string OLD_LogTitle = null;

		string LogDescription = null; //Comment: 
		string OLD_LogDescription = null;

		string QuestDescription = null; //Comment: 
		string OLD_QuestDescription = null;

		string AreaDescription = null; //Comment: 
		string OLD_AreaDescription = null;

		string PortraitGiverText = null; //Comment: 
		string OLD_PortraitGiverText = null;

		string PortraitGiverName = null; //Comment: 
		string OLD_PortraitGiverName = null;

		string PortraitTurnInText = null; //Comment: 
		string OLD_PortraitTurnInText = null;

		string PortraitTurnInName = null; //Comment: 
		string OLD_PortraitTurnInName = null;

		string QuestCompletionLog = null; //Comment: 
		string OLD_QuestCompletionLog = null;

		int VerifiedBuild = 0; //Comment: 
		int OLD_VerifiedBuild = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Quest_template(int _ID, int _QuestType, int _QuestLevel, int _QuestPackageID, int _MinLevel, int _QuestSortID, int _QuestInfoID, int _SuggestedGroupNum, int _RewardNextQuest, int _RewardXPDifficulty, float _RewardXPMultiplier, int _RewardMoney, int _RewardMoneyDifficulty, float _RewardMoneyMultiplier, int _RewardBonusMoney, int _RewardDisplaySpell, int _RewardSpell, int _RewardHonor, int _RewardKillHonor, int _StartItem, int _Flags, int _FlagsEx, int _RewardItem1, int _RewardAmount1, int _RewardItem2, int _RewardAmount2, int _RewardItem3, int _RewardAmount3, int _RewardItem4, int _RewardAmount4, int _ItemDrop1, int _ItemDropQuantity1, int _ItemDrop2, int _ItemDropQuantity2, int _ItemDrop3, int _ItemDropQuantity3, int _ItemDrop4, int _ItemDropQuantity4, int _RewardChoiceItemID1, int _RewardChoiceItemQuantity1, int _RewardChoiceItemDisplayID1, int _RewardChoiceItemID2, int _RewardChoiceItemQuantity2, int _RewardChoiceItemDisplayID2, int _RewardChoiceItemID3, int _RewardChoiceItemQuantity3, int _RewardChoiceItemDisplayID3, int _RewardChoiceItemID4, int _RewardChoiceItemQuantity4, int _RewardChoiceItemDisplayID4, int _RewardChoiceItemID5, int _RewardChoiceItemQuantity5, int _RewardChoiceItemDisplayID5, int _RewardChoiceItemID6, int _RewardChoiceItemQuantity6, int _RewardChoiceItemDisplayID6, int _POIContinent, float _POIx, float _POIy, int _POIPriority, int _RewardTitle, int _RewardTalents, int _RewardArenaPoints, int _RewardSkillLineID, int _RewardNumSkillUps, int _PortraitGiver, int _PortraitTurnIn, int _RewardFactionID1, int _RewardFactionValue1, int _RewardFactionOverride1, int _RewardFactionID2, int _RewardFactionValue2, int _RewardFactionOverride2, int _RewardFactionID3, int _RewardFactionValue3, int _RewardFactionOverride3, int _RewardFactionID4, int _RewardFactionValue4, int _RewardFactionOverride4, int _RewardFactionID5, int _RewardFactionValue5, int _RewardFactionOverride5, int _RewardFactionFlags, int _RewardCurrencyID1, int _RewardCurrencyQty1, int _RewardCurrencyID2, int _RewardCurrencyQty2, int _RewardCurrencyID3, int _RewardCurrencyQty3, int _RewardCurrencyID4, int _RewardCurrencyQty4, int _AcceptedSoundKitID, int _CompleteSoundKitID, int _AreaGroupID, int _TimeAllowed, int _AllowableRaces, string _LogTitle, string _LogDescription, string _QuestDescription, string _AreaDescription, string _PortraitGiverText, string _PortraitGiverName, string _PortraitTurnInText, string _PortraitTurnInName, string _QuestCompletionLog, int _VerifiedBuild)
		{
			ID = _ID;
			QuestType = _QuestType;
			QuestLevel = _QuestLevel;
			QuestPackageID = _QuestPackageID;
			MinLevel = _MinLevel;
			QuestSortID = _QuestSortID;
			QuestInfoID = _QuestInfoID;
			SuggestedGroupNum = _SuggestedGroupNum;
			RewardNextQuest = _RewardNextQuest;
			RewardXPDifficulty = _RewardXPDifficulty;
			RewardXPMultiplier = _RewardXPMultiplier;
			RewardMoney = _RewardMoney;
			RewardMoneyDifficulty = _RewardMoneyDifficulty;
			RewardMoneyMultiplier = _RewardMoneyMultiplier;
			RewardBonusMoney = _RewardBonusMoney;
			RewardDisplaySpell = _RewardDisplaySpell;
			RewardSpell = _RewardSpell;
			RewardHonor = _RewardHonor;
			RewardKillHonor = _RewardKillHonor;
			StartItem = _StartItem;
			Flags = _Flags;
			FlagsEx = _FlagsEx;
			RewardItem1 = _RewardItem1;
			RewardAmount1 = _RewardAmount1;
			RewardItem2 = _RewardItem2;
			RewardAmount2 = _RewardAmount2;
			RewardItem3 = _RewardItem3;
			RewardAmount3 = _RewardAmount3;
			RewardItem4 = _RewardItem4;
			RewardAmount4 = _RewardAmount4;
			ItemDrop1 = _ItemDrop1;
			ItemDropQuantity1 = _ItemDropQuantity1;
			ItemDrop2 = _ItemDrop2;
			ItemDropQuantity2 = _ItemDropQuantity2;
			ItemDrop3 = _ItemDrop3;
			ItemDropQuantity3 = _ItemDropQuantity3;
			ItemDrop4 = _ItemDrop4;
			ItemDropQuantity4 = _ItemDropQuantity4;
			RewardChoiceItemID1 = _RewardChoiceItemID1;
			RewardChoiceItemQuantity1 = _RewardChoiceItemQuantity1;
			RewardChoiceItemDisplayID1 = _RewardChoiceItemDisplayID1;
			RewardChoiceItemID2 = _RewardChoiceItemID2;
			RewardChoiceItemQuantity2 = _RewardChoiceItemQuantity2;
			RewardChoiceItemDisplayID2 = _RewardChoiceItemDisplayID2;
			RewardChoiceItemID3 = _RewardChoiceItemID3;
			RewardChoiceItemQuantity3 = _RewardChoiceItemQuantity3;
			RewardChoiceItemDisplayID3 = _RewardChoiceItemDisplayID3;
			RewardChoiceItemID4 = _RewardChoiceItemID4;
			RewardChoiceItemQuantity4 = _RewardChoiceItemQuantity4;
			RewardChoiceItemDisplayID4 = _RewardChoiceItemDisplayID4;
			RewardChoiceItemID5 = _RewardChoiceItemID5;
			RewardChoiceItemQuantity5 = _RewardChoiceItemQuantity5;
			RewardChoiceItemDisplayID5 = _RewardChoiceItemDisplayID5;
			RewardChoiceItemID6 = _RewardChoiceItemID6;
			RewardChoiceItemQuantity6 = _RewardChoiceItemQuantity6;
			RewardChoiceItemDisplayID6 = _RewardChoiceItemDisplayID6;
			POIContinent = _POIContinent;
			POIx = _POIx;
			POIy = _POIy;
			POIPriority = _POIPriority;
			RewardTitle = _RewardTitle;
			RewardTalents = _RewardTalents;
			RewardArenaPoints = _RewardArenaPoints;
			RewardSkillLineID = _RewardSkillLineID;
			RewardNumSkillUps = _RewardNumSkillUps;
			PortraitGiver = _PortraitGiver;
			PortraitTurnIn = _PortraitTurnIn;
			RewardFactionID1 = _RewardFactionID1;
			RewardFactionValue1 = _RewardFactionValue1;
			RewardFactionOverride1 = _RewardFactionOverride1;
			RewardFactionID2 = _RewardFactionID2;
			RewardFactionValue2 = _RewardFactionValue2;
			RewardFactionOverride2 = _RewardFactionOverride2;
			RewardFactionID3 = _RewardFactionID3;
			RewardFactionValue3 = _RewardFactionValue3;
			RewardFactionOverride3 = _RewardFactionOverride3;
			RewardFactionID4 = _RewardFactionID4;
			RewardFactionValue4 = _RewardFactionValue4;
			RewardFactionOverride4 = _RewardFactionOverride4;
			RewardFactionID5 = _RewardFactionID5;
			RewardFactionValue5 = _RewardFactionValue5;
			RewardFactionOverride5 = _RewardFactionOverride5;
			RewardFactionFlags = _RewardFactionFlags;
			RewardCurrencyID1 = _RewardCurrencyID1;
			RewardCurrencyQty1 = _RewardCurrencyQty1;
			RewardCurrencyID2 = _RewardCurrencyID2;
			RewardCurrencyQty2 = _RewardCurrencyQty2;
			RewardCurrencyID3 = _RewardCurrencyID3;
			RewardCurrencyQty3 = _RewardCurrencyQty3;
			RewardCurrencyID4 = _RewardCurrencyID4;
			RewardCurrencyQty4 = _RewardCurrencyQty4;
			AcceptedSoundKitID = _AcceptedSoundKitID;
			CompleteSoundKitID = _CompleteSoundKitID;
			AreaGroupID = _AreaGroupID;
			TimeAllowed = _TimeAllowed;
			AllowableRaces = _AllowableRaces;
			LogTitle = _LogTitle;
			LogDescription = _LogDescription;
			QuestDescription = _QuestDescription;
			AreaDescription = _AreaDescription;
			PortraitGiverText = _PortraitGiverText;
			PortraitGiverName = _PortraitGiverName;
			PortraitTurnInText = _PortraitTurnInText;
			PortraitTurnInName = _PortraitTurnInName;
			QuestCompletionLog = _QuestCompletionLog;
			VerifiedBuild = _VerifiedBuild;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM quest_template WHERE ID = @ID AND QuestType = @QuestType AND QuestLevel = @QuestLevel AND QuestPackageID = @QuestPackageID AND MinLevel = @MinLevel AND QuestSortID = @QuestSortID AND QuestInfoID = @QuestInfoID AND SuggestedGroupNum = @SuggestedGroupNum AND RewardNextQuest = @RewardNextQuest AND RewardXPDifficulty = @RewardXPDifficulty AND RewardXPMultiplier = @RewardXPMultiplier AND RewardMoney = @RewardMoney AND RewardMoneyDifficulty = @RewardMoneyDifficulty AND RewardMoneyMultiplier = @RewardMoneyMultiplier AND RewardBonusMoney = @RewardBonusMoney AND RewardDisplaySpell = @RewardDisplaySpell AND RewardSpell = @RewardSpell AND RewardHonor = @RewardHonor AND RewardKillHonor = @RewardKillHonor AND StartItem = @StartItem AND Flags = @Flags AND FlagsEx = @FlagsEx AND RewardItem1 = @RewardItem1 AND RewardAmount1 = @RewardAmount1 AND RewardItem2 = @RewardItem2 AND RewardAmount2 = @RewardAmount2 AND RewardItem3 = @RewardItem3 AND RewardAmount3 = @RewardAmount3 AND RewardItem4 = @RewardItem4 AND RewardAmount4 = @RewardAmount4 AND ItemDrop1 = @ItemDrop1 AND ItemDropQuantity1 = @ItemDropQuantity1 AND ItemDrop2 = @ItemDrop2 AND ItemDropQuantity2 = @ItemDropQuantity2 AND ItemDrop3 = @ItemDrop3 AND ItemDropQuantity3 = @ItemDropQuantity3 AND ItemDrop4 = @ItemDrop4 AND ItemDropQuantity4 = @ItemDropQuantity4 AND RewardChoiceItemID1 = @RewardChoiceItemID1 AND RewardChoiceItemQuantity1 = @RewardChoiceItemQuantity1 AND RewardChoiceItemDisplayID1 = @RewardChoiceItemDisplayID1 AND RewardChoiceItemID2 = @RewardChoiceItemID2 AND RewardChoiceItemQuantity2 = @RewardChoiceItemQuantity2 AND RewardChoiceItemDisplayID2 = @RewardChoiceItemDisplayID2 AND RewardChoiceItemID3 = @RewardChoiceItemID3 AND RewardChoiceItemQuantity3 = @RewardChoiceItemQuantity3 AND RewardChoiceItemDisplayID3 = @RewardChoiceItemDisplayID3 AND RewardChoiceItemID4 = @RewardChoiceItemID4 AND RewardChoiceItemQuantity4 = @RewardChoiceItemQuantity4 AND RewardChoiceItemDisplayID4 = @RewardChoiceItemDisplayID4 AND RewardChoiceItemID5 = @RewardChoiceItemID5 AND RewardChoiceItemQuantity5 = @RewardChoiceItemQuantity5 AND RewardChoiceItemDisplayID5 = @RewardChoiceItemDisplayID5 AND RewardChoiceItemID6 = @RewardChoiceItemID6 AND RewardChoiceItemQuantity6 = @RewardChoiceItemQuantity6 AND RewardChoiceItemDisplayID6 = @RewardChoiceItemDisplayID6 AND POIContinent = @POIContinent AND POIx = @POIx AND POIy = @POIy AND POIPriority = @POIPriority AND RewardTitle = @RewardTitle AND RewardTalents = @RewardTalents AND RewardArenaPoints = @RewardArenaPoints AND RewardSkillLineID = @RewardSkillLineID AND RewardNumSkillUps = @RewardNumSkillUps AND PortraitGiver = @PortraitGiver AND PortraitTurnIn = @PortraitTurnIn AND RewardFactionID1 = @RewardFactionID1 AND RewardFactionValue1 = @RewardFactionValue1 AND RewardFactionOverride1 = @RewardFactionOverride1 AND RewardFactionID2 = @RewardFactionID2 AND RewardFactionValue2 = @RewardFactionValue2 AND RewardFactionOverride2 = @RewardFactionOverride2 AND RewardFactionID3 = @RewardFactionID3 AND RewardFactionValue3 = @RewardFactionValue3 AND RewardFactionOverride3 = @RewardFactionOverride3 AND RewardFactionID4 = @RewardFactionID4 AND RewardFactionValue4 = @RewardFactionValue4 AND RewardFactionOverride4 = @RewardFactionOverride4 AND RewardFactionID5 = @RewardFactionID5 AND RewardFactionValue5 = @RewardFactionValue5 AND RewardFactionOverride5 = @RewardFactionOverride5 AND RewardFactionFlags = @RewardFactionFlags AND RewardCurrencyID1 = @RewardCurrencyID1 AND RewardCurrencyQty1 = @RewardCurrencyQty1 AND RewardCurrencyID2 = @RewardCurrencyID2 AND RewardCurrencyQty2 = @RewardCurrencyQty2 AND RewardCurrencyID3 = @RewardCurrencyID3 AND RewardCurrencyQty3 = @RewardCurrencyQty3 AND RewardCurrencyID4 = @RewardCurrencyID4 AND RewardCurrencyQty4 = @RewardCurrencyQty4 AND AcceptedSoundKitID = @AcceptedSoundKitID AND CompleteSoundKitID = @CompleteSoundKitID AND AreaGroupID = @AreaGroupID AND TimeAllowed = @TimeAllowed AND AllowableRaces = @AllowableRaces AND LogTitle = @LogTitle AND LogDescription = @LogDescription AND QuestDescription = @QuestDescription AND AreaDescription = @AreaDescription AND PortraitGiverText = @PortraitGiverText AND PortraitGiverName = @PortraitGiverName AND PortraitTurnInText = @PortraitTurnInText AND PortraitTurnInName = @PortraitTurnInName AND QuestCompletionLog = @QuestCompletionLog AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter questtypeParameter = new MySqlParameter("@QuestType", MySqlDbType.VarChar, 0);
			MySqlParameter questlevelParameter = new MySqlParameter("@QuestLevel", MySqlDbType.VarChar, 0);
			MySqlParameter questpackageidParameter = new MySqlParameter("@QuestPackageID", MySqlDbType.VarChar, 0);
			MySqlParameter minlevelParameter = new MySqlParameter("@MinLevel", MySqlDbType.VarChar, 0);
			MySqlParameter questsortidParameter = new MySqlParameter("@QuestSortID", MySqlDbType.VarChar, 0);
			MySqlParameter questinfoidParameter = new MySqlParameter("@QuestInfoID", MySqlDbType.VarChar, 0);
			MySqlParameter suggestedgroupnumParameter = new MySqlParameter("@SuggestedGroupNum", MySqlDbType.VarChar, 0);
			MySqlParameter rewardnextquestParameter = new MySqlParameter("@RewardNextQuest", MySqlDbType.VarChar, 0);
			MySqlParameter rewardxpdifficultyParameter = new MySqlParameter("@RewardXPDifficulty", MySqlDbType.VarChar, 0);
			MySqlParameter rewardxpmultiplierParameter = new MySqlParameter("@RewardXPMultiplier", MySqlDbType.VarChar, 0);
			MySqlParameter rewardmoneyParameter = new MySqlParameter("@RewardMoney", MySqlDbType.VarChar, 0);
			MySqlParameter rewardmoneydifficultyParameter = new MySqlParameter("@RewardMoneyDifficulty", MySqlDbType.VarChar, 0);
			MySqlParameter rewardmoneymultiplierParameter = new MySqlParameter("@RewardMoneyMultiplier", MySqlDbType.VarChar, 0);
			MySqlParameter rewardbonusmoneyParameter = new MySqlParameter("@RewardBonusMoney", MySqlDbType.VarChar, 0);
			MySqlParameter rewarddisplayspellParameter = new MySqlParameter("@RewardDisplaySpell", MySqlDbType.VarChar, 0);
			MySqlParameter rewardspellParameter = new MySqlParameter("@RewardSpell", MySqlDbType.VarChar, 0);
			MySqlParameter rewardhonorParameter = new MySqlParameter("@RewardHonor", MySqlDbType.VarChar, 0);
			MySqlParameter rewardkillhonorParameter = new MySqlParameter("@RewardKillHonor", MySqlDbType.VarChar, 0);
			MySqlParameter startitemParameter = new MySqlParameter("@StartItem", MySqlDbType.VarChar, 0);
			MySqlParameter flagsParameter = new MySqlParameter("@Flags", MySqlDbType.VarChar, 0);
			MySqlParameter flagsexParameter = new MySqlParameter("@FlagsEx", MySqlDbType.VarChar, 0);
			MySqlParameter rewarditem1Parameter = new MySqlParameter("@RewardItem1", MySqlDbType.VarChar, 0);
			MySqlParameter rewardamount1Parameter = new MySqlParameter("@RewardAmount1", MySqlDbType.VarChar, 0);
			MySqlParameter rewarditem2Parameter = new MySqlParameter("@RewardItem2", MySqlDbType.VarChar, 0);
			MySqlParameter rewardamount2Parameter = new MySqlParameter("@RewardAmount2", MySqlDbType.VarChar, 0);
			MySqlParameter rewarditem3Parameter = new MySqlParameter("@RewardItem3", MySqlDbType.VarChar, 0);
			MySqlParameter rewardamount3Parameter = new MySqlParameter("@RewardAmount3", MySqlDbType.VarChar, 0);
			MySqlParameter rewarditem4Parameter = new MySqlParameter("@RewardItem4", MySqlDbType.VarChar, 0);
			MySqlParameter rewardamount4Parameter = new MySqlParameter("@RewardAmount4", MySqlDbType.VarChar, 0);
			MySqlParameter itemdrop1Parameter = new MySqlParameter("@ItemDrop1", MySqlDbType.VarChar, 0);
			MySqlParameter itemdropquantity1Parameter = new MySqlParameter("@ItemDropQuantity1", MySqlDbType.VarChar, 0);
			MySqlParameter itemdrop2Parameter = new MySqlParameter("@ItemDrop2", MySqlDbType.VarChar, 0);
			MySqlParameter itemdropquantity2Parameter = new MySqlParameter("@ItemDropQuantity2", MySqlDbType.VarChar, 0);
			MySqlParameter itemdrop3Parameter = new MySqlParameter("@ItemDrop3", MySqlDbType.VarChar, 0);
			MySqlParameter itemdropquantity3Parameter = new MySqlParameter("@ItemDropQuantity3", MySqlDbType.VarChar, 0);
			MySqlParameter itemdrop4Parameter = new MySqlParameter("@ItemDrop4", MySqlDbType.VarChar, 0);
			MySqlParameter itemdropquantity4Parameter = new MySqlParameter("@ItemDropQuantity4", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemid1Parameter = new MySqlParameter("@RewardChoiceItemID1", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemquantity1Parameter = new MySqlParameter("@RewardChoiceItemQuantity1", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemdisplayid1Parameter = new MySqlParameter("@RewardChoiceItemDisplayID1", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemid2Parameter = new MySqlParameter("@RewardChoiceItemID2", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemquantity2Parameter = new MySqlParameter("@RewardChoiceItemQuantity2", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemdisplayid2Parameter = new MySqlParameter("@RewardChoiceItemDisplayID2", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemid3Parameter = new MySqlParameter("@RewardChoiceItemID3", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemquantity3Parameter = new MySqlParameter("@RewardChoiceItemQuantity3", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemdisplayid3Parameter = new MySqlParameter("@RewardChoiceItemDisplayID3", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemid4Parameter = new MySqlParameter("@RewardChoiceItemID4", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemquantity4Parameter = new MySqlParameter("@RewardChoiceItemQuantity4", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemdisplayid4Parameter = new MySqlParameter("@RewardChoiceItemDisplayID4", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemid5Parameter = new MySqlParameter("@RewardChoiceItemID5", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemquantity5Parameter = new MySqlParameter("@RewardChoiceItemQuantity5", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemdisplayid5Parameter = new MySqlParameter("@RewardChoiceItemDisplayID5", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemid6Parameter = new MySqlParameter("@RewardChoiceItemID6", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemquantity6Parameter = new MySqlParameter("@RewardChoiceItemQuantity6", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemdisplayid6Parameter = new MySqlParameter("@RewardChoiceItemDisplayID6", MySqlDbType.VarChar, 0);
			MySqlParameter poicontinentParameter = new MySqlParameter("@POIContinent", MySqlDbType.VarChar, 0);
			MySqlParameter poixParameter = new MySqlParameter("@POIx", MySqlDbType.VarChar, 0);
			MySqlParameter poiyParameter = new MySqlParameter("@POIy", MySqlDbType.VarChar, 0);
			MySqlParameter poipriorityParameter = new MySqlParameter("@POIPriority", MySqlDbType.VarChar, 0);
			MySqlParameter rewardtitleParameter = new MySqlParameter("@RewardTitle", MySqlDbType.VarChar, 0);
			MySqlParameter rewardtalentsParameter = new MySqlParameter("@RewardTalents", MySqlDbType.VarChar, 0);
			MySqlParameter rewardarenapointsParameter = new MySqlParameter("@RewardArenaPoints", MySqlDbType.VarChar, 0);
			MySqlParameter rewardskilllineidParameter = new MySqlParameter("@RewardSkillLineID", MySqlDbType.VarChar, 0);
			MySqlParameter rewardnumskillupsParameter = new MySqlParameter("@RewardNumSkillUps", MySqlDbType.VarChar, 0);
			MySqlParameter portraitgiverParameter = new MySqlParameter("@PortraitGiver", MySqlDbType.VarChar, 0);
			MySqlParameter portraitturninParameter = new MySqlParameter("@PortraitTurnIn", MySqlDbType.VarChar, 0);
			MySqlParameter rewardfactionid1Parameter = new MySqlParameter("@RewardFactionID1", MySqlDbType.VarChar, 0);
			MySqlParameter rewardfactionvalue1Parameter = new MySqlParameter("@RewardFactionValue1", MySqlDbType.VarChar, 0);
			MySqlParameter rewardfactionoverride1Parameter = new MySqlParameter("@RewardFactionOverride1", MySqlDbType.VarChar, 0);
			MySqlParameter rewardfactionid2Parameter = new MySqlParameter("@RewardFactionID2", MySqlDbType.VarChar, 0);
			MySqlParameter rewardfactionvalue2Parameter = new MySqlParameter("@RewardFactionValue2", MySqlDbType.VarChar, 0);
			MySqlParameter rewardfactionoverride2Parameter = new MySqlParameter("@RewardFactionOverride2", MySqlDbType.VarChar, 0);
			MySqlParameter rewardfactionid3Parameter = new MySqlParameter("@RewardFactionID3", MySqlDbType.VarChar, 0);
			MySqlParameter rewardfactionvalue3Parameter = new MySqlParameter("@RewardFactionValue3", MySqlDbType.VarChar, 0);
			MySqlParameter rewardfactionoverride3Parameter = new MySqlParameter("@RewardFactionOverride3", MySqlDbType.VarChar, 0);
			MySqlParameter rewardfactionid4Parameter = new MySqlParameter("@RewardFactionID4", MySqlDbType.VarChar, 0);
			MySqlParameter rewardfactionvalue4Parameter = new MySqlParameter("@RewardFactionValue4", MySqlDbType.VarChar, 0);
			MySqlParameter rewardfactionoverride4Parameter = new MySqlParameter("@RewardFactionOverride4", MySqlDbType.VarChar, 0);
			MySqlParameter rewardfactionid5Parameter = new MySqlParameter("@RewardFactionID5", MySqlDbType.VarChar, 0);
			MySqlParameter rewardfactionvalue5Parameter = new MySqlParameter("@RewardFactionValue5", MySqlDbType.VarChar, 0);
			MySqlParameter rewardfactionoverride5Parameter = new MySqlParameter("@RewardFactionOverride5", MySqlDbType.VarChar, 0);
			MySqlParameter rewardfactionflagsParameter = new MySqlParameter("@RewardFactionFlags", MySqlDbType.VarChar, 0);
			MySqlParameter rewardcurrencyid1Parameter = new MySqlParameter("@RewardCurrencyID1", MySqlDbType.VarChar, 0);
			MySqlParameter rewardcurrencyqty1Parameter = new MySqlParameter("@RewardCurrencyQty1", MySqlDbType.VarChar, 0);
			MySqlParameter rewardcurrencyid2Parameter = new MySqlParameter("@RewardCurrencyID2", MySqlDbType.VarChar, 0);
			MySqlParameter rewardcurrencyqty2Parameter = new MySqlParameter("@RewardCurrencyQty2", MySqlDbType.VarChar, 0);
			MySqlParameter rewardcurrencyid3Parameter = new MySqlParameter("@RewardCurrencyID3", MySqlDbType.VarChar, 0);
			MySqlParameter rewardcurrencyqty3Parameter = new MySqlParameter("@RewardCurrencyQty3", MySqlDbType.VarChar, 0);
			MySqlParameter rewardcurrencyid4Parameter = new MySqlParameter("@RewardCurrencyID4", MySqlDbType.VarChar, 0);
			MySqlParameter rewardcurrencyqty4Parameter = new MySqlParameter("@RewardCurrencyQty4", MySqlDbType.VarChar, 0);
			MySqlParameter acceptedsoundkitidParameter = new MySqlParameter("@AcceptedSoundKitID", MySqlDbType.VarChar, 0);
			MySqlParameter completesoundkitidParameter = new MySqlParameter("@CompleteSoundKitID", MySqlDbType.VarChar, 0);
			MySqlParameter areagroupidParameter = new MySqlParameter("@AreaGroupID", MySqlDbType.VarChar, 0);
			MySqlParameter timeallowedParameter = new MySqlParameter("@TimeAllowed", MySqlDbType.VarChar, 0);
			MySqlParameter allowableracesParameter = new MySqlParameter("@AllowableRaces", MySqlDbType.VarChar, 0);
			MySqlParameter logtitleParameter = new MySqlParameter("@LogTitle", MySqlDbType.VarChar, 0);
			MySqlParameter logdescriptionParameter = new MySqlParameter("@LogDescription", MySqlDbType.VarChar, 0);
			MySqlParameter questdescriptionParameter = new MySqlParameter("@QuestDescription", MySqlDbType.VarChar, 0);
			MySqlParameter areadescriptionParameter = new MySqlParameter("@AreaDescription", MySqlDbType.VarChar, 0);
			MySqlParameter portraitgivertextParameter = new MySqlParameter("@PortraitGiverText", MySqlDbType.VarChar, 0);
			MySqlParameter portraitgivernameParameter = new MySqlParameter("@PortraitGiverName", MySqlDbType.VarChar, 0);
			MySqlParameter portraitturnintextParameter = new MySqlParameter("@PortraitTurnInText", MySqlDbType.VarChar, 0);
			MySqlParameter portraitturninnameParameter = new MySqlParameter("@PortraitTurnInName", MySqlDbType.VarChar, 0);
			MySqlParameter questcompletionlogParameter = new MySqlParameter("@QuestCompletionLog", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			questtypeParameter.Value = QuestType;
			questlevelParameter.Value = QuestLevel;
			questpackageidParameter.Value = QuestPackageID;
			minlevelParameter.Value = MinLevel;
			questsortidParameter.Value = QuestSortID;
			questinfoidParameter.Value = QuestInfoID;
			suggestedgroupnumParameter.Value = SuggestedGroupNum;
			rewardnextquestParameter.Value = RewardNextQuest;
			rewardxpdifficultyParameter.Value = RewardXPDifficulty;
			rewardxpmultiplierParameter.Value = RewardXPMultiplier;
			rewardmoneyParameter.Value = RewardMoney;
			rewardmoneydifficultyParameter.Value = RewardMoneyDifficulty;
			rewardmoneymultiplierParameter.Value = RewardMoneyMultiplier;
			rewardbonusmoneyParameter.Value = RewardBonusMoney;
			rewarddisplayspellParameter.Value = RewardDisplaySpell;
			rewardspellParameter.Value = RewardSpell;
			rewardhonorParameter.Value = RewardHonor;
			rewardkillhonorParameter.Value = RewardKillHonor;
			startitemParameter.Value = StartItem;
			flagsParameter.Value = Flags;
			flagsexParameter.Value = FlagsEx;
			rewarditem1Parameter.Value = RewardItem1;
			rewardamount1Parameter.Value = RewardAmount1;
			rewarditem2Parameter.Value = RewardItem2;
			rewardamount2Parameter.Value = RewardAmount2;
			rewarditem3Parameter.Value = RewardItem3;
			rewardamount3Parameter.Value = RewardAmount3;
			rewarditem4Parameter.Value = RewardItem4;
			rewardamount4Parameter.Value = RewardAmount4;
			itemdrop1Parameter.Value = ItemDrop1;
			itemdropquantity1Parameter.Value = ItemDropQuantity1;
			itemdrop2Parameter.Value = ItemDrop2;
			itemdropquantity2Parameter.Value = ItemDropQuantity2;
			itemdrop3Parameter.Value = ItemDrop3;
			itemdropquantity3Parameter.Value = ItemDropQuantity3;
			itemdrop4Parameter.Value = ItemDrop4;
			itemdropquantity4Parameter.Value = ItemDropQuantity4;
			rewardchoiceitemid1Parameter.Value = RewardChoiceItemID1;
			rewardchoiceitemquantity1Parameter.Value = RewardChoiceItemQuantity1;
			rewardchoiceitemdisplayid1Parameter.Value = RewardChoiceItemDisplayID1;
			rewardchoiceitemid2Parameter.Value = RewardChoiceItemID2;
			rewardchoiceitemquantity2Parameter.Value = RewardChoiceItemQuantity2;
			rewardchoiceitemdisplayid2Parameter.Value = RewardChoiceItemDisplayID2;
			rewardchoiceitemid3Parameter.Value = RewardChoiceItemID3;
			rewardchoiceitemquantity3Parameter.Value = RewardChoiceItemQuantity3;
			rewardchoiceitemdisplayid3Parameter.Value = RewardChoiceItemDisplayID3;
			rewardchoiceitemid4Parameter.Value = RewardChoiceItemID4;
			rewardchoiceitemquantity4Parameter.Value = RewardChoiceItemQuantity4;
			rewardchoiceitemdisplayid4Parameter.Value = RewardChoiceItemDisplayID4;
			rewardchoiceitemid5Parameter.Value = RewardChoiceItemID5;
			rewardchoiceitemquantity5Parameter.Value = RewardChoiceItemQuantity5;
			rewardchoiceitemdisplayid5Parameter.Value = RewardChoiceItemDisplayID5;
			rewardchoiceitemid6Parameter.Value = RewardChoiceItemID6;
			rewardchoiceitemquantity6Parameter.Value = RewardChoiceItemQuantity6;
			rewardchoiceitemdisplayid6Parameter.Value = RewardChoiceItemDisplayID6;
			poicontinentParameter.Value = POIContinent;
			poixParameter.Value = POIx;
			poiyParameter.Value = POIy;
			poipriorityParameter.Value = POIPriority;
			rewardtitleParameter.Value = RewardTitle;
			rewardtalentsParameter.Value = RewardTalents;
			rewardarenapointsParameter.Value = RewardArenaPoints;
			rewardskilllineidParameter.Value = RewardSkillLineID;
			rewardnumskillupsParameter.Value = RewardNumSkillUps;
			portraitgiverParameter.Value = PortraitGiver;
			portraitturninParameter.Value = PortraitTurnIn;
			rewardfactionid1Parameter.Value = RewardFactionID1;
			rewardfactionvalue1Parameter.Value = RewardFactionValue1;
			rewardfactionoverride1Parameter.Value = RewardFactionOverride1;
			rewardfactionid2Parameter.Value = RewardFactionID2;
			rewardfactionvalue2Parameter.Value = RewardFactionValue2;
			rewardfactionoverride2Parameter.Value = RewardFactionOverride2;
			rewardfactionid3Parameter.Value = RewardFactionID3;
			rewardfactionvalue3Parameter.Value = RewardFactionValue3;
			rewardfactionoverride3Parameter.Value = RewardFactionOverride3;
			rewardfactionid4Parameter.Value = RewardFactionID4;
			rewardfactionvalue4Parameter.Value = RewardFactionValue4;
			rewardfactionoverride4Parameter.Value = RewardFactionOverride4;
			rewardfactionid5Parameter.Value = RewardFactionID5;
			rewardfactionvalue5Parameter.Value = RewardFactionValue5;
			rewardfactionoverride5Parameter.Value = RewardFactionOverride5;
			rewardfactionflagsParameter.Value = RewardFactionFlags;
			rewardcurrencyid1Parameter.Value = RewardCurrencyID1;
			rewardcurrencyqty1Parameter.Value = RewardCurrencyQty1;
			rewardcurrencyid2Parameter.Value = RewardCurrencyID2;
			rewardcurrencyqty2Parameter.Value = RewardCurrencyQty2;
			rewardcurrencyid3Parameter.Value = RewardCurrencyID3;
			rewardcurrencyqty3Parameter.Value = RewardCurrencyQty3;
			rewardcurrencyid4Parameter.Value = RewardCurrencyID4;
			rewardcurrencyqty4Parameter.Value = RewardCurrencyQty4;
			acceptedsoundkitidParameter.Value = AcceptedSoundKitID;
			completesoundkitidParameter.Value = CompleteSoundKitID;
			areagroupidParameter.Value = AreaGroupID;
			timeallowedParameter.Value = TimeAllowed;
			allowableracesParameter.Value = AllowableRaces;
			logtitleParameter.Value = LogTitle;
			logdescriptionParameter.Value = LogDescription;
			questdescriptionParameter.Value = QuestDescription;
			areadescriptionParameter.Value = AreaDescription;
			portraitgivertextParameter.Value = PortraitGiverText;
			portraitgivernameParameter.Value = PortraitGiverName;
			portraitturnintextParameter.Value = PortraitTurnInText;
			portraitturninnameParameter.Value = PortraitTurnInName;
			questcompletionlogParameter.Value = QuestCompletionLog;
			verifiedbuildParameter.Value = VerifiedBuild;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(questtypeParameter);
			cmd.Parameters.Add(questlevelParameter);
			cmd.Parameters.Add(questpackageidParameter);
			cmd.Parameters.Add(minlevelParameter);
			cmd.Parameters.Add(questsortidParameter);
			cmd.Parameters.Add(questinfoidParameter);
			cmd.Parameters.Add(suggestedgroupnumParameter);
			cmd.Parameters.Add(rewardnextquestParameter);
			cmd.Parameters.Add(rewardxpdifficultyParameter);
			cmd.Parameters.Add(rewardxpmultiplierParameter);
			cmd.Parameters.Add(rewardmoneyParameter);
			cmd.Parameters.Add(rewardmoneydifficultyParameter);
			cmd.Parameters.Add(rewardmoneymultiplierParameter);
			cmd.Parameters.Add(rewardbonusmoneyParameter);
			cmd.Parameters.Add(rewarddisplayspellParameter);
			cmd.Parameters.Add(rewardspellParameter);
			cmd.Parameters.Add(rewardhonorParameter);
			cmd.Parameters.Add(rewardkillhonorParameter);
			cmd.Parameters.Add(startitemParameter);
			cmd.Parameters.Add(flagsParameter);
			cmd.Parameters.Add(flagsexParameter);
			cmd.Parameters.Add(rewarditem1Parameter);
			cmd.Parameters.Add(rewardamount1Parameter);
			cmd.Parameters.Add(rewarditem2Parameter);
			cmd.Parameters.Add(rewardamount2Parameter);
			cmd.Parameters.Add(rewarditem3Parameter);
			cmd.Parameters.Add(rewardamount3Parameter);
			cmd.Parameters.Add(rewarditem4Parameter);
			cmd.Parameters.Add(rewardamount4Parameter);
			cmd.Parameters.Add(itemdrop1Parameter);
			cmd.Parameters.Add(itemdropquantity1Parameter);
			cmd.Parameters.Add(itemdrop2Parameter);
			cmd.Parameters.Add(itemdropquantity2Parameter);
			cmd.Parameters.Add(itemdrop3Parameter);
			cmd.Parameters.Add(itemdropquantity3Parameter);
			cmd.Parameters.Add(itemdrop4Parameter);
			cmd.Parameters.Add(itemdropquantity4Parameter);
			cmd.Parameters.Add(rewardchoiceitemid1Parameter);
			cmd.Parameters.Add(rewardchoiceitemquantity1Parameter);
			cmd.Parameters.Add(rewardchoiceitemdisplayid1Parameter);
			cmd.Parameters.Add(rewardchoiceitemid2Parameter);
			cmd.Parameters.Add(rewardchoiceitemquantity2Parameter);
			cmd.Parameters.Add(rewardchoiceitemdisplayid2Parameter);
			cmd.Parameters.Add(rewardchoiceitemid3Parameter);
			cmd.Parameters.Add(rewardchoiceitemquantity3Parameter);
			cmd.Parameters.Add(rewardchoiceitemdisplayid3Parameter);
			cmd.Parameters.Add(rewardchoiceitemid4Parameter);
			cmd.Parameters.Add(rewardchoiceitemquantity4Parameter);
			cmd.Parameters.Add(rewardchoiceitemdisplayid4Parameter);
			cmd.Parameters.Add(rewardchoiceitemid5Parameter);
			cmd.Parameters.Add(rewardchoiceitemquantity5Parameter);
			cmd.Parameters.Add(rewardchoiceitemdisplayid5Parameter);
			cmd.Parameters.Add(rewardchoiceitemid6Parameter);
			cmd.Parameters.Add(rewardchoiceitemquantity6Parameter);
			cmd.Parameters.Add(rewardchoiceitemdisplayid6Parameter);
			cmd.Parameters.Add(poicontinentParameter);
			cmd.Parameters.Add(poixParameter);
			cmd.Parameters.Add(poiyParameter);
			cmd.Parameters.Add(poipriorityParameter);
			cmd.Parameters.Add(rewardtitleParameter);
			cmd.Parameters.Add(rewardtalentsParameter);
			cmd.Parameters.Add(rewardarenapointsParameter);
			cmd.Parameters.Add(rewardskilllineidParameter);
			cmd.Parameters.Add(rewardnumskillupsParameter);
			cmd.Parameters.Add(portraitgiverParameter);
			cmd.Parameters.Add(portraitturninParameter);
			cmd.Parameters.Add(rewardfactionid1Parameter);
			cmd.Parameters.Add(rewardfactionvalue1Parameter);
			cmd.Parameters.Add(rewardfactionoverride1Parameter);
			cmd.Parameters.Add(rewardfactionid2Parameter);
			cmd.Parameters.Add(rewardfactionvalue2Parameter);
			cmd.Parameters.Add(rewardfactionoverride2Parameter);
			cmd.Parameters.Add(rewardfactionid3Parameter);
			cmd.Parameters.Add(rewardfactionvalue3Parameter);
			cmd.Parameters.Add(rewardfactionoverride3Parameter);
			cmd.Parameters.Add(rewardfactionid4Parameter);
			cmd.Parameters.Add(rewardfactionvalue4Parameter);
			cmd.Parameters.Add(rewardfactionoverride4Parameter);
			cmd.Parameters.Add(rewardfactionid5Parameter);
			cmd.Parameters.Add(rewardfactionvalue5Parameter);
			cmd.Parameters.Add(rewardfactionoverride5Parameter);
			cmd.Parameters.Add(rewardfactionflagsParameter);
			cmd.Parameters.Add(rewardcurrencyid1Parameter);
			cmd.Parameters.Add(rewardcurrencyqty1Parameter);
			cmd.Parameters.Add(rewardcurrencyid2Parameter);
			cmd.Parameters.Add(rewardcurrencyqty2Parameter);
			cmd.Parameters.Add(rewardcurrencyid3Parameter);
			cmd.Parameters.Add(rewardcurrencyqty3Parameter);
			cmd.Parameters.Add(rewardcurrencyid4Parameter);
			cmd.Parameters.Add(rewardcurrencyqty4Parameter);
			cmd.Parameters.Add(acceptedsoundkitidParameter);
			cmd.Parameters.Add(completesoundkitidParameter);
			cmd.Parameters.Add(areagroupidParameter);
			cmd.Parameters.Add(timeallowedParameter);
			cmd.Parameters.Add(allowableracesParameter);
			cmd.Parameters.Add(logtitleParameter);
			cmd.Parameters.Add(logdescriptionParameter);
			cmd.Parameters.Add(questdescriptionParameter);
			cmd.Parameters.Add(areadescriptionParameter);
			cmd.Parameters.Add(portraitgivertextParameter);
			cmd.Parameters.Add(portraitgivernameParameter);
			cmd.Parameters.Add(portraitturnintextParameter);
			cmd.Parameters.Add(portraitturninnameParameter);
			cmd.Parameters.Add(questcompletionlogParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE quest_template SET ID = @newID, QuestType = @newQuestType, QuestLevel = @newQuestLevel, QuestPackageID = @newQuestPackageID, MinLevel = @newMinLevel, QuestSortID = @newQuestSortID, QuestInfoID = @newQuestInfoID, SuggestedGroupNum = @newSuggestedGroupNum, RewardNextQuest = @newRewardNextQuest, RewardXPDifficulty = @newRewardXPDifficulty, RewardXPMultiplier = @newRewardXPMultiplier, RewardMoney = @newRewardMoney, RewardMoneyDifficulty = @newRewardMoneyDifficulty, RewardMoneyMultiplier = @newRewardMoneyMultiplier, RewardBonusMoney = @newRewardBonusMoney, RewardDisplaySpell = @newRewardDisplaySpell, RewardSpell = @newRewardSpell, RewardHonor = @newRewardHonor, RewardKillHonor = @newRewardKillHonor, StartItem = @newStartItem, Flags = @newFlags, FlagsEx = @newFlagsEx, RewardItem1 = @newRewardItem1, RewardAmount1 = @newRewardAmount1, RewardItem2 = @newRewardItem2, RewardAmount2 = @newRewardAmount2, RewardItem3 = @newRewardItem3, RewardAmount3 = @newRewardAmount3, RewardItem4 = @newRewardItem4, RewardAmount4 = @newRewardAmount4, ItemDrop1 = @newItemDrop1, ItemDropQuantity1 = @newItemDropQuantity1, ItemDrop2 = @newItemDrop2, ItemDropQuantity2 = @newItemDropQuantity2, ItemDrop3 = @newItemDrop3, ItemDropQuantity3 = @newItemDropQuantity3, ItemDrop4 = @newItemDrop4, ItemDropQuantity4 = @newItemDropQuantity4, RewardChoiceItemID1 = @newRewardChoiceItemID1, RewardChoiceItemQuantity1 = @newRewardChoiceItemQuantity1, RewardChoiceItemDisplayID1 = @newRewardChoiceItemDisplayID1, RewardChoiceItemID2 = @newRewardChoiceItemID2, RewardChoiceItemQuantity2 = @newRewardChoiceItemQuantity2, RewardChoiceItemDisplayID2 = @newRewardChoiceItemDisplayID2, RewardChoiceItemID3 = @newRewardChoiceItemID3, RewardChoiceItemQuantity3 = @newRewardChoiceItemQuantity3, RewardChoiceItemDisplayID3 = @newRewardChoiceItemDisplayID3, RewardChoiceItemID4 = @newRewardChoiceItemID4, RewardChoiceItemQuantity4 = @newRewardChoiceItemQuantity4, RewardChoiceItemDisplayID4 = @newRewardChoiceItemDisplayID4, RewardChoiceItemID5 = @newRewardChoiceItemID5, RewardChoiceItemQuantity5 = @newRewardChoiceItemQuantity5, RewardChoiceItemDisplayID5 = @newRewardChoiceItemDisplayID5, RewardChoiceItemID6 = @newRewardChoiceItemID6, RewardChoiceItemQuantity6 = @newRewardChoiceItemQuantity6, RewardChoiceItemDisplayID6 = @newRewardChoiceItemDisplayID6, POIContinent = @newPOIContinent, POIx = @newPOIx, POIy = @newPOIy, POIPriority = @newPOIPriority, RewardTitle = @newRewardTitle, RewardTalents = @newRewardTalents, RewardArenaPoints = @newRewardArenaPoints, RewardSkillLineID = @newRewardSkillLineID, RewardNumSkillUps = @newRewardNumSkillUps, PortraitGiver = @newPortraitGiver, PortraitTurnIn = @newPortraitTurnIn, RewardFactionID1 = @newRewardFactionID1, RewardFactionValue1 = @newRewardFactionValue1, RewardFactionOverride1 = @newRewardFactionOverride1, RewardFactionID2 = @newRewardFactionID2, RewardFactionValue2 = @newRewardFactionValue2, RewardFactionOverride2 = @newRewardFactionOverride2, RewardFactionID3 = @newRewardFactionID3, RewardFactionValue3 = @newRewardFactionValue3, RewardFactionOverride3 = @newRewardFactionOverride3, RewardFactionID4 = @newRewardFactionID4, RewardFactionValue4 = @newRewardFactionValue4, RewardFactionOverride4 = @newRewardFactionOverride4, RewardFactionID5 = @newRewardFactionID5, RewardFactionValue5 = @newRewardFactionValue5, RewardFactionOverride5 = @newRewardFactionOverride5, RewardFactionFlags = @newRewardFactionFlags, RewardCurrencyID1 = @newRewardCurrencyID1, RewardCurrencyQty1 = @newRewardCurrencyQty1, RewardCurrencyID2 = @newRewardCurrencyID2, RewardCurrencyQty2 = @newRewardCurrencyQty2, RewardCurrencyID3 = @newRewardCurrencyID3, RewardCurrencyQty3 = @newRewardCurrencyQty3, RewardCurrencyID4 = @newRewardCurrencyID4, RewardCurrencyQty4 = @newRewardCurrencyQty4, AcceptedSoundKitID = @newAcceptedSoundKitID, CompleteSoundKitID = @newCompleteSoundKitID, AreaGroupID = @newAreaGroupID, TimeAllowed = @newTimeAllowed, AllowableRaces = @newAllowableRaces, LogTitle = @newLogTitle, LogDescription = @newLogDescription, QuestDescription = @newQuestDescription, AreaDescription = @newAreaDescription, PortraitGiverText = @newPortraitGiverText, PortraitGiverName = @newPortraitGiverName, PortraitTurnInText = @newPortraitTurnInText, PortraitTurnInName = @newPortraitTurnInName, QuestCompletionLog = @newQuestCompletionLog, VerifiedBuild = @newVerifiedBuild WHERE ID = @ID AND QuestType = @QuestType AND QuestLevel = @QuestLevel AND QuestPackageID = @QuestPackageID AND MinLevel = @MinLevel AND QuestSortID = @QuestSortID AND QuestInfoID = @QuestInfoID AND SuggestedGroupNum = @SuggestedGroupNum AND RewardNextQuest = @RewardNextQuest AND RewardXPDifficulty = @RewardXPDifficulty AND RewardXPMultiplier = @RewardXPMultiplier AND RewardMoney = @RewardMoney AND RewardMoneyDifficulty = @RewardMoneyDifficulty AND RewardMoneyMultiplier = @RewardMoneyMultiplier AND RewardBonusMoney = @RewardBonusMoney AND RewardDisplaySpell = @RewardDisplaySpell AND RewardSpell = @RewardSpell AND RewardHonor = @RewardHonor AND RewardKillHonor = @RewardKillHonor AND StartItem = @StartItem AND Flags = @Flags AND FlagsEx = @FlagsEx AND RewardItem1 = @RewardItem1 AND RewardAmount1 = @RewardAmount1 AND RewardItem2 = @RewardItem2 AND RewardAmount2 = @RewardAmount2 AND RewardItem3 = @RewardItem3 AND RewardAmount3 = @RewardAmount3 AND RewardItem4 = @RewardItem4 AND RewardAmount4 = @RewardAmount4 AND ItemDrop1 = @ItemDrop1 AND ItemDropQuantity1 = @ItemDropQuantity1 AND ItemDrop2 = @ItemDrop2 AND ItemDropQuantity2 = @ItemDropQuantity2 AND ItemDrop3 = @ItemDrop3 AND ItemDropQuantity3 = @ItemDropQuantity3 AND ItemDrop4 = @ItemDrop4 AND ItemDropQuantity4 = @ItemDropQuantity4 AND RewardChoiceItemID1 = @RewardChoiceItemID1 AND RewardChoiceItemQuantity1 = @RewardChoiceItemQuantity1 AND RewardChoiceItemDisplayID1 = @RewardChoiceItemDisplayID1 AND RewardChoiceItemID2 = @RewardChoiceItemID2 AND RewardChoiceItemQuantity2 = @RewardChoiceItemQuantity2 AND RewardChoiceItemDisplayID2 = @RewardChoiceItemDisplayID2 AND RewardChoiceItemID3 = @RewardChoiceItemID3 AND RewardChoiceItemQuantity3 = @RewardChoiceItemQuantity3 AND RewardChoiceItemDisplayID3 = @RewardChoiceItemDisplayID3 AND RewardChoiceItemID4 = @RewardChoiceItemID4 AND RewardChoiceItemQuantity4 = @RewardChoiceItemQuantity4 AND RewardChoiceItemDisplayID4 = @RewardChoiceItemDisplayID4 AND RewardChoiceItemID5 = @RewardChoiceItemID5 AND RewardChoiceItemQuantity5 = @RewardChoiceItemQuantity5 AND RewardChoiceItemDisplayID5 = @RewardChoiceItemDisplayID5 AND RewardChoiceItemID6 = @RewardChoiceItemID6 AND RewardChoiceItemQuantity6 = @RewardChoiceItemQuantity6 AND RewardChoiceItemDisplayID6 = @RewardChoiceItemDisplayID6 AND POIContinent = @POIContinent AND POIx = @POIx AND POIy = @POIy AND POIPriority = @POIPriority AND RewardTitle = @RewardTitle AND RewardTalents = @RewardTalents AND RewardArenaPoints = @RewardArenaPoints AND RewardSkillLineID = @RewardSkillLineID AND RewardNumSkillUps = @RewardNumSkillUps AND PortraitGiver = @PortraitGiver AND PortraitTurnIn = @PortraitTurnIn AND RewardFactionID1 = @RewardFactionID1 AND RewardFactionValue1 = @RewardFactionValue1 AND RewardFactionOverride1 = @RewardFactionOverride1 AND RewardFactionID2 = @RewardFactionID2 AND RewardFactionValue2 = @RewardFactionValue2 AND RewardFactionOverride2 = @RewardFactionOverride2 AND RewardFactionID3 = @RewardFactionID3 AND RewardFactionValue3 = @RewardFactionValue3 AND RewardFactionOverride3 = @RewardFactionOverride3 AND RewardFactionID4 = @RewardFactionID4 AND RewardFactionValue4 = @RewardFactionValue4 AND RewardFactionOverride4 = @RewardFactionOverride4 AND RewardFactionID5 = @RewardFactionID5 AND RewardFactionValue5 = @RewardFactionValue5 AND RewardFactionOverride5 = @RewardFactionOverride5 AND RewardFactionFlags = @RewardFactionFlags AND RewardCurrencyID1 = @RewardCurrencyID1 AND RewardCurrencyQty1 = @RewardCurrencyQty1 AND RewardCurrencyID2 = @RewardCurrencyID2 AND RewardCurrencyQty2 = @RewardCurrencyQty2 AND RewardCurrencyID3 = @RewardCurrencyID3 AND RewardCurrencyQty3 = @RewardCurrencyQty3 AND RewardCurrencyID4 = @RewardCurrencyID4 AND RewardCurrencyQty4 = @RewardCurrencyQty4 AND AcceptedSoundKitID = @AcceptedSoundKitID AND CompleteSoundKitID = @CompleteSoundKitID AND AreaGroupID = @AreaGroupID AND TimeAllowed = @TimeAllowed AND AllowableRaces = @AllowableRaces AND LogTitle = @LogTitle AND LogDescription = @LogDescription AND QuestDescription = @QuestDescription AND AreaDescription = @AreaDescription AND PortraitGiverText = @PortraitGiverText AND PortraitGiverName = @PortraitGiverName AND PortraitTurnInText = @PortraitTurnInText AND PortraitTurnInName = @PortraitTurnInName AND QuestCompletionLog = @QuestCompletionLog AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_questtypeParameter = new MySqlParameter("@QuestType", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_questlevelParameter = new MySqlParameter("@QuestLevel", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_questpackageidParameter = new MySqlParameter("@QuestPackageID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_minlevelParameter = new MySqlParameter("@MinLevel", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_questsortidParameter = new MySqlParameter("@QuestSortID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_questinfoidParameter = new MySqlParameter("@QuestInfoID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_suggestedgroupnumParameter = new MySqlParameter("@SuggestedGroupNum", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardnextquestParameter = new MySqlParameter("@RewardNextQuest", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardxpdifficultyParameter = new MySqlParameter("@RewardXPDifficulty", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardxpmultiplierParameter = new MySqlParameter("@RewardXPMultiplier", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardmoneyParameter = new MySqlParameter("@RewardMoney", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardmoneydifficultyParameter = new MySqlParameter("@RewardMoneyDifficulty", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardmoneymultiplierParameter = new MySqlParameter("@RewardMoneyMultiplier", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardbonusmoneyParameter = new MySqlParameter("@RewardBonusMoney", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewarddisplayspellParameter = new MySqlParameter("@RewardDisplaySpell", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardspellParameter = new MySqlParameter("@RewardSpell", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardhonorParameter = new MySqlParameter("@RewardHonor", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardkillhonorParameter = new MySqlParameter("@RewardKillHonor", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_startitemParameter = new MySqlParameter("@StartItem", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_flagsParameter = new MySqlParameter("@Flags", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_flagsexParameter = new MySqlParameter("@FlagsEx", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewarditem1Parameter = new MySqlParameter("@RewardItem1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardamount1Parameter = new MySqlParameter("@RewardAmount1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewarditem2Parameter = new MySqlParameter("@RewardItem2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardamount2Parameter = new MySqlParameter("@RewardAmount2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewarditem3Parameter = new MySqlParameter("@RewardItem3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardamount3Parameter = new MySqlParameter("@RewardAmount3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewarditem4Parameter = new MySqlParameter("@RewardItem4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardamount4Parameter = new MySqlParameter("@RewardAmount4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_itemdrop1Parameter = new MySqlParameter("@ItemDrop1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_itemdropquantity1Parameter = new MySqlParameter("@ItemDropQuantity1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_itemdrop2Parameter = new MySqlParameter("@ItemDrop2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_itemdropquantity2Parameter = new MySqlParameter("@ItemDropQuantity2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_itemdrop3Parameter = new MySqlParameter("@ItemDrop3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_itemdropquantity3Parameter = new MySqlParameter("@ItemDropQuantity3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_itemdrop4Parameter = new MySqlParameter("@ItemDrop4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_itemdropquantity4Parameter = new MySqlParameter("@ItemDropQuantity4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardchoiceitemid1Parameter = new MySqlParameter("@RewardChoiceItemID1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardchoiceitemquantity1Parameter = new MySqlParameter("@RewardChoiceItemQuantity1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardchoiceitemdisplayid1Parameter = new MySqlParameter("@RewardChoiceItemDisplayID1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardchoiceitemid2Parameter = new MySqlParameter("@RewardChoiceItemID2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardchoiceitemquantity2Parameter = new MySqlParameter("@RewardChoiceItemQuantity2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardchoiceitemdisplayid2Parameter = new MySqlParameter("@RewardChoiceItemDisplayID2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardchoiceitemid3Parameter = new MySqlParameter("@RewardChoiceItemID3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardchoiceitemquantity3Parameter = new MySqlParameter("@RewardChoiceItemQuantity3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardchoiceitemdisplayid3Parameter = new MySqlParameter("@RewardChoiceItemDisplayID3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardchoiceitemid4Parameter = new MySqlParameter("@RewardChoiceItemID4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardchoiceitemquantity4Parameter = new MySqlParameter("@RewardChoiceItemQuantity4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardchoiceitemdisplayid4Parameter = new MySqlParameter("@RewardChoiceItemDisplayID4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardchoiceitemid5Parameter = new MySqlParameter("@RewardChoiceItemID5", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardchoiceitemquantity5Parameter = new MySqlParameter("@RewardChoiceItemQuantity5", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardchoiceitemdisplayid5Parameter = new MySqlParameter("@RewardChoiceItemDisplayID5", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardchoiceitemid6Parameter = new MySqlParameter("@RewardChoiceItemID6", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardchoiceitemquantity6Parameter = new MySqlParameter("@RewardChoiceItemQuantity6", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardchoiceitemdisplayid6Parameter = new MySqlParameter("@RewardChoiceItemDisplayID6", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_poicontinentParameter = new MySqlParameter("@POIContinent", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_poixParameter = new MySqlParameter("@POIx", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_poiyParameter = new MySqlParameter("@POIy", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_poipriorityParameter = new MySqlParameter("@POIPriority", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardtitleParameter = new MySqlParameter("@RewardTitle", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardtalentsParameter = new MySqlParameter("@RewardTalents", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardarenapointsParameter = new MySqlParameter("@RewardArenaPoints", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardskilllineidParameter = new MySqlParameter("@RewardSkillLineID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardnumskillupsParameter = new MySqlParameter("@RewardNumSkillUps", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_portraitgiverParameter = new MySqlParameter("@PortraitGiver", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_portraitturninParameter = new MySqlParameter("@PortraitTurnIn", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardfactionid1Parameter = new MySqlParameter("@RewardFactionID1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardfactionvalue1Parameter = new MySqlParameter("@RewardFactionValue1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardfactionoverride1Parameter = new MySqlParameter("@RewardFactionOverride1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardfactionid2Parameter = new MySqlParameter("@RewardFactionID2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardfactionvalue2Parameter = new MySqlParameter("@RewardFactionValue2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardfactionoverride2Parameter = new MySqlParameter("@RewardFactionOverride2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardfactionid3Parameter = new MySqlParameter("@RewardFactionID3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardfactionvalue3Parameter = new MySqlParameter("@RewardFactionValue3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardfactionoverride3Parameter = new MySqlParameter("@RewardFactionOverride3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardfactionid4Parameter = new MySqlParameter("@RewardFactionID4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardfactionvalue4Parameter = new MySqlParameter("@RewardFactionValue4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardfactionoverride4Parameter = new MySqlParameter("@RewardFactionOverride4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardfactionid5Parameter = new MySqlParameter("@RewardFactionID5", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardfactionvalue5Parameter = new MySqlParameter("@RewardFactionValue5", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardfactionoverride5Parameter = new MySqlParameter("@RewardFactionOverride5", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardfactionflagsParameter = new MySqlParameter("@RewardFactionFlags", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardcurrencyid1Parameter = new MySqlParameter("@RewardCurrencyID1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardcurrencyqty1Parameter = new MySqlParameter("@RewardCurrencyQty1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardcurrencyid2Parameter = new MySqlParameter("@RewardCurrencyID2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardcurrencyqty2Parameter = new MySqlParameter("@RewardCurrencyQty2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardcurrencyid3Parameter = new MySqlParameter("@RewardCurrencyID3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardcurrencyqty3Parameter = new MySqlParameter("@RewardCurrencyQty3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardcurrencyid4Parameter = new MySqlParameter("@RewardCurrencyID4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardcurrencyqty4Parameter = new MySqlParameter("@RewardCurrencyQty4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_acceptedsoundkitidParameter = new MySqlParameter("@AcceptedSoundKitID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_completesoundkitidParameter = new MySqlParameter("@CompleteSoundKitID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_areagroupidParameter = new MySqlParameter("@AreaGroupID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_timeallowedParameter = new MySqlParameter("@TimeAllowed", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_allowableracesParameter = new MySqlParameter("@AllowableRaces", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_logtitleParameter = new MySqlParameter("@LogTitle", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_logdescriptionParameter = new MySqlParameter("@LogDescription", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_questdescriptionParameter = new MySqlParameter("@QuestDescription", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_areadescriptionParameter = new MySqlParameter("@AreaDescription", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_portraitgivertextParameter = new MySqlParameter("@PortraitGiverText", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_portraitgivernameParameter = new MySqlParameter("@PortraitGiverName", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_portraitturnintextParameter = new MySqlParameter("@PortraitTurnInText", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_portraitturninnameParameter = new MySqlParameter("@PortraitTurnInName", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_questcompletionlogParameter = new MySqlParameter("@QuestCompletionLog", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newID", MySqlDbType.VarChar, 0);
			MySqlParameter questtypeParameter = new MySqlParameter("@newQuestType", MySqlDbType.VarChar, 0);
			MySqlParameter questlevelParameter = new MySqlParameter("@newQuestLevel", MySqlDbType.VarChar, 0);
			MySqlParameter questpackageidParameter = new MySqlParameter("@newQuestPackageID", MySqlDbType.VarChar, 0);
			MySqlParameter minlevelParameter = new MySqlParameter("@newMinLevel", MySqlDbType.VarChar, 0);
			MySqlParameter questsortidParameter = new MySqlParameter("@newQuestSortID", MySqlDbType.VarChar, 0);
			MySqlParameter questinfoidParameter = new MySqlParameter("@newQuestInfoID", MySqlDbType.VarChar, 0);
			MySqlParameter suggestedgroupnumParameter = new MySqlParameter("@newSuggestedGroupNum", MySqlDbType.VarChar, 0);
			MySqlParameter rewardnextquestParameter = new MySqlParameter("@newRewardNextQuest", MySqlDbType.VarChar, 0);
			MySqlParameter rewardxpdifficultyParameter = new MySqlParameter("@newRewardXPDifficulty", MySqlDbType.VarChar, 0);
			MySqlParameter rewardxpmultiplierParameter = new MySqlParameter("@newRewardXPMultiplier", MySqlDbType.VarChar, 0);
			MySqlParameter rewardmoneyParameter = new MySqlParameter("@newRewardMoney", MySqlDbType.VarChar, 0);
			MySqlParameter rewardmoneydifficultyParameter = new MySqlParameter("@newRewardMoneyDifficulty", MySqlDbType.VarChar, 0);
			MySqlParameter rewardmoneymultiplierParameter = new MySqlParameter("@newRewardMoneyMultiplier", MySqlDbType.VarChar, 0);
			MySqlParameter rewardbonusmoneyParameter = new MySqlParameter("@newRewardBonusMoney", MySqlDbType.VarChar, 0);
			MySqlParameter rewarddisplayspellParameter = new MySqlParameter("@newRewardDisplaySpell", MySqlDbType.VarChar, 0);
			MySqlParameter rewardspellParameter = new MySqlParameter("@newRewardSpell", MySqlDbType.VarChar, 0);
			MySqlParameter rewardhonorParameter = new MySqlParameter("@newRewardHonor", MySqlDbType.VarChar, 0);
			MySqlParameter rewardkillhonorParameter = new MySqlParameter("@newRewardKillHonor", MySqlDbType.VarChar, 0);
			MySqlParameter startitemParameter = new MySqlParameter("@newStartItem", MySqlDbType.VarChar, 0);
			MySqlParameter flagsParameter = new MySqlParameter("@newFlags", MySqlDbType.VarChar, 0);
			MySqlParameter flagsexParameter = new MySqlParameter("@newFlagsEx", MySqlDbType.VarChar, 0);
			MySqlParameter rewarditem1Parameter = new MySqlParameter("@newRewardItem1", MySqlDbType.VarChar, 0);
			MySqlParameter rewardamount1Parameter = new MySqlParameter("@newRewardAmount1", MySqlDbType.VarChar, 0);
			MySqlParameter rewarditem2Parameter = new MySqlParameter("@newRewardItem2", MySqlDbType.VarChar, 0);
			MySqlParameter rewardamount2Parameter = new MySqlParameter("@newRewardAmount2", MySqlDbType.VarChar, 0);
			MySqlParameter rewarditem3Parameter = new MySqlParameter("@newRewardItem3", MySqlDbType.VarChar, 0);
			MySqlParameter rewardamount3Parameter = new MySqlParameter("@newRewardAmount3", MySqlDbType.VarChar, 0);
			MySqlParameter rewarditem4Parameter = new MySqlParameter("@newRewardItem4", MySqlDbType.VarChar, 0);
			MySqlParameter rewardamount4Parameter = new MySqlParameter("@newRewardAmount4", MySqlDbType.VarChar, 0);
			MySqlParameter itemdrop1Parameter = new MySqlParameter("@newItemDrop1", MySqlDbType.VarChar, 0);
			MySqlParameter itemdropquantity1Parameter = new MySqlParameter("@newItemDropQuantity1", MySqlDbType.VarChar, 0);
			MySqlParameter itemdrop2Parameter = new MySqlParameter("@newItemDrop2", MySqlDbType.VarChar, 0);
			MySqlParameter itemdropquantity2Parameter = new MySqlParameter("@newItemDropQuantity2", MySqlDbType.VarChar, 0);
			MySqlParameter itemdrop3Parameter = new MySqlParameter("@newItemDrop3", MySqlDbType.VarChar, 0);
			MySqlParameter itemdropquantity3Parameter = new MySqlParameter("@newItemDropQuantity3", MySqlDbType.VarChar, 0);
			MySqlParameter itemdrop4Parameter = new MySqlParameter("@newItemDrop4", MySqlDbType.VarChar, 0);
			MySqlParameter itemdropquantity4Parameter = new MySqlParameter("@newItemDropQuantity4", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemid1Parameter = new MySqlParameter("@newRewardChoiceItemID1", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemquantity1Parameter = new MySqlParameter("@newRewardChoiceItemQuantity1", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemdisplayid1Parameter = new MySqlParameter("@newRewardChoiceItemDisplayID1", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemid2Parameter = new MySqlParameter("@newRewardChoiceItemID2", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemquantity2Parameter = new MySqlParameter("@newRewardChoiceItemQuantity2", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemdisplayid2Parameter = new MySqlParameter("@newRewardChoiceItemDisplayID2", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemid3Parameter = new MySqlParameter("@newRewardChoiceItemID3", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemquantity3Parameter = new MySqlParameter("@newRewardChoiceItemQuantity3", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemdisplayid3Parameter = new MySqlParameter("@newRewardChoiceItemDisplayID3", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemid4Parameter = new MySqlParameter("@newRewardChoiceItemID4", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemquantity4Parameter = new MySqlParameter("@newRewardChoiceItemQuantity4", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemdisplayid4Parameter = new MySqlParameter("@newRewardChoiceItemDisplayID4", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemid5Parameter = new MySqlParameter("@newRewardChoiceItemID5", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemquantity5Parameter = new MySqlParameter("@newRewardChoiceItemQuantity5", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemdisplayid5Parameter = new MySqlParameter("@newRewardChoiceItemDisplayID5", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemid6Parameter = new MySqlParameter("@newRewardChoiceItemID6", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemquantity6Parameter = new MySqlParameter("@newRewardChoiceItemQuantity6", MySqlDbType.VarChar, 0);
			MySqlParameter rewardchoiceitemdisplayid6Parameter = new MySqlParameter("@newRewardChoiceItemDisplayID6", MySqlDbType.VarChar, 0);
			MySqlParameter poicontinentParameter = new MySqlParameter("@newPOIContinent", MySqlDbType.VarChar, 0);
			MySqlParameter poixParameter = new MySqlParameter("@newPOIx", MySqlDbType.VarChar, 0);
			MySqlParameter poiyParameter = new MySqlParameter("@newPOIy", MySqlDbType.VarChar, 0);
			MySqlParameter poipriorityParameter = new MySqlParameter("@newPOIPriority", MySqlDbType.VarChar, 0);
			MySqlParameter rewardtitleParameter = new MySqlParameter("@newRewardTitle", MySqlDbType.VarChar, 0);
			MySqlParameter rewardtalentsParameter = new MySqlParameter("@newRewardTalents", MySqlDbType.VarChar, 0);
			MySqlParameter rewardarenapointsParameter = new MySqlParameter("@newRewardArenaPoints", MySqlDbType.VarChar, 0);
			MySqlParameter rewardskilllineidParameter = new MySqlParameter("@newRewardSkillLineID", MySqlDbType.VarChar, 0);
			MySqlParameter rewardnumskillupsParameter = new MySqlParameter("@newRewardNumSkillUps", MySqlDbType.VarChar, 0);
			MySqlParameter portraitgiverParameter = new MySqlParameter("@newPortraitGiver", MySqlDbType.VarChar, 0);
			MySqlParameter portraitturninParameter = new MySqlParameter("@newPortraitTurnIn", MySqlDbType.VarChar, 0);
			MySqlParameter rewardfactionid1Parameter = new MySqlParameter("@newRewardFactionID1", MySqlDbType.VarChar, 0);
			MySqlParameter rewardfactionvalue1Parameter = new MySqlParameter("@newRewardFactionValue1", MySqlDbType.VarChar, 0);
			MySqlParameter rewardfactionoverride1Parameter = new MySqlParameter("@newRewardFactionOverride1", MySqlDbType.VarChar, 0);
			MySqlParameter rewardfactionid2Parameter = new MySqlParameter("@newRewardFactionID2", MySqlDbType.VarChar, 0);
			MySqlParameter rewardfactionvalue2Parameter = new MySqlParameter("@newRewardFactionValue2", MySqlDbType.VarChar, 0);
			MySqlParameter rewardfactionoverride2Parameter = new MySqlParameter("@newRewardFactionOverride2", MySqlDbType.VarChar, 0);
			MySqlParameter rewardfactionid3Parameter = new MySqlParameter("@newRewardFactionID3", MySqlDbType.VarChar, 0);
			MySqlParameter rewardfactionvalue3Parameter = new MySqlParameter("@newRewardFactionValue3", MySqlDbType.VarChar, 0);
			MySqlParameter rewardfactionoverride3Parameter = new MySqlParameter("@newRewardFactionOverride3", MySqlDbType.VarChar, 0);
			MySqlParameter rewardfactionid4Parameter = new MySqlParameter("@newRewardFactionID4", MySqlDbType.VarChar, 0);
			MySqlParameter rewardfactionvalue4Parameter = new MySqlParameter("@newRewardFactionValue4", MySqlDbType.VarChar, 0);
			MySqlParameter rewardfactionoverride4Parameter = new MySqlParameter("@newRewardFactionOverride4", MySqlDbType.VarChar, 0);
			MySqlParameter rewardfactionid5Parameter = new MySqlParameter("@newRewardFactionID5", MySqlDbType.VarChar, 0);
			MySqlParameter rewardfactionvalue5Parameter = new MySqlParameter("@newRewardFactionValue5", MySqlDbType.VarChar, 0);
			MySqlParameter rewardfactionoverride5Parameter = new MySqlParameter("@newRewardFactionOverride5", MySqlDbType.VarChar, 0);
			MySqlParameter rewardfactionflagsParameter = new MySqlParameter("@newRewardFactionFlags", MySqlDbType.VarChar, 0);
			MySqlParameter rewardcurrencyid1Parameter = new MySqlParameter("@newRewardCurrencyID1", MySqlDbType.VarChar, 0);
			MySqlParameter rewardcurrencyqty1Parameter = new MySqlParameter("@newRewardCurrencyQty1", MySqlDbType.VarChar, 0);
			MySqlParameter rewardcurrencyid2Parameter = new MySqlParameter("@newRewardCurrencyID2", MySqlDbType.VarChar, 0);
			MySqlParameter rewardcurrencyqty2Parameter = new MySqlParameter("@newRewardCurrencyQty2", MySqlDbType.VarChar, 0);
			MySqlParameter rewardcurrencyid3Parameter = new MySqlParameter("@newRewardCurrencyID3", MySqlDbType.VarChar, 0);
			MySqlParameter rewardcurrencyqty3Parameter = new MySqlParameter("@newRewardCurrencyQty3", MySqlDbType.VarChar, 0);
			MySqlParameter rewardcurrencyid4Parameter = new MySqlParameter("@newRewardCurrencyID4", MySqlDbType.VarChar, 0);
			MySqlParameter rewardcurrencyqty4Parameter = new MySqlParameter("@newRewardCurrencyQty4", MySqlDbType.VarChar, 0);
			MySqlParameter acceptedsoundkitidParameter = new MySqlParameter("@newAcceptedSoundKitID", MySqlDbType.VarChar, 0);
			MySqlParameter completesoundkitidParameter = new MySqlParameter("@newCompleteSoundKitID", MySqlDbType.VarChar, 0);
			MySqlParameter areagroupidParameter = new MySqlParameter("@newAreaGroupID", MySqlDbType.VarChar, 0);
			MySqlParameter timeallowedParameter = new MySqlParameter("@newTimeAllowed", MySqlDbType.VarChar, 0);
			MySqlParameter allowableracesParameter = new MySqlParameter("@newAllowableRaces", MySqlDbType.VarChar, 0);
			MySqlParameter logtitleParameter = new MySqlParameter("@newLogTitle", MySqlDbType.VarChar, 0);
			MySqlParameter logdescriptionParameter = new MySqlParameter("@newLogDescription", MySqlDbType.VarChar, 0);
			MySqlParameter questdescriptionParameter = new MySqlParameter("@newQuestDescription", MySqlDbType.VarChar, 0);
			MySqlParameter areadescriptionParameter = new MySqlParameter("@newAreaDescription", MySqlDbType.VarChar, 0);
			MySqlParameter portraitgivertextParameter = new MySqlParameter("@newPortraitGiverText", MySqlDbType.VarChar, 0);
			MySqlParameter portraitgivernameParameter = new MySqlParameter("@newPortraitGiverName", MySqlDbType.VarChar, 0);
			MySqlParameter portraitturnintextParameter = new MySqlParameter("@newPortraitTurnInText", MySqlDbType.VarChar, 0);
			MySqlParameter portraitturninnameParameter = new MySqlParameter("@newPortraitTurnInName", MySqlDbType.VarChar, 0);
			MySqlParameter questcompletionlogParameter = new MySqlParameter("@newQuestCompletionLog", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@newVerifiedBuild", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			questtypeParameter.Value = QuestType;
			questlevelParameter.Value = QuestLevel;
			questpackageidParameter.Value = QuestPackageID;
			minlevelParameter.Value = MinLevel;
			questsortidParameter.Value = QuestSortID;
			questinfoidParameter.Value = QuestInfoID;
			suggestedgroupnumParameter.Value = SuggestedGroupNum;
			rewardnextquestParameter.Value = RewardNextQuest;
			rewardxpdifficultyParameter.Value = RewardXPDifficulty;
			rewardxpmultiplierParameter.Value = RewardXPMultiplier;
			rewardmoneyParameter.Value = RewardMoney;
			rewardmoneydifficultyParameter.Value = RewardMoneyDifficulty;
			rewardmoneymultiplierParameter.Value = RewardMoneyMultiplier;
			rewardbonusmoneyParameter.Value = RewardBonusMoney;
			rewarddisplayspellParameter.Value = RewardDisplaySpell;
			rewardspellParameter.Value = RewardSpell;
			rewardhonorParameter.Value = RewardHonor;
			rewardkillhonorParameter.Value = RewardKillHonor;
			startitemParameter.Value = StartItem;
			flagsParameter.Value = Flags;
			flagsexParameter.Value = FlagsEx;
			rewarditem1Parameter.Value = RewardItem1;
			rewardamount1Parameter.Value = RewardAmount1;
			rewarditem2Parameter.Value = RewardItem2;
			rewardamount2Parameter.Value = RewardAmount2;
			rewarditem3Parameter.Value = RewardItem3;
			rewardamount3Parameter.Value = RewardAmount3;
			rewarditem4Parameter.Value = RewardItem4;
			rewardamount4Parameter.Value = RewardAmount4;
			itemdrop1Parameter.Value = ItemDrop1;
			itemdropquantity1Parameter.Value = ItemDropQuantity1;
			itemdrop2Parameter.Value = ItemDrop2;
			itemdropquantity2Parameter.Value = ItemDropQuantity2;
			itemdrop3Parameter.Value = ItemDrop3;
			itemdropquantity3Parameter.Value = ItemDropQuantity3;
			itemdrop4Parameter.Value = ItemDrop4;
			itemdropquantity4Parameter.Value = ItemDropQuantity4;
			rewardchoiceitemid1Parameter.Value = RewardChoiceItemID1;
			rewardchoiceitemquantity1Parameter.Value = RewardChoiceItemQuantity1;
			rewardchoiceitemdisplayid1Parameter.Value = RewardChoiceItemDisplayID1;
			rewardchoiceitemid2Parameter.Value = RewardChoiceItemID2;
			rewardchoiceitemquantity2Parameter.Value = RewardChoiceItemQuantity2;
			rewardchoiceitemdisplayid2Parameter.Value = RewardChoiceItemDisplayID2;
			rewardchoiceitemid3Parameter.Value = RewardChoiceItemID3;
			rewardchoiceitemquantity3Parameter.Value = RewardChoiceItemQuantity3;
			rewardchoiceitemdisplayid3Parameter.Value = RewardChoiceItemDisplayID3;
			rewardchoiceitemid4Parameter.Value = RewardChoiceItemID4;
			rewardchoiceitemquantity4Parameter.Value = RewardChoiceItemQuantity4;
			rewardchoiceitemdisplayid4Parameter.Value = RewardChoiceItemDisplayID4;
			rewardchoiceitemid5Parameter.Value = RewardChoiceItemID5;
			rewardchoiceitemquantity5Parameter.Value = RewardChoiceItemQuantity5;
			rewardchoiceitemdisplayid5Parameter.Value = RewardChoiceItemDisplayID5;
			rewardchoiceitemid6Parameter.Value = RewardChoiceItemID6;
			rewardchoiceitemquantity6Parameter.Value = RewardChoiceItemQuantity6;
			rewardchoiceitemdisplayid6Parameter.Value = RewardChoiceItemDisplayID6;
			poicontinentParameter.Value = POIContinent;
			poixParameter.Value = POIx;
			poiyParameter.Value = POIy;
			poipriorityParameter.Value = POIPriority;
			rewardtitleParameter.Value = RewardTitle;
			rewardtalentsParameter.Value = RewardTalents;
			rewardarenapointsParameter.Value = RewardArenaPoints;
			rewardskilllineidParameter.Value = RewardSkillLineID;
			rewardnumskillupsParameter.Value = RewardNumSkillUps;
			portraitgiverParameter.Value = PortraitGiver;
			portraitturninParameter.Value = PortraitTurnIn;
			rewardfactionid1Parameter.Value = RewardFactionID1;
			rewardfactionvalue1Parameter.Value = RewardFactionValue1;
			rewardfactionoverride1Parameter.Value = RewardFactionOverride1;
			rewardfactionid2Parameter.Value = RewardFactionID2;
			rewardfactionvalue2Parameter.Value = RewardFactionValue2;
			rewardfactionoverride2Parameter.Value = RewardFactionOverride2;
			rewardfactionid3Parameter.Value = RewardFactionID3;
			rewardfactionvalue3Parameter.Value = RewardFactionValue3;
			rewardfactionoverride3Parameter.Value = RewardFactionOverride3;
			rewardfactionid4Parameter.Value = RewardFactionID4;
			rewardfactionvalue4Parameter.Value = RewardFactionValue4;
			rewardfactionoverride4Parameter.Value = RewardFactionOverride4;
			rewardfactionid5Parameter.Value = RewardFactionID5;
			rewardfactionvalue5Parameter.Value = RewardFactionValue5;
			rewardfactionoverride5Parameter.Value = RewardFactionOverride5;
			rewardfactionflagsParameter.Value = RewardFactionFlags;
			rewardcurrencyid1Parameter.Value = RewardCurrencyID1;
			rewardcurrencyqty1Parameter.Value = RewardCurrencyQty1;
			rewardcurrencyid2Parameter.Value = RewardCurrencyID2;
			rewardcurrencyqty2Parameter.Value = RewardCurrencyQty2;
			rewardcurrencyid3Parameter.Value = RewardCurrencyID3;
			rewardcurrencyqty3Parameter.Value = RewardCurrencyQty3;
			rewardcurrencyid4Parameter.Value = RewardCurrencyID4;
			rewardcurrencyqty4Parameter.Value = RewardCurrencyQty4;
			acceptedsoundkitidParameter.Value = AcceptedSoundKitID;
			completesoundkitidParameter.Value = CompleteSoundKitID;
			areagroupidParameter.Value = AreaGroupID;
			timeallowedParameter.Value = TimeAllowed;
			allowableracesParameter.Value = AllowableRaces;
			logtitleParameter.Value = LogTitle;
			logdescriptionParameter.Value = LogDescription;
			questdescriptionParameter.Value = QuestDescription;
			areadescriptionParameter.Value = AreaDescription;
			portraitgivertextParameter.Value = PortraitGiverText;
			portraitgivernameParameter.Value = PortraitGiverName;
			portraitturnintextParameter.Value = PortraitTurnInText;
			portraitturninnameParameter.Value = PortraitTurnInName;
			questcompletionlogParameter.Value = QuestCompletionLog;
			verifiedbuildParameter.Value = VerifiedBuild;
			OLD_idParameter.Value = OLD_ID;
			OLD_questtypeParameter.Value = OLD_QuestType;
			OLD_questlevelParameter.Value = OLD_QuestLevel;
			OLD_questpackageidParameter.Value = OLD_QuestPackageID;
			OLD_minlevelParameter.Value = OLD_MinLevel;
			OLD_questsortidParameter.Value = OLD_QuestSortID;
			OLD_questinfoidParameter.Value = OLD_QuestInfoID;
			OLD_suggestedgroupnumParameter.Value = OLD_SuggestedGroupNum;
			OLD_rewardnextquestParameter.Value = OLD_RewardNextQuest;
			OLD_rewardxpdifficultyParameter.Value = OLD_RewardXPDifficulty;
			OLD_rewardxpmultiplierParameter.Value = OLD_RewardXPMultiplier;
			OLD_rewardmoneyParameter.Value = OLD_RewardMoney;
			OLD_rewardmoneydifficultyParameter.Value = OLD_RewardMoneyDifficulty;
			OLD_rewardmoneymultiplierParameter.Value = OLD_RewardMoneyMultiplier;
			OLD_rewardbonusmoneyParameter.Value = OLD_RewardBonusMoney;
			OLD_rewarddisplayspellParameter.Value = OLD_RewardDisplaySpell;
			OLD_rewardspellParameter.Value = OLD_RewardSpell;
			OLD_rewardhonorParameter.Value = OLD_RewardHonor;
			OLD_rewardkillhonorParameter.Value = OLD_RewardKillHonor;
			OLD_startitemParameter.Value = OLD_StartItem;
			OLD_flagsParameter.Value = OLD_Flags;
			OLD_flagsexParameter.Value = OLD_FlagsEx;
			OLD_rewarditem1Parameter.Value = OLD_RewardItem1;
			OLD_rewardamount1Parameter.Value = OLD_RewardAmount1;
			OLD_rewarditem2Parameter.Value = OLD_RewardItem2;
			OLD_rewardamount2Parameter.Value = OLD_RewardAmount2;
			OLD_rewarditem3Parameter.Value = OLD_RewardItem3;
			OLD_rewardamount3Parameter.Value = OLD_RewardAmount3;
			OLD_rewarditem4Parameter.Value = OLD_RewardItem4;
			OLD_rewardamount4Parameter.Value = OLD_RewardAmount4;
			OLD_itemdrop1Parameter.Value = OLD_ItemDrop1;
			OLD_itemdropquantity1Parameter.Value = OLD_ItemDropQuantity1;
			OLD_itemdrop2Parameter.Value = OLD_ItemDrop2;
			OLD_itemdropquantity2Parameter.Value = OLD_ItemDropQuantity2;
			OLD_itemdrop3Parameter.Value = OLD_ItemDrop3;
			OLD_itemdropquantity3Parameter.Value = OLD_ItemDropQuantity3;
			OLD_itemdrop4Parameter.Value = OLD_ItemDrop4;
			OLD_itemdropquantity4Parameter.Value = OLD_ItemDropQuantity4;
			OLD_rewardchoiceitemid1Parameter.Value = OLD_RewardChoiceItemID1;
			OLD_rewardchoiceitemquantity1Parameter.Value = OLD_RewardChoiceItemQuantity1;
			OLD_rewardchoiceitemdisplayid1Parameter.Value = OLD_RewardChoiceItemDisplayID1;
			OLD_rewardchoiceitemid2Parameter.Value = OLD_RewardChoiceItemID2;
			OLD_rewardchoiceitemquantity2Parameter.Value = OLD_RewardChoiceItemQuantity2;
			OLD_rewardchoiceitemdisplayid2Parameter.Value = OLD_RewardChoiceItemDisplayID2;
			OLD_rewardchoiceitemid3Parameter.Value = OLD_RewardChoiceItemID3;
			OLD_rewardchoiceitemquantity3Parameter.Value = OLD_RewardChoiceItemQuantity3;
			OLD_rewardchoiceitemdisplayid3Parameter.Value = OLD_RewardChoiceItemDisplayID3;
			OLD_rewardchoiceitemid4Parameter.Value = OLD_RewardChoiceItemID4;
			OLD_rewardchoiceitemquantity4Parameter.Value = OLD_RewardChoiceItemQuantity4;
			OLD_rewardchoiceitemdisplayid4Parameter.Value = OLD_RewardChoiceItemDisplayID4;
			OLD_rewardchoiceitemid5Parameter.Value = OLD_RewardChoiceItemID5;
			OLD_rewardchoiceitemquantity5Parameter.Value = OLD_RewardChoiceItemQuantity5;
			OLD_rewardchoiceitemdisplayid5Parameter.Value = OLD_RewardChoiceItemDisplayID5;
			OLD_rewardchoiceitemid6Parameter.Value = OLD_RewardChoiceItemID6;
			OLD_rewardchoiceitemquantity6Parameter.Value = OLD_RewardChoiceItemQuantity6;
			OLD_rewardchoiceitemdisplayid6Parameter.Value = OLD_RewardChoiceItemDisplayID6;
			OLD_poicontinentParameter.Value = OLD_POIContinent;
			OLD_poixParameter.Value = OLD_POIx;
			OLD_poiyParameter.Value = OLD_POIy;
			OLD_poipriorityParameter.Value = OLD_POIPriority;
			OLD_rewardtitleParameter.Value = OLD_RewardTitle;
			OLD_rewardtalentsParameter.Value = OLD_RewardTalents;
			OLD_rewardarenapointsParameter.Value = OLD_RewardArenaPoints;
			OLD_rewardskilllineidParameter.Value = OLD_RewardSkillLineID;
			OLD_rewardnumskillupsParameter.Value = OLD_RewardNumSkillUps;
			OLD_portraitgiverParameter.Value = OLD_PortraitGiver;
			OLD_portraitturninParameter.Value = OLD_PortraitTurnIn;
			OLD_rewardfactionid1Parameter.Value = OLD_RewardFactionID1;
			OLD_rewardfactionvalue1Parameter.Value = OLD_RewardFactionValue1;
			OLD_rewardfactionoverride1Parameter.Value = OLD_RewardFactionOverride1;
			OLD_rewardfactionid2Parameter.Value = OLD_RewardFactionID2;
			OLD_rewardfactionvalue2Parameter.Value = OLD_RewardFactionValue2;
			OLD_rewardfactionoverride2Parameter.Value = OLD_RewardFactionOverride2;
			OLD_rewardfactionid3Parameter.Value = OLD_RewardFactionID3;
			OLD_rewardfactionvalue3Parameter.Value = OLD_RewardFactionValue3;
			OLD_rewardfactionoverride3Parameter.Value = OLD_RewardFactionOverride3;
			OLD_rewardfactionid4Parameter.Value = OLD_RewardFactionID4;
			OLD_rewardfactionvalue4Parameter.Value = OLD_RewardFactionValue4;
			OLD_rewardfactionoverride4Parameter.Value = OLD_RewardFactionOverride4;
			OLD_rewardfactionid5Parameter.Value = OLD_RewardFactionID5;
			OLD_rewardfactionvalue5Parameter.Value = OLD_RewardFactionValue5;
			OLD_rewardfactionoverride5Parameter.Value = OLD_RewardFactionOverride5;
			OLD_rewardfactionflagsParameter.Value = OLD_RewardFactionFlags;
			OLD_rewardcurrencyid1Parameter.Value = OLD_RewardCurrencyID1;
			OLD_rewardcurrencyqty1Parameter.Value = OLD_RewardCurrencyQty1;
			OLD_rewardcurrencyid2Parameter.Value = OLD_RewardCurrencyID2;
			OLD_rewardcurrencyqty2Parameter.Value = OLD_RewardCurrencyQty2;
			OLD_rewardcurrencyid3Parameter.Value = OLD_RewardCurrencyID3;
			OLD_rewardcurrencyqty3Parameter.Value = OLD_RewardCurrencyQty3;
			OLD_rewardcurrencyid4Parameter.Value = OLD_RewardCurrencyID4;
			OLD_rewardcurrencyqty4Parameter.Value = OLD_RewardCurrencyQty4;
			OLD_acceptedsoundkitidParameter.Value = OLD_AcceptedSoundKitID;
			OLD_completesoundkitidParameter.Value = OLD_CompleteSoundKitID;
			OLD_areagroupidParameter.Value = OLD_AreaGroupID;
			OLD_timeallowedParameter.Value = OLD_TimeAllowed;
			OLD_allowableracesParameter.Value = OLD_AllowableRaces;
			OLD_logtitleParameter.Value = OLD_LogTitle;
			OLD_logdescriptionParameter.Value = OLD_LogDescription;
			OLD_questdescriptionParameter.Value = OLD_QuestDescription;
			OLD_areadescriptionParameter.Value = OLD_AreaDescription;
			OLD_portraitgivertextParameter.Value = OLD_PortraitGiverText;
			OLD_portraitgivernameParameter.Value = OLD_PortraitGiverName;
			OLD_portraitturnintextParameter.Value = OLD_PortraitTurnInText;
			OLD_portraitturninnameParameter.Value = OLD_PortraitTurnInName;
			OLD_questcompletionlogParameter.Value = OLD_QuestCompletionLog;
			OLD_verifiedbuildParameter.Value = OLD_VerifiedBuild;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(questtypeParameter);
			cmd.Parameters.Add(questlevelParameter);
			cmd.Parameters.Add(questpackageidParameter);
			cmd.Parameters.Add(minlevelParameter);
			cmd.Parameters.Add(questsortidParameter);
			cmd.Parameters.Add(questinfoidParameter);
			cmd.Parameters.Add(suggestedgroupnumParameter);
			cmd.Parameters.Add(rewardnextquestParameter);
			cmd.Parameters.Add(rewardxpdifficultyParameter);
			cmd.Parameters.Add(rewardxpmultiplierParameter);
			cmd.Parameters.Add(rewardmoneyParameter);
			cmd.Parameters.Add(rewardmoneydifficultyParameter);
			cmd.Parameters.Add(rewardmoneymultiplierParameter);
			cmd.Parameters.Add(rewardbonusmoneyParameter);
			cmd.Parameters.Add(rewarddisplayspellParameter);
			cmd.Parameters.Add(rewardspellParameter);
			cmd.Parameters.Add(rewardhonorParameter);
			cmd.Parameters.Add(rewardkillhonorParameter);
			cmd.Parameters.Add(startitemParameter);
			cmd.Parameters.Add(flagsParameter);
			cmd.Parameters.Add(flagsexParameter);
			cmd.Parameters.Add(rewarditem1Parameter);
			cmd.Parameters.Add(rewardamount1Parameter);
			cmd.Parameters.Add(rewarditem2Parameter);
			cmd.Parameters.Add(rewardamount2Parameter);
			cmd.Parameters.Add(rewarditem3Parameter);
			cmd.Parameters.Add(rewardamount3Parameter);
			cmd.Parameters.Add(rewarditem4Parameter);
			cmd.Parameters.Add(rewardamount4Parameter);
			cmd.Parameters.Add(itemdrop1Parameter);
			cmd.Parameters.Add(itemdropquantity1Parameter);
			cmd.Parameters.Add(itemdrop2Parameter);
			cmd.Parameters.Add(itemdropquantity2Parameter);
			cmd.Parameters.Add(itemdrop3Parameter);
			cmd.Parameters.Add(itemdropquantity3Parameter);
			cmd.Parameters.Add(itemdrop4Parameter);
			cmd.Parameters.Add(itemdropquantity4Parameter);
			cmd.Parameters.Add(rewardchoiceitemid1Parameter);
			cmd.Parameters.Add(rewardchoiceitemquantity1Parameter);
			cmd.Parameters.Add(rewardchoiceitemdisplayid1Parameter);
			cmd.Parameters.Add(rewardchoiceitemid2Parameter);
			cmd.Parameters.Add(rewardchoiceitemquantity2Parameter);
			cmd.Parameters.Add(rewardchoiceitemdisplayid2Parameter);
			cmd.Parameters.Add(rewardchoiceitemid3Parameter);
			cmd.Parameters.Add(rewardchoiceitemquantity3Parameter);
			cmd.Parameters.Add(rewardchoiceitemdisplayid3Parameter);
			cmd.Parameters.Add(rewardchoiceitemid4Parameter);
			cmd.Parameters.Add(rewardchoiceitemquantity4Parameter);
			cmd.Parameters.Add(rewardchoiceitemdisplayid4Parameter);
			cmd.Parameters.Add(rewardchoiceitemid5Parameter);
			cmd.Parameters.Add(rewardchoiceitemquantity5Parameter);
			cmd.Parameters.Add(rewardchoiceitemdisplayid5Parameter);
			cmd.Parameters.Add(rewardchoiceitemid6Parameter);
			cmd.Parameters.Add(rewardchoiceitemquantity6Parameter);
			cmd.Parameters.Add(rewardchoiceitemdisplayid6Parameter);
			cmd.Parameters.Add(poicontinentParameter);
			cmd.Parameters.Add(poixParameter);
			cmd.Parameters.Add(poiyParameter);
			cmd.Parameters.Add(poipriorityParameter);
			cmd.Parameters.Add(rewardtitleParameter);
			cmd.Parameters.Add(rewardtalentsParameter);
			cmd.Parameters.Add(rewardarenapointsParameter);
			cmd.Parameters.Add(rewardskilllineidParameter);
			cmd.Parameters.Add(rewardnumskillupsParameter);
			cmd.Parameters.Add(portraitgiverParameter);
			cmd.Parameters.Add(portraitturninParameter);
			cmd.Parameters.Add(rewardfactionid1Parameter);
			cmd.Parameters.Add(rewardfactionvalue1Parameter);
			cmd.Parameters.Add(rewardfactionoverride1Parameter);
			cmd.Parameters.Add(rewardfactionid2Parameter);
			cmd.Parameters.Add(rewardfactionvalue2Parameter);
			cmd.Parameters.Add(rewardfactionoverride2Parameter);
			cmd.Parameters.Add(rewardfactionid3Parameter);
			cmd.Parameters.Add(rewardfactionvalue3Parameter);
			cmd.Parameters.Add(rewardfactionoverride3Parameter);
			cmd.Parameters.Add(rewardfactionid4Parameter);
			cmd.Parameters.Add(rewardfactionvalue4Parameter);
			cmd.Parameters.Add(rewardfactionoverride4Parameter);
			cmd.Parameters.Add(rewardfactionid5Parameter);
			cmd.Parameters.Add(rewardfactionvalue5Parameter);
			cmd.Parameters.Add(rewardfactionoverride5Parameter);
			cmd.Parameters.Add(rewardfactionflagsParameter);
			cmd.Parameters.Add(rewardcurrencyid1Parameter);
			cmd.Parameters.Add(rewardcurrencyqty1Parameter);
			cmd.Parameters.Add(rewardcurrencyid2Parameter);
			cmd.Parameters.Add(rewardcurrencyqty2Parameter);
			cmd.Parameters.Add(rewardcurrencyid3Parameter);
			cmd.Parameters.Add(rewardcurrencyqty3Parameter);
			cmd.Parameters.Add(rewardcurrencyid4Parameter);
			cmd.Parameters.Add(rewardcurrencyqty4Parameter);
			cmd.Parameters.Add(acceptedsoundkitidParameter);
			cmd.Parameters.Add(completesoundkitidParameter);
			cmd.Parameters.Add(areagroupidParameter);
			cmd.Parameters.Add(timeallowedParameter);
			cmd.Parameters.Add(allowableracesParameter);
			cmd.Parameters.Add(logtitleParameter);
			cmd.Parameters.Add(logdescriptionParameter);
			cmd.Parameters.Add(questdescriptionParameter);
			cmd.Parameters.Add(areadescriptionParameter);
			cmd.Parameters.Add(portraitgivertextParameter);
			cmd.Parameters.Add(portraitgivernameParameter);
			cmd.Parameters.Add(portraitturnintextParameter);
			cmd.Parameters.Add(portraitturninnameParameter);
			cmd.Parameters.Add(questcompletionlogParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_questtypeParameter);
			cmd.Parameters.Add(OLD_questlevelParameter);
			cmd.Parameters.Add(OLD_questpackageidParameter);
			cmd.Parameters.Add(OLD_minlevelParameter);
			cmd.Parameters.Add(OLD_questsortidParameter);
			cmd.Parameters.Add(OLD_questinfoidParameter);
			cmd.Parameters.Add(OLD_suggestedgroupnumParameter);
			cmd.Parameters.Add(OLD_rewardnextquestParameter);
			cmd.Parameters.Add(OLD_rewardxpdifficultyParameter);
			cmd.Parameters.Add(OLD_rewardxpmultiplierParameter);
			cmd.Parameters.Add(OLD_rewardmoneyParameter);
			cmd.Parameters.Add(OLD_rewardmoneydifficultyParameter);
			cmd.Parameters.Add(OLD_rewardmoneymultiplierParameter);
			cmd.Parameters.Add(OLD_rewardbonusmoneyParameter);
			cmd.Parameters.Add(OLD_rewarddisplayspellParameter);
			cmd.Parameters.Add(OLD_rewardspellParameter);
			cmd.Parameters.Add(OLD_rewardhonorParameter);
			cmd.Parameters.Add(OLD_rewardkillhonorParameter);
			cmd.Parameters.Add(OLD_startitemParameter);
			cmd.Parameters.Add(OLD_flagsParameter);
			cmd.Parameters.Add(OLD_flagsexParameter);
			cmd.Parameters.Add(OLD_rewarditem1Parameter);
			cmd.Parameters.Add(OLD_rewardamount1Parameter);
			cmd.Parameters.Add(OLD_rewarditem2Parameter);
			cmd.Parameters.Add(OLD_rewardamount2Parameter);
			cmd.Parameters.Add(OLD_rewarditem3Parameter);
			cmd.Parameters.Add(OLD_rewardamount3Parameter);
			cmd.Parameters.Add(OLD_rewarditem4Parameter);
			cmd.Parameters.Add(OLD_rewardamount4Parameter);
			cmd.Parameters.Add(OLD_itemdrop1Parameter);
			cmd.Parameters.Add(OLD_itemdropquantity1Parameter);
			cmd.Parameters.Add(OLD_itemdrop2Parameter);
			cmd.Parameters.Add(OLD_itemdropquantity2Parameter);
			cmd.Parameters.Add(OLD_itemdrop3Parameter);
			cmd.Parameters.Add(OLD_itemdropquantity3Parameter);
			cmd.Parameters.Add(OLD_itemdrop4Parameter);
			cmd.Parameters.Add(OLD_itemdropquantity4Parameter);
			cmd.Parameters.Add(OLD_rewardchoiceitemid1Parameter);
			cmd.Parameters.Add(OLD_rewardchoiceitemquantity1Parameter);
			cmd.Parameters.Add(OLD_rewardchoiceitemdisplayid1Parameter);
			cmd.Parameters.Add(OLD_rewardchoiceitemid2Parameter);
			cmd.Parameters.Add(OLD_rewardchoiceitemquantity2Parameter);
			cmd.Parameters.Add(OLD_rewardchoiceitemdisplayid2Parameter);
			cmd.Parameters.Add(OLD_rewardchoiceitemid3Parameter);
			cmd.Parameters.Add(OLD_rewardchoiceitemquantity3Parameter);
			cmd.Parameters.Add(OLD_rewardchoiceitemdisplayid3Parameter);
			cmd.Parameters.Add(OLD_rewardchoiceitemid4Parameter);
			cmd.Parameters.Add(OLD_rewardchoiceitemquantity4Parameter);
			cmd.Parameters.Add(OLD_rewardchoiceitemdisplayid4Parameter);
			cmd.Parameters.Add(OLD_rewardchoiceitemid5Parameter);
			cmd.Parameters.Add(OLD_rewardchoiceitemquantity5Parameter);
			cmd.Parameters.Add(OLD_rewardchoiceitemdisplayid5Parameter);
			cmd.Parameters.Add(OLD_rewardchoiceitemid6Parameter);
			cmd.Parameters.Add(OLD_rewardchoiceitemquantity6Parameter);
			cmd.Parameters.Add(OLD_rewardchoiceitemdisplayid6Parameter);
			cmd.Parameters.Add(OLD_poicontinentParameter);
			cmd.Parameters.Add(OLD_poixParameter);
			cmd.Parameters.Add(OLD_poiyParameter);
			cmd.Parameters.Add(OLD_poipriorityParameter);
			cmd.Parameters.Add(OLD_rewardtitleParameter);
			cmd.Parameters.Add(OLD_rewardtalentsParameter);
			cmd.Parameters.Add(OLD_rewardarenapointsParameter);
			cmd.Parameters.Add(OLD_rewardskilllineidParameter);
			cmd.Parameters.Add(OLD_rewardnumskillupsParameter);
			cmd.Parameters.Add(OLD_portraitgiverParameter);
			cmd.Parameters.Add(OLD_portraitturninParameter);
			cmd.Parameters.Add(OLD_rewardfactionid1Parameter);
			cmd.Parameters.Add(OLD_rewardfactionvalue1Parameter);
			cmd.Parameters.Add(OLD_rewardfactionoverride1Parameter);
			cmd.Parameters.Add(OLD_rewardfactionid2Parameter);
			cmd.Parameters.Add(OLD_rewardfactionvalue2Parameter);
			cmd.Parameters.Add(OLD_rewardfactionoverride2Parameter);
			cmd.Parameters.Add(OLD_rewardfactionid3Parameter);
			cmd.Parameters.Add(OLD_rewardfactionvalue3Parameter);
			cmd.Parameters.Add(OLD_rewardfactionoverride3Parameter);
			cmd.Parameters.Add(OLD_rewardfactionid4Parameter);
			cmd.Parameters.Add(OLD_rewardfactionvalue4Parameter);
			cmd.Parameters.Add(OLD_rewardfactionoverride4Parameter);
			cmd.Parameters.Add(OLD_rewardfactionid5Parameter);
			cmd.Parameters.Add(OLD_rewardfactionvalue5Parameter);
			cmd.Parameters.Add(OLD_rewardfactionoverride5Parameter);
			cmd.Parameters.Add(OLD_rewardfactionflagsParameter);
			cmd.Parameters.Add(OLD_rewardcurrencyid1Parameter);
			cmd.Parameters.Add(OLD_rewardcurrencyqty1Parameter);
			cmd.Parameters.Add(OLD_rewardcurrencyid2Parameter);
			cmd.Parameters.Add(OLD_rewardcurrencyqty2Parameter);
			cmd.Parameters.Add(OLD_rewardcurrencyid3Parameter);
			cmd.Parameters.Add(OLD_rewardcurrencyqty3Parameter);
			cmd.Parameters.Add(OLD_rewardcurrencyid4Parameter);
			cmd.Parameters.Add(OLD_rewardcurrencyqty4Parameter);
			cmd.Parameters.Add(OLD_acceptedsoundkitidParameter);
			cmd.Parameters.Add(OLD_completesoundkitidParameter);
			cmd.Parameters.Add(OLD_areagroupidParameter);
			cmd.Parameters.Add(OLD_timeallowedParameter);
			cmd.Parameters.Add(OLD_allowableracesParameter);
			cmd.Parameters.Add(OLD_logtitleParameter);
			cmd.Parameters.Add(OLD_logdescriptionParameter);
			cmd.Parameters.Add(OLD_questdescriptionParameter);
			cmd.Parameters.Add(OLD_areadescriptionParameter);
			cmd.Parameters.Add(OLD_portraitgivertextParameter);
			cmd.Parameters.Add(OLD_portraitgivernameParameter);
			cmd.Parameters.Add(OLD_portraitturnintextParameter);
			cmd.Parameters.Add(OLD_portraitturninnameParameter);
			cmd.Parameters.Add(OLD_questcompletionlogParameter);
			cmd.Parameters.Add(OLD_verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_ID = ID;
			OLD_QuestType = QuestType;
			OLD_QuestLevel = QuestLevel;
			OLD_QuestPackageID = QuestPackageID;
			OLD_MinLevel = MinLevel;
			OLD_QuestSortID = QuestSortID;
			OLD_QuestInfoID = QuestInfoID;
			OLD_SuggestedGroupNum = SuggestedGroupNum;
			OLD_RewardNextQuest = RewardNextQuest;
			OLD_RewardXPDifficulty = RewardXPDifficulty;
			OLD_RewardXPMultiplier = RewardXPMultiplier;
			OLD_RewardMoney = RewardMoney;
			OLD_RewardMoneyDifficulty = RewardMoneyDifficulty;
			OLD_RewardMoneyMultiplier = RewardMoneyMultiplier;
			OLD_RewardBonusMoney = RewardBonusMoney;
			OLD_RewardDisplaySpell = RewardDisplaySpell;
			OLD_RewardSpell = RewardSpell;
			OLD_RewardHonor = RewardHonor;
			OLD_RewardKillHonor = RewardKillHonor;
			OLD_StartItem = StartItem;
			OLD_Flags = Flags;
			OLD_FlagsEx = FlagsEx;
			OLD_RewardItem1 = RewardItem1;
			OLD_RewardAmount1 = RewardAmount1;
			OLD_RewardItem2 = RewardItem2;
			OLD_RewardAmount2 = RewardAmount2;
			OLD_RewardItem3 = RewardItem3;
			OLD_RewardAmount3 = RewardAmount3;
			OLD_RewardItem4 = RewardItem4;
			OLD_RewardAmount4 = RewardAmount4;
			OLD_ItemDrop1 = ItemDrop1;
			OLD_ItemDropQuantity1 = ItemDropQuantity1;
			OLD_ItemDrop2 = ItemDrop2;
			OLD_ItemDropQuantity2 = ItemDropQuantity2;
			OLD_ItemDrop3 = ItemDrop3;
			OLD_ItemDropQuantity3 = ItemDropQuantity3;
			OLD_ItemDrop4 = ItemDrop4;
			OLD_ItemDropQuantity4 = ItemDropQuantity4;
			OLD_RewardChoiceItemID1 = RewardChoiceItemID1;
			OLD_RewardChoiceItemQuantity1 = RewardChoiceItemQuantity1;
			OLD_RewardChoiceItemDisplayID1 = RewardChoiceItemDisplayID1;
			OLD_RewardChoiceItemID2 = RewardChoiceItemID2;
			OLD_RewardChoiceItemQuantity2 = RewardChoiceItemQuantity2;
			OLD_RewardChoiceItemDisplayID2 = RewardChoiceItemDisplayID2;
			OLD_RewardChoiceItemID3 = RewardChoiceItemID3;
			OLD_RewardChoiceItemQuantity3 = RewardChoiceItemQuantity3;
			OLD_RewardChoiceItemDisplayID3 = RewardChoiceItemDisplayID3;
			OLD_RewardChoiceItemID4 = RewardChoiceItemID4;
			OLD_RewardChoiceItemQuantity4 = RewardChoiceItemQuantity4;
			OLD_RewardChoiceItemDisplayID4 = RewardChoiceItemDisplayID4;
			OLD_RewardChoiceItemID5 = RewardChoiceItemID5;
			OLD_RewardChoiceItemQuantity5 = RewardChoiceItemQuantity5;
			OLD_RewardChoiceItemDisplayID5 = RewardChoiceItemDisplayID5;
			OLD_RewardChoiceItemID6 = RewardChoiceItemID6;
			OLD_RewardChoiceItemQuantity6 = RewardChoiceItemQuantity6;
			OLD_RewardChoiceItemDisplayID6 = RewardChoiceItemDisplayID6;
			OLD_POIContinent = POIContinent;
			OLD_POIx = POIx;
			OLD_POIy = POIy;
			OLD_POIPriority = POIPriority;
			OLD_RewardTitle = RewardTitle;
			OLD_RewardTalents = RewardTalents;
			OLD_RewardArenaPoints = RewardArenaPoints;
			OLD_RewardSkillLineID = RewardSkillLineID;
			OLD_RewardNumSkillUps = RewardNumSkillUps;
			OLD_PortraitGiver = PortraitGiver;
			OLD_PortraitTurnIn = PortraitTurnIn;
			OLD_RewardFactionID1 = RewardFactionID1;
			OLD_RewardFactionValue1 = RewardFactionValue1;
			OLD_RewardFactionOverride1 = RewardFactionOverride1;
			OLD_RewardFactionID2 = RewardFactionID2;
			OLD_RewardFactionValue2 = RewardFactionValue2;
			OLD_RewardFactionOverride2 = RewardFactionOverride2;
			OLD_RewardFactionID3 = RewardFactionID3;
			OLD_RewardFactionValue3 = RewardFactionValue3;
			OLD_RewardFactionOverride3 = RewardFactionOverride3;
			OLD_RewardFactionID4 = RewardFactionID4;
			OLD_RewardFactionValue4 = RewardFactionValue4;
			OLD_RewardFactionOverride4 = RewardFactionOverride4;
			OLD_RewardFactionID5 = RewardFactionID5;
			OLD_RewardFactionValue5 = RewardFactionValue5;
			OLD_RewardFactionOverride5 = RewardFactionOverride5;
			OLD_RewardFactionFlags = RewardFactionFlags;
			OLD_RewardCurrencyID1 = RewardCurrencyID1;
			OLD_RewardCurrencyQty1 = RewardCurrencyQty1;
			OLD_RewardCurrencyID2 = RewardCurrencyID2;
			OLD_RewardCurrencyQty2 = RewardCurrencyQty2;
			OLD_RewardCurrencyID3 = RewardCurrencyID3;
			OLD_RewardCurrencyQty3 = RewardCurrencyQty3;
			OLD_RewardCurrencyID4 = RewardCurrencyID4;
			OLD_RewardCurrencyQty4 = RewardCurrencyQty4;
			OLD_AcceptedSoundKitID = AcceptedSoundKitID;
			OLD_CompleteSoundKitID = CompleteSoundKitID;
			OLD_AreaGroupID = AreaGroupID;
			OLD_TimeAllowed = TimeAllowed;
			OLD_AllowableRaces = AllowableRaces;
			OLD_LogTitle = LogTitle;
			OLD_LogDescription = LogDescription;
			OLD_QuestDescription = QuestDescription;
			OLD_AreaDescription = AreaDescription;
			OLD_PortraitGiverText = PortraitGiverText;
			OLD_PortraitGiverName = PortraitGiverName;
			OLD_PortraitTurnInText = PortraitTurnInText;
			OLD_PortraitTurnInName = PortraitTurnInName;
			OLD_QuestCompletionLog = QuestCompletionLog;
			OLD_VerifiedBuild = VerifiedBuild;
		}
	}
}
