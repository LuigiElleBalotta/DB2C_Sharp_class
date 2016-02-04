using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Gameobject_addon
	{
		int guid = 0; //Comment: 
		int OLD_guid = 0;

		int invisibilityType = 0; //Comment: 
		int OLD_invisibilityType = 0;

		int invisibilityValue = 0; //Comment: 
		int OLD_invisibilityValue = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Gameobject_addon(int _guid, int _invisibilityType, int _invisibilityValue)
		{
			guid = _guid;
			invisibilityType = _invisibilityType;
			invisibilityValue = _invisibilityValue;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM gameobject_addon WHERE guid = @guid AND invisibilityType = @invisibilityType AND invisibilityValue = @invisibilityValue;";
			MySqlParameter guidParameter = new MySqlParameter("@guid", MySqlDbType.VarChar, 0);
			MySqlParameter invisibilitytypeParameter = new MySqlParameter("@invisibilityType", MySqlDbType.VarChar, 0);
			MySqlParameter invisibilityvalueParameter = new MySqlParameter("@invisibilityValue", MySqlDbType.VarChar, 0);
			guidParameter.Value = guid;
			invisibilitytypeParameter.Value = invisibilityType;
			invisibilityvalueParameter.Value = invisibilityValue;
			cmd.Parameters.Add(guidParameter);
			cmd.Parameters.Add(invisibilitytypeParameter);
			cmd.Parameters.Add(invisibilityvalueParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE gameobject_addon SET guid = @newguid, invisibilityType = @newinvisibilityType, invisibilityValue = @newinvisibilityValue WHERE guid = @guid AND invisibilityType = @invisibilityType AND invisibilityValue = @invisibilityValue;";
			MySqlParameter OLD_guidParameter = new MySqlParameter("@guid", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_invisibilitytypeParameter = new MySqlParameter("@invisibilityType", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_invisibilityvalueParameter = new MySqlParameter("@invisibilityValue", MySqlDbType.VarChar, 0);
			MySqlParameter guidParameter = new MySqlParameter("@newguid", MySqlDbType.VarChar, 0);
			MySqlParameter invisibilitytypeParameter = new MySqlParameter("@newinvisibilityType", MySqlDbType.VarChar, 0);
			MySqlParameter invisibilityvalueParameter = new MySqlParameter("@newinvisibilityValue", MySqlDbType.VarChar, 0);
			guidParameter.Value = guid;
			invisibilitytypeParameter.Value = invisibilityType;
			invisibilityvalueParameter.Value = invisibilityValue;
			OLD_guidParameter.Value = OLD_guid;
			OLD_invisibilitytypeParameter.Value = OLD_invisibilityType;
			OLD_invisibilityvalueParameter.Value = OLD_invisibilityValue;
			cmd.Parameters.Add(guidParameter);
			cmd.Parameters.Add(invisibilitytypeParameter);
			cmd.Parameters.Add(invisibilityvalueParameter);
			cmd.Parameters.Add(OLD_guidParameter);
			cmd.Parameters.Add(OLD_invisibilitytypeParameter);
			cmd.Parameters.Add(OLD_invisibilityvalueParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_guid = guid;
			OLD_invisibilityType = invisibilityType;
			OLD_invisibilityValue = invisibilityValue;
		}
	}
}
