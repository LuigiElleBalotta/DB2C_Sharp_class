using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Waypoint_data
	{
		int id = 0; //Comment: Creature GUID
		int OLD_id = 0;

		int point = 0; //Comment: 
		int OLD_point = 0;

		float position_x = 0f; //Comment: 
		float OLD_position_x = 0f;

		float position_y = 0f; //Comment: 
		float OLD_position_y = 0f;

		float position_z = 0f; //Comment: 
		float OLD_position_z = 0f;

		float orientation = 0f; //Comment: 
		float OLD_orientation = 0f;

		int delay = 0; //Comment: 
		int OLD_delay = 0;

		int move_type = 0; //Comment: 
		int OLD_move_type = 0;

		int action = 0; //Comment: 
		int OLD_action = 0;

		int action_chance = 100; //Comment: 
		int OLD_action_chance = 100;

		int wpguid = 0; //Comment: 
		int OLD_wpguid = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Waypoint_data(int _id, int _point, float _position_x, float _position_y, float _position_z, float _orientation, int _delay, int _move_type, int _action, int _action_chance, int _wpguid)
		{
			id = _id;
			point = _point;
			position_x = _position_x;
			position_y = _position_y;
			position_z = _position_z;
			orientation = _orientation;
			delay = _delay;
			move_type = _move_type;
			action = _action;
			action_chance = _action_chance;
			wpguid = _wpguid;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM waypoint_data WHERE id = @id AND point = @point AND position_x = @position_x AND position_y = @position_y AND position_z = @position_z AND orientation = @orientation AND delay = @delay AND move_type = @move_type AND action = @action AND action_chance = @action_chance AND wpguid = @wpguid;";
			MySqlParameter idParameter = new MySqlParameter("@id", MySqlDbType.VarChar, 0);
			MySqlParameter pointParameter = new MySqlParameter("@point", MySqlDbType.VarChar, 0);
			MySqlParameter position_xParameter = new MySqlParameter("@position_x", MySqlDbType.VarChar, 0);
			MySqlParameter position_yParameter = new MySqlParameter("@position_y", MySqlDbType.VarChar, 0);
			MySqlParameter position_zParameter = new MySqlParameter("@position_z", MySqlDbType.VarChar, 0);
			MySqlParameter orientationParameter = new MySqlParameter("@orientation", MySqlDbType.VarChar, 0);
			MySqlParameter delayParameter = new MySqlParameter("@delay", MySqlDbType.VarChar, 0);
			MySqlParameter move_typeParameter = new MySqlParameter("@move_type", MySqlDbType.VarChar, 0);
			MySqlParameter actionParameter = new MySqlParameter("@action", MySqlDbType.VarChar, 0);
			MySqlParameter action_chanceParameter = new MySqlParameter("@action_chance", MySqlDbType.VarChar, 0);
			MySqlParameter wpguidParameter = new MySqlParameter("@wpguid", MySqlDbType.VarChar, 0);
			idParameter.Value = id;
			pointParameter.Value = point;
			position_xParameter.Value = position_x;
			position_yParameter.Value = position_y;
			position_zParameter.Value = position_z;
			orientationParameter.Value = orientation;
			delayParameter.Value = delay;
			move_typeParameter.Value = move_type;
			actionParameter.Value = action;
			action_chanceParameter.Value = action_chance;
			wpguidParameter.Value = wpguid;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(pointParameter);
			cmd.Parameters.Add(position_xParameter);
			cmd.Parameters.Add(position_yParameter);
			cmd.Parameters.Add(position_zParameter);
			cmd.Parameters.Add(orientationParameter);
			cmd.Parameters.Add(delayParameter);
			cmd.Parameters.Add(move_typeParameter);
			cmd.Parameters.Add(actionParameter);
			cmd.Parameters.Add(action_chanceParameter);
			cmd.Parameters.Add(wpguidParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE waypoint_data SET id = @newid, point = @newpoint, position_x = @newposition_x, position_y = @newposition_y, position_z = @newposition_z, orientation = @neworientation, delay = @newdelay, move_type = @newmove_type, action = @newaction, action_chance = @newaction_chance, wpguid = @newwpguid WHERE id = @id AND point = @point AND position_x = @position_x AND position_y = @position_y AND position_z = @position_z AND orientation = @orientation AND delay = @delay AND move_type = @move_type AND action = @action AND action_chance = @action_chance AND wpguid = @wpguid;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_pointParameter = new MySqlParameter("@point", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_position_xParameter = new MySqlParameter("@position_x", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_position_yParameter = new MySqlParameter("@position_y", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_position_zParameter = new MySqlParameter("@position_z", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_orientationParameter = new MySqlParameter("@orientation", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_delayParameter = new MySqlParameter("@delay", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_move_typeParameter = new MySqlParameter("@move_type", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_actionParameter = new MySqlParameter("@action", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_action_chanceParameter = new MySqlParameter("@action_chance", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_wpguidParameter = new MySqlParameter("@wpguid", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newid", MySqlDbType.VarChar, 0);
			MySqlParameter pointParameter = new MySqlParameter("@newpoint", MySqlDbType.VarChar, 0);
			MySqlParameter position_xParameter = new MySqlParameter("@newposition_x", MySqlDbType.VarChar, 0);
			MySqlParameter position_yParameter = new MySqlParameter("@newposition_y", MySqlDbType.VarChar, 0);
			MySqlParameter position_zParameter = new MySqlParameter("@newposition_z", MySqlDbType.VarChar, 0);
			MySqlParameter orientationParameter = new MySqlParameter("@neworientation", MySqlDbType.VarChar, 0);
			MySqlParameter delayParameter = new MySqlParameter("@newdelay", MySqlDbType.VarChar, 0);
			MySqlParameter move_typeParameter = new MySqlParameter("@newmove_type", MySqlDbType.VarChar, 0);
			MySqlParameter actionParameter = new MySqlParameter("@newaction", MySqlDbType.VarChar, 0);
			MySqlParameter action_chanceParameter = new MySqlParameter("@newaction_chance", MySqlDbType.VarChar, 0);
			MySqlParameter wpguidParameter = new MySqlParameter("@newwpguid", MySqlDbType.VarChar, 0);
			idParameter.Value = id;
			pointParameter.Value = point;
			position_xParameter.Value = position_x;
			position_yParameter.Value = position_y;
			position_zParameter.Value = position_z;
			orientationParameter.Value = orientation;
			delayParameter.Value = delay;
			move_typeParameter.Value = move_type;
			actionParameter.Value = action;
			action_chanceParameter.Value = action_chance;
			wpguidParameter.Value = wpguid;
			OLD_idParameter.Value = OLD_id;
			OLD_pointParameter.Value = OLD_point;
			OLD_position_xParameter.Value = OLD_position_x;
			OLD_position_yParameter.Value = OLD_position_y;
			OLD_position_zParameter.Value = OLD_position_z;
			OLD_orientationParameter.Value = OLD_orientation;
			OLD_delayParameter.Value = OLD_delay;
			OLD_move_typeParameter.Value = OLD_move_type;
			OLD_actionParameter.Value = OLD_action;
			OLD_action_chanceParameter.Value = OLD_action_chance;
			OLD_wpguidParameter.Value = OLD_wpguid;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(pointParameter);
			cmd.Parameters.Add(position_xParameter);
			cmd.Parameters.Add(position_yParameter);
			cmd.Parameters.Add(position_zParameter);
			cmd.Parameters.Add(orientationParameter);
			cmd.Parameters.Add(delayParameter);
			cmd.Parameters.Add(move_typeParameter);
			cmd.Parameters.Add(actionParameter);
			cmd.Parameters.Add(action_chanceParameter);
			cmd.Parameters.Add(wpguidParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_pointParameter);
			cmd.Parameters.Add(OLD_position_xParameter);
			cmd.Parameters.Add(OLD_position_yParameter);
			cmd.Parameters.Add(OLD_position_zParameter);
			cmd.Parameters.Add(OLD_orientationParameter);
			cmd.Parameters.Add(OLD_delayParameter);
			cmd.Parameters.Add(OLD_move_typeParameter);
			cmd.Parameters.Add(OLD_actionParameter);
			cmd.Parameters.Add(OLD_action_chanceParameter);
			cmd.Parameters.Add(OLD_wpguidParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_id = id;
			OLD_point = point;
			OLD_position_x = position_x;
			OLD_position_y = position_y;
			OLD_position_z = position_z;
			OLD_orientation = orientation;
			OLD_delay = delay;
			OLD_move_type = move_type;
			OLD_action = action;
			OLD_action_chance = action_chance;
			OLD_wpguid = wpguid;
		}
	}
}
