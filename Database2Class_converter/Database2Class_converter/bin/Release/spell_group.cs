using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Spell_group
	{
		int id = 0; //Comment: 
		int OLD_id = 0;

		int spell_id = 0; //Comment: 
		int OLD_spell_id = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Spell_group(int _id, int _spell_id)
		{
			id = _id;
			spell_id = _spell_id;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM spell_group WHERE id = @id AND spell_id = @spell_id;";
			MySqlParameter idParameter = new MySqlParameter("@id", MySqlDbType.VarChar, 0);
			MySqlParameter spell_idParameter = new MySqlParameter("@spell_id", MySqlDbType.VarChar, 0);
			idParameter.Value = id;
			spell_idParameter.Value = spell_id;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(spell_idParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE spell_group SET id = @newid, spell_id = @newspell_id WHERE id = @id AND spell_id = @spell_id;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spell_idParameter = new MySqlParameter("@spell_id", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newid", MySqlDbType.VarChar, 0);
			MySqlParameter spell_idParameter = new MySqlParameter("@newspell_id", MySqlDbType.VarChar, 0);
			idParameter.Value = id;
			spell_idParameter.Value = spell_id;
			OLD_idParameter.Value = OLD_id;
			OLD_spell_idParameter.Value = OLD_spell_id;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(spell_idParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_spell_idParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_id = id;
			OLD_spell_id = spell_id;
		}
	}
}
