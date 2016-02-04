using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Achievement_dbc
	{
		int ID = 0; //Comment: 
		int OLD_ID = 0;

		int requiredFaction = -1; //Comment: 
		int OLD_requiredFaction = -1;

		int mapID = -1; //Comment: 
		int OLD_mapID = -1;

		int points = 0; //Comment: 
		int OLD_points = 0;

		int flags = 0; //Comment: 
		int OLD_flags = 0;

		int count = 0; //Comment: 
		int OLD_count = 0;

		int refAchievement = 0; //Comment: 
		int OLD_refAchievement = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Achievement_dbc(int _ID, int _requiredFaction, int _mapID, int _points, int _flags, int _count, int _refAchievement)
		{
			ID = _ID;
			requiredFaction = _requiredFaction;
			mapID = _mapID;
			points = _points;
			flags = _flags;
			count = _count;
			refAchievement = _refAchievement;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM achievement_dbc WHERE ID = @ID AND requiredFaction = @requiredFaction AND mapID = @mapID AND points = @points AND flags = @flags AND count = @count AND refAchievement = @refAchievement;";
			MySqlParameter idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter requiredfactionParameter = new MySqlParameter("@requiredFaction", MySqlDbType.VarChar, 0);
			MySqlParameter mapidParameter = new MySqlParameter("@mapID", MySqlDbType.VarChar, 0);
			MySqlParameter pointsParameter = new MySqlParameter("@points", MySqlDbType.VarChar, 0);
			MySqlParameter flagsParameter = new MySqlParameter("@flags", MySqlDbType.VarChar, 0);
			MySqlParameter countParameter = new MySqlParameter("@count", MySqlDbType.VarChar, 0);
			MySqlParameter refachievementParameter = new MySqlParameter("@refAchievement", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			requiredfactionParameter.Value = requiredFaction;
			mapidParameter.Value = mapID;
			pointsParameter.Value = points;
			flagsParameter.Value = flags;
			countParameter.Value = count;
			refachievementParameter.Value = refAchievement;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(requiredfactionParameter);
			cmd.Parameters.Add(mapidParameter);
			cmd.Parameters.Add(pointsParameter);
			cmd.Parameters.Add(flagsParameter);
			cmd.Parameters.Add(countParameter);
			cmd.Parameters.Add(refachievementParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE achievement_dbc SET ID = @newID, requiredFaction = @newrequiredFaction, mapID = @newmapID, points = @newpoints, flags = @newflags, count = @newcount, refAchievement = @newrefAchievement WHERE ID = @ID AND requiredFaction = @requiredFaction AND mapID = @mapID AND points = @points AND flags = @flags AND count = @count AND refAchievement = @refAchievement;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_requiredfactionParameter = new MySqlParameter("@requiredFaction", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_mapidParameter = new MySqlParameter("@mapID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_pointsParameter = new MySqlParameter("@points", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_flagsParameter = new MySqlParameter("@flags", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_countParameter = new MySqlParameter("@count", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_refachievementParameter = new MySqlParameter("@refAchievement", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newID", MySqlDbType.VarChar, 0);
			MySqlParameter requiredfactionParameter = new MySqlParameter("@newrequiredFaction", MySqlDbType.VarChar, 0);
			MySqlParameter mapidParameter = new MySqlParameter("@newmapID", MySqlDbType.VarChar, 0);
			MySqlParameter pointsParameter = new MySqlParameter("@newpoints", MySqlDbType.VarChar, 0);
			MySqlParameter flagsParameter = new MySqlParameter("@newflags", MySqlDbType.VarChar, 0);
			MySqlParameter countParameter = new MySqlParameter("@newcount", MySqlDbType.VarChar, 0);
			MySqlParameter refachievementParameter = new MySqlParameter("@newrefAchievement", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			requiredfactionParameter.Value = requiredFaction;
			mapidParameter.Value = mapID;
			pointsParameter.Value = points;
			flagsParameter.Value = flags;
			countParameter.Value = count;
			refachievementParameter.Value = refAchievement;
			OLD_idParameter.Value = OLD_ID;
			OLD_requiredfactionParameter.Value = OLD_requiredFaction;
			OLD_mapidParameter.Value = OLD_mapID;
			OLD_pointsParameter.Value = OLD_points;
			OLD_flagsParameter.Value = OLD_flags;
			OLD_countParameter.Value = OLD_count;
			OLD_refachievementParameter.Value = OLD_refAchievement;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(requiredfactionParameter);
			cmd.Parameters.Add(mapidParameter);
			cmd.Parameters.Add(pointsParameter);
			cmd.Parameters.Add(flagsParameter);
			cmd.Parameters.Add(countParameter);
			cmd.Parameters.Add(refachievementParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_requiredfactionParameter);
			cmd.Parameters.Add(OLD_mapidParameter);
			cmd.Parameters.Add(OLD_pointsParameter);
			cmd.Parameters.Add(OLD_flagsParameter);
			cmd.Parameters.Add(OLD_countParameter);
			cmd.Parameters.Add(OLD_refachievementParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_ID = ID;
			OLD_requiredFaction = requiredFaction;
			OLD_mapID = mapID;
			OLD_points = points;
			OLD_flags = flags;
			OLD_count = count;
			OLD_refAchievement = refAchievement;
		}
	}
}
