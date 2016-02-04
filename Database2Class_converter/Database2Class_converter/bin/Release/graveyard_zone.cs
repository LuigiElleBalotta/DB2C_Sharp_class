using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Graveyard_zone
	{
		int ID = 0; //Comment: 
		int OLD_ID = 0;

		int GhostZone = 0; //Comment: 
		int OLD_GhostZone = 0;

		int Faction = 0; //Comment: 
		int OLD_Faction = 0;

		string Comment = null; //Comment: 
		string OLD_Comment = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Graveyard_zone(int _ID, int _GhostZone, int _Faction, string _Comment)
		{
			ID = _ID;
			GhostZone = _GhostZone;
			Faction = _Faction;
			Comment = _Comment;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM graveyard_zone WHERE ID = @ID AND GhostZone = @GhostZone AND Faction = @Faction AND Comment = @Comment;";
			MySqlParameter idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter ghostzoneParameter = new MySqlParameter("@GhostZone", MySqlDbType.VarChar, 0);
			MySqlParameter factionParameter = new MySqlParameter("@Faction", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@Comment", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			ghostzoneParameter.Value = GhostZone;
			factionParameter.Value = Faction;
			commentParameter.Value = Comment;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(ghostzoneParameter);
			cmd.Parameters.Add(factionParameter);
			cmd.Parameters.Add(commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE graveyard_zone SET ID = @newID, GhostZone = @newGhostZone, Faction = @newFaction, Comment = @newComment WHERE ID = @ID AND GhostZone = @GhostZone AND Faction = @Faction AND Comment = @Comment;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_ghostzoneParameter = new MySqlParameter("@GhostZone", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_factionParameter = new MySqlParameter("@Faction", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_commentParameter = new MySqlParameter("@Comment", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newID", MySqlDbType.VarChar, 0);
			MySqlParameter ghostzoneParameter = new MySqlParameter("@newGhostZone", MySqlDbType.VarChar, 0);
			MySqlParameter factionParameter = new MySqlParameter("@newFaction", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@newComment", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			ghostzoneParameter.Value = GhostZone;
			factionParameter.Value = Faction;
			commentParameter.Value = Comment;
			OLD_idParameter.Value = OLD_ID;
			OLD_ghostzoneParameter.Value = OLD_GhostZone;
			OLD_factionParameter.Value = OLD_Faction;
			OLD_commentParameter.Value = OLD_Comment;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(ghostzoneParameter);
			cmd.Parameters.Add(factionParameter);
			cmd.Parameters.Add(commentParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_ghostzoneParameter);
			cmd.Parameters.Add(OLD_factionParameter);
			cmd.Parameters.Add(OLD_commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_ID = ID;
			OLD_GhostZone = GhostZone;
			OLD_Faction = Faction;
			OLD_Comment = Comment;
		}
	}
}
