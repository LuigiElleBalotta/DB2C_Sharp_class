using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Instance_encounters
	{
		int entry = 0; //Comment: Unique entry from DungeonEncounter.dbc
		int OLD_entry = 0;

		int creditType = 0; //Comment: 
		int OLD_creditType = 0;

		int creditEntry = 0; //Comment: 
		int OLD_creditEntry = 0;

		int lastEncounterDungeon = 0; //Comment: If not 0, LfgDungeon.dbc entry for the instance it is last encounter in
		int OLD_lastEncounterDungeon = 0;

		string comment = null; //Comment: 
		string OLD_comment = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Instance_encounters(int _entry, int _creditType, int _creditEntry, int _lastEncounterDungeon, string _comment)
		{
			entry = _entry;
			creditType = _creditType;
			creditEntry = _creditEntry;
			lastEncounterDungeon = _lastEncounterDungeon;
			comment = _comment;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM instance_encounters WHERE entry = @entry AND creditType = @creditType AND creditEntry = @creditEntry AND lastEncounterDungeon = @lastEncounterDungeon AND comment = @comment;";
			MySqlParameter entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter credittypeParameter = new MySqlParameter("@creditType", MySqlDbType.VarChar, 0);
			MySqlParameter creditentryParameter = new MySqlParameter("@creditEntry", MySqlDbType.VarChar, 0);
			MySqlParameter lastencounterdungeonParameter = new MySqlParameter("@lastEncounterDungeon", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@comment", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			credittypeParameter.Value = creditType;
			creditentryParameter.Value = creditEntry;
			lastencounterdungeonParameter.Value = lastEncounterDungeon;
			commentParameter.Value = comment;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(credittypeParameter);
			cmd.Parameters.Add(creditentryParameter);
			cmd.Parameters.Add(lastencounterdungeonParameter);
			cmd.Parameters.Add(commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE instance_encounters SET entry = @newentry, creditType = @newcreditType, creditEntry = @newcreditEntry, lastEncounterDungeon = @newlastEncounterDungeon, comment = @newcomment WHERE entry = @entry AND creditType = @creditType AND creditEntry = @creditEntry AND lastEncounterDungeon = @lastEncounterDungeon AND comment = @comment;";
			MySqlParameter OLD_entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_credittypeParameter = new MySqlParameter("@creditType", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_creditentryParameter = new MySqlParameter("@creditEntry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_lastencounterdungeonParameter = new MySqlParameter("@lastEncounterDungeon", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_commentParameter = new MySqlParameter("@comment", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@newentry", MySqlDbType.VarChar, 0);
			MySqlParameter credittypeParameter = new MySqlParameter("@newcreditType", MySqlDbType.VarChar, 0);
			MySqlParameter creditentryParameter = new MySqlParameter("@newcreditEntry", MySqlDbType.VarChar, 0);
			MySqlParameter lastencounterdungeonParameter = new MySqlParameter("@newlastEncounterDungeon", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@newcomment", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			credittypeParameter.Value = creditType;
			creditentryParameter.Value = creditEntry;
			lastencounterdungeonParameter.Value = lastEncounterDungeon;
			commentParameter.Value = comment;
			OLD_entryParameter.Value = OLD_entry;
			OLD_credittypeParameter.Value = OLD_creditType;
			OLD_creditentryParameter.Value = OLD_creditEntry;
			OLD_lastencounterdungeonParameter.Value = OLD_lastEncounterDungeon;
			OLD_commentParameter.Value = OLD_comment;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(credittypeParameter);
			cmd.Parameters.Add(creditentryParameter);
			cmd.Parameters.Add(lastencounterdungeonParameter);
			cmd.Parameters.Add(commentParameter);
			cmd.Parameters.Add(OLD_entryParameter);
			cmd.Parameters.Add(OLD_credittypeParameter);
			cmd.Parameters.Add(OLD_creditentryParameter);
			cmd.Parameters.Add(OLD_lastencounterdungeonParameter);
			cmd.Parameters.Add(OLD_commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_entry = entry;
			OLD_creditType = creditType;
			OLD_creditEntry = creditEntry;
			OLD_lastEncounterDungeon = lastEncounterDungeon;
			OLD_comment = comment;
		}
	}
}
