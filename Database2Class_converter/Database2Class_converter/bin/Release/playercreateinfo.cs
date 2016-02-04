using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Playercreateinfo
	{
		int race = 0; //Comment: 
		int OLD_race = 0;

		int class_var = 0; //Comment: 
		int OLD_class_var = 0;

		int map = 0; //Comment: 
		int OLD_map = 0;

		int zone = 0; //Comment: 
		int OLD_zone = 0;

		float position_x = 0f; //Comment: 
		float OLD_position_x = 0f;

		float position_y = 0f; //Comment: 
		float OLD_position_y = 0f;

		float position_z = 0f; //Comment: 
		float OLD_position_z = 0f;

		float orientation = 0f; //Comment: 
		float OLD_orientation = 0f;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Playercreateinfo(int _race, int _class_var, int _map, int _zone, float _position_x, float _position_y, float _position_z, float _orientation)
		{
			race = _race;
			class_var = _class_var;
			map = _map;
			zone = _zone;
			position_x = _position_x;
			position_y = _position_y;
			position_z = _position_z;
			orientation = _orientation;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM playercreateinfo WHERE race = @race AND class_var = @class_var AND map = @map AND zone = @zone AND position_x = @position_x AND position_y = @position_y AND position_z = @position_z AND orientation = @orientation;";
			MySqlParameter raceParameter = new MySqlParameter("@race", MySqlDbType.VarChar, 0);
			MySqlParameter class_varParameter = new MySqlParameter("@class_var", MySqlDbType.VarChar, 0);
			MySqlParameter mapParameter = new MySqlParameter("@map", MySqlDbType.VarChar, 0);
			MySqlParameter zoneParameter = new MySqlParameter("@zone", MySqlDbType.VarChar, 0);
			MySqlParameter position_xParameter = new MySqlParameter("@position_x", MySqlDbType.VarChar, 0);
			MySqlParameter position_yParameter = new MySqlParameter("@position_y", MySqlDbType.VarChar, 0);
			MySqlParameter position_zParameter = new MySqlParameter("@position_z", MySqlDbType.VarChar, 0);
			MySqlParameter orientationParameter = new MySqlParameter("@orientation", MySqlDbType.VarChar, 0);
			raceParameter.Value = race;
			class_varParameter.Value = class_var;
			mapParameter.Value = map;
			zoneParameter.Value = zone;
			position_xParameter.Value = position_x;
			position_yParameter.Value = position_y;
			position_zParameter.Value = position_z;
			orientationParameter.Value = orientation;
			cmd.Parameters.Add(raceParameter);
			cmd.Parameters.Add(class_varParameter);
			cmd.Parameters.Add(mapParameter);
			cmd.Parameters.Add(zoneParameter);
			cmd.Parameters.Add(position_xParameter);
			cmd.Parameters.Add(position_yParameter);
			cmd.Parameters.Add(position_zParameter);
			cmd.Parameters.Add(orientationParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE playercreateinfo SET race = @newrace, class_var = @newclass_var, map = @newmap, zone = @newzone, position_x = @newposition_x, position_y = @newposition_y, position_z = @newposition_z, orientation = @neworientation WHERE race = @race AND class_var = @class_var AND map = @map AND zone = @zone AND position_x = @position_x AND position_y = @position_y AND position_z = @position_z AND orientation = @orientation;";
			MySqlParameter OLD_raceParameter = new MySqlParameter("@race", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_class_varParameter = new MySqlParameter("@class_var", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_mapParameter = new MySqlParameter("@map", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_zoneParameter = new MySqlParameter("@zone", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_position_xParameter = new MySqlParameter("@position_x", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_position_yParameter = new MySqlParameter("@position_y", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_position_zParameter = new MySqlParameter("@position_z", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_orientationParameter = new MySqlParameter("@orientation", MySqlDbType.VarChar, 0);
			MySqlParameter raceParameter = new MySqlParameter("@newrace", MySqlDbType.VarChar, 0);
			MySqlParameter class_varParameter = new MySqlParameter("@newclass_var", MySqlDbType.VarChar, 0);
			MySqlParameter mapParameter = new MySqlParameter("@newmap", MySqlDbType.VarChar, 0);
			MySqlParameter zoneParameter = new MySqlParameter("@newzone", MySqlDbType.VarChar, 0);
			MySqlParameter position_xParameter = new MySqlParameter("@newposition_x", MySqlDbType.VarChar, 0);
			MySqlParameter position_yParameter = new MySqlParameter("@newposition_y", MySqlDbType.VarChar, 0);
			MySqlParameter position_zParameter = new MySqlParameter("@newposition_z", MySqlDbType.VarChar, 0);
			MySqlParameter orientationParameter = new MySqlParameter("@neworientation", MySqlDbType.VarChar, 0);
			raceParameter.Value = race;
			class_varParameter.Value = class_var;
			mapParameter.Value = map;
			zoneParameter.Value = zone;
			position_xParameter.Value = position_x;
			position_yParameter.Value = position_y;
			position_zParameter.Value = position_z;
			orientationParameter.Value = orientation;
			OLD_raceParameter.Value = OLD_race;
			OLD_class_varParameter.Value = OLD_class_var;
			OLD_mapParameter.Value = OLD_map;
			OLD_zoneParameter.Value = OLD_zone;
			OLD_position_xParameter.Value = OLD_position_x;
			OLD_position_yParameter.Value = OLD_position_y;
			OLD_position_zParameter.Value = OLD_position_z;
			OLD_orientationParameter.Value = OLD_orientation;
			cmd.Parameters.Add(raceParameter);
			cmd.Parameters.Add(class_varParameter);
			cmd.Parameters.Add(mapParameter);
			cmd.Parameters.Add(zoneParameter);
			cmd.Parameters.Add(position_xParameter);
			cmd.Parameters.Add(position_yParameter);
			cmd.Parameters.Add(position_zParameter);
			cmd.Parameters.Add(orientationParameter);
			cmd.Parameters.Add(OLD_raceParameter);
			cmd.Parameters.Add(OLD_class_varParameter);
			cmd.Parameters.Add(OLD_mapParameter);
			cmd.Parameters.Add(OLD_zoneParameter);
			cmd.Parameters.Add(OLD_position_xParameter);
			cmd.Parameters.Add(OLD_position_yParameter);
			cmd.Parameters.Add(OLD_position_zParameter);
			cmd.Parameters.Add(OLD_orientationParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_race = race;
			OLD_class_var = class_var;
			OLD_map = map;
			OLD_zone = zone;
			OLD_position_x = position_x;
			OLD_position_y = position_y;
			OLD_position_z = position_z;
			OLD_orientation = orientation;
		}
	}
}
