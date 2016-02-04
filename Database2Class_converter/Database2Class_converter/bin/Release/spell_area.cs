using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Spell_area
	{
		int spell = 0; //Comment: 
		int OLD_spell = 0;

		int area = 0; //Comment: 
		int OLD_area = 0;

		int quest_start = 0; //Comment: 
		int OLD_quest_start = 0;

		int quest_end = 0; //Comment: 
		int OLD_quest_end = 0;

		int aura_spell = 0; //Comment: 
		int OLD_aura_spell = 0;

		int racemask = 0; //Comment: 
		int OLD_racemask = 0;

		int gender = 2; //Comment: 
		int OLD_gender = 2;

		int autocast = 0; //Comment: 
		int OLD_autocast = 0;

		int quest_start_status = 64; //Comment: 
		int OLD_quest_start_status = 64;

		int quest_end_status = 11; //Comment: 
		int OLD_quest_end_status = 11;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Spell_area(int _spell, int _area, int _quest_start, int _quest_end, int _aura_spell, int _racemask, int _gender, int _autocast, int _quest_start_status, int _quest_end_status)
		{
			spell = _spell;
			area = _area;
			quest_start = _quest_start;
			quest_end = _quest_end;
			aura_spell = _aura_spell;
			racemask = _racemask;
			gender = _gender;
			autocast = _autocast;
			quest_start_status = _quest_start_status;
			quest_end_status = _quest_end_status;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM spell_area WHERE spell = @spell AND area = @area AND quest_start = @quest_start AND quest_end = @quest_end AND aura_spell = @aura_spell AND racemask = @racemask AND gender = @gender AND autocast = @autocast AND quest_start_status = @quest_start_status AND quest_end_status = @quest_end_status;";
			MySqlParameter spellParameter = new MySqlParameter("@spell", MySqlDbType.VarChar, 0);
			MySqlParameter areaParameter = new MySqlParameter("@area", MySqlDbType.VarChar, 0);
			MySqlParameter quest_startParameter = new MySqlParameter("@quest_start", MySqlDbType.VarChar, 0);
			MySqlParameter quest_endParameter = new MySqlParameter("@quest_end", MySqlDbType.VarChar, 0);
			MySqlParameter aura_spellParameter = new MySqlParameter("@aura_spell", MySqlDbType.VarChar, 0);
			MySqlParameter racemaskParameter = new MySqlParameter("@racemask", MySqlDbType.VarChar, 0);
			MySqlParameter genderParameter = new MySqlParameter("@gender", MySqlDbType.VarChar, 0);
			MySqlParameter autocastParameter = new MySqlParameter("@autocast", MySqlDbType.VarChar, 0);
			MySqlParameter quest_start_statusParameter = new MySqlParameter("@quest_start_status", MySqlDbType.VarChar, 0);
			MySqlParameter quest_end_statusParameter = new MySqlParameter("@quest_end_status", MySqlDbType.VarChar, 0);
			spellParameter.Value = spell;
			areaParameter.Value = area;
			quest_startParameter.Value = quest_start;
			quest_endParameter.Value = quest_end;
			aura_spellParameter.Value = aura_spell;
			racemaskParameter.Value = racemask;
			genderParameter.Value = gender;
			autocastParameter.Value = autocast;
			quest_start_statusParameter.Value = quest_start_status;
			quest_end_statusParameter.Value = quest_end_status;
			cmd.Parameters.Add(spellParameter);
			cmd.Parameters.Add(areaParameter);
			cmd.Parameters.Add(quest_startParameter);
			cmd.Parameters.Add(quest_endParameter);
			cmd.Parameters.Add(aura_spellParameter);
			cmd.Parameters.Add(racemaskParameter);
			cmd.Parameters.Add(genderParameter);
			cmd.Parameters.Add(autocastParameter);
			cmd.Parameters.Add(quest_start_statusParameter);
			cmd.Parameters.Add(quest_end_statusParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE spell_area SET spell = @newspell, area = @newarea, quest_start = @newquest_start, quest_end = @newquest_end, aura_spell = @newaura_spell, racemask = @newracemask, gender = @newgender, autocast = @newautocast, quest_start_status = @newquest_start_status, quest_end_status = @newquest_end_status WHERE spell = @spell AND area = @area AND quest_start = @quest_start AND quest_end = @quest_end AND aura_spell = @aura_spell AND racemask = @racemask AND gender = @gender AND autocast = @autocast AND quest_start_status = @quest_start_status AND quest_end_status = @quest_end_status;";
			MySqlParameter OLD_spellParameter = new MySqlParameter("@spell", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_areaParameter = new MySqlParameter("@area", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_quest_startParameter = new MySqlParameter("@quest_start", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_quest_endParameter = new MySqlParameter("@quest_end", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_aura_spellParameter = new MySqlParameter("@aura_spell", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_racemaskParameter = new MySqlParameter("@racemask", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_genderParameter = new MySqlParameter("@gender", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_autocastParameter = new MySqlParameter("@autocast", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_quest_start_statusParameter = new MySqlParameter("@quest_start_status", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_quest_end_statusParameter = new MySqlParameter("@quest_end_status", MySqlDbType.VarChar, 0);
			MySqlParameter spellParameter = new MySqlParameter("@newspell", MySqlDbType.VarChar, 0);
			MySqlParameter areaParameter = new MySqlParameter("@newarea", MySqlDbType.VarChar, 0);
			MySqlParameter quest_startParameter = new MySqlParameter("@newquest_start", MySqlDbType.VarChar, 0);
			MySqlParameter quest_endParameter = new MySqlParameter("@newquest_end", MySqlDbType.VarChar, 0);
			MySqlParameter aura_spellParameter = new MySqlParameter("@newaura_spell", MySqlDbType.VarChar, 0);
			MySqlParameter racemaskParameter = new MySqlParameter("@newracemask", MySqlDbType.VarChar, 0);
			MySqlParameter genderParameter = new MySqlParameter("@newgender", MySqlDbType.VarChar, 0);
			MySqlParameter autocastParameter = new MySqlParameter("@newautocast", MySqlDbType.VarChar, 0);
			MySqlParameter quest_start_statusParameter = new MySqlParameter("@newquest_start_status", MySqlDbType.VarChar, 0);
			MySqlParameter quest_end_statusParameter = new MySqlParameter("@newquest_end_status", MySqlDbType.VarChar, 0);
			spellParameter.Value = spell;
			areaParameter.Value = area;
			quest_startParameter.Value = quest_start;
			quest_endParameter.Value = quest_end;
			aura_spellParameter.Value = aura_spell;
			racemaskParameter.Value = racemask;
			genderParameter.Value = gender;
			autocastParameter.Value = autocast;
			quest_start_statusParameter.Value = quest_start_status;
			quest_end_statusParameter.Value = quest_end_status;
			OLD_spellParameter.Value = OLD_spell;
			OLD_areaParameter.Value = OLD_area;
			OLD_quest_startParameter.Value = OLD_quest_start;
			OLD_quest_endParameter.Value = OLD_quest_end;
			OLD_aura_spellParameter.Value = OLD_aura_spell;
			OLD_racemaskParameter.Value = OLD_racemask;
			OLD_genderParameter.Value = OLD_gender;
			OLD_autocastParameter.Value = OLD_autocast;
			OLD_quest_start_statusParameter.Value = OLD_quest_start_status;
			OLD_quest_end_statusParameter.Value = OLD_quest_end_status;
			cmd.Parameters.Add(spellParameter);
			cmd.Parameters.Add(areaParameter);
			cmd.Parameters.Add(quest_startParameter);
			cmd.Parameters.Add(quest_endParameter);
			cmd.Parameters.Add(aura_spellParameter);
			cmd.Parameters.Add(racemaskParameter);
			cmd.Parameters.Add(genderParameter);
			cmd.Parameters.Add(autocastParameter);
			cmd.Parameters.Add(quest_start_statusParameter);
			cmd.Parameters.Add(quest_end_statusParameter);
			cmd.Parameters.Add(OLD_spellParameter);
			cmd.Parameters.Add(OLD_areaParameter);
			cmd.Parameters.Add(OLD_quest_startParameter);
			cmd.Parameters.Add(OLD_quest_endParameter);
			cmd.Parameters.Add(OLD_aura_spellParameter);
			cmd.Parameters.Add(OLD_racemaskParameter);
			cmd.Parameters.Add(OLD_genderParameter);
			cmd.Parameters.Add(OLD_autocastParameter);
			cmd.Parameters.Add(OLD_quest_start_statusParameter);
			cmd.Parameters.Add(OLD_quest_end_statusParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_spell = spell;
			OLD_area = area;
			OLD_quest_start = quest_start;
			OLD_quest_end = quest_end;
			OLD_aura_spell = aura_spell;
			OLD_racemask = racemask;
			OLD_gender = gender;
			OLD_autocast = autocast;
			OLD_quest_start_status = quest_start_status;
			OLD_quest_end_status = quest_end_status;
		}
	}
}
