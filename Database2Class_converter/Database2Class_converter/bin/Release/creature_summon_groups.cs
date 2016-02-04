using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Creature_summon_groups
	{
		int summonerId = 0; //Comment: 
		int OLD_summonerId = 0;

		int summonerType = 0; //Comment: 
		int OLD_summonerType = 0;

		int groupId = 0; //Comment: 
		int OLD_groupId = 0;

		int entry = 0; //Comment: 
		int OLD_entry = 0;

		float position_x = 0f; //Comment: 
		float OLD_position_x = 0f;

		float position_y = 0f; //Comment: 
		float OLD_position_y = 0f;

		float position_z = 0f; //Comment: 
		float OLD_position_z = 0f;

		float orientation = 0f; //Comment: 
		float OLD_orientation = 0f;

		int summonType = 0; //Comment: 
		int OLD_summonType = 0;

		int summonTime = 0; //Comment: 
		int OLD_summonTime = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Creature_summon_groups(int _summonerId, int _summonerType, int _groupId, int _entry, float _position_x, float _position_y, float _position_z, float _orientation, int _summonType, int _summonTime)
		{
			summonerId = _summonerId;
			summonerType = _summonerType;
			groupId = _groupId;
			entry = _entry;
			position_x = _position_x;
			position_y = _position_y;
			position_z = _position_z;
			orientation = _orientation;
			summonType = _summonType;
			summonTime = _summonTime;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM creature_summon_groups WHERE summonerId = @summonerId AND summonerType = @summonerType AND groupId = @groupId AND entry = @entry AND position_x = @position_x AND position_y = @position_y AND position_z = @position_z AND orientation = @orientation AND summonType = @summonType AND summonTime = @summonTime;";
			MySqlParameter summoneridParameter = new MySqlParameter("@summonerId", MySqlDbType.VarChar, 0);
			MySqlParameter summonertypeParameter = new MySqlParameter("@summonerType", MySqlDbType.VarChar, 0);
			MySqlParameter groupidParameter = new MySqlParameter("@groupId", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter position_xParameter = new MySqlParameter("@position_x", MySqlDbType.VarChar, 0);
			MySqlParameter position_yParameter = new MySqlParameter("@position_y", MySqlDbType.VarChar, 0);
			MySqlParameter position_zParameter = new MySqlParameter("@position_z", MySqlDbType.VarChar, 0);
			MySqlParameter orientationParameter = new MySqlParameter("@orientation", MySqlDbType.VarChar, 0);
			MySqlParameter summontypeParameter = new MySqlParameter("@summonType", MySqlDbType.VarChar, 0);
			MySqlParameter summontimeParameter = new MySqlParameter("@summonTime", MySqlDbType.VarChar, 0);
			summoneridParameter.Value = summonerId;
			summonertypeParameter.Value = summonerType;
			groupidParameter.Value = groupId;
			entryParameter.Value = entry;
			position_xParameter.Value = position_x;
			position_yParameter.Value = position_y;
			position_zParameter.Value = position_z;
			orientationParameter.Value = orientation;
			summontypeParameter.Value = summonType;
			summontimeParameter.Value = summonTime;
			cmd.Parameters.Add(summoneridParameter);
			cmd.Parameters.Add(summonertypeParameter);
			cmd.Parameters.Add(groupidParameter);
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(position_xParameter);
			cmd.Parameters.Add(position_yParameter);
			cmd.Parameters.Add(position_zParameter);
			cmd.Parameters.Add(orientationParameter);
			cmd.Parameters.Add(summontypeParameter);
			cmd.Parameters.Add(summontimeParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE creature_summon_groups SET summonerId = @newsummonerId, summonerType = @newsummonerType, groupId = @newgroupId, entry = @newentry, position_x = @newposition_x, position_y = @newposition_y, position_z = @newposition_z, orientation = @neworientation, summonType = @newsummonType, summonTime = @newsummonTime WHERE summonerId = @summonerId AND summonerType = @summonerType AND groupId = @groupId AND entry = @entry AND position_x = @position_x AND position_y = @position_y AND position_z = @position_z AND orientation = @orientation AND summonType = @summonType AND summonTime = @summonTime;";
			MySqlParameter OLD_summoneridParameter = new MySqlParameter("@summonerId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_summonertypeParameter = new MySqlParameter("@summonerType", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_groupidParameter = new MySqlParameter("@groupId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_position_xParameter = new MySqlParameter("@position_x", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_position_yParameter = new MySqlParameter("@position_y", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_position_zParameter = new MySqlParameter("@position_z", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_orientationParameter = new MySqlParameter("@orientation", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_summontypeParameter = new MySqlParameter("@summonType", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_summontimeParameter = new MySqlParameter("@summonTime", MySqlDbType.VarChar, 0);
			MySqlParameter summoneridParameter = new MySqlParameter("@newsummonerId", MySqlDbType.VarChar, 0);
			MySqlParameter summonertypeParameter = new MySqlParameter("@newsummonerType", MySqlDbType.VarChar, 0);
			MySqlParameter groupidParameter = new MySqlParameter("@newgroupId", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@newentry", MySqlDbType.VarChar, 0);
			MySqlParameter position_xParameter = new MySqlParameter("@newposition_x", MySqlDbType.VarChar, 0);
			MySqlParameter position_yParameter = new MySqlParameter("@newposition_y", MySqlDbType.VarChar, 0);
			MySqlParameter position_zParameter = new MySqlParameter("@newposition_z", MySqlDbType.VarChar, 0);
			MySqlParameter orientationParameter = new MySqlParameter("@neworientation", MySqlDbType.VarChar, 0);
			MySqlParameter summontypeParameter = new MySqlParameter("@newsummonType", MySqlDbType.VarChar, 0);
			MySqlParameter summontimeParameter = new MySqlParameter("@newsummonTime", MySqlDbType.VarChar, 0);
			summoneridParameter.Value = summonerId;
			summonertypeParameter.Value = summonerType;
			groupidParameter.Value = groupId;
			entryParameter.Value = entry;
			position_xParameter.Value = position_x;
			position_yParameter.Value = position_y;
			position_zParameter.Value = position_z;
			orientationParameter.Value = orientation;
			summontypeParameter.Value = summonType;
			summontimeParameter.Value = summonTime;
			OLD_summoneridParameter.Value = OLD_summonerId;
			OLD_summonertypeParameter.Value = OLD_summonerType;
			OLD_groupidParameter.Value = OLD_groupId;
			OLD_entryParameter.Value = OLD_entry;
			OLD_position_xParameter.Value = OLD_position_x;
			OLD_position_yParameter.Value = OLD_position_y;
			OLD_position_zParameter.Value = OLD_position_z;
			OLD_orientationParameter.Value = OLD_orientation;
			OLD_summontypeParameter.Value = OLD_summonType;
			OLD_summontimeParameter.Value = OLD_summonTime;
			cmd.Parameters.Add(summoneridParameter);
			cmd.Parameters.Add(summonertypeParameter);
			cmd.Parameters.Add(groupidParameter);
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(position_xParameter);
			cmd.Parameters.Add(position_yParameter);
			cmd.Parameters.Add(position_zParameter);
			cmd.Parameters.Add(orientationParameter);
			cmd.Parameters.Add(summontypeParameter);
			cmd.Parameters.Add(summontimeParameter);
			cmd.Parameters.Add(OLD_summoneridParameter);
			cmd.Parameters.Add(OLD_summonertypeParameter);
			cmd.Parameters.Add(OLD_groupidParameter);
			cmd.Parameters.Add(OLD_entryParameter);
			cmd.Parameters.Add(OLD_position_xParameter);
			cmd.Parameters.Add(OLD_position_yParameter);
			cmd.Parameters.Add(OLD_position_zParameter);
			cmd.Parameters.Add(OLD_orientationParameter);
			cmd.Parameters.Add(OLD_summontypeParameter);
			cmd.Parameters.Add(OLD_summontimeParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_summonerId = summonerId;
			OLD_summonerType = summonerType;
			OLD_groupId = groupId;
			OLD_entry = entry;
			OLD_position_x = position_x;
			OLD_position_y = position_y;
			OLD_position_z = position_z;
			OLD_orientation = orientation;
			OLD_summonType = summonType;
			OLD_summonTime = summonTime;
		}
	}
}
