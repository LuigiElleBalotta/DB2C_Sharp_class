using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Reputation_reward_rate
	{
		int faction = 0; //Comment: 
		int OLD_faction = 0;

		float quest_rate = 1f; //Comment: 
		float OLD_quest_rate = 1f;

		float quest_daily_rate = 1f; //Comment: 
		float OLD_quest_daily_rate = 1f;

		float quest_weekly_rate = 1f; //Comment: 
		float OLD_quest_weekly_rate = 1f;

		float quest_monthly_rate = 1f; //Comment: 
		float OLD_quest_monthly_rate = 1f;

		float quest_repeatable_rate = 1f; //Comment: 
		float OLD_quest_repeatable_rate = 1f;

		float creature_rate = 1f; //Comment: 
		float OLD_creature_rate = 1f;

		float spell_rate = 1f; //Comment: 
		float OLD_spell_rate = 1f;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Reputation_reward_rate(int _faction, float _quest_rate, float _quest_daily_rate, float _quest_weekly_rate, float _quest_monthly_rate, float _quest_repeatable_rate, float _creature_rate, float _spell_rate)
		{
			faction = _faction;
			quest_rate = _quest_rate;
			quest_daily_rate = _quest_daily_rate;
			quest_weekly_rate = _quest_weekly_rate;
			quest_monthly_rate = _quest_monthly_rate;
			quest_repeatable_rate = _quest_repeatable_rate;
			creature_rate = _creature_rate;
			spell_rate = _spell_rate;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM reputation_reward_rate WHERE faction = @faction AND quest_rate = @quest_rate AND quest_daily_rate = @quest_daily_rate AND quest_weekly_rate = @quest_weekly_rate AND quest_monthly_rate = @quest_monthly_rate AND quest_repeatable_rate = @quest_repeatable_rate AND creature_rate = @creature_rate AND spell_rate = @spell_rate;";
			MySqlParameter factionParameter = new MySqlParameter("@faction", MySqlDbType.VarChar, 0);
			MySqlParameter quest_rateParameter = new MySqlParameter("@quest_rate", MySqlDbType.VarChar, 0);
			MySqlParameter quest_daily_rateParameter = new MySqlParameter("@quest_daily_rate", MySqlDbType.VarChar, 0);
			MySqlParameter quest_weekly_rateParameter = new MySqlParameter("@quest_weekly_rate", MySqlDbType.VarChar, 0);
			MySqlParameter quest_monthly_rateParameter = new MySqlParameter("@quest_monthly_rate", MySqlDbType.VarChar, 0);
			MySqlParameter quest_repeatable_rateParameter = new MySqlParameter("@quest_repeatable_rate", MySqlDbType.VarChar, 0);
			MySqlParameter creature_rateParameter = new MySqlParameter("@creature_rate", MySqlDbType.VarChar, 0);
			MySqlParameter spell_rateParameter = new MySqlParameter("@spell_rate", MySqlDbType.VarChar, 0);
			factionParameter.Value = faction;
			quest_rateParameter.Value = quest_rate;
			quest_daily_rateParameter.Value = quest_daily_rate;
			quest_weekly_rateParameter.Value = quest_weekly_rate;
			quest_monthly_rateParameter.Value = quest_monthly_rate;
			quest_repeatable_rateParameter.Value = quest_repeatable_rate;
			creature_rateParameter.Value = creature_rate;
			spell_rateParameter.Value = spell_rate;
			cmd.Parameters.Add(factionParameter);
			cmd.Parameters.Add(quest_rateParameter);
			cmd.Parameters.Add(quest_daily_rateParameter);
			cmd.Parameters.Add(quest_weekly_rateParameter);
			cmd.Parameters.Add(quest_monthly_rateParameter);
			cmd.Parameters.Add(quest_repeatable_rateParameter);
			cmd.Parameters.Add(creature_rateParameter);
			cmd.Parameters.Add(spell_rateParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE reputation_reward_rate SET faction = @newfaction, quest_rate = @newquest_rate, quest_daily_rate = @newquest_daily_rate, quest_weekly_rate = @newquest_weekly_rate, quest_monthly_rate = @newquest_monthly_rate, quest_repeatable_rate = @newquest_repeatable_rate, creature_rate = @newcreature_rate, spell_rate = @newspell_rate WHERE faction = @faction AND quest_rate = @quest_rate AND quest_daily_rate = @quest_daily_rate AND quest_weekly_rate = @quest_weekly_rate AND quest_monthly_rate = @quest_monthly_rate AND quest_repeatable_rate = @quest_repeatable_rate AND creature_rate = @creature_rate AND spell_rate = @spell_rate;";
			MySqlParameter OLD_factionParameter = new MySqlParameter("@faction", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_quest_rateParameter = new MySqlParameter("@quest_rate", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_quest_daily_rateParameter = new MySqlParameter("@quest_daily_rate", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_quest_weekly_rateParameter = new MySqlParameter("@quest_weekly_rate", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_quest_monthly_rateParameter = new MySqlParameter("@quest_monthly_rate", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_quest_repeatable_rateParameter = new MySqlParameter("@quest_repeatable_rate", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_creature_rateParameter = new MySqlParameter("@creature_rate", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spell_rateParameter = new MySqlParameter("@spell_rate", MySqlDbType.VarChar, 0);
			MySqlParameter factionParameter = new MySqlParameter("@newfaction", MySqlDbType.VarChar, 0);
			MySqlParameter quest_rateParameter = new MySqlParameter("@newquest_rate", MySqlDbType.VarChar, 0);
			MySqlParameter quest_daily_rateParameter = new MySqlParameter("@newquest_daily_rate", MySqlDbType.VarChar, 0);
			MySqlParameter quest_weekly_rateParameter = new MySqlParameter("@newquest_weekly_rate", MySqlDbType.VarChar, 0);
			MySqlParameter quest_monthly_rateParameter = new MySqlParameter("@newquest_monthly_rate", MySqlDbType.VarChar, 0);
			MySqlParameter quest_repeatable_rateParameter = new MySqlParameter("@newquest_repeatable_rate", MySqlDbType.VarChar, 0);
			MySqlParameter creature_rateParameter = new MySqlParameter("@newcreature_rate", MySqlDbType.VarChar, 0);
			MySqlParameter spell_rateParameter = new MySqlParameter("@newspell_rate", MySqlDbType.VarChar, 0);
			factionParameter.Value = faction;
			quest_rateParameter.Value = quest_rate;
			quest_daily_rateParameter.Value = quest_daily_rate;
			quest_weekly_rateParameter.Value = quest_weekly_rate;
			quest_monthly_rateParameter.Value = quest_monthly_rate;
			quest_repeatable_rateParameter.Value = quest_repeatable_rate;
			creature_rateParameter.Value = creature_rate;
			spell_rateParameter.Value = spell_rate;
			OLD_factionParameter.Value = OLD_faction;
			OLD_quest_rateParameter.Value = OLD_quest_rate;
			OLD_quest_daily_rateParameter.Value = OLD_quest_daily_rate;
			OLD_quest_weekly_rateParameter.Value = OLD_quest_weekly_rate;
			OLD_quest_monthly_rateParameter.Value = OLD_quest_monthly_rate;
			OLD_quest_repeatable_rateParameter.Value = OLD_quest_repeatable_rate;
			OLD_creature_rateParameter.Value = OLD_creature_rate;
			OLD_spell_rateParameter.Value = OLD_spell_rate;
			cmd.Parameters.Add(factionParameter);
			cmd.Parameters.Add(quest_rateParameter);
			cmd.Parameters.Add(quest_daily_rateParameter);
			cmd.Parameters.Add(quest_weekly_rateParameter);
			cmd.Parameters.Add(quest_monthly_rateParameter);
			cmd.Parameters.Add(quest_repeatable_rateParameter);
			cmd.Parameters.Add(creature_rateParameter);
			cmd.Parameters.Add(spell_rateParameter);
			cmd.Parameters.Add(OLD_factionParameter);
			cmd.Parameters.Add(OLD_quest_rateParameter);
			cmd.Parameters.Add(OLD_quest_daily_rateParameter);
			cmd.Parameters.Add(OLD_quest_weekly_rateParameter);
			cmd.Parameters.Add(OLD_quest_monthly_rateParameter);
			cmd.Parameters.Add(OLD_quest_repeatable_rateParameter);
			cmd.Parameters.Add(OLD_creature_rateParameter);
			cmd.Parameters.Add(OLD_spell_rateParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_faction = faction;
			OLD_quest_rate = quest_rate;
			OLD_quest_daily_rate = quest_daily_rate;
			OLD_quest_weekly_rate = quest_weekly_rate;
			OLD_quest_monthly_rate = quest_monthly_rate;
			OLD_quest_repeatable_rate = quest_repeatable_rate;
			OLD_creature_rate = creature_rate;
			OLD_spell_rate = spell_rate;
		}
	}
}
