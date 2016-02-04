using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Updates
	{
		string name = null; //Comment: filename with extension of the update.
		string OLD_name = null;

		char hash = Char.MinValue; //Comment: sha1 hash of the sql file.
		char OLD_hash = Char.MinValue;

		string state = "RELEASED"; //Comment: defines if an update is released or archived.
		string OLD_state = "RELEASED";

		string timestamp = "CURRENT_TIMESTAMP"; //Comment: timestamp when the query was applied.
		string OLD_timestamp = "CURRENT_TIMESTAMP";

		int speed = 0; //Comment: time the query takes to apply in ms.
		int OLD_speed = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Updates(string _name, char _hash, string _state, string _timestamp, int _speed)
		{
			name = _name;
			hash = _hash;
			state = _state;
			timestamp = _timestamp;
			speed = _speed;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM updates WHERE name = @name AND hash = @hash AND state = @state AND timestamp = @timestamp AND speed = @speed;";
			MySqlParameter nameParameter = new MySqlParameter("@name", MySqlDbType.VarChar, 0);
			MySqlParameter hashParameter = new MySqlParameter("@hash", MySqlDbType.VarChar, 0);
			MySqlParameter stateParameter = new MySqlParameter("@state", MySqlDbType.VarChar, 0);
			MySqlParameter timestampParameter = new MySqlParameter("@timestamp", MySqlDbType.VarChar, 0);
			MySqlParameter speedParameter = new MySqlParameter("@speed", MySqlDbType.VarChar, 0);
			nameParameter.Value = name;
			hashParameter.Value = hash;
			stateParameter.Value = state;
			timestampParameter.Value = timestamp;
			speedParameter.Value = speed;
			cmd.Parameters.Add(nameParameter);
			cmd.Parameters.Add(hashParameter);
			cmd.Parameters.Add(stateParameter);
			cmd.Parameters.Add(timestampParameter);
			cmd.Parameters.Add(speedParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE updates SET name = @newname, hash = @newhash, state = @newstate, timestamp = @newtimestamp, speed = @newspeed WHERE name = @name AND hash = @hash AND state = @state AND timestamp = @timestamp AND speed = @speed;";
			MySqlParameter OLD_nameParameter = new MySqlParameter("@name", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_hashParameter = new MySqlParameter("@hash", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_stateParameter = new MySqlParameter("@state", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_timestampParameter = new MySqlParameter("@timestamp", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_speedParameter = new MySqlParameter("@speed", MySqlDbType.VarChar, 0);
			MySqlParameter nameParameter = new MySqlParameter("@newname", MySqlDbType.VarChar, 0);
			MySqlParameter hashParameter = new MySqlParameter("@newhash", MySqlDbType.VarChar, 0);
			MySqlParameter stateParameter = new MySqlParameter("@newstate", MySqlDbType.VarChar, 0);
			MySqlParameter timestampParameter = new MySqlParameter("@newtimestamp", MySqlDbType.VarChar, 0);
			MySqlParameter speedParameter = new MySqlParameter("@newspeed", MySqlDbType.VarChar, 0);
			nameParameter.Value = name;
			hashParameter.Value = hash;
			stateParameter.Value = state;
			timestampParameter.Value = timestamp;
			speedParameter.Value = speed;
			OLD_nameParameter.Value = OLD_name;
			OLD_hashParameter.Value = OLD_hash;
			OLD_stateParameter.Value = OLD_state;
			OLD_timestampParameter.Value = OLD_timestamp;
			OLD_speedParameter.Value = OLD_speed;
			cmd.Parameters.Add(nameParameter);
			cmd.Parameters.Add(hashParameter);
			cmd.Parameters.Add(stateParameter);
			cmd.Parameters.Add(timestampParameter);
			cmd.Parameters.Add(speedParameter);
			cmd.Parameters.Add(OLD_nameParameter);
			cmd.Parameters.Add(OLD_hashParameter);
			cmd.Parameters.Add(OLD_stateParameter);
			cmd.Parameters.Add(OLD_timestampParameter);
			cmd.Parameters.Add(OLD_speedParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_name = name;
			OLD_hash = hash;
			OLD_state = state;
			OLD_timestamp = timestamp;
			OLD_speed = speed;
		}
	}
}
