using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Spell_pet_auras
	{
		int spell = 0; //Comment: dummy spell id
		int OLD_spell = 0;

		int effectId = 0; //Comment: 
		int OLD_effectId = 0;

		int pet = 0; //Comment: pet id; 0 = all
		int OLD_pet = 0;

		int aura = 0; //Comment: pet aura id
		int OLD_aura = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Spell_pet_auras(int _spell, int _effectId, int _pet, int _aura)
		{
			spell = _spell;
			effectId = _effectId;
			pet = _pet;
			aura = _aura;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM spell_pet_auras WHERE spell = @spell AND effectId = @effectId AND pet = @pet AND aura = @aura;";
			MySqlParameter spellParameter = new MySqlParameter("@spell", MySqlDbType.VarChar, 0);
			MySqlParameter effectidParameter = new MySqlParameter("@effectId", MySqlDbType.VarChar, 0);
			MySqlParameter petParameter = new MySqlParameter("@pet", MySqlDbType.VarChar, 0);
			MySqlParameter auraParameter = new MySqlParameter("@aura", MySqlDbType.VarChar, 0);
			spellParameter.Value = spell;
			effectidParameter.Value = effectId;
			petParameter.Value = pet;
			auraParameter.Value = aura;
			cmd.Parameters.Add(spellParameter);
			cmd.Parameters.Add(effectidParameter);
			cmd.Parameters.Add(petParameter);
			cmd.Parameters.Add(auraParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE spell_pet_auras SET spell = @newspell, effectId = @neweffectId, pet = @newpet, aura = @newaura WHERE spell = @spell AND effectId = @effectId AND pet = @pet AND aura = @aura;";
			MySqlParameter OLD_spellParameter = new MySqlParameter("@spell", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_effectidParameter = new MySqlParameter("@effectId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_petParameter = new MySqlParameter("@pet", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_auraParameter = new MySqlParameter("@aura", MySqlDbType.VarChar, 0);
			MySqlParameter spellParameter = new MySqlParameter("@newspell", MySqlDbType.VarChar, 0);
			MySqlParameter effectidParameter = new MySqlParameter("@neweffectId", MySqlDbType.VarChar, 0);
			MySqlParameter petParameter = new MySqlParameter("@newpet", MySqlDbType.VarChar, 0);
			MySqlParameter auraParameter = new MySqlParameter("@newaura", MySqlDbType.VarChar, 0);
			spellParameter.Value = spell;
			effectidParameter.Value = effectId;
			petParameter.Value = pet;
			auraParameter.Value = aura;
			OLD_spellParameter.Value = OLD_spell;
			OLD_effectidParameter.Value = OLD_effectId;
			OLD_petParameter.Value = OLD_pet;
			OLD_auraParameter.Value = OLD_aura;
			cmd.Parameters.Add(spellParameter);
			cmd.Parameters.Add(effectidParameter);
			cmd.Parameters.Add(petParameter);
			cmd.Parameters.Add(auraParameter);
			cmd.Parameters.Add(OLD_spellParameter);
			cmd.Parameters.Add(OLD_effectidParameter);
			cmd.Parameters.Add(OLD_petParameter);
			cmd.Parameters.Add(OLD_auraParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_spell = spell;
			OLD_effectId = effectId;
			OLD_pet = pet;
			OLD_aura = aura;
		}
	}
}
