using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Script_waypoint
	{
		int entry = 0; //Comment: creature_template entry
		int OLD_entry = 0;

		int pointid = 0; //Comment: 
		int OLD_pointid = 0;

		float location_x = 0f; //Comment: 
		float OLD_location_x = 0f;

		float location_y = 0f; //Comment: 
		float OLD_location_y = 0f;

		float location_z = 0f; //Comment: 
		float OLD_location_z = 0f;

		int waittime = 0; //Comment: waittime in millisecs
		int OLD_waittime = 0;

		string point_comment = null; //Comment: 
		string OLD_point_comment = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Script_waypoint(int _entry, int _pointid, float _location_x, float _location_y, float _location_z, int _waittime, string _point_comment)
		{
			entry = _entry;
			pointid = _pointid;
			location_x = _location_x;
			location_y = _location_y;
			location_z = _location_z;
			waittime = _waittime;
			point_comment = _point_comment;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM script_waypoint WHERE entry = @entry AND pointid = @pointid AND location_x = @location_x AND location_y = @location_y AND location_z = @location_z AND waittime = @waittime AND point_comment = @point_comment;";
			MySqlParameter entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter pointidParameter = new MySqlParameter("@pointid", MySqlDbType.VarChar, 0);
			MySqlParameter location_xParameter = new MySqlParameter("@location_x", MySqlDbType.VarChar, 0);
			MySqlParameter location_yParameter = new MySqlParameter("@location_y", MySqlDbType.VarChar, 0);
			MySqlParameter location_zParameter = new MySqlParameter("@location_z", MySqlDbType.VarChar, 0);
			MySqlParameter waittimeParameter = new MySqlParameter("@waittime", MySqlDbType.VarChar, 0);
			MySqlParameter point_commentParameter = new MySqlParameter("@point_comment", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			pointidParameter.Value = pointid;
			location_xParameter.Value = location_x;
			location_yParameter.Value = location_y;
			location_zParameter.Value = location_z;
			waittimeParameter.Value = waittime;
			point_commentParameter.Value = point_comment;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(pointidParameter);
			cmd.Parameters.Add(location_xParameter);
			cmd.Parameters.Add(location_yParameter);
			cmd.Parameters.Add(location_zParameter);
			cmd.Parameters.Add(waittimeParameter);
			cmd.Parameters.Add(point_commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE script_waypoint SET entry = @newentry, pointid = @newpointid, location_x = @newlocation_x, location_y = @newlocation_y, location_z = @newlocation_z, waittime = @newwaittime, point_comment = @newpoint_comment WHERE entry = @entry AND pointid = @pointid AND location_x = @location_x AND location_y = @location_y AND location_z = @location_z AND waittime = @waittime AND point_comment = @point_comment;";
			MySqlParameter OLD_entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_pointidParameter = new MySqlParameter("@pointid", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_location_xParameter = new MySqlParameter("@location_x", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_location_yParameter = new MySqlParameter("@location_y", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_location_zParameter = new MySqlParameter("@location_z", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_waittimeParameter = new MySqlParameter("@waittime", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_point_commentParameter = new MySqlParameter("@point_comment", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@newentry", MySqlDbType.VarChar, 0);
			MySqlParameter pointidParameter = new MySqlParameter("@newpointid", MySqlDbType.VarChar, 0);
			MySqlParameter location_xParameter = new MySqlParameter("@newlocation_x", MySqlDbType.VarChar, 0);
			MySqlParameter location_yParameter = new MySqlParameter("@newlocation_y", MySqlDbType.VarChar, 0);
			MySqlParameter location_zParameter = new MySqlParameter("@newlocation_z", MySqlDbType.VarChar, 0);
			MySqlParameter waittimeParameter = new MySqlParameter("@newwaittime", MySqlDbType.VarChar, 0);
			MySqlParameter point_commentParameter = new MySqlParameter("@newpoint_comment", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			pointidParameter.Value = pointid;
			location_xParameter.Value = location_x;
			location_yParameter.Value = location_y;
			location_zParameter.Value = location_z;
			waittimeParameter.Value = waittime;
			point_commentParameter.Value = point_comment;
			OLD_entryParameter.Value = OLD_entry;
			OLD_pointidParameter.Value = OLD_pointid;
			OLD_location_xParameter.Value = OLD_location_x;
			OLD_location_yParameter.Value = OLD_location_y;
			OLD_location_zParameter.Value = OLD_location_z;
			OLD_waittimeParameter.Value = OLD_waittime;
			OLD_point_commentParameter.Value = OLD_point_comment;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(pointidParameter);
			cmd.Parameters.Add(location_xParameter);
			cmd.Parameters.Add(location_yParameter);
			cmd.Parameters.Add(location_zParameter);
			cmd.Parameters.Add(waittimeParameter);
			cmd.Parameters.Add(point_commentParameter);
			cmd.Parameters.Add(OLD_entryParameter);
			cmd.Parameters.Add(OLD_pointidParameter);
			cmd.Parameters.Add(OLD_location_xParameter);
			cmd.Parameters.Add(OLD_location_yParameter);
			cmd.Parameters.Add(OLD_location_zParameter);
			cmd.Parameters.Add(OLD_waittimeParameter);
			cmd.Parameters.Add(OLD_point_commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_entry = entry;
			OLD_pointid = pointid;
			OLD_location_x = location_x;
			OLD_location_y = location_y;
			OLD_location_z = location_z;
			OLD_waittime = waittime;
			OLD_point_comment = point_comment;
		}
	}
}
