using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Spell_threat
	{
		int entry = 0; //Comment: 
		int OLD_entry = 0;

		int flatMod = 0; //Comment: 
		int OLD_flatMod = 0;

		float pctMod = 1f; //Comment: threat multiplier for damage/healing
		float OLD_pctMod = 1f;

		float apPctMod = 0f; //Comment: additional threat bonus from attack power
		float OLD_apPctMod = 0f;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Spell_threat(int _entry, int _flatMod, float _pctMod, float _apPctMod)
		{
			entry = _entry;
			flatMod = _flatMod;
			pctMod = _pctMod;
			apPctMod = _apPctMod;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM spell_threat WHERE entry = @entry AND flatMod = @flatMod AND pctMod = @pctMod AND apPctMod = @apPctMod;";
			MySqlParameter entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter flatmodParameter = new MySqlParameter("@flatMod", MySqlDbType.VarChar, 0);
			MySqlParameter pctmodParameter = new MySqlParameter("@pctMod", MySqlDbType.VarChar, 0);
			MySqlParameter appctmodParameter = new MySqlParameter("@apPctMod", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			flatmodParameter.Value = flatMod;
			pctmodParameter.Value = pctMod;
			appctmodParameter.Value = apPctMod;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(flatmodParameter);
			cmd.Parameters.Add(pctmodParameter);
			cmd.Parameters.Add(appctmodParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE spell_threat SET entry = @newentry, flatMod = @newflatMod, pctMod = @newpctMod, apPctMod = @newapPctMod WHERE entry = @entry AND flatMod = @flatMod AND pctMod = @pctMod AND apPctMod = @apPctMod;";
			MySqlParameter OLD_entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_flatmodParameter = new MySqlParameter("@flatMod", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_pctmodParameter = new MySqlParameter("@pctMod", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_appctmodParameter = new MySqlParameter("@apPctMod", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@newentry", MySqlDbType.VarChar, 0);
			MySqlParameter flatmodParameter = new MySqlParameter("@newflatMod", MySqlDbType.VarChar, 0);
			MySqlParameter pctmodParameter = new MySqlParameter("@newpctMod", MySqlDbType.VarChar, 0);
			MySqlParameter appctmodParameter = new MySqlParameter("@newapPctMod", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			flatmodParameter.Value = flatMod;
			pctmodParameter.Value = pctMod;
			appctmodParameter.Value = apPctMod;
			OLD_entryParameter.Value = OLD_entry;
			OLD_flatmodParameter.Value = OLD_flatMod;
			OLD_pctmodParameter.Value = OLD_pctMod;
			OLD_appctmodParameter.Value = OLD_apPctMod;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(flatmodParameter);
			cmd.Parameters.Add(pctmodParameter);
			cmd.Parameters.Add(appctmodParameter);
			cmd.Parameters.Add(OLD_entryParameter);
			cmd.Parameters.Add(OLD_flatmodParameter);
			cmd.Parameters.Add(OLD_pctmodParameter);
			cmd.Parameters.Add(OLD_appctmodParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_entry = entry;
			OLD_flatMod = flatMod;
			OLD_pctMod = pctMod;
			OLD_apPctMod = apPctMod;
		}
	}
}
