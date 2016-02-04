using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Creature_formations
	{
		int leaderGUID = 0; //Comment: 
		int OLD_leaderGUID = 0;

		int memberGUID = 0; //Comment: 
		int OLD_memberGUID = 0;

		float dist = 0.0f; //Comment: 
		float OLD_dist = 0.0f;

		float angle = 0.0f; //Comment: 
		float OLD_angle = 0.0f;

		int groupAI = 0; //Comment: 
		int OLD_groupAI = 0;

		int point_1 = 0; //Comment: 
		int OLD_point_1 = 0;

		int point_2 = 0; //Comment: 
		int OLD_point_2 = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Creature_formations(int _leaderGUID, int _memberGUID, float _dist, float _angle, int _groupAI, int _point_1, int _point_2)
		{
			leaderGUID = _leaderGUID;
			memberGUID = _memberGUID;
			dist = _dist;
			angle = _angle;
			groupAI = _groupAI;
			point_1 = _point_1;
			point_2 = _point_2;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM creature_formations WHERE leaderGUID = @leaderGUID AND memberGUID = @memberGUID AND dist = @dist AND angle = @angle AND groupAI = @groupAI AND point_1 = @point_1 AND point_2 = @point_2;";
			MySqlParameter leaderguidParameter = new MySqlParameter("@leaderGUID", MySqlDbType.VarChar, 0);
			MySqlParameter memberguidParameter = new MySqlParameter("@memberGUID", MySqlDbType.VarChar, 0);
			MySqlParameter distParameter = new MySqlParameter("@dist", MySqlDbType.VarChar, 0);
			MySqlParameter angleParameter = new MySqlParameter("@angle", MySqlDbType.VarChar, 0);
			MySqlParameter groupaiParameter = new MySqlParameter("@groupAI", MySqlDbType.VarChar, 0);
			MySqlParameter point_1Parameter = new MySqlParameter("@point_1", MySqlDbType.VarChar, 0);
			MySqlParameter point_2Parameter = new MySqlParameter("@point_2", MySqlDbType.VarChar, 0);
			leaderguidParameter.Value = leaderGUID;
			memberguidParameter.Value = memberGUID;
			distParameter.Value = dist;
			angleParameter.Value = angle;
			groupaiParameter.Value = groupAI;
			point_1Parameter.Value = point_1;
			point_2Parameter.Value = point_2;
			cmd.Parameters.Add(leaderguidParameter);
			cmd.Parameters.Add(memberguidParameter);
			cmd.Parameters.Add(distParameter);
			cmd.Parameters.Add(angleParameter);
			cmd.Parameters.Add(groupaiParameter);
			cmd.Parameters.Add(point_1Parameter);
			cmd.Parameters.Add(point_2Parameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE creature_formations SET leaderGUID = @newleaderGUID, memberGUID = @newmemberGUID, dist = @newdist, angle = @newangle, groupAI = @newgroupAI, point_1 = @newpoint_1, point_2 = @newpoint_2 WHERE leaderGUID = @leaderGUID AND memberGUID = @memberGUID AND dist = @dist AND angle = @angle AND groupAI = @groupAI AND point_1 = @point_1 AND point_2 = @point_2;";
			MySqlParameter OLD_leaderguidParameter = new MySqlParameter("@leaderGUID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_memberguidParameter = new MySqlParameter("@memberGUID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_distParameter = new MySqlParameter("@dist", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_angleParameter = new MySqlParameter("@angle", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_groupaiParameter = new MySqlParameter("@groupAI", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_point_1Parameter = new MySqlParameter("@point_1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_point_2Parameter = new MySqlParameter("@point_2", MySqlDbType.VarChar, 0);
			MySqlParameter leaderguidParameter = new MySqlParameter("@newleaderGUID", MySqlDbType.VarChar, 0);
			MySqlParameter memberguidParameter = new MySqlParameter("@newmemberGUID", MySqlDbType.VarChar, 0);
			MySqlParameter distParameter = new MySqlParameter("@newdist", MySqlDbType.VarChar, 0);
			MySqlParameter angleParameter = new MySqlParameter("@newangle", MySqlDbType.VarChar, 0);
			MySqlParameter groupaiParameter = new MySqlParameter("@newgroupAI", MySqlDbType.VarChar, 0);
			MySqlParameter point_1Parameter = new MySqlParameter("@newpoint_1", MySqlDbType.VarChar, 0);
			MySqlParameter point_2Parameter = new MySqlParameter("@newpoint_2", MySqlDbType.VarChar, 0);
			leaderguidParameter.Value = leaderGUID;
			memberguidParameter.Value = memberGUID;
			distParameter.Value = dist;
			angleParameter.Value = angle;
			groupaiParameter.Value = groupAI;
			point_1Parameter.Value = point_1;
			point_2Parameter.Value = point_2;
			OLD_leaderguidParameter.Value = OLD_leaderGUID;
			OLD_memberguidParameter.Value = OLD_memberGUID;
			OLD_distParameter.Value = OLD_dist;
			OLD_angleParameter.Value = OLD_angle;
			OLD_groupaiParameter.Value = OLD_groupAI;
			OLD_point_1Parameter.Value = OLD_point_1;
			OLD_point_2Parameter.Value = OLD_point_2;
			cmd.Parameters.Add(leaderguidParameter);
			cmd.Parameters.Add(memberguidParameter);
			cmd.Parameters.Add(distParameter);
			cmd.Parameters.Add(angleParameter);
			cmd.Parameters.Add(groupaiParameter);
			cmd.Parameters.Add(point_1Parameter);
			cmd.Parameters.Add(point_2Parameter);
			cmd.Parameters.Add(OLD_leaderguidParameter);
			cmd.Parameters.Add(OLD_memberguidParameter);
			cmd.Parameters.Add(OLD_distParameter);
			cmd.Parameters.Add(OLD_angleParameter);
			cmd.Parameters.Add(OLD_groupaiParameter);
			cmd.Parameters.Add(OLD_point_1Parameter);
			cmd.Parameters.Add(OLD_point_2Parameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_leaderGUID = leaderGUID;
			OLD_memberGUID = memberGUID;
			OLD_dist = dist;
			OLD_angle = angle;
			OLD_groupAI = groupAI;
			OLD_point_1 = point_1;
			OLD_point_2 = point_2;
		}
	}
}
