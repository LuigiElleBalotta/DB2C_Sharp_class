using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Spell_dbc
	{
		int Id = 0; //Comment: 
		int OLD_Id = 0;

		int Attributes = 0; //Comment: 
		int OLD_Attributes = 0;

		int AttributesEx = 0; //Comment: 
		int OLD_AttributesEx = 0;

		int AttributesEx2 = 0; //Comment: 
		int OLD_AttributesEx2 = 0;

		int AttributesEx3 = 0; //Comment: 
		int OLD_AttributesEx3 = 0;

		int AttributesEx4 = 0; //Comment: 
		int OLD_AttributesEx4 = 0;

		int AttributesEx5 = 0; //Comment: 
		int OLD_AttributesEx5 = 0;

		int AttributesEx6 = 0; //Comment: 
		int OLD_AttributesEx6 = 0;

		int AttributesEx7 = 0; //Comment: 
		int OLD_AttributesEx7 = 0;

		int AttributesEx8 = 0; //Comment: 
		int OLD_AttributesEx8 = 0;

		int AttributesEx9 = 0; //Comment: 
		int OLD_AttributesEx9 = 0;

		int AttributesEx10 = 0; //Comment: 
		int OLD_AttributesEx10 = 0;

		int CastingTimeIndex = 1; //Comment: 
		int OLD_CastingTimeIndex = 1;

		int DurationIndex = 0; //Comment: 
		int OLD_DurationIndex = 0;

		int RangeIndex = 1; //Comment: 
		int OLD_RangeIndex = 1;

		int SchoolMask = 0; //Comment: 
		int OLD_SchoolMask = 0;

		int SpellAuraOptionsId = 0; //Comment: 
		int OLD_SpellAuraOptionsId = 0;

		int SpellCastingRequirementsId = 0; //Comment: 
		int OLD_SpellCastingRequirementsId = 0;

		int SpellCategoriesId = 0; //Comment: 
		int OLD_SpellCategoriesId = 0;

		int SpellClassOptionsId = 0; //Comment: 
		int OLD_SpellClassOptionsId = 0;

		int SpellEquippedItemsId = 0; //Comment: 
		int OLD_SpellEquippedItemsId = 0;

		int SpellLevelsId = 0; //Comment: 
		int OLD_SpellLevelsId = 0;

		int SpellTargetRestrictionsId = 0; //Comment: 
		int OLD_SpellTargetRestrictionsId = 0;

		int SpellInterruptsId = 0; //Comment: 
		int OLD_SpellInterruptsId = 0;

		string Comment = null; //Comment: 
		string OLD_Comment = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Spell_dbc(int _Id, int _Attributes, int _AttributesEx, int _AttributesEx2, int _AttributesEx3, int _AttributesEx4, int _AttributesEx5, int _AttributesEx6, int _AttributesEx7, int _AttributesEx8, int _AttributesEx9, int _AttributesEx10, int _CastingTimeIndex, int _DurationIndex, int _RangeIndex, int _SchoolMask, int _SpellAuraOptionsId, int _SpellCastingRequirementsId, int _SpellCategoriesId, int _SpellClassOptionsId, int _SpellEquippedItemsId, int _SpellLevelsId, int _SpellTargetRestrictionsId, int _SpellInterruptsId, string _Comment)
		{
			Id = _Id;
			Attributes = _Attributes;
			AttributesEx = _AttributesEx;
			AttributesEx2 = _AttributesEx2;
			AttributesEx3 = _AttributesEx3;
			AttributesEx4 = _AttributesEx4;
			AttributesEx5 = _AttributesEx5;
			AttributesEx6 = _AttributesEx6;
			AttributesEx7 = _AttributesEx7;
			AttributesEx8 = _AttributesEx8;
			AttributesEx9 = _AttributesEx9;
			AttributesEx10 = _AttributesEx10;
			CastingTimeIndex = _CastingTimeIndex;
			DurationIndex = _DurationIndex;
			RangeIndex = _RangeIndex;
			SchoolMask = _SchoolMask;
			SpellAuraOptionsId = _SpellAuraOptionsId;
			SpellCastingRequirementsId = _SpellCastingRequirementsId;
			SpellCategoriesId = _SpellCategoriesId;
			SpellClassOptionsId = _SpellClassOptionsId;
			SpellEquippedItemsId = _SpellEquippedItemsId;
			SpellLevelsId = _SpellLevelsId;
			SpellTargetRestrictionsId = _SpellTargetRestrictionsId;
			SpellInterruptsId = _SpellInterruptsId;
			Comment = _Comment;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM spell_dbc WHERE Id = @Id AND Attributes = @Attributes AND AttributesEx = @AttributesEx AND AttributesEx2 = @AttributesEx2 AND AttributesEx3 = @AttributesEx3 AND AttributesEx4 = @AttributesEx4 AND AttributesEx5 = @AttributesEx5 AND AttributesEx6 = @AttributesEx6 AND AttributesEx7 = @AttributesEx7 AND AttributesEx8 = @AttributesEx8 AND AttributesEx9 = @AttributesEx9 AND AttributesEx10 = @AttributesEx10 AND CastingTimeIndex = @CastingTimeIndex AND DurationIndex = @DurationIndex AND RangeIndex = @RangeIndex AND SchoolMask = @SchoolMask AND SpellAuraOptionsId = @SpellAuraOptionsId AND SpellCastingRequirementsId = @SpellCastingRequirementsId AND SpellCategoriesId = @SpellCategoriesId AND SpellClassOptionsId = @SpellClassOptionsId AND SpellEquippedItemsId = @SpellEquippedItemsId AND SpellLevelsId = @SpellLevelsId AND SpellTargetRestrictionsId = @SpellTargetRestrictionsId AND SpellInterruptsId = @SpellInterruptsId AND Comment = @Comment;";
			MySqlParameter idParameter = new MySqlParameter("@Id", MySqlDbType.VarChar, 0);
			MySqlParameter attributesParameter = new MySqlParameter("@Attributes", MySqlDbType.VarChar, 0);
			MySqlParameter attributesexParameter = new MySqlParameter("@AttributesEx", MySqlDbType.VarChar, 0);
			MySqlParameter attributesex2Parameter = new MySqlParameter("@AttributesEx2", MySqlDbType.VarChar, 0);
			MySqlParameter attributesex3Parameter = new MySqlParameter("@AttributesEx3", MySqlDbType.VarChar, 0);
			MySqlParameter attributesex4Parameter = new MySqlParameter("@AttributesEx4", MySqlDbType.VarChar, 0);
			MySqlParameter attributesex5Parameter = new MySqlParameter("@AttributesEx5", MySqlDbType.VarChar, 0);
			MySqlParameter attributesex6Parameter = new MySqlParameter("@AttributesEx6", MySqlDbType.VarChar, 0);
			MySqlParameter attributesex7Parameter = new MySqlParameter("@AttributesEx7", MySqlDbType.VarChar, 0);
			MySqlParameter attributesex8Parameter = new MySqlParameter("@AttributesEx8", MySqlDbType.VarChar, 0);
			MySqlParameter attributesex9Parameter = new MySqlParameter("@AttributesEx9", MySqlDbType.VarChar, 0);
			MySqlParameter attributesex10Parameter = new MySqlParameter("@AttributesEx10", MySqlDbType.VarChar, 0);
			MySqlParameter castingtimeindexParameter = new MySqlParameter("@CastingTimeIndex", MySqlDbType.VarChar, 0);
			MySqlParameter durationindexParameter = new MySqlParameter("@DurationIndex", MySqlDbType.VarChar, 0);
			MySqlParameter rangeindexParameter = new MySqlParameter("@RangeIndex", MySqlDbType.VarChar, 0);
			MySqlParameter schoolmaskParameter = new MySqlParameter("@SchoolMask", MySqlDbType.VarChar, 0);
			MySqlParameter spellauraoptionsidParameter = new MySqlParameter("@SpellAuraOptionsId", MySqlDbType.VarChar, 0);
			MySqlParameter spellcastingrequirementsidParameter = new MySqlParameter("@SpellCastingRequirementsId", MySqlDbType.VarChar, 0);
			MySqlParameter spellcategoriesidParameter = new MySqlParameter("@SpellCategoriesId", MySqlDbType.VarChar, 0);
			MySqlParameter spellclassoptionsidParameter = new MySqlParameter("@SpellClassOptionsId", MySqlDbType.VarChar, 0);
			MySqlParameter spellequippeditemsidParameter = new MySqlParameter("@SpellEquippedItemsId", MySqlDbType.VarChar, 0);
			MySqlParameter spelllevelsidParameter = new MySqlParameter("@SpellLevelsId", MySqlDbType.VarChar, 0);
			MySqlParameter spelltargetrestrictionsidParameter = new MySqlParameter("@SpellTargetRestrictionsId", MySqlDbType.VarChar, 0);
			MySqlParameter spellinterruptsidParameter = new MySqlParameter("@SpellInterruptsId", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@Comment", MySqlDbType.VarChar, 0);
			idParameter.Value = Id;
			attributesParameter.Value = Attributes;
			attributesexParameter.Value = AttributesEx;
			attributesex2Parameter.Value = AttributesEx2;
			attributesex3Parameter.Value = AttributesEx3;
			attributesex4Parameter.Value = AttributesEx4;
			attributesex5Parameter.Value = AttributesEx5;
			attributesex6Parameter.Value = AttributesEx6;
			attributesex7Parameter.Value = AttributesEx7;
			attributesex8Parameter.Value = AttributesEx8;
			attributesex9Parameter.Value = AttributesEx9;
			attributesex10Parameter.Value = AttributesEx10;
			castingtimeindexParameter.Value = CastingTimeIndex;
			durationindexParameter.Value = DurationIndex;
			rangeindexParameter.Value = RangeIndex;
			schoolmaskParameter.Value = SchoolMask;
			spellauraoptionsidParameter.Value = SpellAuraOptionsId;
			spellcastingrequirementsidParameter.Value = SpellCastingRequirementsId;
			spellcategoriesidParameter.Value = SpellCategoriesId;
			spellclassoptionsidParameter.Value = SpellClassOptionsId;
			spellequippeditemsidParameter.Value = SpellEquippedItemsId;
			spelllevelsidParameter.Value = SpellLevelsId;
			spelltargetrestrictionsidParameter.Value = SpellTargetRestrictionsId;
			spellinterruptsidParameter.Value = SpellInterruptsId;
			commentParameter.Value = Comment;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(attributesParameter);
			cmd.Parameters.Add(attributesexParameter);
			cmd.Parameters.Add(attributesex2Parameter);
			cmd.Parameters.Add(attributesex3Parameter);
			cmd.Parameters.Add(attributesex4Parameter);
			cmd.Parameters.Add(attributesex5Parameter);
			cmd.Parameters.Add(attributesex6Parameter);
			cmd.Parameters.Add(attributesex7Parameter);
			cmd.Parameters.Add(attributesex8Parameter);
			cmd.Parameters.Add(attributesex9Parameter);
			cmd.Parameters.Add(attributesex10Parameter);
			cmd.Parameters.Add(castingtimeindexParameter);
			cmd.Parameters.Add(durationindexParameter);
			cmd.Parameters.Add(rangeindexParameter);
			cmd.Parameters.Add(schoolmaskParameter);
			cmd.Parameters.Add(spellauraoptionsidParameter);
			cmd.Parameters.Add(spellcastingrequirementsidParameter);
			cmd.Parameters.Add(spellcategoriesidParameter);
			cmd.Parameters.Add(spellclassoptionsidParameter);
			cmd.Parameters.Add(spellequippeditemsidParameter);
			cmd.Parameters.Add(spelllevelsidParameter);
			cmd.Parameters.Add(spelltargetrestrictionsidParameter);
			cmd.Parameters.Add(spellinterruptsidParameter);
			cmd.Parameters.Add(commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE spell_dbc SET Id = @newId, Attributes = @newAttributes, AttributesEx = @newAttributesEx, AttributesEx2 = @newAttributesEx2, AttributesEx3 = @newAttributesEx3, AttributesEx4 = @newAttributesEx4, AttributesEx5 = @newAttributesEx5, AttributesEx6 = @newAttributesEx6, AttributesEx7 = @newAttributesEx7, AttributesEx8 = @newAttributesEx8, AttributesEx9 = @newAttributesEx9, AttributesEx10 = @newAttributesEx10, CastingTimeIndex = @newCastingTimeIndex, DurationIndex = @newDurationIndex, RangeIndex = @newRangeIndex, SchoolMask = @newSchoolMask, SpellAuraOptionsId = @newSpellAuraOptionsId, SpellCastingRequirementsId = @newSpellCastingRequirementsId, SpellCategoriesId = @newSpellCategoriesId, SpellClassOptionsId = @newSpellClassOptionsId, SpellEquippedItemsId = @newSpellEquippedItemsId, SpellLevelsId = @newSpellLevelsId, SpellTargetRestrictionsId = @newSpellTargetRestrictionsId, SpellInterruptsId = @newSpellInterruptsId, Comment = @newComment WHERE Id = @Id AND Attributes = @Attributes AND AttributesEx = @AttributesEx AND AttributesEx2 = @AttributesEx2 AND AttributesEx3 = @AttributesEx3 AND AttributesEx4 = @AttributesEx4 AND AttributesEx5 = @AttributesEx5 AND AttributesEx6 = @AttributesEx6 AND AttributesEx7 = @AttributesEx7 AND AttributesEx8 = @AttributesEx8 AND AttributesEx9 = @AttributesEx9 AND AttributesEx10 = @AttributesEx10 AND CastingTimeIndex = @CastingTimeIndex AND DurationIndex = @DurationIndex AND RangeIndex = @RangeIndex AND SchoolMask = @SchoolMask AND SpellAuraOptionsId = @SpellAuraOptionsId AND SpellCastingRequirementsId = @SpellCastingRequirementsId AND SpellCategoriesId = @SpellCategoriesId AND SpellClassOptionsId = @SpellClassOptionsId AND SpellEquippedItemsId = @SpellEquippedItemsId AND SpellLevelsId = @SpellLevelsId AND SpellTargetRestrictionsId = @SpellTargetRestrictionsId AND SpellInterruptsId = @SpellInterruptsId AND Comment = @Comment;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@Id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_attributesParameter = new MySqlParameter("@Attributes", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_attributesexParameter = new MySqlParameter("@AttributesEx", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_attributesex2Parameter = new MySqlParameter("@AttributesEx2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_attributesex3Parameter = new MySqlParameter("@AttributesEx3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_attributesex4Parameter = new MySqlParameter("@AttributesEx4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_attributesex5Parameter = new MySqlParameter("@AttributesEx5", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_attributesex6Parameter = new MySqlParameter("@AttributesEx6", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_attributesex7Parameter = new MySqlParameter("@AttributesEx7", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_attributesex8Parameter = new MySqlParameter("@AttributesEx8", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_attributesex9Parameter = new MySqlParameter("@AttributesEx9", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_attributesex10Parameter = new MySqlParameter("@AttributesEx10", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_castingtimeindexParameter = new MySqlParameter("@CastingTimeIndex", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_durationindexParameter = new MySqlParameter("@DurationIndex", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rangeindexParameter = new MySqlParameter("@RangeIndex", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_schoolmaskParameter = new MySqlParameter("@SchoolMask", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spellauraoptionsidParameter = new MySqlParameter("@SpellAuraOptionsId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spellcastingrequirementsidParameter = new MySqlParameter("@SpellCastingRequirementsId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spellcategoriesidParameter = new MySqlParameter("@SpellCategoriesId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spellclassoptionsidParameter = new MySqlParameter("@SpellClassOptionsId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spellequippeditemsidParameter = new MySqlParameter("@SpellEquippedItemsId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spelllevelsidParameter = new MySqlParameter("@SpellLevelsId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spelltargetrestrictionsidParameter = new MySqlParameter("@SpellTargetRestrictionsId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spellinterruptsidParameter = new MySqlParameter("@SpellInterruptsId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_commentParameter = new MySqlParameter("@Comment", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newId", MySqlDbType.VarChar, 0);
			MySqlParameter attributesParameter = new MySqlParameter("@newAttributes", MySqlDbType.VarChar, 0);
			MySqlParameter attributesexParameter = new MySqlParameter("@newAttributesEx", MySqlDbType.VarChar, 0);
			MySqlParameter attributesex2Parameter = new MySqlParameter("@newAttributesEx2", MySqlDbType.VarChar, 0);
			MySqlParameter attributesex3Parameter = new MySqlParameter("@newAttributesEx3", MySqlDbType.VarChar, 0);
			MySqlParameter attributesex4Parameter = new MySqlParameter("@newAttributesEx4", MySqlDbType.VarChar, 0);
			MySqlParameter attributesex5Parameter = new MySqlParameter("@newAttributesEx5", MySqlDbType.VarChar, 0);
			MySqlParameter attributesex6Parameter = new MySqlParameter("@newAttributesEx6", MySqlDbType.VarChar, 0);
			MySqlParameter attributesex7Parameter = new MySqlParameter("@newAttributesEx7", MySqlDbType.VarChar, 0);
			MySqlParameter attributesex8Parameter = new MySqlParameter("@newAttributesEx8", MySqlDbType.VarChar, 0);
			MySqlParameter attributesex9Parameter = new MySqlParameter("@newAttributesEx9", MySqlDbType.VarChar, 0);
			MySqlParameter attributesex10Parameter = new MySqlParameter("@newAttributesEx10", MySqlDbType.VarChar, 0);
			MySqlParameter castingtimeindexParameter = new MySqlParameter("@newCastingTimeIndex", MySqlDbType.VarChar, 0);
			MySqlParameter durationindexParameter = new MySqlParameter("@newDurationIndex", MySqlDbType.VarChar, 0);
			MySqlParameter rangeindexParameter = new MySqlParameter("@newRangeIndex", MySqlDbType.VarChar, 0);
			MySqlParameter schoolmaskParameter = new MySqlParameter("@newSchoolMask", MySqlDbType.VarChar, 0);
			MySqlParameter spellauraoptionsidParameter = new MySqlParameter("@newSpellAuraOptionsId", MySqlDbType.VarChar, 0);
			MySqlParameter spellcastingrequirementsidParameter = new MySqlParameter("@newSpellCastingRequirementsId", MySqlDbType.VarChar, 0);
			MySqlParameter spellcategoriesidParameter = new MySqlParameter("@newSpellCategoriesId", MySqlDbType.VarChar, 0);
			MySqlParameter spellclassoptionsidParameter = new MySqlParameter("@newSpellClassOptionsId", MySqlDbType.VarChar, 0);
			MySqlParameter spellequippeditemsidParameter = new MySqlParameter("@newSpellEquippedItemsId", MySqlDbType.VarChar, 0);
			MySqlParameter spelllevelsidParameter = new MySqlParameter("@newSpellLevelsId", MySqlDbType.VarChar, 0);
			MySqlParameter spelltargetrestrictionsidParameter = new MySqlParameter("@newSpellTargetRestrictionsId", MySqlDbType.VarChar, 0);
			MySqlParameter spellinterruptsidParameter = new MySqlParameter("@newSpellInterruptsId", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@newComment", MySqlDbType.VarChar, 0);
			idParameter.Value = Id;
			attributesParameter.Value = Attributes;
			attributesexParameter.Value = AttributesEx;
			attributesex2Parameter.Value = AttributesEx2;
			attributesex3Parameter.Value = AttributesEx3;
			attributesex4Parameter.Value = AttributesEx4;
			attributesex5Parameter.Value = AttributesEx5;
			attributesex6Parameter.Value = AttributesEx6;
			attributesex7Parameter.Value = AttributesEx7;
			attributesex8Parameter.Value = AttributesEx8;
			attributesex9Parameter.Value = AttributesEx9;
			attributesex10Parameter.Value = AttributesEx10;
			castingtimeindexParameter.Value = CastingTimeIndex;
			durationindexParameter.Value = DurationIndex;
			rangeindexParameter.Value = RangeIndex;
			schoolmaskParameter.Value = SchoolMask;
			spellauraoptionsidParameter.Value = SpellAuraOptionsId;
			spellcastingrequirementsidParameter.Value = SpellCastingRequirementsId;
			spellcategoriesidParameter.Value = SpellCategoriesId;
			spellclassoptionsidParameter.Value = SpellClassOptionsId;
			spellequippeditemsidParameter.Value = SpellEquippedItemsId;
			spelllevelsidParameter.Value = SpellLevelsId;
			spelltargetrestrictionsidParameter.Value = SpellTargetRestrictionsId;
			spellinterruptsidParameter.Value = SpellInterruptsId;
			commentParameter.Value = Comment;
			OLD_idParameter.Value = OLD_Id;
			OLD_attributesParameter.Value = OLD_Attributes;
			OLD_attributesexParameter.Value = OLD_AttributesEx;
			OLD_attributesex2Parameter.Value = OLD_AttributesEx2;
			OLD_attributesex3Parameter.Value = OLD_AttributesEx3;
			OLD_attributesex4Parameter.Value = OLD_AttributesEx4;
			OLD_attributesex5Parameter.Value = OLD_AttributesEx5;
			OLD_attributesex6Parameter.Value = OLD_AttributesEx6;
			OLD_attributesex7Parameter.Value = OLD_AttributesEx7;
			OLD_attributesex8Parameter.Value = OLD_AttributesEx8;
			OLD_attributesex9Parameter.Value = OLD_AttributesEx9;
			OLD_attributesex10Parameter.Value = OLD_AttributesEx10;
			OLD_castingtimeindexParameter.Value = OLD_CastingTimeIndex;
			OLD_durationindexParameter.Value = OLD_DurationIndex;
			OLD_rangeindexParameter.Value = OLD_RangeIndex;
			OLD_schoolmaskParameter.Value = OLD_SchoolMask;
			OLD_spellauraoptionsidParameter.Value = OLD_SpellAuraOptionsId;
			OLD_spellcastingrequirementsidParameter.Value = OLD_SpellCastingRequirementsId;
			OLD_spellcategoriesidParameter.Value = OLD_SpellCategoriesId;
			OLD_spellclassoptionsidParameter.Value = OLD_SpellClassOptionsId;
			OLD_spellequippeditemsidParameter.Value = OLD_SpellEquippedItemsId;
			OLD_spelllevelsidParameter.Value = OLD_SpellLevelsId;
			OLD_spelltargetrestrictionsidParameter.Value = OLD_SpellTargetRestrictionsId;
			OLD_spellinterruptsidParameter.Value = OLD_SpellInterruptsId;
			OLD_commentParameter.Value = OLD_Comment;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(attributesParameter);
			cmd.Parameters.Add(attributesexParameter);
			cmd.Parameters.Add(attributesex2Parameter);
			cmd.Parameters.Add(attributesex3Parameter);
			cmd.Parameters.Add(attributesex4Parameter);
			cmd.Parameters.Add(attributesex5Parameter);
			cmd.Parameters.Add(attributesex6Parameter);
			cmd.Parameters.Add(attributesex7Parameter);
			cmd.Parameters.Add(attributesex8Parameter);
			cmd.Parameters.Add(attributesex9Parameter);
			cmd.Parameters.Add(attributesex10Parameter);
			cmd.Parameters.Add(castingtimeindexParameter);
			cmd.Parameters.Add(durationindexParameter);
			cmd.Parameters.Add(rangeindexParameter);
			cmd.Parameters.Add(schoolmaskParameter);
			cmd.Parameters.Add(spellauraoptionsidParameter);
			cmd.Parameters.Add(spellcastingrequirementsidParameter);
			cmd.Parameters.Add(spellcategoriesidParameter);
			cmd.Parameters.Add(spellclassoptionsidParameter);
			cmd.Parameters.Add(spellequippeditemsidParameter);
			cmd.Parameters.Add(spelllevelsidParameter);
			cmd.Parameters.Add(spelltargetrestrictionsidParameter);
			cmd.Parameters.Add(spellinterruptsidParameter);
			cmd.Parameters.Add(commentParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_attributesParameter);
			cmd.Parameters.Add(OLD_attributesexParameter);
			cmd.Parameters.Add(OLD_attributesex2Parameter);
			cmd.Parameters.Add(OLD_attributesex3Parameter);
			cmd.Parameters.Add(OLD_attributesex4Parameter);
			cmd.Parameters.Add(OLD_attributesex5Parameter);
			cmd.Parameters.Add(OLD_attributesex6Parameter);
			cmd.Parameters.Add(OLD_attributesex7Parameter);
			cmd.Parameters.Add(OLD_attributesex8Parameter);
			cmd.Parameters.Add(OLD_attributesex9Parameter);
			cmd.Parameters.Add(OLD_attributesex10Parameter);
			cmd.Parameters.Add(OLD_castingtimeindexParameter);
			cmd.Parameters.Add(OLD_durationindexParameter);
			cmd.Parameters.Add(OLD_rangeindexParameter);
			cmd.Parameters.Add(OLD_schoolmaskParameter);
			cmd.Parameters.Add(OLD_spellauraoptionsidParameter);
			cmd.Parameters.Add(OLD_spellcastingrequirementsidParameter);
			cmd.Parameters.Add(OLD_spellcategoriesidParameter);
			cmd.Parameters.Add(OLD_spellclassoptionsidParameter);
			cmd.Parameters.Add(OLD_spellequippeditemsidParameter);
			cmd.Parameters.Add(OLD_spelllevelsidParameter);
			cmd.Parameters.Add(OLD_spelltargetrestrictionsidParameter);
			cmd.Parameters.Add(OLD_spellinterruptsidParameter);
			cmd.Parameters.Add(OLD_commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_Id = Id;
			OLD_Attributes = Attributes;
			OLD_AttributesEx = AttributesEx;
			OLD_AttributesEx2 = AttributesEx2;
			OLD_AttributesEx3 = AttributesEx3;
			OLD_AttributesEx4 = AttributesEx4;
			OLD_AttributesEx5 = AttributesEx5;
			OLD_AttributesEx6 = AttributesEx6;
			OLD_AttributesEx7 = AttributesEx7;
			OLD_AttributesEx8 = AttributesEx8;
			OLD_AttributesEx9 = AttributesEx9;
			OLD_AttributesEx10 = AttributesEx10;
			OLD_CastingTimeIndex = CastingTimeIndex;
			OLD_DurationIndex = DurationIndex;
			OLD_RangeIndex = RangeIndex;
			OLD_SchoolMask = SchoolMask;
			OLD_SpellAuraOptionsId = SpellAuraOptionsId;
			OLD_SpellCastingRequirementsId = SpellCastingRequirementsId;
			OLD_SpellCategoriesId = SpellCategoriesId;
			OLD_SpellClassOptionsId = SpellClassOptionsId;
			OLD_SpellEquippedItemsId = SpellEquippedItemsId;
			OLD_SpellLevelsId = SpellLevelsId;
			OLD_SpellTargetRestrictionsId = SpellTargetRestrictionsId;
			OLD_SpellInterruptsId = SpellInterruptsId;
			OLD_Comment = Comment;
		}
	}
}
