using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Achievement_criteria_data
	{
		int criteria_id = 0; //Comment: 
		int OLD_criteria_id = 0;

		int type = 0; //Comment: 
		int OLD_type = 0;

		int value1 = 0; //Comment: 
		int OLD_value1 = 0;

		int value2 = 0; //Comment: 
		int OLD_value2 = 0;

		char ScriptName = Char.MinValue; //Comment: 
		char OLD_ScriptName = Char.MinValue;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Achievement_criteria_data(int _criteria_id, int _type, int _value1, int _value2, char _ScriptName)
		{
			criteria_id = _criteria_id;
			type = _type;
			value1 = _value1;
			value2 = _value2;
			ScriptName = _ScriptName;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM achievement_criteria_data WHERE criteria_id = @criteria_id AND type = @type AND value1 = @value1 AND value2 = @value2 AND ScriptName = @ScriptName;";
			MySqlParameter criteria_idParameter = new MySqlParameter("@criteria_id", MySqlDbType.VarChar, 0);
			MySqlParameter typeParameter = new MySqlParameter("@type", MySqlDbType.VarChar, 0);
			MySqlParameter value1Parameter = new MySqlParameter("@value1", MySqlDbType.VarChar, 0);
			MySqlParameter value2Parameter = new MySqlParameter("@value2", MySqlDbType.VarChar, 0);
			MySqlParameter scriptnameParameter = new MySqlParameter("@ScriptName", MySqlDbType.VarChar, 0);
			criteria_idParameter.Value = criteria_id;
			typeParameter.Value = type;
			value1Parameter.Value = value1;
			value2Parameter.Value = value2;
			scriptnameParameter.Value = ScriptName;
			cmd.Parameters.Add(criteria_idParameter);
			cmd.Parameters.Add(typeParameter);
			cmd.Parameters.Add(value1Parameter);
			cmd.Parameters.Add(value2Parameter);
			cmd.Parameters.Add(scriptnameParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE achievement_criteria_data SET criteria_id = @newcriteria_id, type = @newtype, value1 = @newvalue1, value2 = @newvalue2, ScriptName = @newScriptName WHERE criteria_id = @criteria_id AND type = @type AND value1 = @value1 AND value2 = @value2 AND ScriptName = @ScriptName;";
			MySqlParameter OLD_criteria_idParameter = new MySqlParameter("@criteria_id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_typeParameter = new MySqlParameter("@type", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_value1Parameter = new MySqlParameter("@value1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_value2Parameter = new MySqlParameter("@value2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_scriptnameParameter = new MySqlParameter("@ScriptName", MySqlDbType.VarChar, 0);
			MySqlParameter criteria_idParameter = new MySqlParameter("@newcriteria_id", MySqlDbType.VarChar, 0);
			MySqlParameter typeParameter = new MySqlParameter("@newtype", MySqlDbType.VarChar, 0);
			MySqlParameter value1Parameter = new MySqlParameter("@newvalue1", MySqlDbType.VarChar, 0);
			MySqlParameter value2Parameter = new MySqlParameter("@newvalue2", MySqlDbType.VarChar, 0);
			MySqlParameter scriptnameParameter = new MySqlParameter("@newScriptName", MySqlDbType.VarChar, 0);
			criteria_idParameter.Value = criteria_id;
			typeParameter.Value = type;
			value1Parameter.Value = value1;
			value2Parameter.Value = value2;
			scriptnameParameter.Value = ScriptName;
			OLD_criteria_idParameter.Value = OLD_criteria_id;
			OLD_typeParameter.Value = OLD_type;
			OLD_value1Parameter.Value = OLD_value1;
			OLD_value2Parameter.Value = OLD_value2;
			OLD_scriptnameParameter.Value = OLD_ScriptName;
			cmd.Parameters.Add(criteria_idParameter);
			cmd.Parameters.Add(typeParameter);
			cmd.Parameters.Add(value1Parameter);
			cmd.Parameters.Add(value2Parameter);
			cmd.Parameters.Add(scriptnameParameter);
			cmd.Parameters.Add(OLD_criteria_idParameter);
			cmd.Parameters.Add(OLD_typeParameter);
			cmd.Parameters.Add(OLD_value1Parameter);
			cmd.Parameters.Add(OLD_value2Parameter);
			cmd.Parameters.Add(OLD_scriptnameParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_criteria_id = criteria_id;
			OLD_type = type;
			OLD_value1 = value1;
			OLD_value2 = value2;
			OLD_ScriptName = ScriptName;
		}
	}
}
