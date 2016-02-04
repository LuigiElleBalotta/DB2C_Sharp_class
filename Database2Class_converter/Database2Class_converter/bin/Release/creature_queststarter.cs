using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Creature_queststarter
	{
		int id = 0; //Comment: Identifier
		int OLD_id = 0;

		int quest = 0; //Comment: Quest Identifier
		int OLD_quest = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Creature_queststarter(int _id, int _quest)
		{
			id = _id;
			quest = _quest;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM creature_queststarter WHERE id = @id AND quest = @quest;";
			MySqlParameter idParameter = new MySqlParameter("@id", MySqlDbType.VarChar, 0);
			MySqlParameter questParameter = new MySqlParameter("@quest", MySqlDbType.VarChar, 0);
			idParameter.Value = id;
			questParameter.Value = quest;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(questParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE creature_queststarter SET id = @newid, quest = @newquest WHERE id = @id AND quest = @quest;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_questParameter = new MySqlParameter("@quest", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newid", MySqlDbType.VarChar, 0);
			MySqlParameter questParameter = new MySqlParameter("@newquest", MySqlDbType.VarChar, 0);
			idParameter.Value = id;
			questParameter.Value = quest;
			OLD_idParameter.Value = OLD_id;
			OLD_questParameter.Value = OLD_quest;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(questParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_questParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_id = id;
			OLD_quest = quest;
		}
	}
}
