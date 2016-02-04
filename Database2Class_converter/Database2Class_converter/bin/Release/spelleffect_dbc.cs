using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Spelleffect_dbc
	{
		int Id = 0; //Comment: 
		int OLD_Id = 0;

		int Effect = 0; //Comment: 
		int OLD_Effect = 0;

		float EffectValueMultiplier = 0f; //Comment: 
		float OLD_EffectValueMultiplier = 0f;

		int EffectApplyAuraName = 0; //Comment: 
		int OLD_EffectApplyAuraName = 0;

		int EffectAmplitude = 0; //Comment: 
		int OLD_EffectAmplitude = 0;

		int EffectBasePoints = 0; //Comment: 
		int OLD_EffectBasePoints = 0;

		float EffectBonusMultiplier = 0f; //Comment: 
		float OLD_EffectBonusMultiplier = 0f;

		float EffectDamageMultiplier = 0f; //Comment: 
		float OLD_EffectDamageMultiplier = 0f;

		int EffectChainTarget = 0; //Comment: 
		int OLD_EffectChainTarget = 0;

		int EffectDieSides = 0; //Comment: 
		int OLD_EffectDieSides = 0;

		int EffectItemType = 0; //Comment: 
		int OLD_EffectItemType = 0;

		int EffectMechanic = 0; //Comment: 
		int OLD_EffectMechanic = 0;

		int EffectMiscValue = 0; //Comment: 
		int OLD_EffectMiscValue = 0;

		int EffectMiscValueB = 0; //Comment: 
		int OLD_EffectMiscValueB = 0;

		int EffectRadiusIndex = 0; //Comment: 
		int OLD_EffectRadiusIndex = 0;

		int EffectRadiusIndexMax = 0; //Comment: 
		int OLD_EffectRadiusIndexMax = 0;

		float EffectRealPointsPerLevel = 0f; //Comment: 
		float OLD_EffectRealPointsPerLevel = 0f;

		int EffectSpellClassMaskA = 0; //Comment: 
		int OLD_EffectSpellClassMaskA = 0;

		int EffectSpellClassMaskB = 0; //Comment: 
		int OLD_EffectSpellClassMaskB = 0;

		int EffectSpellClassMaskC = 0; //Comment: 
		int OLD_EffectSpellClassMaskC = 0;

		int EffectTriggerSpell = 0; //Comment: 
		int OLD_EffectTriggerSpell = 0;

		int EffectImplicitTargetA = 0; //Comment: 
		int OLD_EffectImplicitTargetA = 0;

		int EffectImplicitTargetB = 0; //Comment: 
		int OLD_EffectImplicitTargetB = 0;

		int EffectSpellId = 0; //Comment: 
		int OLD_EffectSpellId = 0;

		int EffectIndex = 0; //Comment: 
		int OLD_EffectIndex = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Spelleffect_dbc(int _Id, int _Effect, float _EffectValueMultiplier, int _EffectApplyAuraName, int _EffectAmplitude, int _EffectBasePoints, float _EffectBonusMultiplier, float _EffectDamageMultiplier, int _EffectChainTarget, int _EffectDieSides, int _EffectItemType, int _EffectMechanic, int _EffectMiscValue, int _EffectMiscValueB, int _EffectRadiusIndex, int _EffectRadiusIndexMax, float _EffectRealPointsPerLevel, int _EffectSpellClassMaskA, int _EffectSpellClassMaskB, int _EffectSpellClassMaskC, int _EffectTriggerSpell, int _EffectImplicitTargetA, int _EffectImplicitTargetB, int _EffectSpellId, int _EffectIndex)
		{
			Id = _Id;
			Effect = _Effect;
			EffectValueMultiplier = _EffectValueMultiplier;
			EffectApplyAuraName = _EffectApplyAuraName;
			EffectAmplitude = _EffectAmplitude;
			EffectBasePoints = _EffectBasePoints;
			EffectBonusMultiplier = _EffectBonusMultiplier;
			EffectDamageMultiplier = _EffectDamageMultiplier;
			EffectChainTarget = _EffectChainTarget;
			EffectDieSides = _EffectDieSides;
			EffectItemType = _EffectItemType;
			EffectMechanic = _EffectMechanic;
			EffectMiscValue = _EffectMiscValue;
			EffectMiscValueB = _EffectMiscValueB;
			EffectRadiusIndex = _EffectRadiusIndex;
			EffectRadiusIndexMax = _EffectRadiusIndexMax;
			EffectRealPointsPerLevel = _EffectRealPointsPerLevel;
			EffectSpellClassMaskA = _EffectSpellClassMaskA;
			EffectSpellClassMaskB = _EffectSpellClassMaskB;
			EffectSpellClassMaskC = _EffectSpellClassMaskC;
			EffectTriggerSpell = _EffectTriggerSpell;
			EffectImplicitTargetA = _EffectImplicitTargetA;
			EffectImplicitTargetB = _EffectImplicitTargetB;
			EffectSpellId = _EffectSpellId;
			EffectIndex = _EffectIndex;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM spelleffect_dbc WHERE Id = @Id AND Effect = @Effect AND EffectValueMultiplier = @EffectValueMultiplier AND EffectApplyAuraName = @EffectApplyAuraName AND EffectAmplitude = @EffectAmplitude AND EffectBasePoints = @EffectBasePoints AND EffectBonusMultiplier = @EffectBonusMultiplier AND EffectDamageMultiplier = @EffectDamageMultiplier AND EffectChainTarget = @EffectChainTarget AND EffectDieSides = @EffectDieSides AND EffectItemType = @EffectItemType AND EffectMechanic = @EffectMechanic AND EffectMiscValue = @EffectMiscValue AND EffectMiscValueB = @EffectMiscValueB AND EffectRadiusIndex = @EffectRadiusIndex AND EffectRadiusIndexMax = @EffectRadiusIndexMax AND EffectRealPointsPerLevel = @EffectRealPointsPerLevel AND EffectSpellClassMaskA = @EffectSpellClassMaskA AND EffectSpellClassMaskB = @EffectSpellClassMaskB AND EffectSpellClassMaskC = @EffectSpellClassMaskC AND EffectTriggerSpell = @EffectTriggerSpell AND EffectImplicitTargetA = @EffectImplicitTargetA AND EffectImplicitTargetB = @EffectImplicitTargetB AND EffectSpellId = @EffectSpellId AND EffectIndex = @EffectIndex;";
			MySqlParameter idParameter = new MySqlParameter("@Id", MySqlDbType.VarChar, 0);
			MySqlParameter effectParameter = new MySqlParameter("@Effect", MySqlDbType.VarChar, 0);
			MySqlParameter effectvaluemultiplierParameter = new MySqlParameter("@EffectValueMultiplier", MySqlDbType.VarChar, 0);
			MySqlParameter effectapplyauranameParameter = new MySqlParameter("@EffectApplyAuraName", MySqlDbType.VarChar, 0);
			MySqlParameter effectamplitudeParameter = new MySqlParameter("@EffectAmplitude", MySqlDbType.VarChar, 0);
			MySqlParameter effectbasepointsParameter = new MySqlParameter("@EffectBasePoints", MySqlDbType.VarChar, 0);
			MySqlParameter effectbonusmultiplierParameter = new MySqlParameter("@EffectBonusMultiplier", MySqlDbType.VarChar, 0);
			MySqlParameter effectdamagemultiplierParameter = new MySqlParameter("@EffectDamageMultiplier", MySqlDbType.VarChar, 0);
			MySqlParameter effectchaintargetParameter = new MySqlParameter("@EffectChainTarget", MySqlDbType.VarChar, 0);
			MySqlParameter effectdiesidesParameter = new MySqlParameter("@EffectDieSides", MySqlDbType.VarChar, 0);
			MySqlParameter effectitemtypeParameter = new MySqlParameter("@EffectItemType", MySqlDbType.VarChar, 0);
			MySqlParameter effectmechanicParameter = new MySqlParameter("@EffectMechanic", MySqlDbType.VarChar, 0);
			MySqlParameter effectmiscvalueParameter = new MySqlParameter("@EffectMiscValue", MySqlDbType.VarChar, 0);
			MySqlParameter effectmiscvaluebParameter = new MySqlParameter("@EffectMiscValueB", MySqlDbType.VarChar, 0);
			MySqlParameter effectradiusindexParameter = new MySqlParameter("@EffectRadiusIndex", MySqlDbType.VarChar, 0);
			MySqlParameter effectradiusindexmaxParameter = new MySqlParameter("@EffectRadiusIndexMax", MySqlDbType.VarChar, 0);
			MySqlParameter effectrealpointsperlevelParameter = new MySqlParameter("@EffectRealPointsPerLevel", MySqlDbType.VarChar, 0);
			MySqlParameter effectspellclassmaskaParameter = new MySqlParameter("@EffectSpellClassMaskA", MySqlDbType.VarChar, 0);
			MySqlParameter effectspellclassmaskbParameter = new MySqlParameter("@EffectSpellClassMaskB", MySqlDbType.VarChar, 0);
			MySqlParameter effectspellclassmaskcParameter = new MySqlParameter("@EffectSpellClassMaskC", MySqlDbType.VarChar, 0);
			MySqlParameter effecttriggerspellParameter = new MySqlParameter("@EffectTriggerSpell", MySqlDbType.VarChar, 0);
			MySqlParameter effectimplicittargetaParameter = new MySqlParameter("@EffectImplicitTargetA", MySqlDbType.VarChar, 0);
			MySqlParameter effectimplicittargetbParameter = new MySqlParameter("@EffectImplicitTargetB", MySqlDbType.VarChar, 0);
			MySqlParameter effectspellidParameter = new MySqlParameter("@EffectSpellId", MySqlDbType.VarChar, 0);
			MySqlParameter effectindexParameter = new MySqlParameter("@EffectIndex", MySqlDbType.VarChar, 0);
			idParameter.Value = Id;
			effectParameter.Value = Effect;
			effectvaluemultiplierParameter.Value = EffectValueMultiplier;
			effectapplyauranameParameter.Value = EffectApplyAuraName;
			effectamplitudeParameter.Value = EffectAmplitude;
			effectbasepointsParameter.Value = EffectBasePoints;
			effectbonusmultiplierParameter.Value = EffectBonusMultiplier;
			effectdamagemultiplierParameter.Value = EffectDamageMultiplier;
			effectchaintargetParameter.Value = EffectChainTarget;
			effectdiesidesParameter.Value = EffectDieSides;
			effectitemtypeParameter.Value = EffectItemType;
			effectmechanicParameter.Value = EffectMechanic;
			effectmiscvalueParameter.Value = EffectMiscValue;
			effectmiscvaluebParameter.Value = EffectMiscValueB;
			effectradiusindexParameter.Value = EffectRadiusIndex;
			effectradiusindexmaxParameter.Value = EffectRadiusIndexMax;
			effectrealpointsperlevelParameter.Value = EffectRealPointsPerLevel;
			effectspellclassmaskaParameter.Value = EffectSpellClassMaskA;
			effectspellclassmaskbParameter.Value = EffectSpellClassMaskB;
			effectspellclassmaskcParameter.Value = EffectSpellClassMaskC;
			effecttriggerspellParameter.Value = EffectTriggerSpell;
			effectimplicittargetaParameter.Value = EffectImplicitTargetA;
			effectimplicittargetbParameter.Value = EffectImplicitTargetB;
			effectspellidParameter.Value = EffectSpellId;
			effectindexParameter.Value = EffectIndex;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(effectParameter);
			cmd.Parameters.Add(effectvaluemultiplierParameter);
			cmd.Parameters.Add(effectapplyauranameParameter);
			cmd.Parameters.Add(effectamplitudeParameter);
			cmd.Parameters.Add(effectbasepointsParameter);
			cmd.Parameters.Add(effectbonusmultiplierParameter);
			cmd.Parameters.Add(effectdamagemultiplierParameter);
			cmd.Parameters.Add(effectchaintargetParameter);
			cmd.Parameters.Add(effectdiesidesParameter);
			cmd.Parameters.Add(effectitemtypeParameter);
			cmd.Parameters.Add(effectmechanicParameter);
			cmd.Parameters.Add(effectmiscvalueParameter);
			cmd.Parameters.Add(effectmiscvaluebParameter);
			cmd.Parameters.Add(effectradiusindexParameter);
			cmd.Parameters.Add(effectradiusindexmaxParameter);
			cmd.Parameters.Add(effectrealpointsperlevelParameter);
			cmd.Parameters.Add(effectspellclassmaskaParameter);
			cmd.Parameters.Add(effectspellclassmaskbParameter);
			cmd.Parameters.Add(effectspellclassmaskcParameter);
			cmd.Parameters.Add(effecttriggerspellParameter);
			cmd.Parameters.Add(effectimplicittargetaParameter);
			cmd.Parameters.Add(effectimplicittargetbParameter);
			cmd.Parameters.Add(effectspellidParameter);
			cmd.Parameters.Add(effectindexParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE spelleffect_dbc SET Id = @newId, Effect = @newEffect, EffectValueMultiplier = @newEffectValueMultiplier, EffectApplyAuraName = @newEffectApplyAuraName, EffectAmplitude = @newEffectAmplitude, EffectBasePoints = @newEffectBasePoints, EffectBonusMultiplier = @newEffectBonusMultiplier, EffectDamageMultiplier = @newEffectDamageMultiplier, EffectChainTarget = @newEffectChainTarget, EffectDieSides = @newEffectDieSides, EffectItemType = @newEffectItemType, EffectMechanic = @newEffectMechanic, EffectMiscValue = @newEffectMiscValue, EffectMiscValueB = @newEffectMiscValueB, EffectRadiusIndex = @newEffectRadiusIndex, EffectRadiusIndexMax = @newEffectRadiusIndexMax, EffectRealPointsPerLevel = @newEffectRealPointsPerLevel, EffectSpellClassMaskA = @newEffectSpellClassMaskA, EffectSpellClassMaskB = @newEffectSpellClassMaskB, EffectSpellClassMaskC = @newEffectSpellClassMaskC, EffectTriggerSpell = @newEffectTriggerSpell, EffectImplicitTargetA = @newEffectImplicitTargetA, EffectImplicitTargetB = @newEffectImplicitTargetB, EffectSpellId = @newEffectSpellId, EffectIndex = @newEffectIndex WHERE Id = @Id AND Effect = @Effect AND EffectValueMultiplier = @EffectValueMultiplier AND EffectApplyAuraName = @EffectApplyAuraName AND EffectAmplitude = @EffectAmplitude AND EffectBasePoints = @EffectBasePoints AND EffectBonusMultiplier = @EffectBonusMultiplier AND EffectDamageMultiplier = @EffectDamageMultiplier AND EffectChainTarget = @EffectChainTarget AND EffectDieSides = @EffectDieSides AND EffectItemType = @EffectItemType AND EffectMechanic = @EffectMechanic AND EffectMiscValue = @EffectMiscValue AND EffectMiscValueB = @EffectMiscValueB AND EffectRadiusIndex = @EffectRadiusIndex AND EffectRadiusIndexMax = @EffectRadiusIndexMax AND EffectRealPointsPerLevel = @EffectRealPointsPerLevel AND EffectSpellClassMaskA = @EffectSpellClassMaskA AND EffectSpellClassMaskB = @EffectSpellClassMaskB AND EffectSpellClassMaskC = @EffectSpellClassMaskC AND EffectTriggerSpell = @EffectTriggerSpell AND EffectImplicitTargetA = @EffectImplicitTargetA AND EffectImplicitTargetB = @EffectImplicitTargetB AND EffectSpellId = @EffectSpellId AND EffectIndex = @EffectIndex;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@Id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_effectParameter = new MySqlParameter("@Effect", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_effectvaluemultiplierParameter = new MySqlParameter("@EffectValueMultiplier", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_effectapplyauranameParameter = new MySqlParameter("@EffectApplyAuraName", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_effectamplitudeParameter = new MySqlParameter("@EffectAmplitude", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_effectbasepointsParameter = new MySqlParameter("@EffectBasePoints", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_effectbonusmultiplierParameter = new MySqlParameter("@EffectBonusMultiplier", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_effectdamagemultiplierParameter = new MySqlParameter("@EffectDamageMultiplier", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_effectchaintargetParameter = new MySqlParameter("@EffectChainTarget", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_effectdiesidesParameter = new MySqlParameter("@EffectDieSides", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_effectitemtypeParameter = new MySqlParameter("@EffectItemType", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_effectmechanicParameter = new MySqlParameter("@EffectMechanic", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_effectmiscvalueParameter = new MySqlParameter("@EffectMiscValue", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_effectmiscvaluebParameter = new MySqlParameter("@EffectMiscValueB", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_effectradiusindexParameter = new MySqlParameter("@EffectRadiusIndex", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_effectradiusindexmaxParameter = new MySqlParameter("@EffectRadiusIndexMax", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_effectrealpointsperlevelParameter = new MySqlParameter("@EffectRealPointsPerLevel", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_effectspellclassmaskaParameter = new MySqlParameter("@EffectSpellClassMaskA", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_effectspellclassmaskbParameter = new MySqlParameter("@EffectSpellClassMaskB", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_effectspellclassmaskcParameter = new MySqlParameter("@EffectSpellClassMaskC", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_effecttriggerspellParameter = new MySqlParameter("@EffectTriggerSpell", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_effectimplicittargetaParameter = new MySqlParameter("@EffectImplicitTargetA", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_effectimplicittargetbParameter = new MySqlParameter("@EffectImplicitTargetB", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_effectspellidParameter = new MySqlParameter("@EffectSpellId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_effectindexParameter = new MySqlParameter("@EffectIndex", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newId", MySqlDbType.VarChar, 0);
			MySqlParameter effectParameter = new MySqlParameter("@newEffect", MySqlDbType.VarChar, 0);
			MySqlParameter effectvaluemultiplierParameter = new MySqlParameter("@newEffectValueMultiplier", MySqlDbType.VarChar, 0);
			MySqlParameter effectapplyauranameParameter = new MySqlParameter("@newEffectApplyAuraName", MySqlDbType.VarChar, 0);
			MySqlParameter effectamplitudeParameter = new MySqlParameter("@newEffectAmplitude", MySqlDbType.VarChar, 0);
			MySqlParameter effectbasepointsParameter = new MySqlParameter("@newEffectBasePoints", MySqlDbType.VarChar, 0);
			MySqlParameter effectbonusmultiplierParameter = new MySqlParameter("@newEffectBonusMultiplier", MySqlDbType.VarChar, 0);
			MySqlParameter effectdamagemultiplierParameter = new MySqlParameter("@newEffectDamageMultiplier", MySqlDbType.VarChar, 0);
			MySqlParameter effectchaintargetParameter = new MySqlParameter("@newEffectChainTarget", MySqlDbType.VarChar, 0);
			MySqlParameter effectdiesidesParameter = new MySqlParameter("@newEffectDieSides", MySqlDbType.VarChar, 0);
			MySqlParameter effectitemtypeParameter = new MySqlParameter("@newEffectItemType", MySqlDbType.VarChar, 0);
			MySqlParameter effectmechanicParameter = new MySqlParameter("@newEffectMechanic", MySqlDbType.VarChar, 0);
			MySqlParameter effectmiscvalueParameter = new MySqlParameter("@newEffectMiscValue", MySqlDbType.VarChar, 0);
			MySqlParameter effectmiscvaluebParameter = new MySqlParameter("@newEffectMiscValueB", MySqlDbType.VarChar, 0);
			MySqlParameter effectradiusindexParameter = new MySqlParameter("@newEffectRadiusIndex", MySqlDbType.VarChar, 0);
			MySqlParameter effectradiusindexmaxParameter = new MySqlParameter("@newEffectRadiusIndexMax", MySqlDbType.VarChar, 0);
			MySqlParameter effectrealpointsperlevelParameter = new MySqlParameter("@newEffectRealPointsPerLevel", MySqlDbType.VarChar, 0);
			MySqlParameter effectspellclassmaskaParameter = new MySqlParameter("@newEffectSpellClassMaskA", MySqlDbType.VarChar, 0);
			MySqlParameter effectspellclassmaskbParameter = new MySqlParameter("@newEffectSpellClassMaskB", MySqlDbType.VarChar, 0);
			MySqlParameter effectspellclassmaskcParameter = new MySqlParameter("@newEffectSpellClassMaskC", MySqlDbType.VarChar, 0);
			MySqlParameter effecttriggerspellParameter = new MySqlParameter("@newEffectTriggerSpell", MySqlDbType.VarChar, 0);
			MySqlParameter effectimplicittargetaParameter = new MySqlParameter("@newEffectImplicitTargetA", MySqlDbType.VarChar, 0);
			MySqlParameter effectimplicittargetbParameter = new MySqlParameter("@newEffectImplicitTargetB", MySqlDbType.VarChar, 0);
			MySqlParameter effectspellidParameter = new MySqlParameter("@newEffectSpellId", MySqlDbType.VarChar, 0);
			MySqlParameter effectindexParameter = new MySqlParameter("@newEffectIndex", MySqlDbType.VarChar, 0);
			idParameter.Value = Id;
			effectParameter.Value = Effect;
			effectvaluemultiplierParameter.Value = EffectValueMultiplier;
			effectapplyauranameParameter.Value = EffectApplyAuraName;
			effectamplitudeParameter.Value = EffectAmplitude;
			effectbasepointsParameter.Value = EffectBasePoints;
			effectbonusmultiplierParameter.Value = EffectBonusMultiplier;
			effectdamagemultiplierParameter.Value = EffectDamageMultiplier;
			effectchaintargetParameter.Value = EffectChainTarget;
			effectdiesidesParameter.Value = EffectDieSides;
			effectitemtypeParameter.Value = EffectItemType;
			effectmechanicParameter.Value = EffectMechanic;
			effectmiscvalueParameter.Value = EffectMiscValue;
			effectmiscvaluebParameter.Value = EffectMiscValueB;
			effectradiusindexParameter.Value = EffectRadiusIndex;
			effectradiusindexmaxParameter.Value = EffectRadiusIndexMax;
			effectrealpointsperlevelParameter.Value = EffectRealPointsPerLevel;
			effectspellclassmaskaParameter.Value = EffectSpellClassMaskA;
			effectspellclassmaskbParameter.Value = EffectSpellClassMaskB;
			effectspellclassmaskcParameter.Value = EffectSpellClassMaskC;
			effecttriggerspellParameter.Value = EffectTriggerSpell;
			effectimplicittargetaParameter.Value = EffectImplicitTargetA;
			effectimplicittargetbParameter.Value = EffectImplicitTargetB;
			effectspellidParameter.Value = EffectSpellId;
			effectindexParameter.Value = EffectIndex;
			OLD_idParameter.Value = OLD_Id;
			OLD_effectParameter.Value = OLD_Effect;
			OLD_effectvaluemultiplierParameter.Value = OLD_EffectValueMultiplier;
			OLD_effectapplyauranameParameter.Value = OLD_EffectApplyAuraName;
			OLD_effectamplitudeParameter.Value = OLD_EffectAmplitude;
			OLD_effectbasepointsParameter.Value = OLD_EffectBasePoints;
			OLD_effectbonusmultiplierParameter.Value = OLD_EffectBonusMultiplier;
			OLD_effectdamagemultiplierParameter.Value = OLD_EffectDamageMultiplier;
			OLD_effectchaintargetParameter.Value = OLD_EffectChainTarget;
			OLD_effectdiesidesParameter.Value = OLD_EffectDieSides;
			OLD_effectitemtypeParameter.Value = OLD_EffectItemType;
			OLD_effectmechanicParameter.Value = OLD_EffectMechanic;
			OLD_effectmiscvalueParameter.Value = OLD_EffectMiscValue;
			OLD_effectmiscvaluebParameter.Value = OLD_EffectMiscValueB;
			OLD_effectradiusindexParameter.Value = OLD_EffectRadiusIndex;
			OLD_effectradiusindexmaxParameter.Value = OLD_EffectRadiusIndexMax;
			OLD_effectrealpointsperlevelParameter.Value = OLD_EffectRealPointsPerLevel;
			OLD_effectspellclassmaskaParameter.Value = OLD_EffectSpellClassMaskA;
			OLD_effectspellclassmaskbParameter.Value = OLD_EffectSpellClassMaskB;
			OLD_effectspellclassmaskcParameter.Value = OLD_EffectSpellClassMaskC;
			OLD_effecttriggerspellParameter.Value = OLD_EffectTriggerSpell;
			OLD_effectimplicittargetaParameter.Value = OLD_EffectImplicitTargetA;
			OLD_effectimplicittargetbParameter.Value = OLD_EffectImplicitTargetB;
			OLD_effectspellidParameter.Value = OLD_EffectSpellId;
			OLD_effectindexParameter.Value = OLD_EffectIndex;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(effectParameter);
			cmd.Parameters.Add(effectvaluemultiplierParameter);
			cmd.Parameters.Add(effectapplyauranameParameter);
			cmd.Parameters.Add(effectamplitudeParameter);
			cmd.Parameters.Add(effectbasepointsParameter);
			cmd.Parameters.Add(effectbonusmultiplierParameter);
			cmd.Parameters.Add(effectdamagemultiplierParameter);
			cmd.Parameters.Add(effectchaintargetParameter);
			cmd.Parameters.Add(effectdiesidesParameter);
			cmd.Parameters.Add(effectitemtypeParameter);
			cmd.Parameters.Add(effectmechanicParameter);
			cmd.Parameters.Add(effectmiscvalueParameter);
			cmd.Parameters.Add(effectmiscvaluebParameter);
			cmd.Parameters.Add(effectradiusindexParameter);
			cmd.Parameters.Add(effectradiusindexmaxParameter);
			cmd.Parameters.Add(effectrealpointsperlevelParameter);
			cmd.Parameters.Add(effectspellclassmaskaParameter);
			cmd.Parameters.Add(effectspellclassmaskbParameter);
			cmd.Parameters.Add(effectspellclassmaskcParameter);
			cmd.Parameters.Add(effecttriggerspellParameter);
			cmd.Parameters.Add(effectimplicittargetaParameter);
			cmd.Parameters.Add(effectimplicittargetbParameter);
			cmd.Parameters.Add(effectspellidParameter);
			cmd.Parameters.Add(effectindexParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_effectParameter);
			cmd.Parameters.Add(OLD_effectvaluemultiplierParameter);
			cmd.Parameters.Add(OLD_effectapplyauranameParameter);
			cmd.Parameters.Add(OLD_effectamplitudeParameter);
			cmd.Parameters.Add(OLD_effectbasepointsParameter);
			cmd.Parameters.Add(OLD_effectbonusmultiplierParameter);
			cmd.Parameters.Add(OLD_effectdamagemultiplierParameter);
			cmd.Parameters.Add(OLD_effectchaintargetParameter);
			cmd.Parameters.Add(OLD_effectdiesidesParameter);
			cmd.Parameters.Add(OLD_effectitemtypeParameter);
			cmd.Parameters.Add(OLD_effectmechanicParameter);
			cmd.Parameters.Add(OLD_effectmiscvalueParameter);
			cmd.Parameters.Add(OLD_effectmiscvaluebParameter);
			cmd.Parameters.Add(OLD_effectradiusindexParameter);
			cmd.Parameters.Add(OLD_effectradiusindexmaxParameter);
			cmd.Parameters.Add(OLD_effectrealpointsperlevelParameter);
			cmd.Parameters.Add(OLD_effectspellclassmaskaParameter);
			cmd.Parameters.Add(OLD_effectspellclassmaskbParameter);
			cmd.Parameters.Add(OLD_effectspellclassmaskcParameter);
			cmd.Parameters.Add(OLD_effecttriggerspellParameter);
			cmd.Parameters.Add(OLD_effectimplicittargetaParameter);
			cmd.Parameters.Add(OLD_effectimplicittargetbParameter);
			cmd.Parameters.Add(OLD_effectspellidParameter);
			cmd.Parameters.Add(OLD_effectindexParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_Id = Id;
			OLD_Effect = Effect;
			OLD_EffectValueMultiplier = EffectValueMultiplier;
			OLD_EffectApplyAuraName = EffectApplyAuraName;
			OLD_EffectAmplitude = EffectAmplitude;
			OLD_EffectBasePoints = EffectBasePoints;
			OLD_EffectBonusMultiplier = EffectBonusMultiplier;
			OLD_EffectDamageMultiplier = EffectDamageMultiplier;
			OLD_EffectChainTarget = EffectChainTarget;
			OLD_EffectDieSides = EffectDieSides;
			OLD_EffectItemType = EffectItemType;
			OLD_EffectMechanic = EffectMechanic;
			OLD_EffectMiscValue = EffectMiscValue;
			OLD_EffectMiscValueB = EffectMiscValueB;
			OLD_EffectRadiusIndex = EffectRadiusIndex;
			OLD_EffectRadiusIndexMax = EffectRadiusIndexMax;
			OLD_EffectRealPointsPerLevel = EffectRealPointsPerLevel;
			OLD_EffectSpellClassMaskA = EffectSpellClassMaskA;
			OLD_EffectSpellClassMaskB = EffectSpellClassMaskB;
			OLD_EffectSpellClassMaskC = EffectSpellClassMaskC;
			OLD_EffectTriggerSpell = EffectTriggerSpell;
			OLD_EffectImplicitTargetA = EffectImplicitTargetA;
			OLD_EffectImplicitTargetB = EffectImplicitTargetB;
			OLD_EffectSpellId = EffectSpellId;
			OLD_EffectIndex = EffectIndex;
		}
	}
}
