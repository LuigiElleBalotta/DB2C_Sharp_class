using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Access_requirement
	{
		int mapId = 0; //Comment: 
		int OLD_mapId = 0;

		int difficulty = 0; //Comment: 
		int OLD_difficulty = 0;

		int level_min = 0; //Comment: 
		int OLD_level_min = 0;

		int level_max = 0; //Comment: 
		int OLD_level_max = 0;

		int item = 0; //Comment: 
		int OLD_item = 0;

		int item2 = 0; //Comment: 
		int OLD_item2 = 0;

		int quest_done_A = 0; //Comment: 
		int OLD_quest_done_A = 0;

		int quest_done_H = 0; //Comment: 
		int OLD_quest_done_H = 0;

		int completed_achievement = 0; //Comment: 
		int OLD_completed_achievement = 0;

		string quest_failed_text = null; //Comment: 
		string OLD_quest_failed_text = null;

		string comment = null; //Comment: 
		string OLD_comment = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Access_requirement(int _mapId, int _difficulty, int _level_min, int _level_max, int _item, int _item2, int _quest_done_A, int _quest_done_H, int _completed_achievement, string _quest_failed_text, string _comment)
		{
			mapId = _mapId;
			difficulty = _difficulty;
			level_min = _level_min;
			level_max = _level_max;
			item = _item;
			item2 = _item2;
			quest_done_A = _quest_done_A;
			quest_done_H = _quest_done_H;
			completed_achievement = _completed_achievement;
			quest_failed_text = _quest_failed_text;
			comment = _comment;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM access_requirement WHERE mapId = @mapId AND difficulty = @difficulty AND level_min = @level_min AND level_max = @level_max AND item = @item AND item2 = @item2 AND quest_done_A = @quest_done_A AND quest_done_H = @quest_done_H AND completed_achievement = @completed_achievement AND quest_failed_text = @quest_failed_text AND comment = @comment;";
			MySqlParameter mapidParameter = new MySqlParameter("@mapId", MySqlDbType.VarChar, 0);
			MySqlParameter difficultyParameter = new MySqlParameter("@difficulty", MySqlDbType.VarChar, 0);
			MySqlParameter level_minParameter = new MySqlParameter("@level_min", MySqlDbType.VarChar, 0);
			MySqlParameter level_maxParameter = new MySqlParameter("@level_max", MySqlDbType.VarChar, 0);
			MySqlParameter itemParameter = new MySqlParameter("@item", MySqlDbType.VarChar, 0);
			MySqlParameter item2Parameter = new MySqlParameter("@item2", MySqlDbType.VarChar, 0);
			MySqlParameter quest_done_aParameter = new MySqlParameter("@quest_done_A", MySqlDbType.VarChar, 0);
			MySqlParameter quest_done_hParameter = new MySqlParameter("@quest_done_H", MySqlDbType.VarChar, 0);
			MySqlParameter completed_achievementParameter = new MySqlParameter("@completed_achievement", MySqlDbType.VarChar, 0);
			MySqlParameter quest_failed_textParameter = new MySqlParameter("@quest_failed_text", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@comment", MySqlDbType.VarChar, 0);
			mapidParameter.Value = mapId;
			difficultyParameter.Value = difficulty;
			level_minParameter.Value = level_min;
			level_maxParameter.Value = level_max;
			itemParameter.Value = item;
			item2Parameter.Value = item2;
			quest_done_aParameter.Value = quest_done_A;
			quest_done_hParameter.Value = quest_done_H;
			completed_achievementParameter.Value = completed_achievement;
			quest_failed_textParameter.Value = quest_failed_text;
			commentParameter.Value = comment;
			cmd.Parameters.Add(mapidParameter);
			cmd.Parameters.Add(difficultyParameter);
			cmd.Parameters.Add(level_minParameter);
			cmd.Parameters.Add(level_maxParameter);
			cmd.Parameters.Add(itemParameter);
			cmd.Parameters.Add(item2Parameter);
			cmd.Parameters.Add(quest_done_aParameter);
			cmd.Parameters.Add(quest_done_hParameter);
			cmd.Parameters.Add(completed_achievementParameter);
			cmd.Parameters.Add(quest_failed_textParameter);
			cmd.Parameters.Add(commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE access_requirement SET mapId = @newmapId, difficulty = @newdifficulty, level_min = @newlevel_min, level_max = @newlevel_max, item = @newitem, item2 = @newitem2, quest_done_A = @newquest_done_A, quest_done_H = @newquest_done_H, completed_achievement = @newcompleted_achievement, quest_failed_text = @newquest_failed_text, comment = @newcomment WHERE mapId = @mapId AND difficulty = @difficulty AND level_min = @level_min AND level_max = @level_max AND item = @item AND item2 = @item2 AND quest_done_A = @quest_done_A AND quest_done_H = @quest_done_H AND completed_achievement = @completed_achievement AND quest_failed_text = @quest_failed_text AND comment = @comment;";
			MySqlParameter OLD_mapidParameter = new MySqlParameter("@mapId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_difficultyParameter = new MySqlParameter("@difficulty", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_level_minParameter = new MySqlParameter("@level_min", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_level_maxParameter = new MySqlParameter("@level_max", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_itemParameter = new MySqlParameter("@item", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_item2Parameter = new MySqlParameter("@item2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_quest_done_aParameter = new MySqlParameter("@quest_done_A", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_quest_done_hParameter = new MySqlParameter("@quest_done_H", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_completed_achievementParameter = new MySqlParameter("@completed_achievement", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_quest_failed_textParameter = new MySqlParameter("@quest_failed_text", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_commentParameter = new MySqlParameter("@comment", MySqlDbType.VarChar, 0);
			MySqlParameter mapidParameter = new MySqlParameter("@newmapId", MySqlDbType.VarChar, 0);
			MySqlParameter difficultyParameter = new MySqlParameter("@newdifficulty", MySqlDbType.VarChar, 0);
			MySqlParameter level_minParameter = new MySqlParameter("@newlevel_min", MySqlDbType.VarChar, 0);
			MySqlParameter level_maxParameter = new MySqlParameter("@newlevel_max", MySqlDbType.VarChar, 0);
			MySqlParameter itemParameter = new MySqlParameter("@newitem", MySqlDbType.VarChar, 0);
			MySqlParameter item2Parameter = new MySqlParameter("@newitem2", MySqlDbType.VarChar, 0);
			MySqlParameter quest_done_aParameter = new MySqlParameter("@newquest_done_A", MySqlDbType.VarChar, 0);
			MySqlParameter quest_done_hParameter = new MySqlParameter("@newquest_done_H", MySqlDbType.VarChar, 0);
			MySqlParameter completed_achievementParameter = new MySqlParameter("@newcompleted_achievement", MySqlDbType.VarChar, 0);
			MySqlParameter quest_failed_textParameter = new MySqlParameter("@newquest_failed_text", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@newcomment", MySqlDbType.VarChar, 0);
			mapidParameter.Value = mapId;
			difficultyParameter.Value = difficulty;
			level_minParameter.Value = level_min;
			level_maxParameter.Value = level_max;
			itemParameter.Value = item;
			item2Parameter.Value = item2;
			quest_done_aParameter.Value = quest_done_A;
			quest_done_hParameter.Value = quest_done_H;
			completed_achievementParameter.Value = completed_achievement;
			quest_failed_textParameter.Value = quest_failed_text;
			commentParameter.Value = comment;
			OLD_mapidParameter.Value = OLD_mapId;
			OLD_difficultyParameter.Value = OLD_difficulty;
			OLD_level_minParameter.Value = OLD_level_min;
			OLD_level_maxParameter.Value = OLD_level_max;
			OLD_itemParameter.Value = OLD_item;
			OLD_item2Parameter.Value = OLD_item2;
			OLD_quest_done_aParameter.Value = OLD_quest_done_A;
			OLD_quest_done_hParameter.Value = OLD_quest_done_H;
			OLD_completed_achievementParameter.Value = OLD_completed_achievement;
			OLD_quest_failed_textParameter.Value = OLD_quest_failed_text;
			OLD_commentParameter.Value = OLD_comment;
			cmd.Parameters.Add(mapidParameter);
			cmd.Parameters.Add(difficultyParameter);
			cmd.Parameters.Add(level_minParameter);
			cmd.Parameters.Add(level_maxParameter);
			cmd.Parameters.Add(itemParameter);
			cmd.Parameters.Add(item2Parameter);
			cmd.Parameters.Add(quest_done_aParameter);
			cmd.Parameters.Add(quest_done_hParameter);
			cmd.Parameters.Add(completed_achievementParameter);
			cmd.Parameters.Add(quest_failed_textParameter);
			cmd.Parameters.Add(commentParameter);
			cmd.Parameters.Add(OLD_mapidParameter);
			cmd.Parameters.Add(OLD_difficultyParameter);
			cmd.Parameters.Add(OLD_level_minParameter);
			cmd.Parameters.Add(OLD_level_maxParameter);
			cmd.Parameters.Add(OLD_itemParameter);
			cmd.Parameters.Add(OLD_item2Parameter);
			cmd.Parameters.Add(OLD_quest_done_aParameter);
			cmd.Parameters.Add(OLD_quest_done_hParameter);
			cmd.Parameters.Add(OLD_completed_achievementParameter);
			cmd.Parameters.Add(OLD_quest_failed_textParameter);
			cmd.Parameters.Add(OLD_commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_mapId = mapId;
			OLD_difficulty = difficulty;
			OLD_level_min = level_min;
			OLD_level_max = level_max;
			OLD_item = item;
			OLD_item2 = item2;
			OLD_quest_done_A = quest_done_A;
			OLD_quest_done_H = quest_done_H;
			OLD_completed_achievement = completed_achievement;
			OLD_quest_failed_text = quest_failed_text;
			OLD_comment = comment;
		}
	}
}
