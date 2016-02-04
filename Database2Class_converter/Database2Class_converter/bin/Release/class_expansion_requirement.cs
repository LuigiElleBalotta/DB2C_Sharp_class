using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Class_expansion_requirement
	{
		int classID = 0; //Comment: 
		int OLD_classID = 0;

		int expansion = 0; //Comment: 
		int OLD_expansion = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Class_expansion_requirement(int _classID, int _expansion)
		{
			classID = _classID;
			expansion = _expansion;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM class_expansion_requirement WHERE classID = @classID AND expansion = @expansion;";
			MySqlParameter classidParameter = new MySqlParameter("@classID", MySqlDbType.VarChar, 0);
			MySqlParameter expansionParameter = new MySqlParameter("@expansion", MySqlDbType.VarChar, 0);
			classidParameter.Value = classID;
			expansionParameter.Value = expansion;
			cmd.Parameters.Add(classidParameter);
			cmd.Parameters.Add(expansionParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE class_expansion_requirement SET classID = @newclassID, expansion = @newexpansion WHERE classID = @classID AND expansion = @expansion;";
			MySqlParameter OLD_classidParameter = new MySqlParameter("@classID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_expansionParameter = new MySqlParameter("@expansion", MySqlDbType.VarChar, 0);
			MySqlParameter classidParameter = new MySqlParameter("@newclassID", MySqlDbType.VarChar, 0);
			MySqlParameter expansionParameter = new MySqlParameter("@newexpansion", MySqlDbType.VarChar, 0);
			classidParameter.Value = classID;
			expansionParameter.Value = expansion;
			OLD_classidParameter.Value = OLD_classID;
			OLD_expansionParameter.Value = OLD_expansion;
			cmd.Parameters.Add(classidParameter);
			cmd.Parameters.Add(expansionParameter);
			cmd.Parameters.Add(OLD_classidParameter);
			cmd.Parameters.Add(OLD_expansionParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_classID = classID;
			OLD_expansion = expansion;
		}
	}
}
