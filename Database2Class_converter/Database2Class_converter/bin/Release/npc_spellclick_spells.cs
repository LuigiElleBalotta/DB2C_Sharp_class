using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Npc_spellclick_spells
	{
		int npc_entry = 0; //Comment: reference to creature_template
		int OLD_npc_entry = 0;

		int spell_id = 0; //Comment: spell which should be casted 
		int OLD_spell_id = 0;

		int cast_flags = 0; //Comment: first bit defines caster: 1=player, 0=creature; second bit defines target, same mapping as caster bit
		int OLD_cast_flags = 0;

		int user_type = 0; //Comment: relation with summoner: 0-no 1-friendly 2-raid 3-party player can click
		int OLD_user_type = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Npc_spellclick_spells(int _npc_entry, int _spell_id, int _cast_flags, int _user_type)
		{
			npc_entry = _npc_entry;
			spell_id = _spell_id;
			cast_flags = _cast_flags;
			user_type = _user_type;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM npc_spellclick_spells WHERE npc_entry = @npc_entry AND spell_id = @spell_id AND cast_flags = @cast_flags AND user_type = @user_type;";
			MySqlParameter npc_entryParameter = new MySqlParameter("@npc_entry", MySqlDbType.VarChar, 0);
			MySqlParameter spell_idParameter = new MySqlParameter("@spell_id", MySqlDbType.VarChar, 0);
			MySqlParameter cast_flagsParameter = new MySqlParameter("@cast_flags", MySqlDbType.VarChar, 0);
			MySqlParameter user_typeParameter = new MySqlParameter("@user_type", MySqlDbType.VarChar, 0);
			npc_entryParameter.Value = npc_entry;
			spell_idParameter.Value = spell_id;
			cast_flagsParameter.Value = cast_flags;
			user_typeParameter.Value = user_type;
			cmd.Parameters.Add(npc_entryParameter);
			cmd.Parameters.Add(spell_idParameter);
			cmd.Parameters.Add(cast_flagsParameter);
			cmd.Parameters.Add(user_typeParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE npc_spellclick_spells SET npc_entry = @newnpc_entry, spell_id = @newspell_id, cast_flags = @newcast_flags, user_type = @newuser_type WHERE npc_entry = @npc_entry AND spell_id = @spell_id AND cast_flags = @cast_flags AND user_type = @user_type;";
			MySqlParameter OLD_npc_entryParameter = new MySqlParameter("@npc_entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spell_idParameter = new MySqlParameter("@spell_id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_cast_flagsParameter = new MySqlParameter("@cast_flags", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_user_typeParameter = new MySqlParameter("@user_type", MySqlDbType.VarChar, 0);
			MySqlParameter npc_entryParameter = new MySqlParameter("@newnpc_entry", MySqlDbType.VarChar, 0);
			MySqlParameter spell_idParameter = new MySqlParameter("@newspell_id", MySqlDbType.VarChar, 0);
			MySqlParameter cast_flagsParameter = new MySqlParameter("@newcast_flags", MySqlDbType.VarChar, 0);
			MySqlParameter user_typeParameter = new MySqlParameter("@newuser_type", MySqlDbType.VarChar, 0);
			npc_entryParameter.Value = npc_entry;
			spell_idParameter.Value = spell_id;
			cast_flagsParameter.Value = cast_flags;
			user_typeParameter.Value = user_type;
			OLD_npc_entryParameter.Value = OLD_npc_entry;
			OLD_spell_idParameter.Value = OLD_spell_id;
			OLD_cast_flagsParameter.Value = OLD_cast_flags;
			OLD_user_typeParameter.Value = OLD_user_type;
			cmd.Parameters.Add(npc_entryParameter);
			cmd.Parameters.Add(spell_idParameter);
			cmd.Parameters.Add(cast_flagsParameter);
			cmd.Parameters.Add(user_typeParameter);
			cmd.Parameters.Add(OLD_npc_entryParameter);
			cmd.Parameters.Add(OLD_spell_idParameter);
			cmd.Parameters.Add(OLD_cast_flagsParameter);
			cmd.Parameters.Add(OLD_user_typeParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_npc_entry = npc_entry;
			OLD_spell_id = spell_id;
			OLD_cast_flags = cast_flags;
			OLD_user_type = user_type;
		}
	}
}
