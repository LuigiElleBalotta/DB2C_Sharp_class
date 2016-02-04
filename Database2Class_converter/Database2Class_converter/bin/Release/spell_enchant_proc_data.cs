using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Spell_enchant_proc_data
	{
		int entry = 0; //Comment: 
		int OLD_entry = 0;

		int customChance = 0; //Comment: 
		int OLD_customChance = 0;

		float PPMChance = 0f; //Comment: 
		float OLD_PPMChance = 0f;

		int procEx = 0; //Comment: 
		int OLD_procEx = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Spell_enchant_proc_data(int _entry, int _customChance, float _PPMChance, int _procEx)
		{
			entry = _entry;
			customChance = _customChance;
			PPMChance = _PPMChance;
			procEx = _procEx;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM spell_enchant_proc_data WHERE entry = @entry AND customChance = @customChance AND PPMChance = @PPMChance AND procEx = @procEx;";
			MySqlParameter entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter customchanceParameter = new MySqlParameter("@customChance", MySqlDbType.VarChar, 0);
			MySqlParameter ppmchanceParameter = new MySqlParameter("@PPMChance", MySqlDbType.VarChar, 0);
			MySqlParameter procexParameter = new MySqlParameter("@procEx", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			customchanceParameter.Value = customChance;
			ppmchanceParameter.Value = PPMChance;
			procexParameter.Value = procEx;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(customchanceParameter);
			cmd.Parameters.Add(ppmchanceParameter);
			cmd.Parameters.Add(procexParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE spell_enchant_proc_data SET entry = @newentry, customChance = @newcustomChance, PPMChance = @newPPMChance, procEx = @newprocEx WHERE entry = @entry AND customChance = @customChance AND PPMChance = @PPMChance AND procEx = @procEx;";
			MySqlParameter OLD_entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_customchanceParameter = new MySqlParameter("@customChance", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_ppmchanceParameter = new MySqlParameter("@PPMChance", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_procexParameter = new MySqlParameter("@procEx", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@newentry", MySqlDbType.VarChar, 0);
			MySqlParameter customchanceParameter = new MySqlParameter("@newcustomChance", MySqlDbType.VarChar, 0);
			MySqlParameter ppmchanceParameter = new MySqlParameter("@newPPMChance", MySqlDbType.VarChar, 0);
			MySqlParameter procexParameter = new MySqlParameter("@newprocEx", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			customchanceParameter.Value = customChance;
			ppmchanceParameter.Value = PPMChance;
			procexParameter.Value = procEx;
			OLD_entryParameter.Value = OLD_entry;
			OLD_customchanceParameter.Value = OLD_customChance;
			OLD_ppmchanceParameter.Value = OLD_PPMChance;
			OLD_procexParameter.Value = OLD_procEx;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(customchanceParameter);
			cmd.Parameters.Add(ppmchanceParameter);
			cmd.Parameters.Add(procexParameter);
			cmd.Parameters.Add(OLD_entryParameter);
			cmd.Parameters.Add(OLD_customchanceParameter);
			cmd.Parameters.Add(OLD_ppmchanceParameter);
			cmd.Parameters.Add(OLD_procexParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_entry = entry;
			OLD_customChance = customChance;
			OLD_PPMChance = PPMChance;
			OLD_procEx = procEx;
		}
	}
}
