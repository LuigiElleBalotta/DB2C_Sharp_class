using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Game_event
	{
		int eventEntry = 0; //Comment: Entry of the game event
		int OLD_eventEntry = 0;

		string start_time = "0000-00-00 00:00:00"; //Comment: Absolute start date, the event will never start before
		string OLD_start_time = "0000-00-00 00:00:00";

		string end_time = "0000-00-00 00:00:00"; //Comment: Absolute end date, the event will never start afler
		string OLD_end_time = "0000-00-00 00:00:00";

		int occurence = 5184000; //Comment: Delay in minutes between occurences of the event
		int OLD_occurence = 5184000;

		int length = 2592000; //Comment: Length in minutes of the event
		int OLD_length = 2592000;

		int holiday = 0; //Comment: Client side holiday id
		int OLD_holiday = 0;

		string description = null; //Comment: Description of the event displayed in console
		string OLD_description = null;

		int world_event = 0; //Comment: 0 if normal event, 1 if world event
		int OLD_world_event = 0;

		int announce = 2; //Comment: 0 dont announce, 1 announce, 2 value from config
		int OLD_announce = 2;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Game_event(int _eventEntry, string _start_time, string _end_time, int _occurence, int _length, int _holiday, string _description, int _world_event, int _announce)
		{
			eventEntry = _eventEntry;
			start_time = _start_time;
			end_time = _end_time;
			occurence = _occurence;
			length = _length;
			holiday = _holiday;
			description = _description;
			world_event = _world_event;
			announce = _announce;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM game_event WHERE eventEntry = @eventEntry AND start_time = @start_time AND end_time = @end_time AND occurence = @occurence AND length = @length AND holiday = @holiday AND description = @description AND world_event = @world_event AND announce = @announce;";
			MySqlParameter evententryParameter = new MySqlParameter("@eventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter start_timeParameter = new MySqlParameter("@start_time", MySqlDbType.VarChar, 0);
			MySqlParameter end_timeParameter = new MySqlParameter("@end_time", MySqlDbType.VarChar, 0);
			MySqlParameter occurenceParameter = new MySqlParameter("@occurence", MySqlDbType.VarChar, 0);
			MySqlParameter lengthParameter = new MySqlParameter("@length", MySqlDbType.VarChar, 0);
			MySqlParameter holidayParameter = new MySqlParameter("@holiday", MySqlDbType.VarChar, 0);
			MySqlParameter descriptionParameter = new MySqlParameter("@description", MySqlDbType.VarChar, 0);
			MySqlParameter world_eventParameter = new MySqlParameter("@world_event", MySqlDbType.VarChar, 0);
			MySqlParameter announceParameter = new MySqlParameter("@announce", MySqlDbType.VarChar, 0);
			evententryParameter.Value = eventEntry;
			start_timeParameter.Value = start_time;
			end_timeParameter.Value = end_time;
			occurenceParameter.Value = occurence;
			lengthParameter.Value = length;
			holidayParameter.Value = holiday;
			descriptionParameter.Value = description;
			world_eventParameter.Value = world_event;
			announceParameter.Value = announce;
			cmd.Parameters.Add(evententryParameter);
			cmd.Parameters.Add(start_timeParameter);
			cmd.Parameters.Add(end_timeParameter);
			cmd.Parameters.Add(occurenceParameter);
			cmd.Parameters.Add(lengthParameter);
			cmd.Parameters.Add(holidayParameter);
			cmd.Parameters.Add(descriptionParameter);
			cmd.Parameters.Add(world_eventParameter);
			cmd.Parameters.Add(announceParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE game_event SET eventEntry = @neweventEntry, start_time = @newstart_time, end_time = @newend_time, occurence = @newoccurence, length = @newlength, holiday = @newholiday, description = @newdescription, world_event = @newworld_event, announce = @newannounce WHERE eventEntry = @eventEntry AND start_time = @start_time AND end_time = @end_time AND occurence = @occurence AND length = @length AND holiday = @holiday AND description = @description AND world_event = @world_event AND announce = @announce;";
			MySqlParameter OLD_evententryParameter = new MySqlParameter("@eventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_start_timeParameter = new MySqlParameter("@start_time", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_end_timeParameter = new MySqlParameter("@end_time", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_occurenceParameter = new MySqlParameter("@occurence", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_lengthParameter = new MySqlParameter("@length", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_holidayParameter = new MySqlParameter("@holiday", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_descriptionParameter = new MySqlParameter("@description", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_world_eventParameter = new MySqlParameter("@world_event", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_announceParameter = new MySqlParameter("@announce", MySqlDbType.VarChar, 0);
			MySqlParameter evententryParameter = new MySqlParameter("@neweventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter start_timeParameter = new MySqlParameter("@newstart_time", MySqlDbType.VarChar, 0);
			MySqlParameter end_timeParameter = new MySqlParameter("@newend_time", MySqlDbType.VarChar, 0);
			MySqlParameter occurenceParameter = new MySqlParameter("@newoccurence", MySqlDbType.VarChar, 0);
			MySqlParameter lengthParameter = new MySqlParameter("@newlength", MySqlDbType.VarChar, 0);
			MySqlParameter holidayParameter = new MySqlParameter("@newholiday", MySqlDbType.VarChar, 0);
			MySqlParameter descriptionParameter = new MySqlParameter("@newdescription", MySqlDbType.VarChar, 0);
			MySqlParameter world_eventParameter = new MySqlParameter("@newworld_event", MySqlDbType.VarChar, 0);
			MySqlParameter announceParameter = new MySqlParameter("@newannounce", MySqlDbType.VarChar, 0);
			evententryParameter.Value = eventEntry;
			start_timeParameter.Value = start_time;
			end_timeParameter.Value = end_time;
			occurenceParameter.Value = occurence;
			lengthParameter.Value = length;
			holidayParameter.Value = holiday;
			descriptionParameter.Value = description;
			world_eventParameter.Value = world_event;
			announceParameter.Value = announce;
			OLD_evententryParameter.Value = OLD_eventEntry;
			OLD_start_timeParameter.Value = OLD_start_time;
			OLD_end_timeParameter.Value = OLD_end_time;
			OLD_occurenceParameter.Value = OLD_occurence;
			OLD_lengthParameter.Value = OLD_length;
			OLD_holidayParameter.Value = OLD_holiday;
			OLD_descriptionParameter.Value = OLD_description;
			OLD_world_eventParameter.Value = OLD_world_event;
			OLD_announceParameter.Value = OLD_announce;
			cmd.Parameters.Add(evententryParameter);
			cmd.Parameters.Add(start_timeParameter);
			cmd.Parameters.Add(end_timeParameter);
			cmd.Parameters.Add(occurenceParameter);
			cmd.Parameters.Add(lengthParameter);
			cmd.Parameters.Add(holidayParameter);
			cmd.Parameters.Add(descriptionParameter);
			cmd.Parameters.Add(world_eventParameter);
			cmd.Parameters.Add(announceParameter);
			cmd.Parameters.Add(OLD_evententryParameter);
			cmd.Parameters.Add(OLD_start_timeParameter);
			cmd.Parameters.Add(OLD_end_timeParameter);
			cmd.Parameters.Add(OLD_occurenceParameter);
			cmd.Parameters.Add(OLD_lengthParameter);
			cmd.Parameters.Add(OLD_holidayParameter);
			cmd.Parameters.Add(OLD_descriptionParameter);
			cmd.Parameters.Add(OLD_world_eventParameter);
			cmd.Parameters.Add(OLD_announceParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_eventEntry = eventEntry;
			OLD_start_time = start_time;
			OLD_end_time = end_time;
			OLD_occurence = occurence;
			OLD_length = length;
			OLD_holiday = holiday;
			OLD_description = description;
			OLD_world_event = world_event;
			OLD_announce = announce;
		}
	}
}
