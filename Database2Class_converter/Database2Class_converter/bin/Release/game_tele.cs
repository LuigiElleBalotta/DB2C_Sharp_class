using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Game_tele
	{
		int id = 0; //Comment: 
		int OLD_id = 0;

		float position_x = 0f; //Comment: 
		float OLD_position_x = 0f;

		float position_y = 0f; //Comment: 
		float OLD_position_y = 0f;

		float position_z = 0f; //Comment: 
		float OLD_position_z = 0f;

		float orientation = 0f; //Comment: 
		float OLD_orientation = 0f;

		int map = 0; //Comment: 
		int OLD_map = 0;

		string name = null; //Comment: 
		string OLD_name = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Game_tele(int _id, float _position_x, float _position_y, float _position_z, float _orientation, int _map, string _name)
		{
			id = _id;
			position_x = _position_x;
			position_y = _position_y;
			position_z = _position_z;
			orientation = _orientation;
			map = _map;
			name = _name;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM game_tele WHERE id = @id AND position_x = @position_x AND position_y = @position_y AND position_z = @position_z AND orientation = @orientation AND map = @map AND name = @name;";
			MySqlParameter idParameter = new MySqlParameter("@id", MySqlDbType.VarChar, 0);
			MySqlParameter position_xParameter = new MySqlParameter("@position_x", MySqlDbType.VarChar, 0);
			MySqlParameter position_yParameter = new MySqlParameter("@position_y", MySqlDbType.VarChar, 0);
			MySqlParameter position_zParameter = new MySqlParameter("@position_z", MySqlDbType.VarChar, 0);
			MySqlParameter orientationParameter = new MySqlParameter("@orientation", MySqlDbType.VarChar, 0);
			MySqlParameter mapParameter = new MySqlParameter("@map", MySqlDbType.VarChar, 0);
			MySqlParameter nameParameter = new MySqlParameter("@name", MySqlDbType.VarChar, 0);
			idParameter.Value = id;
			position_xParameter.Value = position_x;
			position_yParameter.Value = position_y;
			position_zParameter.Value = position_z;
			orientationParameter.Value = orientation;
			mapParameter.Value = map;
			nameParameter.Value = name;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(position_xParameter);
			cmd.Parameters.Add(position_yParameter);
			cmd.Parameters.Add(position_zParameter);
			cmd.Parameters.Add(orientationParameter);
			cmd.Parameters.Add(mapParameter);
			cmd.Parameters.Add(nameParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE game_tele SET id = @newid, position_x = @newposition_x, position_y = @newposition_y, position_z = @newposition_z, orientation = @neworientation, map = @newmap, name = @newname WHERE id = @id AND position_x = @position_x AND position_y = @position_y AND position_z = @position_z AND orientation = @orientation AND map = @map AND name = @name;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_position_xParameter = new MySqlParameter("@position_x", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_position_yParameter = new MySqlParameter("@position_y", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_position_zParameter = new MySqlParameter("@position_z", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_orientationParameter = new MySqlParameter("@orientation", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_mapParameter = new MySqlParameter("@map", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_nameParameter = new MySqlParameter("@name", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newid", MySqlDbType.VarChar, 0);
			MySqlParameter position_xParameter = new MySqlParameter("@newposition_x", MySqlDbType.VarChar, 0);
			MySqlParameter position_yParameter = new MySqlParameter("@newposition_y", MySqlDbType.VarChar, 0);
			MySqlParameter position_zParameter = new MySqlParameter("@newposition_z", MySqlDbType.VarChar, 0);
			MySqlParameter orientationParameter = new MySqlParameter("@neworientation", MySqlDbType.VarChar, 0);
			MySqlParameter mapParameter = new MySqlParameter("@newmap", MySqlDbType.VarChar, 0);
			MySqlParameter nameParameter = new MySqlParameter("@newname", MySqlDbType.VarChar, 0);
			idParameter.Value = id;
			position_xParameter.Value = position_x;
			position_yParameter.Value = position_y;
			position_zParameter.Value = position_z;
			orientationParameter.Value = orientation;
			mapParameter.Value = map;
			nameParameter.Value = name;
			OLD_idParameter.Value = OLD_id;
			OLD_position_xParameter.Value = OLD_position_x;
			OLD_position_yParameter.Value = OLD_position_y;
			OLD_position_zParameter.Value = OLD_position_z;
			OLD_orientationParameter.Value = OLD_orientation;
			OLD_mapParameter.Value = OLD_map;
			OLD_nameParameter.Value = OLD_name;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(position_xParameter);
			cmd.Parameters.Add(position_yParameter);
			cmd.Parameters.Add(position_zParameter);
			cmd.Parameters.Add(orientationParameter);
			cmd.Parameters.Add(mapParameter);
			cmd.Parameters.Add(nameParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_position_xParameter);
			cmd.Parameters.Add(OLD_position_yParameter);
			cmd.Parameters.Add(OLD_position_zParameter);
			cmd.Parameters.Add(OLD_orientationParameter);
			cmd.Parameters.Add(OLD_mapParameter);
			cmd.Parameters.Add(OLD_nameParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_id = id;
			OLD_position_x = position_x;
			OLD_position_y = position_y;
			OLD_position_z = position_z;
			OLD_orientation = orientation;
			OLD_map = map;
			OLD_name = name;
		}
	}
}
