using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Garrison_follower_class_spec_abilities
	{
		int classSpecId = 0; //Comment: 
		int OLD_classSpecId = 0;

		int abilityId = 0; //Comment: 
		int OLD_abilityId = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Garrison_follower_class_spec_abilities(int _classSpecId, int _abilityId)
		{
			classSpecId = _classSpecId;
			abilityId = _abilityId;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM garrison_follower_class_spec_abilities WHERE classSpecId = @classSpecId AND abilityId = @abilityId;";
			MySqlParameter classspecidParameter = new MySqlParameter("@classSpecId", MySqlDbType.VarChar, 0);
			MySqlParameter abilityidParameter = new MySqlParameter("@abilityId", MySqlDbType.VarChar, 0);
			classspecidParameter.Value = classSpecId;
			abilityidParameter.Value = abilityId;
			cmd.Parameters.Add(classspecidParameter);
			cmd.Parameters.Add(abilityidParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE garrison_follower_class_spec_abilities SET classSpecId = @newclassSpecId, abilityId = @newabilityId WHERE classSpecId = @classSpecId AND abilityId = @abilityId;";
			MySqlParameter OLD_classspecidParameter = new MySqlParameter("@classSpecId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_abilityidParameter = new MySqlParameter("@abilityId", MySqlDbType.VarChar, 0);
			MySqlParameter classspecidParameter = new MySqlParameter("@newclassSpecId", MySqlDbType.VarChar, 0);
			MySqlParameter abilityidParameter = new MySqlParameter("@newabilityId", MySqlDbType.VarChar, 0);
			classspecidParameter.Value = classSpecId;
			abilityidParameter.Value = abilityId;
			OLD_classspecidParameter.Value = OLD_classSpecId;
			OLD_abilityidParameter.Value = OLD_abilityId;
			cmd.Parameters.Add(classspecidParameter);
			cmd.Parameters.Add(abilityidParameter);
			cmd.Parameters.Add(OLD_classspecidParameter);
			cmd.Parameters.Add(OLD_abilityidParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_classSpecId = classSpecId;
			OLD_abilityId = abilityId;
		}
	}
}
