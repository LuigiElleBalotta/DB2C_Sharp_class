using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Reputation_spillover_template
	{
		int faction = 0; //Comment: faction entry
		int OLD_faction = 0;

		int faction1 = 0; //Comment: faction to give spillover for
		int OLD_faction1 = 0;

		float rate_1 = 0f; //Comment: the given rep points * rate
		float OLD_rate_1 = 0f;

		int rank_1 = 0; //Comment: max rank,above this will not give any spillover
		int OLD_rank_1 = 0;

		int faction2 = 0; //Comment: 
		int OLD_faction2 = 0;

		float rate_2 = 0f; //Comment: 
		float OLD_rate_2 = 0f;

		int rank_2 = 0; //Comment: 
		int OLD_rank_2 = 0;

		int faction3 = 0; //Comment: 
		int OLD_faction3 = 0;

		float rate_3 = 0f; //Comment: 
		float OLD_rate_3 = 0f;

		int rank_3 = 0; //Comment: 
		int OLD_rank_3 = 0;

		int faction4 = 0; //Comment: 
		int OLD_faction4 = 0;

		float rate_4 = 0f; //Comment: 
		float OLD_rate_4 = 0f;

		int rank_4 = 0; //Comment: 
		int OLD_rank_4 = 0;

		int faction5 = 0; //Comment: 
		int OLD_faction5 = 0;

		float rate_5 = 0f; //Comment: 
		float OLD_rate_5 = 0f;

		int rank_5 = 0; //Comment: 
		int OLD_rank_5 = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Reputation_spillover_template(int _faction, int _faction1, float _rate_1, int _rank_1, int _faction2, float _rate_2, int _rank_2, int _faction3, float _rate_3, int _rank_3, int _faction4, float _rate_4, int _rank_4, int _faction5, float _rate_5, int _rank_5)
		{
			faction = _faction;
			faction1 = _faction1;
			rate_1 = _rate_1;
			rank_1 = _rank_1;
			faction2 = _faction2;
			rate_2 = _rate_2;
			rank_2 = _rank_2;
			faction3 = _faction3;
			rate_3 = _rate_3;
			rank_3 = _rank_3;
			faction4 = _faction4;
			rate_4 = _rate_4;
			rank_4 = _rank_4;
			faction5 = _faction5;
			rate_5 = _rate_5;
			rank_5 = _rank_5;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM reputation_spillover_template WHERE faction = @faction AND faction1 = @faction1 AND rate_1 = @rate_1 AND rank_1 = @rank_1 AND faction2 = @faction2 AND rate_2 = @rate_2 AND rank_2 = @rank_2 AND faction3 = @faction3 AND rate_3 = @rate_3 AND rank_3 = @rank_3 AND faction4 = @faction4 AND rate_4 = @rate_4 AND rank_4 = @rank_4 AND faction5 = @faction5 AND rate_5 = @rate_5 AND rank_5 = @rank_5;";
			MySqlParameter factionParameter = new MySqlParameter("@faction", MySqlDbType.VarChar, 0);
			MySqlParameter faction1Parameter = new MySqlParameter("@faction1", MySqlDbType.VarChar, 0);
			MySqlParameter rate_1Parameter = new MySqlParameter("@rate_1", MySqlDbType.VarChar, 0);
			MySqlParameter rank_1Parameter = new MySqlParameter("@rank_1", MySqlDbType.VarChar, 0);
			MySqlParameter faction2Parameter = new MySqlParameter("@faction2", MySqlDbType.VarChar, 0);
			MySqlParameter rate_2Parameter = new MySqlParameter("@rate_2", MySqlDbType.VarChar, 0);
			MySqlParameter rank_2Parameter = new MySqlParameter("@rank_2", MySqlDbType.VarChar, 0);
			MySqlParameter faction3Parameter = new MySqlParameter("@faction3", MySqlDbType.VarChar, 0);
			MySqlParameter rate_3Parameter = new MySqlParameter("@rate_3", MySqlDbType.VarChar, 0);
			MySqlParameter rank_3Parameter = new MySqlParameter("@rank_3", MySqlDbType.VarChar, 0);
			MySqlParameter faction4Parameter = new MySqlParameter("@faction4", MySqlDbType.VarChar, 0);
			MySqlParameter rate_4Parameter = new MySqlParameter("@rate_4", MySqlDbType.VarChar, 0);
			MySqlParameter rank_4Parameter = new MySqlParameter("@rank_4", MySqlDbType.VarChar, 0);
			MySqlParameter faction5Parameter = new MySqlParameter("@faction5", MySqlDbType.VarChar, 0);
			MySqlParameter rate_5Parameter = new MySqlParameter("@rate_5", MySqlDbType.VarChar, 0);
			MySqlParameter rank_5Parameter = new MySqlParameter("@rank_5", MySqlDbType.VarChar, 0);
			factionParameter.Value = faction;
			faction1Parameter.Value = faction1;
			rate_1Parameter.Value = rate_1;
			rank_1Parameter.Value = rank_1;
			faction2Parameter.Value = faction2;
			rate_2Parameter.Value = rate_2;
			rank_2Parameter.Value = rank_2;
			faction3Parameter.Value = faction3;
			rate_3Parameter.Value = rate_3;
			rank_3Parameter.Value = rank_3;
			faction4Parameter.Value = faction4;
			rate_4Parameter.Value = rate_4;
			rank_4Parameter.Value = rank_4;
			faction5Parameter.Value = faction5;
			rate_5Parameter.Value = rate_5;
			rank_5Parameter.Value = rank_5;
			cmd.Parameters.Add(factionParameter);
			cmd.Parameters.Add(faction1Parameter);
			cmd.Parameters.Add(rate_1Parameter);
			cmd.Parameters.Add(rank_1Parameter);
			cmd.Parameters.Add(faction2Parameter);
			cmd.Parameters.Add(rate_2Parameter);
			cmd.Parameters.Add(rank_2Parameter);
			cmd.Parameters.Add(faction3Parameter);
			cmd.Parameters.Add(rate_3Parameter);
			cmd.Parameters.Add(rank_3Parameter);
			cmd.Parameters.Add(faction4Parameter);
			cmd.Parameters.Add(rate_4Parameter);
			cmd.Parameters.Add(rank_4Parameter);
			cmd.Parameters.Add(faction5Parameter);
			cmd.Parameters.Add(rate_5Parameter);
			cmd.Parameters.Add(rank_5Parameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE reputation_spillover_template SET faction = @newfaction, faction1 = @newfaction1, rate_1 = @newrate_1, rank_1 = @newrank_1, faction2 = @newfaction2, rate_2 = @newrate_2, rank_2 = @newrank_2, faction3 = @newfaction3, rate_3 = @newrate_3, rank_3 = @newrank_3, faction4 = @newfaction4, rate_4 = @newrate_4, rank_4 = @newrank_4, faction5 = @newfaction5, rate_5 = @newrate_5, rank_5 = @newrank_5 WHERE faction = @faction AND faction1 = @faction1 AND rate_1 = @rate_1 AND rank_1 = @rank_1 AND faction2 = @faction2 AND rate_2 = @rate_2 AND rank_2 = @rank_2 AND faction3 = @faction3 AND rate_3 = @rate_3 AND rank_3 = @rank_3 AND faction4 = @faction4 AND rate_4 = @rate_4 AND rank_4 = @rank_4 AND faction5 = @faction5 AND rate_5 = @rate_5 AND rank_5 = @rank_5;";
			MySqlParameter OLD_factionParameter = new MySqlParameter("@faction", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_faction1Parameter = new MySqlParameter("@faction1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rate_1Parameter = new MySqlParameter("@rate_1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rank_1Parameter = new MySqlParameter("@rank_1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_faction2Parameter = new MySqlParameter("@faction2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rate_2Parameter = new MySqlParameter("@rate_2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rank_2Parameter = new MySqlParameter("@rank_2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_faction3Parameter = new MySqlParameter("@faction3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rate_3Parameter = new MySqlParameter("@rate_3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rank_3Parameter = new MySqlParameter("@rank_3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_faction4Parameter = new MySqlParameter("@faction4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rate_4Parameter = new MySqlParameter("@rate_4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rank_4Parameter = new MySqlParameter("@rank_4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_faction5Parameter = new MySqlParameter("@faction5", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rate_5Parameter = new MySqlParameter("@rate_5", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rank_5Parameter = new MySqlParameter("@rank_5", MySqlDbType.VarChar, 0);
			MySqlParameter factionParameter = new MySqlParameter("@newfaction", MySqlDbType.VarChar, 0);
			MySqlParameter faction1Parameter = new MySqlParameter("@newfaction1", MySqlDbType.VarChar, 0);
			MySqlParameter rate_1Parameter = new MySqlParameter("@newrate_1", MySqlDbType.VarChar, 0);
			MySqlParameter rank_1Parameter = new MySqlParameter("@newrank_1", MySqlDbType.VarChar, 0);
			MySqlParameter faction2Parameter = new MySqlParameter("@newfaction2", MySqlDbType.VarChar, 0);
			MySqlParameter rate_2Parameter = new MySqlParameter("@newrate_2", MySqlDbType.VarChar, 0);
			MySqlParameter rank_2Parameter = new MySqlParameter("@newrank_2", MySqlDbType.VarChar, 0);
			MySqlParameter faction3Parameter = new MySqlParameter("@newfaction3", MySqlDbType.VarChar, 0);
			MySqlParameter rate_3Parameter = new MySqlParameter("@newrate_3", MySqlDbType.VarChar, 0);
			MySqlParameter rank_3Parameter = new MySqlParameter("@newrank_3", MySqlDbType.VarChar, 0);
			MySqlParameter faction4Parameter = new MySqlParameter("@newfaction4", MySqlDbType.VarChar, 0);
			MySqlParameter rate_4Parameter = new MySqlParameter("@newrate_4", MySqlDbType.VarChar, 0);
			MySqlParameter rank_4Parameter = new MySqlParameter("@newrank_4", MySqlDbType.VarChar, 0);
			MySqlParameter faction5Parameter = new MySqlParameter("@newfaction5", MySqlDbType.VarChar, 0);
			MySqlParameter rate_5Parameter = new MySqlParameter("@newrate_5", MySqlDbType.VarChar, 0);
			MySqlParameter rank_5Parameter = new MySqlParameter("@newrank_5", MySqlDbType.VarChar, 0);
			factionParameter.Value = faction;
			faction1Parameter.Value = faction1;
			rate_1Parameter.Value = rate_1;
			rank_1Parameter.Value = rank_1;
			faction2Parameter.Value = faction2;
			rate_2Parameter.Value = rate_2;
			rank_2Parameter.Value = rank_2;
			faction3Parameter.Value = faction3;
			rate_3Parameter.Value = rate_3;
			rank_3Parameter.Value = rank_3;
			faction4Parameter.Value = faction4;
			rate_4Parameter.Value = rate_4;
			rank_4Parameter.Value = rank_4;
			faction5Parameter.Value = faction5;
			rate_5Parameter.Value = rate_5;
			rank_5Parameter.Value = rank_5;
			OLD_factionParameter.Value = OLD_faction;
			OLD_faction1Parameter.Value = OLD_faction1;
			OLD_rate_1Parameter.Value = OLD_rate_1;
			OLD_rank_1Parameter.Value = OLD_rank_1;
			OLD_faction2Parameter.Value = OLD_faction2;
			OLD_rate_2Parameter.Value = OLD_rate_2;
			OLD_rank_2Parameter.Value = OLD_rank_2;
			OLD_faction3Parameter.Value = OLD_faction3;
			OLD_rate_3Parameter.Value = OLD_rate_3;
			OLD_rank_3Parameter.Value = OLD_rank_3;
			OLD_faction4Parameter.Value = OLD_faction4;
			OLD_rate_4Parameter.Value = OLD_rate_4;
			OLD_rank_4Parameter.Value = OLD_rank_4;
			OLD_faction5Parameter.Value = OLD_faction5;
			OLD_rate_5Parameter.Value = OLD_rate_5;
			OLD_rank_5Parameter.Value = OLD_rank_5;
			cmd.Parameters.Add(factionParameter);
			cmd.Parameters.Add(faction1Parameter);
			cmd.Parameters.Add(rate_1Parameter);
			cmd.Parameters.Add(rank_1Parameter);
			cmd.Parameters.Add(faction2Parameter);
			cmd.Parameters.Add(rate_2Parameter);
			cmd.Parameters.Add(rank_2Parameter);
			cmd.Parameters.Add(faction3Parameter);
			cmd.Parameters.Add(rate_3Parameter);
			cmd.Parameters.Add(rank_3Parameter);
			cmd.Parameters.Add(faction4Parameter);
			cmd.Parameters.Add(rate_4Parameter);
			cmd.Parameters.Add(rank_4Parameter);
			cmd.Parameters.Add(faction5Parameter);
			cmd.Parameters.Add(rate_5Parameter);
			cmd.Parameters.Add(rank_5Parameter);
			cmd.Parameters.Add(OLD_factionParameter);
			cmd.Parameters.Add(OLD_faction1Parameter);
			cmd.Parameters.Add(OLD_rate_1Parameter);
			cmd.Parameters.Add(OLD_rank_1Parameter);
			cmd.Parameters.Add(OLD_faction2Parameter);
			cmd.Parameters.Add(OLD_rate_2Parameter);
			cmd.Parameters.Add(OLD_rank_2Parameter);
			cmd.Parameters.Add(OLD_faction3Parameter);
			cmd.Parameters.Add(OLD_rate_3Parameter);
			cmd.Parameters.Add(OLD_rank_3Parameter);
			cmd.Parameters.Add(OLD_faction4Parameter);
			cmd.Parameters.Add(OLD_rate_4Parameter);
			cmd.Parameters.Add(OLD_rank_4Parameter);
			cmd.Parameters.Add(OLD_faction5Parameter);
			cmd.Parameters.Add(OLD_rate_5Parameter);
			cmd.Parameters.Add(OLD_rank_5Parameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_faction = faction;
			OLD_faction1 = faction1;
			OLD_rate_1 = rate_1;
			OLD_rank_1 = rank_1;
			OLD_faction2 = faction2;
			OLD_rate_2 = rate_2;
			OLD_rank_2 = rank_2;
			OLD_faction3 = faction3;
			OLD_rate_3 = rate_3;
			OLD_rank_3 = rank_3;
			OLD_faction4 = faction4;
			OLD_rate_4 = rate_4;
			OLD_rank_4 = rank_4;
			OLD_faction5 = faction5;
			OLD_rate_5 = rate_5;
			OLD_rank_5 = rank_5;
		}
	}
}
