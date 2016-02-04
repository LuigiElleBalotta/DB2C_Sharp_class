using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Spell_proc
	{
		int spellId = 0; //Comment: 
		int OLD_spellId = 0;

		int schoolMask = 0; //Comment: 
		int OLD_schoolMask = 0;

		int spellFamilyName = 0; //Comment: 
		int OLD_spellFamilyName = 0;

		int spellFamilyMask0 = 0; //Comment: 
		int OLD_spellFamilyMask0 = 0;

		int spellFamilyMask1 = 0; //Comment: 
		int OLD_spellFamilyMask1 = 0;

		int spellFamilyMask2 = 0; //Comment: 
		int OLD_spellFamilyMask2 = 0;

		int spellFamilyMask3 = 0; //Comment: 
		int OLD_spellFamilyMask3 = 0;

		int typeMask = 0; //Comment: 
		int OLD_typeMask = 0;

		int spellTypeMask = 0; //Comment: 
		int OLD_spellTypeMask = 0;

		int spellPhaseMask = 0; //Comment: 
		int OLD_spellPhaseMask = 0;

		int hitMask = 0; //Comment: 
		int OLD_hitMask = 0;

		int attributesMask = 0; //Comment: 
		int OLD_attributesMask = 0;

		float ratePerMinute = 0f; //Comment: 
		float OLD_ratePerMinute = 0f;

		float chance = 0f; //Comment: 
		float OLD_chance = 0f;

		float cooldown = 0f; //Comment: 
		float OLD_cooldown = 0f;

		int charges = 0; //Comment: 
		int OLD_charges = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Spell_proc(int _spellId, int _schoolMask, int _spellFamilyName, int _spellFamilyMask0, int _spellFamilyMask1, int _spellFamilyMask2, int _spellFamilyMask3, int _typeMask, int _spellTypeMask, int _spellPhaseMask, int _hitMask, int _attributesMask, float _ratePerMinute, float _chance, float _cooldown, int _charges)
		{
			spellId = _spellId;
			schoolMask = _schoolMask;
			spellFamilyName = _spellFamilyName;
			spellFamilyMask0 = _spellFamilyMask0;
			spellFamilyMask1 = _spellFamilyMask1;
			spellFamilyMask2 = _spellFamilyMask2;
			spellFamilyMask3 = _spellFamilyMask3;
			typeMask = _typeMask;
			spellTypeMask = _spellTypeMask;
			spellPhaseMask = _spellPhaseMask;
			hitMask = _hitMask;
			attributesMask = _attributesMask;
			ratePerMinute = _ratePerMinute;
			chance = _chance;
			cooldown = _cooldown;
			charges = _charges;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM spell_proc WHERE spellId = @spellId AND schoolMask = @schoolMask AND spellFamilyName = @spellFamilyName AND spellFamilyMask0 = @spellFamilyMask0 AND spellFamilyMask1 = @spellFamilyMask1 AND spellFamilyMask2 = @spellFamilyMask2 AND spellFamilyMask3 = @spellFamilyMask3 AND typeMask = @typeMask AND spellTypeMask = @spellTypeMask AND spellPhaseMask = @spellPhaseMask AND hitMask = @hitMask AND attributesMask = @attributesMask AND ratePerMinute = @ratePerMinute AND chance = @chance AND cooldown = @cooldown AND charges = @charges;";
			MySqlParameter spellidParameter = new MySqlParameter("@spellId", MySqlDbType.VarChar, 0);
			MySqlParameter schoolmaskParameter = new MySqlParameter("@schoolMask", MySqlDbType.VarChar, 0);
			MySqlParameter spellfamilynameParameter = new MySqlParameter("@spellFamilyName", MySqlDbType.VarChar, 0);
			MySqlParameter spellfamilymask0Parameter = new MySqlParameter("@spellFamilyMask0", MySqlDbType.VarChar, 0);
			MySqlParameter spellfamilymask1Parameter = new MySqlParameter("@spellFamilyMask1", MySqlDbType.VarChar, 0);
			MySqlParameter spellfamilymask2Parameter = new MySqlParameter("@spellFamilyMask2", MySqlDbType.VarChar, 0);
			MySqlParameter spellfamilymask3Parameter = new MySqlParameter("@spellFamilyMask3", MySqlDbType.VarChar, 0);
			MySqlParameter typemaskParameter = new MySqlParameter("@typeMask", MySqlDbType.VarChar, 0);
			MySqlParameter spelltypemaskParameter = new MySqlParameter("@spellTypeMask", MySqlDbType.VarChar, 0);
			MySqlParameter spellphasemaskParameter = new MySqlParameter("@spellPhaseMask", MySqlDbType.VarChar, 0);
			MySqlParameter hitmaskParameter = new MySqlParameter("@hitMask", MySqlDbType.VarChar, 0);
			MySqlParameter attributesmaskParameter = new MySqlParameter("@attributesMask", MySqlDbType.VarChar, 0);
			MySqlParameter rateperminuteParameter = new MySqlParameter("@ratePerMinute", MySqlDbType.VarChar, 0);
			MySqlParameter chanceParameter = new MySqlParameter("@chance", MySqlDbType.VarChar, 0);
			MySqlParameter cooldownParameter = new MySqlParameter("@cooldown", MySqlDbType.VarChar, 0);
			MySqlParameter chargesParameter = new MySqlParameter("@charges", MySqlDbType.VarChar, 0);
			spellidParameter.Value = spellId;
			schoolmaskParameter.Value = schoolMask;
			spellfamilynameParameter.Value = spellFamilyName;
			spellfamilymask0Parameter.Value = spellFamilyMask0;
			spellfamilymask1Parameter.Value = spellFamilyMask1;
			spellfamilymask2Parameter.Value = spellFamilyMask2;
			spellfamilymask3Parameter.Value = spellFamilyMask3;
			typemaskParameter.Value = typeMask;
			spelltypemaskParameter.Value = spellTypeMask;
			spellphasemaskParameter.Value = spellPhaseMask;
			hitmaskParameter.Value = hitMask;
			attributesmaskParameter.Value = attributesMask;
			rateperminuteParameter.Value = ratePerMinute;
			chanceParameter.Value = chance;
			cooldownParameter.Value = cooldown;
			chargesParameter.Value = charges;
			cmd.Parameters.Add(spellidParameter);
			cmd.Parameters.Add(schoolmaskParameter);
			cmd.Parameters.Add(spellfamilynameParameter);
			cmd.Parameters.Add(spellfamilymask0Parameter);
			cmd.Parameters.Add(spellfamilymask1Parameter);
			cmd.Parameters.Add(spellfamilymask2Parameter);
			cmd.Parameters.Add(spellfamilymask3Parameter);
			cmd.Parameters.Add(typemaskParameter);
			cmd.Parameters.Add(spelltypemaskParameter);
			cmd.Parameters.Add(spellphasemaskParameter);
			cmd.Parameters.Add(hitmaskParameter);
			cmd.Parameters.Add(attributesmaskParameter);
			cmd.Parameters.Add(rateperminuteParameter);
			cmd.Parameters.Add(chanceParameter);
			cmd.Parameters.Add(cooldownParameter);
			cmd.Parameters.Add(chargesParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE spell_proc SET spellId = @newspellId, schoolMask = @newschoolMask, spellFamilyName = @newspellFamilyName, spellFamilyMask0 = @newspellFamilyMask0, spellFamilyMask1 = @newspellFamilyMask1, spellFamilyMask2 = @newspellFamilyMask2, spellFamilyMask3 = @newspellFamilyMask3, typeMask = @newtypeMask, spellTypeMask = @newspellTypeMask, spellPhaseMask = @newspellPhaseMask, hitMask = @newhitMask, attributesMask = @newattributesMask, ratePerMinute = @newratePerMinute, chance = @newchance, cooldown = @newcooldown, charges = @newcharges WHERE spellId = @spellId AND schoolMask = @schoolMask AND spellFamilyName = @spellFamilyName AND spellFamilyMask0 = @spellFamilyMask0 AND spellFamilyMask1 = @spellFamilyMask1 AND spellFamilyMask2 = @spellFamilyMask2 AND spellFamilyMask3 = @spellFamilyMask3 AND typeMask = @typeMask AND spellTypeMask = @spellTypeMask AND spellPhaseMask = @spellPhaseMask AND hitMask = @hitMask AND attributesMask = @attributesMask AND ratePerMinute = @ratePerMinute AND chance = @chance AND cooldown = @cooldown AND charges = @charges;";
			MySqlParameter OLD_spellidParameter = new MySqlParameter("@spellId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_schoolmaskParameter = new MySqlParameter("@schoolMask", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spellfamilynameParameter = new MySqlParameter("@spellFamilyName", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spellfamilymask0Parameter = new MySqlParameter("@spellFamilyMask0", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spellfamilymask1Parameter = new MySqlParameter("@spellFamilyMask1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spellfamilymask2Parameter = new MySqlParameter("@spellFamilyMask2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spellfamilymask3Parameter = new MySqlParameter("@spellFamilyMask3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_typemaskParameter = new MySqlParameter("@typeMask", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spelltypemaskParameter = new MySqlParameter("@spellTypeMask", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spellphasemaskParameter = new MySqlParameter("@spellPhaseMask", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_hitmaskParameter = new MySqlParameter("@hitMask", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_attributesmaskParameter = new MySqlParameter("@attributesMask", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rateperminuteParameter = new MySqlParameter("@ratePerMinute", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_chanceParameter = new MySqlParameter("@chance", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_cooldownParameter = new MySqlParameter("@cooldown", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_chargesParameter = new MySqlParameter("@charges", MySqlDbType.VarChar, 0);
			MySqlParameter spellidParameter = new MySqlParameter("@newspellId", MySqlDbType.VarChar, 0);
			MySqlParameter schoolmaskParameter = new MySqlParameter("@newschoolMask", MySqlDbType.VarChar, 0);
			MySqlParameter spellfamilynameParameter = new MySqlParameter("@newspellFamilyName", MySqlDbType.VarChar, 0);
			MySqlParameter spellfamilymask0Parameter = new MySqlParameter("@newspellFamilyMask0", MySqlDbType.VarChar, 0);
			MySqlParameter spellfamilymask1Parameter = new MySqlParameter("@newspellFamilyMask1", MySqlDbType.VarChar, 0);
			MySqlParameter spellfamilymask2Parameter = new MySqlParameter("@newspellFamilyMask2", MySqlDbType.VarChar, 0);
			MySqlParameter spellfamilymask3Parameter = new MySqlParameter("@newspellFamilyMask3", MySqlDbType.VarChar, 0);
			MySqlParameter typemaskParameter = new MySqlParameter("@newtypeMask", MySqlDbType.VarChar, 0);
			MySqlParameter spelltypemaskParameter = new MySqlParameter("@newspellTypeMask", MySqlDbType.VarChar, 0);
			MySqlParameter spellphasemaskParameter = new MySqlParameter("@newspellPhaseMask", MySqlDbType.VarChar, 0);
			MySqlParameter hitmaskParameter = new MySqlParameter("@newhitMask", MySqlDbType.VarChar, 0);
			MySqlParameter attributesmaskParameter = new MySqlParameter("@newattributesMask", MySqlDbType.VarChar, 0);
			MySqlParameter rateperminuteParameter = new MySqlParameter("@newratePerMinute", MySqlDbType.VarChar, 0);
			MySqlParameter chanceParameter = new MySqlParameter("@newchance", MySqlDbType.VarChar, 0);
			MySqlParameter cooldownParameter = new MySqlParameter("@newcooldown", MySqlDbType.VarChar, 0);
			MySqlParameter chargesParameter = new MySqlParameter("@newcharges", MySqlDbType.VarChar, 0);
			spellidParameter.Value = spellId;
			schoolmaskParameter.Value = schoolMask;
			spellfamilynameParameter.Value = spellFamilyName;
			spellfamilymask0Parameter.Value = spellFamilyMask0;
			spellfamilymask1Parameter.Value = spellFamilyMask1;
			spellfamilymask2Parameter.Value = spellFamilyMask2;
			spellfamilymask3Parameter.Value = spellFamilyMask3;
			typemaskParameter.Value = typeMask;
			spelltypemaskParameter.Value = spellTypeMask;
			spellphasemaskParameter.Value = spellPhaseMask;
			hitmaskParameter.Value = hitMask;
			attributesmaskParameter.Value = attributesMask;
			rateperminuteParameter.Value = ratePerMinute;
			chanceParameter.Value = chance;
			cooldownParameter.Value = cooldown;
			chargesParameter.Value = charges;
			OLD_spellidParameter.Value = OLD_spellId;
			OLD_schoolmaskParameter.Value = OLD_schoolMask;
			OLD_spellfamilynameParameter.Value = OLD_spellFamilyName;
			OLD_spellfamilymask0Parameter.Value = OLD_spellFamilyMask0;
			OLD_spellfamilymask1Parameter.Value = OLD_spellFamilyMask1;
			OLD_spellfamilymask2Parameter.Value = OLD_spellFamilyMask2;
			OLD_spellfamilymask3Parameter.Value = OLD_spellFamilyMask3;
			OLD_typemaskParameter.Value = OLD_typeMask;
			OLD_spelltypemaskParameter.Value = OLD_spellTypeMask;
			OLD_spellphasemaskParameter.Value = OLD_spellPhaseMask;
			OLD_hitmaskParameter.Value = OLD_hitMask;
			OLD_attributesmaskParameter.Value = OLD_attributesMask;
			OLD_rateperminuteParameter.Value = OLD_ratePerMinute;
			OLD_chanceParameter.Value = OLD_chance;
			OLD_cooldownParameter.Value = OLD_cooldown;
			OLD_chargesParameter.Value = OLD_charges;
			cmd.Parameters.Add(spellidParameter);
			cmd.Parameters.Add(schoolmaskParameter);
			cmd.Parameters.Add(spellfamilynameParameter);
			cmd.Parameters.Add(spellfamilymask0Parameter);
			cmd.Parameters.Add(spellfamilymask1Parameter);
			cmd.Parameters.Add(spellfamilymask2Parameter);
			cmd.Parameters.Add(spellfamilymask3Parameter);
			cmd.Parameters.Add(typemaskParameter);
			cmd.Parameters.Add(spelltypemaskParameter);
			cmd.Parameters.Add(spellphasemaskParameter);
			cmd.Parameters.Add(hitmaskParameter);
			cmd.Parameters.Add(attributesmaskParameter);
			cmd.Parameters.Add(rateperminuteParameter);
			cmd.Parameters.Add(chanceParameter);
			cmd.Parameters.Add(cooldownParameter);
			cmd.Parameters.Add(chargesParameter);
			cmd.Parameters.Add(OLD_spellidParameter);
			cmd.Parameters.Add(OLD_schoolmaskParameter);
			cmd.Parameters.Add(OLD_spellfamilynameParameter);
			cmd.Parameters.Add(OLD_spellfamilymask0Parameter);
			cmd.Parameters.Add(OLD_spellfamilymask1Parameter);
			cmd.Parameters.Add(OLD_spellfamilymask2Parameter);
			cmd.Parameters.Add(OLD_spellfamilymask3Parameter);
			cmd.Parameters.Add(OLD_typemaskParameter);
			cmd.Parameters.Add(OLD_spelltypemaskParameter);
			cmd.Parameters.Add(OLD_spellphasemaskParameter);
			cmd.Parameters.Add(OLD_hitmaskParameter);
			cmd.Parameters.Add(OLD_attributesmaskParameter);
			cmd.Parameters.Add(OLD_rateperminuteParameter);
			cmd.Parameters.Add(OLD_chanceParameter);
			cmd.Parameters.Add(OLD_cooldownParameter);
			cmd.Parameters.Add(OLD_chargesParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_spellId = spellId;
			OLD_schoolMask = schoolMask;
			OLD_spellFamilyName = spellFamilyName;
			OLD_spellFamilyMask0 = spellFamilyMask0;
			OLD_spellFamilyMask1 = spellFamilyMask1;
			OLD_spellFamilyMask2 = spellFamilyMask2;
			OLD_spellFamilyMask3 = spellFamilyMask3;
			OLD_typeMask = typeMask;
			OLD_spellTypeMask = spellTypeMask;
			OLD_spellPhaseMask = spellPhaseMask;
			OLD_hitMask = hitMask;
			OLD_attributesMask = attributesMask;
			OLD_ratePerMinute = ratePerMinute;
			OLD_chance = chance;
			OLD_cooldown = cooldown;
			OLD_charges = charges;
		}
	}
}
