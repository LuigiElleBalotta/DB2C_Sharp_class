using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Quest_template_addon
	{
		int ID = 0; //Comment: 
		int OLD_ID = 0;

		int MaxLevel = 0; //Comment: 
		int OLD_MaxLevel = 0;

		int AllowableClasses = 0; //Comment: 
		int OLD_AllowableClasses = 0;

		int SourceSpellID = 0; //Comment: 
		int OLD_SourceSpellID = 0;

		int PrevQuestID = 0; //Comment: 
		int OLD_PrevQuestID = 0;

		int NextQuestID = 0; //Comment: 
		int OLD_NextQuestID = 0;

		int ExclusiveGroup = 0; //Comment: 
		int OLD_ExclusiveGroup = 0;

		int RewardMailTemplateID = 0; //Comment: 
		int OLD_RewardMailTemplateID = 0;

		int RewardMailDelay = 0; //Comment: 
		int OLD_RewardMailDelay = 0;

		int RequiredSkillID = 0; //Comment: 
		int OLD_RequiredSkillID = 0;

		int RequiredSkillPoints = 0; //Comment: 
		int OLD_RequiredSkillPoints = 0;

		int RequiredMinRepFaction = 0; //Comment: 
		int OLD_RequiredMinRepFaction = 0;

		int RequiredMaxRepFaction = 0; //Comment: 
		int OLD_RequiredMaxRepFaction = 0;

		int RequiredMinRepValue = 0; //Comment: 
		int OLD_RequiredMinRepValue = 0;

		int RequiredMaxRepValue = 0; //Comment: 
		int OLD_RequiredMaxRepValue = 0;

		int ProvidedItemCount = 0; //Comment: 
		int OLD_ProvidedItemCount = 0;

		int SpecialFlags = 0; //Comment: 
		int OLD_SpecialFlags = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Quest_template_addon(int _ID, int _MaxLevel, int _AllowableClasses, int _SourceSpellID, int _PrevQuestID, int _NextQuestID, int _ExclusiveGroup, int _RewardMailTemplateID, int _RewardMailDelay, int _RequiredSkillID, int _RequiredSkillPoints, int _RequiredMinRepFaction, int _RequiredMaxRepFaction, int _RequiredMinRepValue, int _RequiredMaxRepValue, int _ProvidedItemCount, int _SpecialFlags)
		{
			ID = _ID;
			MaxLevel = _MaxLevel;
			AllowableClasses = _AllowableClasses;
			SourceSpellID = _SourceSpellID;
			PrevQuestID = _PrevQuestID;
			NextQuestID = _NextQuestID;
			ExclusiveGroup = _ExclusiveGroup;
			RewardMailTemplateID = _RewardMailTemplateID;
			RewardMailDelay = _RewardMailDelay;
			RequiredSkillID = _RequiredSkillID;
			RequiredSkillPoints = _RequiredSkillPoints;
			RequiredMinRepFaction = _RequiredMinRepFaction;
			RequiredMaxRepFaction = _RequiredMaxRepFaction;
			RequiredMinRepValue = _RequiredMinRepValue;
			RequiredMaxRepValue = _RequiredMaxRepValue;
			ProvidedItemCount = _ProvidedItemCount;
			SpecialFlags = _SpecialFlags;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM quest_template_addon WHERE ID = @ID AND MaxLevel = @MaxLevel AND AllowableClasses = @AllowableClasses AND SourceSpellID = @SourceSpellID AND PrevQuestID = @PrevQuestID AND NextQuestID = @NextQuestID AND ExclusiveGroup = @ExclusiveGroup AND RewardMailTemplateID = @RewardMailTemplateID AND RewardMailDelay = @RewardMailDelay AND RequiredSkillID = @RequiredSkillID AND RequiredSkillPoints = @RequiredSkillPoints AND RequiredMinRepFaction = @RequiredMinRepFaction AND RequiredMaxRepFaction = @RequiredMaxRepFaction AND RequiredMinRepValue = @RequiredMinRepValue AND RequiredMaxRepValue = @RequiredMaxRepValue AND ProvidedItemCount = @ProvidedItemCount AND SpecialFlags = @SpecialFlags;";
			MySqlParameter idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter maxlevelParameter = new MySqlParameter("@MaxLevel", MySqlDbType.VarChar, 0);
			MySqlParameter allowableclassesParameter = new MySqlParameter("@AllowableClasses", MySqlDbType.VarChar, 0);
			MySqlParameter sourcespellidParameter = new MySqlParameter("@SourceSpellID", MySqlDbType.VarChar, 0);
			MySqlParameter prevquestidParameter = new MySqlParameter("@PrevQuestID", MySqlDbType.VarChar, 0);
			MySqlParameter nextquestidParameter = new MySqlParameter("@NextQuestID", MySqlDbType.VarChar, 0);
			MySqlParameter exclusivegroupParameter = new MySqlParameter("@ExclusiveGroup", MySqlDbType.VarChar, 0);
			MySqlParameter rewardmailtemplateidParameter = new MySqlParameter("@RewardMailTemplateID", MySqlDbType.VarChar, 0);
			MySqlParameter rewardmaildelayParameter = new MySqlParameter("@RewardMailDelay", MySqlDbType.VarChar, 0);
			MySqlParameter requiredskillidParameter = new MySqlParameter("@RequiredSkillID", MySqlDbType.VarChar, 0);
			MySqlParameter requiredskillpointsParameter = new MySqlParameter("@RequiredSkillPoints", MySqlDbType.VarChar, 0);
			MySqlParameter requiredminrepfactionParameter = new MySqlParameter("@RequiredMinRepFaction", MySqlDbType.VarChar, 0);
			MySqlParameter requiredmaxrepfactionParameter = new MySqlParameter("@RequiredMaxRepFaction", MySqlDbType.VarChar, 0);
			MySqlParameter requiredminrepvalueParameter = new MySqlParameter("@RequiredMinRepValue", MySqlDbType.VarChar, 0);
			MySqlParameter requiredmaxrepvalueParameter = new MySqlParameter("@RequiredMaxRepValue", MySqlDbType.VarChar, 0);
			MySqlParameter provideditemcountParameter = new MySqlParameter("@ProvidedItemCount", MySqlDbType.VarChar, 0);
			MySqlParameter specialflagsParameter = new MySqlParameter("@SpecialFlags", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			maxlevelParameter.Value = MaxLevel;
			allowableclassesParameter.Value = AllowableClasses;
			sourcespellidParameter.Value = SourceSpellID;
			prevquestidParameter.Value = PrevQuestID;
			nextquestidParameter.Value = NextQuestID;
			exclusivegroupParameter.Value = ExclusiveGroup;
			rewardmailtemplateidParameter.Value = RewardMailTemplateID;
			rewardmaildelayParameter.Value = RewardMailDelay;
			requiredskillidParameter.Value = RequiredSkillID;
			requiredskillpointsParameter.Value = RequiredSkillPoints;
			requiredminrepfactionParameter.Value = RequiredMinRepFaction;
			requiredmaxrepfactionParameter.Value = RequiredMaxRepFaction;
			requiredminrepvalueParameter.Value = RequiredMinRepValue;
			requiredmaxrepvalueParameter.Value = RequiredMaxRepValue;
			provideditemcountParameter.Value = ProvidedItemCount;
			specialflagsParameter.Value = SpecialFlags;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(maxlevelParameter);
			cmd.Parameters.Add(allowableclassesParameter);
			cmd.Parameters.Add(sourcespellidParameter);
			cmd.Parameters.Add(prevquestidParameter);
			cmd.Parameters.Add(nextquestidParameter);
			cmd.Parameters.Add(exclusivegroupParameter);
			cmd.Parameters.Add(rewardmailtemplateidParameter);
			cmd.Parameters.Add(rewardmaildelayParameter);
			cmd.Parameters.Add(requiredskillidParameter);
			cmd.Parameters.Add(requiredskillpointsParameter);
			cmd.Parameters.Add(requiredminrepfactionParameter);
			cmd.Parameters.Add(requiredmaxrepfactionParameter);
			cmd.Parameters.Add(requiredminrepvalueParameter);
			cmd.Parameters.Add(requiredmaxrepvalueParameter);
			cmd.Parameters.Add(provideditemcountParameter);
			cmd.Parameters.Add(specialflagsParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE quest_template_addon SET ID = @newID, MaxLevel = @newMaxLevel, AllowableClasses = @newAllowableClasses, SourceSpellID = @newSourceSpellID, PrevQuestID = @newPrevQuestID, NextQuestID = @newNextQuestID, ExclusiveGroup = @newExclusiveGroup, RewardMailTemplateID = @newRewardMailTemplateID, RewardMailDelay = @newRewardMailDelay, RequiredSkillID = @newRequiredSkillID, RequiredSkillPoints = @newRequiredSkillPoints, RequiredMinRepFaction = @newRequiredMinRepFaction, RequiredMaxRepFaction = @newRequiredMaxRepFaction, RequiredMinRepValue = @newRequiredMinRepValue, RequiredMaxRepValue = @newRequiredMaxRepValue, ProvidedItemCount = @newProvidedItemCount, SpecialFlags = @newSpecialFlags WHERE ID = @ID AND MaxLevel = @MaxLevel AND AllowableClasses = @AllowableClasses AND SourceSpellID = @SourceSpellID AND PrevQuestID = @PrevQuestID AND NextQuestID = @NextQuestID AND ExclusiveGroup = @ExclusiveGroup AND RewardMailTemplateID = @RewardMailTemplateID AND RewardMailDelay = @RewardMailDelay AND RequiredSkillID = @RequiredSkillID AND RequiredSkillPoints = @RequiredSkillPoints AND RequiredMinRepFaction = @RequiredMinRepFaction AND RequiredMaxRepFaction = @RequiredMaxRepFaction AND RequiredMinRepValue = @RequiredMinRepValue AND RequiredMaxRepValue = @RequiredMaxRepValue AND ProvidedItemCount = @ProvidedItemCount AND SpecialFlags = @SpecialFlags;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_maxlevelParameter = new MySqlParameter("@MaxLevel", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_allowableclassesParameter = new MySqlParameter("@AllowableClasses", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_sourcespellidParameter = new MySqlParameter("@SourceSpellID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_prevquestidParameter = new MySqlParameter("@PrevQuestID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_nextquestidParameter = new MySqlParameter("@NextQuestID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_exclusivegroupParameter = new MySqlParameter("@ExclusiveGroup", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardmailtemplateidParameter = new MySqlParameter("@RewardMailTemplateID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewardmaildelayParameter = new MySqlParameter("@RewardMailDelay", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_requiredskillidParameter = new MySqlParameter("@RequiredSkillID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_requiredskillpointsParameter = new MySqlParameter("@RequiredSkillPoints", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_requiredminrepfactionParameter = new MySqlParameter("@RequiredMinRepFaction", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_requiredmaxrepfactionParameter = new MySqlParameter("@RequiredMaxRepFaction", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_requiredminrepvalueParameter = new MySqlParameter("@RequiredMinRepValue", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_requiredmaxrepvalueParameter = new MySqlParameter("@RequiredMaxRepValue", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_provideditemcountParameter = new MySqlParameter("@ProvidedItemCount", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_specialflagsParameter = new MySqlParameter("@SpecialFlags", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newID", MySqlDbType.VarChar, 0);
			MySqlParameter maxlevelParameter = new MySqlParameter("@newMaxLevel", MySqlDbType.VarChar, 0);
			MySqlParameter allowableclassesParameter = new MySqlParameter("@newAllowableClasses", MySqlDbType.VarChar, 0);
			MySqlParameter sourcespellidParameter = new MySqlParameter("@newSourceSpellID", MySqlDbType.VarChar, 0);
			MySqlParameter prevquestidParameter = new MySqlParameter("@newPrevQuestID", MySqlDbType.VarChar, 0);
			MySqlParameter nextquestidParameter = new MySqlParameter("@newNextQuestID", MySqlDbType.VarChar, 0);
			MySqlParameter exclusivegroupParameter = new MySqlParameter("@newExclusiveGroup", MySqlDbType.VarChar, 0);
			MySqlParameter rewardmailtemplateidParameter = new MySqlParameter("@newRewardMailTemplateID", MySqlDbType.VarChar, 0);
			MySqlParameter rewardmaildelayParameter = new MySqlParameter("@newRewardMailDelay", MySqlDbType.VarChar, 0);
			MySqlParameter requiredskillidParameter = new MySqlParameter("@newRequiredSkillID", MySqlDbType.VarChar, 0);
			MySqlParameter requiredskillpointsParameter = new MySqlParameter("@newRequiredSkillPoints", MySqlDbType.VarChar, 0);
			MySqlParameter requiredminrepfactionParameter = new MySqlParameter("@newRequiredMinRepFaction", MySqlDbType.VarChar, 0);
			MySqlParameter requiredmaxrepfactionParameter = new MySqlParameter("@newRequiredMaxRepFaction", MySqlDbType.VarChar, 0);
			MySqlParameter requiredminrepvalueParameter = new MySqlParameter("@newRequiredMinRepValue", MySqlDbType.VarChar, 0);
			MySqlParameter requiredmaxrepvalueParameter = new MySqlParameter("@newRequiredMaxRepValue", MySqlDbType.VarChar, 0);
			MySqlParameter provideditemcountParameter = new MySqlParameter("@newProvidedItemCount", MySqlDbType.VarChar, 0);
			MySqlParameter specialflagsParameter = new MySqlParameter("@newSpecialFlags", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			maxlevelParameter.Value = MaxLevel;
			allowableclassesParameter.Value = AllowableClasses;
			sourcespellidParameter.Value = SourceSpellID;
			prevquestidParameter.Value = PrevQuestID;
			nextquestidParameter.Value = NextQuestID;
			exclusivegroupParameter.Value = ExclusiveGroup;
			rewardmailtemplateidParameter.Value = RewardMailTemplateID;
			rewardmaildelayParameter.Value = RewardMailDelay;
			requiredskillidParameter.Value = RequiredSkillID;
			requiredskillpointsParameter.Value = RequiredSkillPoints;
			requiredminrepfactionParameter.Value = RequiredMinRepFaction;
			requiredmaxrepfactionParameter.Value = RequiredMaxRepFaction;
			requiredminrepvalueParameter.Value = RequiredMinRepValue;
			requiredmaxrepvalueParameter.Value = RequiredMaxRepValue;
			provideditemcountParameter.Value = ProvidedItemCount;
			specialflagsParameter.Value = SpecialFlags;
			OLD_idParameter.Value = OLD_ID;
			OLD_maxlevelParameter.Value = OLD_MaxLevel;
			OLD_allowableclassesParameter.Value = OLD_AllowableClasses;
			OLD_sourcespellidParameter.Value = OLD_SourceSpellID;
			OLD_prevquestidParameter.Value = OLD_PrevQuestID;
			OLD_nextquestidParameter.Value = OLD_NextQuestID;
			OLD_exclusivegroupParameter.Value = OLD_ExclusiveGroup;
			OLD_rewardmailtemplateidParameter.Value = OLD_RewardMailTemplateID;
			OLD_rewardmaildelayParameter.Value = OLD_RewardMailDelay;
			OLD_requiredskillidParameter.Value = OLD_RequiredSkillID;
			OLD_requiredskillpointsParameter.Value = OLD_RequiredSkillPoints;
			OLD_requiredminrepfactionParameter.Value = OLD_RequiredMinRepFaction;
			OLD_requiredmaxrepfactionParameter.Value = OLD_RequiredMaxRepFaction;
			OLD_requiredminrepvalueParameter.Value = OLD_RequiredMinRepValue;
			OLD_requiredmaxrepvalueParameter.Value = OLD_RequiredMaxRepValue;
			OLD_provideditemcountParameter.Value = OLD_ProvidedItemCount;
			OLD_specialflagsParameter.Value = OLD_SpecialFlags;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(maxlevelParameter);
			cmd.Parameters.Add(allowableclassesParameter);
			cmd.Parameters.Add(sourcespellidParameter);
			cmd.Parameters.Add(prevquestidParameter);
			cmd.Parameters.Add(nextquestidParameter);
			cmd.Parameters.Add(exclusivegroupParameter);
			cmd.Parameters.Add(rewardmailtemplateidParameter);
			cmd.Parameters.Add(rewardmaildelayParameter);
			cmd.Parameters.Add(requiredskillidParameter);
			cmd.Parameters.Add(requiredskillpointsParameter);
			cmd.Parameters.Add(requiredminrepfactionParameter);
			cmd.Parameters.Add(requiredmaxrepfactionParameter);
			cmd.Parameters.Add(requiredminrepvalueParameter);
			cmd.Parameters.Add(requiredmaxrepvalueParameter);
			cmd.Parameters.Add(provideditemcountParameter);
			cmd.Parameters.Add(specialflagsParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_maxlevelParameter);
			cmd.Parameters.Add(OLD_allowableclassesParameter);
			cmd.Parameters.Add(OLD_sourcespellidParameter);
			cmd.Parameters.Add(OLD_prevquestidParameter);
			cmd.Parameters.Add(OLD_nextquestidParameter);
			cmd.Parameters.Add(OLD_exclusivegroupParameter);
			cmd.Parameters.Add(OLD_rewardmailtemplateidParameter);
			cmd.Parameters.Add(OLD_rewardmaildelayParameter);
			cmd.Parameters.Add(OLD_requiredskillidParameter);
			cmd.Parameters.Add(OLD_requiredskillpointsParameter);
			cmd.Parameters.Add(OLD_requiredminrepfactionParameter);
			cmd.Parameters.Add(OLD_requiredmaxrepfactionParameter);
			cmd.Parameters.Add(OLD_requiredminrepvalueParameter);
			cmd.Parameters.Add(OLD_requiredmaxrepvalueParameter);
			cmd.Parameters.Add(OLD_provideditemcountParameter);
			cmd.Parameters.Add(OLD_specialflagsParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_ID = ID;
			OLD_MaxLevel = MaxLevel;
			OLD_AllowableClasses = AllowableClasses;
			OLD_SourceSpellID = SourceSpellID;
			OLD_PrevQuestID = PrevQuestID;
			OLD_NextQuestID = NextQuestID;
			OLD_ExclusiveGroup = ExclusiveGroup;
			OLD_RewardMailTemplateID = RewardMailTemplateID;
			OLD_RewardMailDelay = RewardMailDelay;
			OLD_RequiredSkillID = RequiredSkillID;
			OLD_RequiredSkillPoints = RequiredSkillPoints;
			OLD_RequiredMinRepFaction = RequiredMinRepFaction;
			OLD_RequiredMaxRepFaction = RequiredMaxRepFaction;
			OLD_RequiredMinRepValue = RequiredMinRepValue;
			OLD_RequiredMaxRepValue = RequiredMaxRepValue;
			OLD_ProvidedItemCount = ProvidedItemCount;
			OLD_SpecialFlags = SpecialFlags;
		}
	}
}
