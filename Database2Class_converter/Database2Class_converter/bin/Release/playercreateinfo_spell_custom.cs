using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Playercreateinfo_spell_custom
	{
		int racemask = 0; //Comment: 
		int OLD_racemask = 0;

		int classmask = 0; //Comment: 
		int OLD_classmask = 0;

		int Spell = 0; //Comment: 
		int OLD_Spell = 0;

		string Note = null; //Comment: 
		string OLD_Note = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Playercreateinfo_spell_custom(int _racemask, int _classmask, int _Spell, string _Note)
		{
			racemask = _racemask;
			classmask = _classmask;
			Spell = _Spell;
			Note = _Note;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM playercreateinfo_spell_custom WHERE racemask = @racemask AND classmask = @classmask AND Spell = @Spell AND Note = @Note;";
			MySqlParameter racemaskParameter = new MySqlParameter("@racemask", MySqlDbType.VarChar, 0);
			MySqlParameter classmaskParameter = new MySqlParameter("@classmask", MySqlDbType.VarChar, 0);
			MySqlParameter spellParameter = new MySqlParameter("@Spell", MySqlDbType.VarChar, 0);
			MySqlParameter noteParameter = new MySqlParameter("@Note", MySqlDbType.VarChar, 0);
			racemaskParameter.Value = racemask;
			classmaskParameter.Value = classmask;
			spellParameter.Value = Spell;
			noteParameter.Value = Note;
			cmd.Parameters.Add(racemaskParameter);
			cmd.Parameters.Add(classmaskParameter);
			cmd.Parameters.Add(spellParameter);
			cmd.Parameters.Add(noteParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE playercreateinfo_spell_custom SET racemask = @newracemask, classmask = @newclassmask, Spell = @newSpell, Note = @newNote WHERE racemask = @racemask AND classmask = @classmask AND Spell = @Spell AND Note = @Note;";
			MySqlParameter OLD_racemaskParameter = new MySqlParameter("@racemask", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_classmaskParameter = new MySqlParameter("@classmask", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spellParameter = new MySqlParameter("@Spell", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_noteParameter = new MySqlParameter("@Note", MySqlDbType.VarChar, 0);
			MySqlParameter racemaskParameter = new MySqlParameter("@newracemask", MySqlDbType.VarChar, 0);
			MySqlParameter classmaskParameter = new MySqlParameter("@newclassmask", MySqlDbType.VarChar, 0);
			MySqlParameter spellParameter = new MySqlParameter("@newSpell", MySqlDbType.VarChar, 0);
			MySqlParameter noteParameter = new MySqlParameter("@newNote", MySqlDbType.VarChar, 0);
			racemaskParameter.Value = racemask;
			classmaskParameter.Value = classmask;
			spellParameter.Value = Spell;
			noteParameter.Value = Note;
			OLD_racemaskParameter.Value = OLD_racemask;
			OLD_classmaskParameter.Value = OLD_classmask;
			OLD_spellParameter.Value = OLD_Spell;
			OLD_noteParameter.Value = OLD_Note;
			cmd.Parameters.Add(racemaskParameter);
			cmd.Parameters.Add(classmaskParameter);
			cmd.Parameters.Add(spellParameter);
			cmd.Parameters.Add(noteParameter);
			cmd.Parameters.Add(OLD_racemaskParameter);
			cmd.Parameters.Add(OLD_classmaskParameter);
			cmd.Parameters.Add(OLD_spellParameter);
			cmd.Parameters.Add(OLD_noteParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_racemask = racemask;
			OLD_classmask = classmask;
			OLD_Spell = Spell;
			OLD_Note = Note;
		}
	}
}
