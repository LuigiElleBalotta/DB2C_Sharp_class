using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Pet_name_generation
	{
		int id = 0; //Comment: 
		int OLD_id = 0;

		string word = null; //Comment: 
		string OLD_word = null;

		int entry = 0; //Comment: 
		int OLD_entry = 0;

		int half = 0; //Comment: 
		int OLD_half = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Pet_name_generation(int _id, string _word, int _entry, int _half)
		{
			id = _id;
			word = _word;
			entry = _entry;
			half = _half;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM pet_name_generation WHERE id = @id AND word = @word AND entry = @entry AND half = @half;";
			MySqlParameter idParameter = new MySqlParameter("@id", MySqlDbType.VarChar, 0);
			MySqlParameter wordParameter = new MySqlParameter("@word", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter halfParameter = new MySqlParameter("@half", MySqlDbType.VarChar, 0);
			idParameter.Value = id;
			wordParameter.Value = word;
			entryParameter.Value = entry;
			halfParameter.Value = half;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(wordParameter);
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(halfParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE pet_name_generation SET id = @newid, word = @newword, entry = @newentry, half = @newhalf WHERE id = @id AND word = @word AND entry = @entry AND half = @half;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_wordParameter = new MySqlParameter("@word", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_halfParameter = new MySqlParameter("@half", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newid", MySqlDbType.VarChar, 0);
			MySqlParameter wordParameter = new MySqlParameter("@newword", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@newentry", MySqlDbType.VarChar, 0);
			MySqlParameter halfParameter = new MySqlParameter("@newhalf", MySqlDbType.VarChar, 0);
			idParameter.Value = id;
			wordParameter.Value = word;
			entryParameter.Value = entry;
			halfParameter.Value = half;
			OLD_idParameter.Value = OLD_id;
			OLD_wordParameter.Value = OLD_word;
			OLD_entryParameter.Value = OLD_entry;
			OLD_halfParameter.Value = OLD_half;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(wordParameter);
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(halfParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_wordParameter);
			cmd.Parameters.Add(OLD_entryParameter);
			cmd.Parameters.Add(OLD_halfParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_id = id;
			OLD_word = word;
			OLD_entry = entry;
			OLD_half = half;
		}
	}
}
