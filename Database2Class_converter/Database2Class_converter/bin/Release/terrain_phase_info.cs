using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Terrain_phase_info
	{
		int Id = 0; //Comment: 
		int OLD_Id = 0;

		int TerrainSwapMap = 0; //Comment: 
		int OLD_TerrainSwapMap = 0;

		string Comment = null; //Comment: 
		string OLD_Comment = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Terrain_phase_info(int _Id, int _TerrainSwapMap, string _Comment)
		{
			Id = _Id;
			TerrainSwapMap = _TerrainSwapMap;
			Comment = _Comment;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM terrain_phase_info WHERE Id = @Id AND TerrainSwapMap = @TerrainSwapMap AND Comment = @Comment;";
			MySqlParameter idParameter = new MySqlParameter("@Id", MySqlDbType.VarChar, 0);
			MySqlParameter terrainswapmapParameter = new MySqlParameter("@TerrainSwapMap", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@Comment", MySqlDbType.VarChar, 0);
			idParameter.Value = Id;
			terrainswapmapParameter.Value = TerrainSwapMap;
			commentParameter.Value = Comment;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(terrainswapmapParameter);
			cmd.Parameters.Add(commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE terrain_phase_info SET Id = @newId, TerrainSwapMap = @newTerrainSwapMap, Comment = @newComment WHERE Id = @Id AND TerrainSwapMap = @TerrainSwapMap AND Comment = @Comment;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@Id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_terrainswapmapParameter = new MySqlParameter("@TerrainSwapMap", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_commentParameter = new MySqlParameter("@Comment", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newId", MySqlDbType.VarChar, 0);
			MySqlParameter terrainswapmapParameter = new MySqlParameter("@newTerrainSwapMap", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@newComment", MySqlDbType.VarChar, 0);
			idParameter.Value = Id;
			terrainswapmapParameter.Value = TerrainSwapMap;
			commentParameter.Value = Comment;
			OLD_idParameter.Value = OLD_Id;
			OLD_terrainswapmapParameter.Value = OLD_TerrainSwapMap;
			OLD_commentParameter.Value = OLD_Comment;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(terrainswapmapParameter);
			cmd.Parameters.Add(commentParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_terrainswapmapParameter);
			cmd.Parameters.Add(OLD_commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_Id = Id;
			OLD_TerrainSwapMap = TerrainSwapMap;
			OLD_Comment = Comment;
		}
	}
}
