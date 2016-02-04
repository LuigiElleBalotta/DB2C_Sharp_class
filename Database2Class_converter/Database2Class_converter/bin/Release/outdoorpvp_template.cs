using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Outdoorpvp_template
	{
		int TypeId = 0; //Comment: 
		int OLD_TypeId = 0;

		char ScriptName = Char.MinValue; //Comment: 
		char OLD_ScriptName = Char.MinValue;

		string comment = null; //Comment: 
		string OLD_comment = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Outdoorpvp_template(int _TypeId, char _ScriptName, string _comment)
		{
			TypeId = _TypeId;
			ScriptName = _ScriptName;
			comment = _comment;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM outdoorpvp_template WHERE TypeId = @TypeId AND ScriptName = @ScriptName AND comment = @comment;";
			MySqlParameter typeidParameter = new MySqlParameter("@TypeId", MySqlDbType.VarChar, 0);
			MySqlParameter scriptnameParameter = new MySqlParameter("@ScriptName", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@comment", MySqlDbType.VarChar, 0);
			typeidParameter.Value = TypeId;
			scriptnameParameter.Value = ScriptName;
			commentParameter.Value = comment;
			cmd.Parameters.Add(typeidParameter);
			cmd.Parameters.Add(scriptnameParameter);
			cmd.Parameters.Add(commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE outdoorpvp_template SET TypeId = @newTypeId, ScriptName = @newScriptName, comment = @newcomment WHERE TypeId = @TypeId AND ScriptName = @ScriptName AND comment = @comment;";
			MySqlParameter OLD_typeidParameter = new MySqlParameter("@TypeId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_scriptnameParameter = new MySqlParameter("@ScriptName", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_commentParameter = new MySqlParameter("@comment", MySqlDbType.VarChar, 0);
			MySqlParameter typeidParameter = new MySqlParameter("@newTypeId", MySqlDbType.VarChar, 0);
			MySqlParameter scriptnameParameter = new MySqlParameter("@newScriptName", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@newcomment", MySqlDbType.VarChar, 0);
			typeidParameter.Value = TypeId;
			scriptnameParameter.Value = ScriptName;
			commentParameter.Value = comment;
			OLD_typeidParameter.Value = OLD_TypeId;
			OLD_scriptnameParameter.Value = OLD_ScriptName;
			OLD_commentParameter.Value = OLD_comment;
			cmd.Parameters.Add(typeidParameter);
			cmd.Parameters.Add(scriptnameParameter);
			cmd.Parameters.Add(commentParameter);
			cmd.Parameters.Add(OLD_typeidParameter);
			cmd.Parameters.Add(OLD_scriptnameParameter);
			cmd.Parameters.Add(OLD_commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_TypeId = TypeId;
			OLD_ScriptName = ScriptName;
			OLD_comment = comment;
		}
	}
}
