using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Terrain_worldmap
	{
		int TerrainSwapMap = 0; //Comment: 
		int OLD_TerrainSwapMap = 0;

		int WorldMapArea = 0; //Comment: 
		int OLD_WorldMapArea = 0;

		string Comment = null; //Comment: 
		string OLD_Comment = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Terrain_worldmap(int _TerrainSwapMap, int _WorldMapArea, string _Comment)
		{
			TerrainSwapMap = _TerrainSwapMap;
			WorldMapArea = _WorldMapArea;
			Comment = _Comment;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM terrain_worldmap WHERE TerrainSwapMap = @TerrainSwapMap AND WorldMapArea = @WorldMapArea AND Comment = @Comment;";
			MySqlParameter terrainswapmapParameter = new MySqlParameter("@TerrainSwapMap", MySqlDbType.VarChar, 0);
			MySqlParameter worldmapareaParameter = new MySqlParameter("@WorldMapArea", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@Comment", MySqlDbType.VarChar, 0);
			terrainswapmapParameter.Value = TerrainSwapMap;
			worldmapareaParameter.Value = WorldMapArea;
			commentParameter.Value = Comment;
			cmd.Parameters.Add(terrainswapmapParameter);
			cmd.Parameters.Add(worldmapareaParameter);
			cmd.Parameters.Add(commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE terrain_worldmap SET TerrainSwapMap = @newTerrainSwapMap, WorldMapArea = @newWorldMapArea, Comment = @newComment WHERE TerrainSwapMap = @TerrainSwapMap AND WorldMapArea = @WorldMapArea AND Comment = @Comment;";
			MySqlParameter OLD_terrainswapmapParameter = new MySqlParameter("@TerrainSwapMap", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_worldmapareaParameter = new MySqlParameter("@WorldMapArea", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_commentParameter = new MySqlParameter("@Comment", MySqlDbType.VarChar, 0);
			MySqlParameter terrainswapmapParameter = new MySqlParameter("@newTerrainSwapMap", MySqlDbType.VarChar, 0);
			MySqlParameter worldmapareaParameter = new MySqlParameter("@newWorldMapArea", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@newComment", MySqlDbType.VarChar, 0);
			terrainswapmapParameter.Value = TerrainSwapMap;
			worldmapareaParameter.Value = WorldMapArea;
			commentParameter.Value = Comment;
			OLD_terrainswapmapParameter.Value = OLD_TerrainSwapMap;
			OLD_worldmapareaParameter.Value = OLD_WorldMapArea;
			OLD_commentParameter.Value = OLD_Comment;
			cmd.Parameters.Add(terrainswapmapParameter);
			cmd.Parameters.Add(worldmapareaParameter);
			cmd.Parameters.Add(commentParameter);
			cmd.Parameters.Add(OLD_terrainswapmapParameter);
			cmd.Parameters.Add(OLD_worldmapareaParameter);
			cmd.Parameters.Add(OLD_commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_TerrainSwapMap = TerrainSwapMap;
			OLD_WorldMapArea = WorldMapArea;
			OLD_Comment = Comment;
		}
	}
}
