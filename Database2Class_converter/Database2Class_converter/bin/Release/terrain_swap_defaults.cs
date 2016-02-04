using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Terrain_swap_defaults
	{
		int MapId = 0; //Comment: 
		int OLD_MapId = 0;

		int TerrainSwapMap = 0; //Comment: 
		int OLD_TerrainSwapMap = 0;

		string Comment = null; //Comment: 
		string OLD_Comment = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Terrain_swap_defaults(int _MapId, int _TerrainSwapMap, string _Comment)
		{
			MapId = _MapId;
			TerrainSwapMap = _TerrainSwapMap;
			Comment = _Comment;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM terrain_swap_defaults WHERE MapId = @MapId AND TerrainSwapMap = @TerrainSwapMap AND Comment = @Comment;";
			MySqlParameter mapidParameter = new MySqlParameter("@MapId", MySqlDbType.VarChar, 0);
			MySqlParameter terrainswapmapParameter = new MySqlParameter("@TerrainSwapMap", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@Comment", MySqlDbType.VarChar, 0);
			mapidParameter.Value = MapId;
			terrainswapmapParameter.Value = TerrainSwapMap;
			commentParameter.Value = Comment;
			cmd.Parameters.Add(mapidParameter);
			cmd.Parameters.Add(terrainswapmapParameter);
			cmd.Parameters.Add(commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE terrain_swap_defaults SET MapId = @newMapId, TerrainSwapMap = @newTerrainSwapMap, Comment = @newComment WHERE MapId = @MapId AND TerrainSwapMap = @TerrainSwapMap AND Comment = @Comment;";
			MySqlParameter OLD_mapidParameter = new MySqlParameter("@MapId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_terrainswapmapParameter = new MySqlParameter("@TerrainSwapMap", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_commentParameter = new MySqlParameter("@Comment", MySqlDbType.VarChar, 0);
			MySqlParameter mapidParameter = new MySqlParameter("@newMapId", MySqlDbType.VarChar, 0);
			MySqlParameter terrainswapmapParameter = new MySqlParameter("@newTerrainSwapMap", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@newComment", MySqlDbType.VarChar, 0);
			mapidParameter.Value = MapId;
			terrainswapmapParameter.Value = TerrainSwapMap;
			commentParameter.Value = Comment;
			OLD_mapidParameter.Value = OLD_MapId;
			OLD_terrainswapmapParameter.Value = OLD_TerrainSwapMap;
			OLD_commentParameter.Value = OLD_Comment;
			cmd.Parameters.Add(mapidParameter);
			cmd.Parameters.Add(terrainswapmapParameter);
			cmd.Parameters.Add(commentParameter);
			cmd.Parameters.Add(OLD_mapidParameter);
			cmd.Parameters.Add(OLD_terrainswapmapParameter);
			cmd.Parameters.Add(OLD_commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_MapId = MapId;
			OLD_TerrainSwapMap = TerrainSwapMap;
			OLD_Comment = Comment;
		}
	}
}
