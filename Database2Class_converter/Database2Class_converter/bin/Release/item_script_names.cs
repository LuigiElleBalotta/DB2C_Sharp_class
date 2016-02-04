using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Item_script_names
	{
		int Id = 0; //Comment: 
		int OLD_Id = 0;

		string ScriptName = null; //Comment: 
		string OLD_ScriptName = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Item_script_names(int _Id, string _ScriptName)
		{
			Id = _Id;
			ScriptName = _ScriptName;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM item_script_names WHERE Id = @Id AND ScriptName = @ScriptName;";
			MySqlParameter idParameter = new MySqlParameter("@Id", MySqlDbType.VarChar, 0);
			MySqlParameter scriptnameParameter = new MySqlParameter("@ScriptName", MySqlDbType.VarChar, 0);
			idParameter.Value = Id;
			scriptnameParameter.Value = ScriptName;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(scriptnameParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE item_script_names SET Id = @newId, ScriptName = @newScriptName WHERE Id = @Id AND ScriptName = @ScriptName;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@Id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_scriptnameParameter = new MySqlParameter("@ScriptName", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newId", MySqlDbType.VarChar, 0);
			MySqlParameter scriptnameParameter = new MySqlParameter("@newScriptName", MySqlDbType.VarChar, 0);
			idParameter.Value = Id;
			scriptnameParameter.Value = ScriptName;
			OLD_idParameter.Value = OLD_Id;
			OLD_scriptnameParameter.Value = OLD_ScriptName;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(scriptnameParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_scriptnameParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_Id = Id;
			OLD_ScriptName = ScriptName;
		}
	}
}
