using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Transports
	{
		int guid = 0; //Comment: 
		int OLD_guid = 0;

		int entry = 0; //Comment: 
		int OLD_entry = 0;

		string name = null; //Comment: 
		string OLD_name = null;

		int phaseid = 0; //Comment: 
		int OLD_phaseid = 0;

		int phasegroup = 0; //Comment: 
		int OLD_phasegroup = 0;

		char ScriptName = Char.MinValue; //Comment: 
		char OLD_ScriptName = Char.MinValue;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Transports(int _guid, int _entry, string _name, int _phaseid, int _phasegroup, char _ScriptName)
		{
			guid = _guid;
			entry = _entry;
			name = _name;
			phaseid = _phaseid;
			phasegroup = _phasegroup;
			ScriptName = _ScriptName;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM transports WHERE guid = @guid AND entry = @entry AND name = @name AND phaseid = @phaseid AND phasegroup = @phasegroup AND ScriptName = @ScriptName;";
			MySqlParameter guidParameter = new MySqlParameter("@guid", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter nameParameter = new MySqlParameter("@name", MySqlDbType.VarChar, 0);
			MySqlParameter phaseidParameter = new MySqlParameter("@phaseid", MySqlDbType.VarChar, 0);
			MySqlParameter phasegroupParameter = new MySqlParameter("@phasegroup", MySqlDbType.VarChar, 0);
			MySqlParameter scriptnameParameter = new MySqlParameter("@ScriptName", MySqlDbType.VarChar, 0);
			guidParameter.Value = guid;
			entryParameter.Value = entry;
			nameParameter.Value = name;
			phaseidParameter.Value = phaseid;
			phasegroupParameter.Value = phasegroup;
			scriptnameParameter.Value = ScriptName;
			cmd.Parameters.Add(guidParameter);
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(nameParameter);
			cmd.Parameters.Add(phaseidParameter);
			cmd.Parameters.Add(phasegroupParameter);
			cmd.Parameters.Add(scriptnameParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE transports SET guid = @newguid, entry = @newentry, name = @newname, phaseid = @newphaseid, phasegroup = @newphasegroup, ScriptName = @newScriptName WHERE guid = @guid AND entry = @entry AND name = @name AND phaseid = @phaseid AND phasegroup = @phasegroup AND ScriptName = @ScriptName;";
			MySqlParameter OLD_guidParameter = new MySqlParameter("@guid", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_nameParameter = new MySqlParameter("@name", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_phaseidParameter = new MySqlParameter("@phaseid", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_phasegroupParameter = new MySqlParameter("@phasegroup", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_scriptnameParameter = new MySqlParameter("@ScriptName", MySqlDbType.VarChar, 0);
			MySqlParameter guidParameter = new MySqlParameter("@newguid", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@newentry", MySqlDbType.VarChar, 0);
			MySqlParameter nameParameter = new MySqlParameter("@newname", MySqlDbType.VarChar, 0);
			MySqlParameter phaseidParameter = new MySqlParameter("@newphaseid", MySqlDbType.VarChar, 0);
			MySqlParameter phasegroupParameter = new MySqlParameter("@newphasegroup", MySqlDbType.VarChar, 0);
			MySqlParameter scriptnameParameter = new MySqlParameter("@newScriptName", MySqlDbType.VarChar, 0);
			guidParameter.Value = guid;
			entryParameter.Value = entry;
			nameParameter.Value = name;
			phaseidParameter.Value = phaseid;
			phasegroupParameter.Value = phasegroup;
			scriptnameParameter.Value = ScriptName;
			OLD_guidParameter.Value = OLD_guid;
			OLD_entryParameter.Value = OLD_entry;
			OLD_nameParameter.Value = OLD_name;
			OLD_phaseidParameter.Value = OLD_phaseid;
			OLD_phasegroupParameter.Value = OLD_phasegroup;
			OLD_scriptnameParameter.Value = OLD_ScriptName;
			cmd.Parameters.Add(guidParameter);
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(nameParameter);
			cmd.Parameters.Add(phaseidParameter);
			cmd.Parameters.Add(phasegroupParameter);
			cmd.Parameters.Add(scriptnameParameter);
			cmd.Parameters.Add(OLD_guidParameter);
			cmd.Parameters.Add(OLD_entryParameter);
			cmd.Parameters.Add(OLD_nameParameter);
			cmd.Parameters.Add(OLD_phaseidParameter);
			cmd.Parameters.Add(OLD_phasegroupParameter);
			cmd.Parameters.Add(OLD_scriptnameParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_guid = guid;
			OLD_entry = entry;
			OLD_name = name;
			OLD_phaseid = phaseid;
			OLD_phasegroup = phasegroup;
			OLD_ScriptName = ScriptName;
		}
	}
}
