using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Lfg_dungeon_template
	{
		int dungeonId = 0; //Comment: Unique id from LFGDungeons.dbc
		int OLD_dungeonId = 0;

		string name = null; //Comment: 
		string OLD_name = null;

		float position_x = 0f; //Comment: 
		float OLD_position_x = 0f;

		float position_y = 0f; //Comment: 
		float OLD_position_y = 0f;

		float position_z = 0f; //Comment: 
		float OLD_position_z = 0f;

		float orientation = 0f; //Comment: 
		float OLD_orientation = 0f;

		int requiredItemLevel = 0; //Comment: 
		int OLD_requiredItemLevel = 0;

		int VerifiedBuild = 0; //Comment: 
		int OLD_VerifiedBuild = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Lfg_dungeon_template(int _dungeonId, string _name, float _position_x, float _position_y, float _position_z, float _orientation, int _requiredItemLevel, int _VerifiedBuild)
		{
			dungeonId = _dungeonId;
			name = _name;
			position_x = _position_x;
			position_y = _position_y;
			position_z = _position_z;
			orientation = _orientation;
			requiredItemLevel = _requiredItemLevel;
			VerifiedBuild = _VerifiedBuild;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM lfg_dungeon_template WHERE dungeonId = @dungeonId AND name = @name AND position_x = @position_x AND position_y = @position_y AND position_z = @position_z AND orientation = @orientation AND requiredItemLevel = @requiredItemLevel AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter dungeonidParameter = new MySqlParameter("@dungeonId", MySqlDbType.VarChar, 0);
			MySqlParameter nameParameter = new MySqlParameter("@name", MySqlDbType.VarChar, 0);
			MySqlParameter position_xParameter = new MySqlParameter("@position_x", MySqlDbType.VarChar, 0);
			MySqlParameter position_yParameter = new MySqlParameter("@position_y", MySqlDbType.VarChar, 0);
			MySqlParameter position_zParameter = new MySqlParameter("@position_z", MySqlDbType.VarChar, 0);
			MySqlParameter orientationParameter = new MySqlParameter("@orientation", MySqlDbType.VarChar, 0);
			MySqlParameter requireditemlevelParameter = new MySqlParameter("@requiredItemLevel", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			dungeonidParameter.Value = dungeonId;
			nameParameter.Value = name;
			position_xParameter.Value = position_x;
			position_yParameter.Value = position_y;
			position_zParameter.Value = position_z;
			orientationParameter.Value = orientation;
			requireditemlevelParameter.Value = requiredItemLevel;
			verifiedbuildParameter.Value = VerifiedBuild;
			cmd.Parameters.Add(dungeonidParameter);
			cmd.Parameters.Add(nameParameter);
			cmd.Parameters.Add(position_xParameter);
			cmd.Parameters.Add(position_yParameter);
			cmd.Parameters.Add(position_zParameter);
			cmd.Parameters.Add(orientationParameter);
			cmd.Parameters.Add(requireditemlevelParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE lfg_dungeon_template SET dungeonId = @newdungeonId, name = @newname, position_x = @newposition_x, position_y = @newposition_y, position_z = @newposition_z, orientation = @neworientation, requiredItemLevel = @newrequiredItemLevel, VerifiedBuild = @newVerifiedBuild WHERE dungeonId = @dungeonId AND name = @name AND position_x = @position_x AND position_y = @position_y AND position_z = @position_z AND orientation = @orientation AND requiredItemLevel = @requiredItemLevel AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter OLD_dungeonidParameter = new MySqlParameter("@dungeonId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_nameParameter = new MySqlParameter("@name", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_position_xParameter = new MySqlParameter("@position_x", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_position_yParameter = new MySqlParameter("@position_y", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_position_zParameter = new MySqlParameter("@position_z", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_orientationParameter = new MySqlParameter("@orientation", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_requireditemlevelParameter = new MySqlParameter("@requiredItemLevel", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			MySqlParameter dungeonidParameter = new MySqlParameter("@newdungeonId", MySqlDbType.VarChar, 0);
			MySqlParameter nameParameter = new MySqlParameter("@newname", MySqlDbType.VarChar, 0);
			MySqlParameter position_xParameter = new MySqlParameter("@newposition_x", MySqlDbType.VarChar, 0);
			MySqlParameter position_yParameter = new MySqlParameter("@newposition_y", MySqlDbType.VarChar, 0);
			MySqlParameter position_zParameter = new MySqlParameter("@newposition_z", MySqlDbType.VarChar, 0);
			MySqlParameter orientationParameter = new MySqlParameter("@neworientation", MySqlDbType.VarChar, 0);
			MySqlParameter requireditemlevelParameter = new MySqlParameter("@newrequiredItemLevel", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@newVerifiedBuild", MySqlDbType.VarChar, 0);
			dungeonidParameter.Value = dungeonId;
			nameParameter.Value = name;
			position_xParameter.Value = position_x;
			position_yParameter.Value = position_y;
			position_zParameter.Value = position_z;
			orientationParameter.Value = orientation;
			requireditemlevelParameter.Value = requiredItemLevel;
			verifiedbuildParameter.Value = VerifiedBuild;
			OLD_dungeonidParameter.Value = OLD_dungeonId;
			OLD_nameParameter.Value = OLD_name;
			OLD_position_xParameter.Value = OLD_position_x;
			OLD_position_yParameter.Value = OLD_position_y;
			OLD_position_zParameter.Value = OLD_position_z;
			OLD_orientationParameter.Value = OLD_orientation;
			OLD_requireditemlevelParameter.Value = OLD_requiredItemLevel;
			OLD_verifiedbuildParameter.Value = OLD_VerifiedBuild;
			cmd.Parameters.Add(dungeonidParameter);
			cmd.Parameters.Add(nameParameter);
			cmd.Parameters.Add(position_xParameter);
			cmd.Parameters.Add(position_yParameter);
			cmd.Parameters.Add(position_zParameter);
			cmd.Parameters.Add(orientationParameter);
			cmd.Parameters.Add(requireditemlevelParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.Parameters.Add(OLD_dungeonidParameter);
			cmd.Parameters.Add(OLD_nameParameter);
			cmd.Parameters.Add(OLD_position_xParameter);
			cmd.Parameters.Add(OLD_position_yParameter);
			cmd.Parameters.Add(OLD_position_zParameter);
			cmd.Parameters.Add(OLD_orientationParameter);
			cmd.Parameters.Add(OLD_requireditemlevelParameter);
			cmd.Parameters.Add(OLD_verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_dungeonId = dungeonId;
			OLD_name = name;
			OLD_position_x = position_x;
			OLD_position_y = position_y;
			OLD_position_z = position_z;
			OLD_orientation = orientation;
			OLD_requiredItemLevel = requiredItemLevel;
			OLD_VerifiedBuild = VerifiedBuild;
		}
	}
}
