using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Waypoints
	{
		int entry = 0; //Comment: 
		int OLD_entry = 0;

		int pointid = 0; //Comment: 
		int OLD_pointid = 0;

		float position_x = 0f; //Comment: 
		float OLD_position_x = 0f;

		float position_y = 0f; //Comment: 
		float OLD_position_y = 0f;

		float position_z = 0f; //Comment: 
		float OLD_position_z = 0f;

		string point_comment = null; //Comment: 
		string OLD_point_comment = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Waypoints(int _entry, int _pointid, float _position_x, float _position_y, float _position_z, string _point_comment)
		{
			entry = _entry;
			pointid = _pointid;
			position_x = _position_x;
			position_y = _position_y;
			position_z = _position_z;
			point_comment = _point_comment;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM waypoints WHERE entry = @entry AND pointid = @pointid AND position_x = @position_x AND position_y = @position_y AND position_z = @position_z AND point_comment = @point_comment;";
			MySqlParameter entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter pointidParameter = new MySqlParameter("@pointid", MySqlDbType.VarChar, 0);
			MySqlParameter position_xParameter = new MySqlParameter("@position_x", MySqlDbType.VarChar, 0);
			MySqlParameter position_yParameter = new MySqlParameter("@position_y", MySqlDbType.VarChar, 0);
			MySqlParameter position_zParameter = new MySqlParameter("@position_z", MySqlDbType.VarChar, 0);
			MySqlParameter point_commentParameter = new MySqlParameter("@point_comment", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			pointidParameter.Value = pointid;
			position_xParameter.Value = position_x;
			position_yParameter.Value = position_y;
			position_zParameter.Value = position_z;
			point_commentParameter.Value = point_comment;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(pointidParameter);
			cmd.Parameters.Add(position_xParameter);
			cmd.Parameters.Add(position_yParameter);
			cmd.Parameters.Add(position_zParameter);
			cmd.Parameters.Add(point_commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE waypoints SET entry = @newentry, pointid = @newpointid, position_x = @newposition_x, position_y = @newposition_y, position_z = @newposition_z, point_comment = @newpoint_comment WHERE entry = @entry AND pointid = @pointid AND position_x = @position_x AND position_y = @position_y AND position_z = @position_z AND point_comment = @point_comment;";
			MySqlParameter OLD_entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_pointidParameter = new MySqlParameter("@pointid", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_position_xParameter = new MySqlParameter("@position_x", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_position_yParameter = new MySqlParameter("@position_y", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_position_zParameter = new MySqlParameter("@position_z", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_point_commentParameter = new MySqlParameter("@point_comment", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@newentry", MySqlDbType.VarChar, 0);
			MySqlParameter pointidParameter = new MySqlParameter("@newpointid", MySqlDbType.VarChar, 0);
			MySqlParameter position_xParameter = new MySqlParameter("@newposition_x", MySqlDbType.VarChar, 0);
			MySqlParameter position_yParameter = new MySqlParameter("@newposition_y", MySqlDbType.VarChar, 0);
			MySqlParameter position_zParameter = new MySqlParameter("@newposition_z", MySqlDbType.VarChar, 0);
			MySqlParameter point_commentParameter = new MySqlParameter("@newpoint_comment", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			pointidParameter.Value = pointid;
			position_xParameter.Value = position_x;
			position_yParameter.Value = position_y;
			position_zParameter.Value = position_z;
			point_commentParameter.Value = point_comment;
			OLD_entryParameter.Value = OLD_entry;
			OLD_pointidParameter.Value = OLD_pointid;
			OLD_position_xParameter.Value = OLD_position_x;
			OLD_position_yParameter.Value = OLD_position_y;
			OLD_position_zParameter.Value = OLD_position_z;
			OLD_point_commentParameter.Value = OLD_point_comment;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(pointidParameter);
			cmd.Parameters.Add(position_xParameter);
			cmd.Parameters.Add(position_yParameter);
			cmd.Parameters.Add(position_zParameter);
			cmd.Parameters.Add(point_commentParameter);
			cmd.Parameters.Add(OLD_entryParameter);
			cmd.Parameters.Add(OLD_pointidParameter);
			cmd.Parameters.Add(OLD_position_xParameter);
			cmd.Parameters.Add(OLD_position_yParameter);
			cmd.Parameters.Add(OLD_position_zParameter);
			cmd.Parameters.Add(OLD_point_commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_entry = entry;
			OLD_pointid = pointid;
			OLD_position_x = position_x;
			OLD_position_y = position_y;
			OLD_position_z = position_z;
			OLD_point_comment = point_comment;
		}
	}
}
