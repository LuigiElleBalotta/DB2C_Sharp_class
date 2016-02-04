using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Spell_ranks
	{
		int first_spell_id = 0; //Comment: 
		int OLD_first_spell_id = 0;

		int spell_id = 0; //Comment: 
		int OLD_spell_id = 0;

		int rank = 0; //Comment: 
		int OLD_rank = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Spell_ranks(int _first_spell_id, int _spell_id, int _rank)
		{
			first_spell_id = _first_spell_id;
			spell_id = _spell_id;
			rank = _rank;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM spell_ranks WHERE first_spell_id = @first_spell_id AND spell_id = @spell_id AND rank = @rank;";
			MySqlParameter first_spell_idParameter = new MySqlParameter("@first_spell_id", MySqlDbType.VarChar, 0);
			MySqlParameter spell_idParameter = new MySqlParameter("@spell_id", MySqlDbType.VarChar, 0);
			MySqlParameter rankParameter = new MySqlParameter("@rank", MySqlDbType.VarChar, 0);
			first_spell_idParameter.Value = first_spell_id;
			spell_idParameter.Value = spell_id;
			rankParameter.Value = rank;
			cmd.Parameters.Add(first_spell_idParameter);
			cmd.Parameters.Add(spell_idParameter);
			cmd.Parameters.Add(rankParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE spell_ranks SET first_spell_id = @newfirst_spell_id, spell_id = @newspell_id, rank = @newrank WHERE first_spell_id = @first_spell_id AND spell_id = @spell_id AND rank = @rank;";
			MySqlParameter OLD_first_spell_idParameter = new MySqlParameter("@first_spell_id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spell_idParameter = new MySqlParameter("@spell_id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rankParameter = new MySqlParameter("@rank", MySqlDbType.VarChar, 0);
			MySqlParameter first_spell_idParameter = new MySqlParameter("@newfirst_spell_id", MySqlDbType.VarChar, 0);
			MySqlParameter spell_idParameter = new MySqlParameter("@newspell_id", MySqlDbType.VarChar, 0);
			MySqlParameter rankParameter = new MySqlParameter("@newrank", MySqlDbType.VarChar, 0);
			first_spell_idParameter.Value = first_spell_id;
			spell_idParameter.Value = spell_id;
			rankParameter.Value = rank;
			OLD_first_spell_idParameter.Value = OLD_first_spell_id;
			OLD_spell_idParameter.Value = OLD_spell_id;
			OLD_rankParameter.Value = OLD_rank;
			cmd.Parameters.Add(first_spell_idParameter);
			cmd.Parameters.Add(spell_idParameter);
			cmd.Parameters.Add(rankParameter);
			cmd.Parameters.Add(OLD_first_spell_idParameter);
			cmd.Parameters.Add(OLD_spell_idParameter);
			cmd.Parameters.Add(OLD_rankParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_first_spell_id = first_spell_id;
			OLD_spell_id = spell_id;
			OLD_rank = rank;
		}
	}
}
