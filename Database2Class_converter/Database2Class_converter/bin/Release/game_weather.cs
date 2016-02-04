using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Game_weather
	{
		int zone = 0; //Comment: 
		int OLD_zone = 0;

		int spring_rain_chance = 25; //Comment: 
		int OLD_spring_rain_chance = 25;

		int spring_snow_chance = 25; //Comment: 
		int OLD_spring_snow_chance = 25;

		int spring_storm_chance = 25; //Comment: 
		int OLD_spring_storm_chance = 25;

		int summer_rain_chance = 25; //Comment: 
		int OLD_summer_rain_chance = 25;

		int summer_snow_chance = 25; //Comment: 
		int OLD_summer_snow_chance = 25;

		int summer_storm_chance = 25; //Comment: 
		int OLD_summer_storm_chance = 25;

		int fall_rain_chance = 25; //Comment: 
		int OLD_fall_rain_chance = 25;

		int fall_snow_chance = 25; //Comment: 
		int OLD_fall_snow_chance = 25;

		int fall_storm_chance = 25; //Comment: 
		int OLD_fall_storm_chance = 25;

		int winter_rain_chance = 25; //Comment: 
		int OLD_winter_rain_chance = 25;

		int winter_snow_chance = 25; //Comment: 
		int OLD_winter_snow_chance = 25;

		int winter_storm_chance = 25; //Comment: 
		int OLD_winter_storm_chance = 25;

		char ScriptName = Char.MinValue; //Comment: 
		char OLD_ScriptName = Char.MinValue;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Game_weather(int _zone, int _spring_rain_chance, int _spring_snow_chance, int _spring_storm_chance, int _summer_rain_chance, int _summer_snow_chance, int _summer_storm_chance, int _fall_rain_chance, int _fall_snow_chance, int _fall_storm_chance, int _winter_rain_chance, int _winter_snow_chance, int _winter_storm_chance, char _ScriptName)
		{
			zone = _zone;
			spring_rain_chance = _spring_rain_chance;
			spring_snow_chance = _spring_snow_chance;
			spring_storm_chance = _spring_storm_chance;
			summer_rain_chance = _summer_rain_chance;
			summer_snow_chance = _summer_snow_chance;
			summer_storm_chance = _summer_storm_chance;
			fall_rain_chance = _fall_rain_chance;
			fall_snow_chance = _fall_snow_chance;
			fall_storm_chance = _fall_storm_chance;
			winter_rain_chance = _winter_rain_chance;
			winter_snow_chance = _winter_snow_chance;
			winter_storm_chance = _winter_storm_chance;
			ScriptName = _ScriptName;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM game_weather WHERE zone = @zone AND spring_rain_chance = @spring_rain_chance AND spring_snow_chance = @spring_snow_chance AND spring_storm_chance = @spring_storm_chance AND summer_rain_chance = @summer_rain_chance AND summer_snow_chance = @summer_snow_chance AND summer_storm_chance = @summer_storm_chance AND fall_rain_chance = @fall_rain_chance AND fall_snow_chance = @fall_snow_chance AND fall_storm_chance = @fall_storm_chance AND winter_rain_chance = @winter_rain_chance AND winter_snow_chance = @winter_snow_chance AND winter_storm_chance = @winter_storm_chance AND ScriptName = @ScriptName;";
			MySqlParameter zoneParameter = new MySqlParameter("@zone", MySqlDbType.VarChar, 0);
			MySqlParameter spring_rain_chanceParameter = new MySqlParameter("@spring_rain_chance", MySqlDbType.VarChar, 0);
			MySqlParameter spring_snow_chanceParameter = new MySqlParameter("@spring_snow_chance", MySqlDbType.VarChar, 0);
			MySqlParameter spring_storm_chanceParameter = new MySqlParameter("@spring_storm_chance", MySqlDbType.VarChar, 0);
			MySqlParameter summer_rain_chanceParameter = new MySqlParameter("@summer_rain_chance", MySqlDbType.VarChar, 0);
			MySqlParameter summer_snow_chanceParameter = new MySqlParameter("@summer_snow_chance", MySqlDbType.VarChar, 0);
			MySqlParameter summer_storm_chanceParameter = new MySqlParameter("@summer_storm_chance", MySqlDbType.VarChar, 0);
			MySqlParameter fall_rain_chanceParameter = new MySqlParameter("@fall_rain_chance", MySqlDbType.VarChar, 0);
			MySqlParameter fall_snow_chanceParameter = new MySqlParameter("@fall_snow_chance", MySqlDbType.VarChar, 0);
			MySqlParameter fall_storm_chanceParameter = new MySqlParameter("@fall_storm_chance", MySqlDbType.VarChar, 0);
			MySqlParameter winter_rain_chanceParameter = new MySqlParameter("@winter_rain_chance", MySqlDbType.VarChar, 0);
			MySqlParameter winter_snow_chanceParameter = new MySqlParameter("@winter_snow_chance", MySqlDbType.VarChar, 0);
			MySqlParameter winter_storm_chanceParameter = new MySqlParameter("@winter_storm_chance", MySqlDbType.VarChar, 0);
			MySqlParameter scriptnameParameter = new MySqlParameter("@ScriptName", MySqlDbType.VarChar, 0);
			zoneParameter.Value = zone;
			spring_rain_chanceParameter.Value = spring_rain_chance;
			spring_snow_chanceParameter.Value = spring_snow_chance;
			spring_storm_chanceParameter.Value = spring_storm_chance;
			summer_rain_chanceParameter.Value = summer_rain_chance;
			summer_snow_chanceParameter.Value = summer_snow_chance;
			summer_storm_chanceParameter.Value = summer_storm_chance;
			fall_rain_chanceParameter.Value = fall_rain_chance;
			fall_snow_chanceParameter.Value = fall_snow_chance;
			fall_storm_chanceParameter.Value = fall_storm_chance;
			winter_rain_chanceParameter.Value = winter_rain_chance;
			winter_snow_chanceParameter.Value = winter_snow_chance;
			winter_storm_chanceParameter.Value = winter_storm_chance;
			scriptnameParameter.Value = ScriptName;
			cmd.Parameters.Add(zoneParameter);
			cmd.Parameters.Add(spring_rain_chanceParameter);
			cmd.Parameters.Add(spring_snow_chanceParameter);
			cmd.Parameters.Add(spring_storm_chanceParameter);
			cmd.Parameters.Add(summer_rain_chanceParameter);
			cmd.Parameters.Add(summer_snow_chanceParameter);
			cmd.Parameters.Add(summer_storm_chanceParameter);
			cmd.Parameters.Add(fall_rain_chanceParameter);
			cmd.Parameters.Add(fall_snow_chanceParameter);
			cmd.Parameters.Add(fall_storm_chanceParameter);
			cmd.Parameters.Add(winter_rain_chanceParameter);
			cmd.Parameters.Add(winter_snow_chanceParameter);
			cmd.Parameters.Add(winter_storm_chanceParameter);
			cmd.Parameters.Add(scriptnameParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE game_weather SET zone = @newzone, spring_rain_chance = @newspring_rain_chance, spring_snow_chance = @newspring_snow_chance, spring_storm_chance = @newspring_storm_chance, summer_rain_chance = @newsummer_rain_chance, summer_snow_chance = @newsummer_snow_chance, summer_storm_chance = @newsummer_storm_chance, fall_rain_chance = @newfall_rain_chance, fall_snow_chance = @newfall_snow_chance, fall_storm_chance = @newfall_storm_chance, winter_rain_chance = @newwinter_rain_chance, winter_snow_chance = @newwinter_snow_chance, winter_storm_chance = @newwinter_storm_chance, ScriptName = @newScriptName WHERE zone = @zone AND spring_rain_chance = @spring_rain_chance AND spring_snow_chance = @spring_snow_chance AND spring_storm_chance = @spring_storm_chance AND summer_rain_chance = @summer_rain_chance AND summer_snow_chance = @summer_snow_chance AND summer_storm_chance = @summer_storm_chance AND fall_rain_chance = @fall_rain_chance AND fall_snow_chance = @fall_snow_chance AND fall_storm_chance = @fall_storm_chance AND winter_rain_chance = @winter_rain_chance AND winter_snow_chance = @winter_snow_chance AND winter_storm_chance = @winter_storm_chance AND ScriptName = @ScriptName;";
			MySqlParameter OLD_zoneParameter = new MySqlParameter("@zone", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spring_rain_chanceParameter = new MySqlParameter("@spring_rain_chance", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spring_snow_chanceParameter = new MySqlParameter("@spring_snow_chance", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spring_storm_chanceParameter = new MySqlParameter("@spring_storm_chance", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_summer_rain_chanceParameter = new MySqlParameter("@summer_rain_chance", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_summer_snow_chanceParameter = new MySqlParameter("@summer_snow_chance", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_summer_storm_chanceParameter = new MySqlParameter("@summer_storm_chance", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_fall_rain_chanceParameter = new MySqlParameter("@fall_rain_chance", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_fall_snow_chanceParameter = new MySqlParameter("@fall_snow_chance", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_fall_storm_chanceParameter = new MySqlParameter("@fall_storm_chance", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_winter_rain_chanceParameter = new MySqlParameter("@winter_rain_chance", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_winter_snow_chanceParameter = new MySqlParameter("@winter_snow_chance", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_winter_storm_chanceParameter = new MySqlParameter("@winter_storm_chance", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_scriptnameParameter = new MySqlParameter("@ScriptName", MySqlDbType.VarChar, 0);
			MySqlParameter zoneParameter = new MySqlParameter("@newzone", MySqlDbType.VarChar, 0);
			MySqlParameter spring_rain_chanceParameter = new MySqlParameter("@newspring_rain_chance", MySqlDbType.VarChar, 0);
			MySqlParameter spring_snow_chanceParameter = new MySqlParameter("@newspring_snow_chance", MySqlDbType.VarChar, 0);
			MySqlParameter spring_storm_chanceParameter = new MySqlParameter("@newspring_storm_chance", MySqlDbType.VarChar, 0);
			MySqlParameter summer_rain_chanceParameter = new MySqlParameter("@newsummer_rain_chance", MySqlDbType.VarChar, 0);
			MySqlParameter summer_snow_chanceParameter = new MySqlParameter("@newsummer_snow_chance", MySqlDbType.VarChar, 0);
			MySqlParameter summer_storm_chanceParameter = new MySqlParameter("@newsummer_storm_chance", MySqlDbType.VarChar, 0);
			MySqlParameter fall_rain_chanceParameter = new MySqlParameter("@newfall_rain_chance", MySqlDbType.VarChar, 0);
			MySqlParameter fall_snow_chanceParameter = new MySqlParameter("@newfall_snow_chance", MySqlDbType.VarChar, 0);
			MySqlParameter fall_storm_chanceParameter = new MySqlParameter("@newfall_storm_chance", MySqlDbType.VarChar, 0);
			MySqlParameter winter_rain_chanceParameter = new MySqlParameter("@newwinter_rain_chance", MySqlDbType.VarChar, 0);
			MySqlParameter winter_snow_chanceParameter = new MySqlParameter("@newwinter_snow_chance", MySqlDbType.VarChar, 0);
			MySqlParameter winter_storm_chanceParameter = new MySqlParameter("@newwinter_storm_chance", MySqlDbType.VarChar, 0);
			MySqlParameter scriptnameParameter = new MySqlParameter("@newScriptName", MySqlDbType.VarChar, 0);
			zoneParameter.Value = zone;
			spring_rain_chanceParameter.Value = spring_rain_chance;
			spring_snow_chanceParameter.Value = spring_snow_chance;
			spring_storm_chanceParameter.Value = spring_storm_chance;
			summer_rain_chanceParameter.Value = summer_rain_chance;
			summer_snow_chanceParameter.Value = summer_snow_chance;
			summer_storm_chanceParameter.Value = summer_storm_chance;
			fall_rain_chanceParameter.Value = fall_rain_chance;
			fall_snow_chanceParameter.Value = fall_snow_chance;
			fall_storm_chanceParameter.Value = fall_storm_chance;
			winter_rain_chanceParameter.Value = winter_rain_chance;
			winter_snow_chanceParameter.Value = winter_snow_chance;
			winter_storm_chanceParameter.Value = winter_storm_chance;
			scriptnameParameter.Value = ScriptName;
			OLD_zoneParameter.Value = OLD_zone;
			OLD_spring_rain_chanceParameter.Value = OLD_spring_rain_chance;
			OLD_spring_snow_chanceParameter.Value = OLD_spring_snow_chance;
			OLD_spring_storm_chanceParameter.Value = OLD_spring_storm_chance;
			OLD_summer_rain_chanceParameter.Value = OLD_summer_rain_chance;
			OLD_summer_snow_chanceParameter.Value = OLD_summer_snow_chance;
			OLD_summer_storm_chanceParameter.Value = OLD_summer_storm_chance;
			OLD_fall_rain_chanceParameter.Value = OLD_fall_rain_chance;
			OLD_fall_snow_chanceParameter.Value = OLD_fall_snow_chance;
			OLD_fall_storm_chanceParameter.Value = OLD_fall_storm_chance;
			OLD_winter_rain_chanceParameter.Value = OLD_winter_rain_chance;
			OLD_winter_snow_chanceParameter.Value = OLD_winter_snow_chance;
			OLD_winter_storm_chanceParameter.Value = OLD_winter_storm_chance;
			OLD_scriptnameParameter.Value = OLD_ScriptName;
			cmd.Parameters.Add(zoneParameter);
			cmd.Parameters.Add(spring_rain_chanceParameter);
			cmd.Parameters.Add(spring_snow_chanceParameter);
			cmd.Parameters.Add(spring_storm_chanceParameter);
			cmd.Parameters.Add(summer_rain_chanceParameter);
			cmd.Parameters.Add(summer_snow_chanceParameter);
			cmd.Parameters.Add(summer_storm_chanceParameter);
			cmd.Parameters.Add(fall_rain_chanceParameter);
			cmd.Parameters.Add(fall_snow_chanceParameter);
			cmd.Parameters.Add(fall_storm_chanceParameter);
			cmd.Parameters.Add(winter_rain_chanceParameter);
			cmd.Parameters.Add(winter_snow_chanceParameter);
			cmd.Parameters.Add(winter_storm_chanceParameter);
			cmd.Parameters.Add(scriptnameParameter);
			cmd.Parameters.Add(OLD_zoneParameter);
			cmd.Parameters.Add(OLD_spring_rain_chanceParameter);
			cmd.Parameters.Add(OLD_spring_snow_chanceParameter);
			cmd.Parameters.Add(OLD_spring_storm_chanceParameter);
			cmd.Parameters.Add(OLD_summer_rain_chanceParameter);
			cmd.Parameters.Add(OLD_summer_snow_chanceParameter);
			cmd.Parameters.Add(OLD_summer_storm_chanceParameter);
			cmd.Parameters.Add(OLD_fall_rain_chanceParameter);
			cmd.Parameters.Add(OLD_fall_snow_chanceParameter);
			cmd.Parameters.Add(OLD_fall_storm_chanceParameter);
			cmd.Parameters.Add(OLD_winter_rain_chanceParameter);
			cmd.Parameters.Add(OLD_winter_snow_chanceParameter);
			cmd.Parameters.Add(OLD_winter_storm_chanceParameter);
			cmd.Parameters.Add(OLD_scriptnameParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_zone = zone;
			OLD_spring_rain_chance = spring_rain_chance;
			OLD_spring_snow_chance = spring_snow_chance;
			OLD_spring_storm_chance = spring_storm_chance;
			OLD_summer_rain_chance = summer_rain_chance;
			OLD_summer_snow_chance = summer_snow_chance;
			OLD_summer_storm_chance = summer_storm_chance;
			OLD_fall_rain_chance = fall_rain_chance;
			OLD_fall_snow_chance = fall_snow_chance;
			OLD_fall_storm_chance = fall_storm_chance;
			OLD_winter_rain_chance = winter_rain_chance;
			OLD_winter_snow_chance = winter_snow_chance;
			OLD_winter_storm_chance = winter_storm_chance;
			OLD_ScriptName = ScriptName;
		}
	}
}
