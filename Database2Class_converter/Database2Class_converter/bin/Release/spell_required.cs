using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Spell_required
	{
		int spell_id = 0; //Comment: 
		int OLD_spell_id = 0;

		int req_spell = 0; //Comment: 
		int OLD_req_spell = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Spell_required(int _spell_id, int _req_spell)
		{
			spell_id = _spell_id;
			req_spell = _req_spell;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM spell_required WHERE spell_id = @spell_id AND req_spell = @req_spell;";
			MySqlParameter spell_idParameter = new MySqlParameter("@spell_id", MySqlDbType.VarChar, 0);
			MySqlParameter req_spellParameter = new MySqlParameter("@req_spell", MySqlDbType.VarChar, 0);
			spell_idParameter.Value = spell_id;
			req_spellParameter.Value = req_spell;
			cmd.Parameters.Add(spell_idParameter);
			cmd.Parameters.Add(req_spellParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE spell_required SET spell_id = @newspell_id, req_spell = @newreq_spell WHERE spell_id = @spell_id AND req_spell = @req_spell;";
			MySqlParameter OLD_spell_idParameter = new MySqlParameter("@spell_id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_req_spellParameter = new MySqlParameter("@req_spell", MySqlDbType.VarChar, 0);
			MySqlParameter spell_idParameter = new MySqlParameter("@newspell_id", MySqlDbType.VarChar, 0);
			MySqlParameter req_spellParameter = new MySqlParameter("@newreq_spell", MySqlDbType.VarChar, 0);
			spell_idParameter.Value = spell_id;
			req_spellParameter.Value = req_spell;
			OLD_spell_idParameter.Value = OLD_spell_id;
			OLD_req_spellParameter.Value = OLD_req_spell;
			cmd.Parameters.Add(spell_idParameter);
			cmd.Parameters.Add(req_spellParameter);
			cmd.Parameters.Add(OLD_spell_idParameter);
			cmd.Parameters.Add(OLD_req_spellParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_spell_id = spell_id;
			OLD_req_spell = req_spell;
		}
	}
}
