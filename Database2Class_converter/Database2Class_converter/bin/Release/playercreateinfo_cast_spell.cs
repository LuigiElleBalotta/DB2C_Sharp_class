using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Playercreateinfo_cast_spell
	{
		int raceMask = 0; //Comment: 
		int OLD_raceMask = 0;

		int classMask = 0; //Comment: 
		int OLD_classMask = 0;

		int spell = 0; //Comment: 
		int OLD_spell = 0;

		string note = null; //Comment: 
		string OLD_note = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Playercreateinfo_cast_spell(int _raceMask, int _classMask, int _spell, string _note)
		{
			raceMask = _raceMask;
			classMask = _classMask;
			spell = _spell;
			note = _note;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM playercreateinfo_cast_spell WHERE raceMask = @raceMask AND classMask = @classMask AND spell = @spell AND note = @note;";
			MySqlParameter racemaskParameter = new MySqlParameter("@raceMask", MySqlDbType.VarChar, 0);
			MySqlParameter classmaskParameter = new MySqlParameter("@classMask", MySqlDbType.VarChar, 0);
			MySqlParameter spellParameter = new MySqlParameter("@spell", MySqlDbType.VarChar, 0);
			MySqlParameter noteParameter = new MySqlParameter("@note", MySqlDbType.VarChar, 0);
			racemaskParameter.Value = raceMask;
			classmaskParameter.Value = classMask;
			spellParameter.Value = spell;
			noteParameter.Value = note;
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
			cmd.CommandText = "UPDATE playercreateinfo_cast_spell SET raceMask = @newraceMask, classMask = @newclassMask, spell = @newspell, note = @newnote WHERE raceMask = @raceMask AND classMask = @classMask AND spell = @spell AND note = @note;";
			MySqlParameter OLD_racemaskParameter = new MySqlParameter("@raceMask", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_classmaskParameter = new MySqlParameter("@classMask", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spellParameter = new MySqlParameter("@spell", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_noteParameter = new MySqlParameter("@note", MySqlDbType.VarChar, 0);
			MySqlParameter racemaskParameter = new MySqlParameter("@newraceMask", MySqlDbType.VarChar, 0);
			MySqlParameter classmaskParameter = new MySqlParameter("@newclassMask", MySqlDbType.VarChar, 0);
			MySqlParameter spellParameter = new MySqlParameter("@newspell", MySqlDbType.VarChar, 0);
			MySqlParameter noteParameter = new MySqlParameter("@newnote", MySqlDbType.VarChar, 0);
			racemaskParameter.Value = raceMask;
			classmaskParameter.Value = classMask;
			spellParameter.Value = spell;
			noteParameter.Value = note;
			OLD_racemaskParameter.Value = OLD_raceMask;
			OLD_classmaskParameter.Value = OLD_classMask;
			OLD_spellParameter.Value = OLD_spell;
			OLD_noteParameter.Value = OLD_note;
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
			OLD_raceMask = raceMask;
			OLD_classMask = classMask;
			OLD_spell = spell;
			OLD_note = note;
		}
	}
}
