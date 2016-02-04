using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Lfg_dungeon_rewards
	{
		int dungeonId = 0; //Comment: Dungeon entry from dbc
		int OLD_dungeonId = 0;

		int maxLevel = 0; //Comment: Max level at which this reward is rewarded
		int OLD_maxLevel = 0;

		int firstQuestId = 0; //Comment: Quest id with rewards for first dungeon this day
		int OLD_firstQuestId = 0;

		int otherQuestId = 0; //Comment: Quest id with rewards for Nth dungeon this day
		int OLD_otherQuestId = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Lfg_dungeon_rewards(int _dungeonId, int _maxLevel, int _firstQuestId, int _otherQuestId)
		{
			dungeonId = _dungeonId;
			maxLevel = _maxLevel;
			firstQuestId = _firstQuestId;
			otherQuestId = _otherQuestId;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM lfg_dungeon_rewards WHERE dungeonId = @dungeonId AND maxLevel = @maxLevel AND firstQuestId = @firstQuestId AND otherQuestId = @otherQuestId;";
			MySqlParameter dungeonidParameter = new MySqlParameter("@dungeonId", MySqlDbType.VarChar, 0);
			MySqlParameter maxlevelParameter = new MySqlParameter("@maxLevel", MySqlDbType.VarChar, 0);
			MySqlParameter firstquestidParameter = new MySqlParameter("@firstQuestId", MySqlDbType.VarChar, 0);
			MySqlParameter otherquestidParameter = new MySqlParameter("@otherQuestId", MySqlDbType.VarChar, 0);
			dungeonidParameter.Value = dungeonId;
			maxlevelParameter.Value = maxLevel;
			firstquestidParameter.Value = firstQuestId;
			otherquestidParameter.Value = otherQuestId;
			cmd.Parameters.Add(dungeonidParameter);
			cmd.Parameters.Add(maxlevelParameter);
			cmd.Parameters.Add(firstquestidParameter);
			cmd.Parameters.Add(otherquestidParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE lfg_dungeon_rewards SET dungeonId = @newdungeonId, maxLevel = @newmaxLevel, firstQuestId = @newfirstQuestId, otherQuestId = @newotherQuestId WHERE dungeonId = @dungeonId AND maxLevel = @maxLevel AND firstQuestId = @firstQuestId AND otherQuestId = @otherQuestId;";
			MySqlParameter OLD_dungeonidParameter = new MySqlParameter("@dungeonId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_maxlevelParameter = new MySqlParameter("@maxLevel", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_firstquestidParameter = new MySqlParameter("@firstQuestId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_otherquestidParameter = new MySqlParameter("@otherQuestId", MySqlDbType.VarChar, 0);
			MySqlParameter dungeonidParameter = new MySqlParameter("@newdungeonId", MySqlDbType.VarChar, 0);
			MySqlParameter maxlevelParameter = new MySqlParameter("@newmaxLevel", MySqlDbType.VarChar, 0);
			MySqlParameter firstquestidParameter = new MySqlParameter("@newfirstQuestId", MySqlDbType.VarChar, 0);
			MySqlParameter otherquestidParameter = new MySqlParameter("@newotherQuestId", MySqlDbType.VarChar, 0);
			dungeonidParameter.Value = dungeonId;
			maxlevelParameter.Value = maxLevel;
			firstquestidParameter.Value = firstQuestId;
			otherquestidParameter.Value = otherQuestId;
			OLD_dungeonidParameter.Value = OLD_dungeonId;
			OLD_maxlevelParameter.Value = OLD_maxLevel;
			OLD_firstquestidParameter.Value = OLD_firstQuestId;
			OLD_otherquestidParameter.Value = OLD_otherQuestId;
			cmd.Parameters.Add(dungeonidParameter);
			cmd.Parameters.Add(maxlevelParameter);
			cmd.Parameters.Add(firstquestidParameter);
			cmd.Parameters.Add(otherquestidParameter);
			cmd.Parameters.Add(OLD_dungeonidParameter);
			cmd.Parameters.Add(OLD_maxlevelParameter);
			cmd.Parameters.Add(OLD_firstquestidParameter);
			cmd.Parameters.Add(OLD_otherquestidParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_dungeonId = dungeonId;
			OLD_maxLevel = maxLevel;
			OLD_firstQuestId = firstQuestId;
			OLD_otherQuestId = otherQuestId;
		}
	}
}
