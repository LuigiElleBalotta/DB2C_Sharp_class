using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Battleground_template
	{
		int ID = 0; //Comment: 
		int OLD_ID = 0;

		int MinPlayersPerTeam = 0; //Comment: 
		int OLD_MinPlayersPerTeam = 0;

		int MaxPlayersPerTeam = 0; //Comment: 
		int OLD_MaxPlayersPerTeam = 0;

		int MinLvl = 0; //Comment: 
		int OLD_MinLvl = 0;

		int MaxLvl = 0; //Comment: 
		int OLD_MaxLvl = 0;

		int AllianceStartLoc = 0; //Comment: 
		int OLD_AllianceStartLoc = 0;

		int HordeStartLoc = 0; //Comment: 
		int OLD_HordeStartLoc = 0;

		float StartMaxDist = 0f; //Comment: 
		float OLD_StartMaxDist = 0f;

		int Weight = 1; //Comment: 
		int OLD_Weight = 1;

		char ScriptName = Char.MinValue; //Comment: 
		char OLD_ScriptName = Char.MinValue;

		char Comment = Char.MinValue; //Comment: 
		char OLD_Comment = Char.MinValue;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Battleground_template(int _ID, int _MinPlayersPerTeam, int _MaxPlayersPerTeam, int _MinLvl, int _MaxLvl, int _AllianceStartLoc, int _HordeStartLoc, float _StartMaxDist, int _Weight, char _ScriptName, char _Comment)
		{
			ID = _ID;
			MinPlayersPerTeam = _MinPlayersPerTeam;
			MaxPlayersPerTeam = _MaxPlayersPerTeam;
			MinLvl = _MinLvl;
			MaxLvl = _MaxLvl;
			AllianceStartLoc = _AllianceStartLoc;
			HordeStartLoc = _HordeStartLoc;
			StartMaxDist = _StartMaxDist;
			Weight = _Weight;
			ScriptName = _ScriptName;
			Comment = _Comment;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM battleground_template WHERE ID = @ID AND MinPlayersPerTeam = @MinPlayersPerTeam AND MaxPlayersPerTeam = @MaxPlayersPerTeam AND MinLvl = @MinLvl AND MaxLvl = @MaxLvl AND AllianceStartLoc = @AllianceStartLoc AND HordeStartLoc = @HordeStartLoc AND StartMaxDist = @StartMaxDist AND Weight = @Weight AND ScriptName = @ScriptName AND Comment = @Comment;";
			MySqlParameter idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter minplayersperteamParameter = new MySqlParameter("@MinPlayersPerTeam", MySqlDbType.VarChar, 0);
			MySqlParameter maxplayersperteamParameter = new MySqlParameter("@MaxPlayersPerTeam", MySqlDbType.VarChar, 0);
			MySqlParameter minlvlParameter = new MySqlParameter("@MinLvl", MySqlDbType.VarChar, 0);
			MySqlParameter maxlvlParameter = new MySqlParameter("@MaxLvl", MySqlDbType.VarChar, 0);
			MySqlParameter alliancestartlocParameter = new MySqlParameter("@AllianceStartLoc", MySqlDbType.VarChar, 0);
			MySqlParameter hordestartlocParameter = new MySqlParameter("@HordeStartLoc", MySqlDbType.VarChar, 0);
			MySqlParameter startmaxdistParameter = new MySqlParameter("@StartMaxDist", MySqlDbType.VarChar, 0);
			MySqlParameter weightParameter = new MySqlParameter("@Weight", MySqlDbType.VarChar, 0);
			MySqlParameter scriptnameParameter = new MySqlParameter("@ScriptName", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@Comment", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			minplayersperteamParameter.Value = MinPlayersPerTeam;
			maxplayersperteamParameter.Value = MaxPlayersPerTeam;
			minlvlParameter.Value = MinLvl;
			maxlvlParameter.Value = MaxLvl;
			alliancestartlocParameter.Value = AllianceStartLoc;
			hordestartlocParameter.Value = HordeStartLoc;
			startmaxdistParameter.Value = StartMaxDist;
			weightParameter.Value = Weight;
			scriptnameParameter.Value = ScriptName;
			commentParameter.Value = Comment;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(minplayersperteamParameter);
			cmd.Parameters.Add(maxplayersperteamParameter);
			cmd.Parameters.Add(minlvlParameter);
			cmd.Parameters.Add(maxlvlParameter);
			cmd.Parameters.Add(alliancestartlocParameter);
			cmd.Parameters.Add(hordestartlocParameter);
			cmd.Parameters.Add(startmaxdistParameter);
			cmd.Parameters.Add(weightParameter);
			cmd.Parameters.Add(scriptnameParameter);
			cmd.Parameters.Add(commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE battleground_template SET ID = @newID, MinPlayersPerTeam = @newMinPlayersPerTeam, MaxPlayersPerTeam = @newMaxPlayersPerTeam, MinLvl = @newMinLvl, MaxLvl = @newMaxLvl, AllianceStartLoc = @newAllianceStartLoc, HordeStartLoc = @newHordeStartLoc, StartMaxDist = @newStartMaxDist, Weight = @newWeight, ScriptName = @newScriptName, Comment = @newComment WHERE ID = @ID AND MinPlayersPerTeam = @MinPlayersPerTeam AND MaxPlayersPerTeam = @MaxPlayersPerTeam AND MinLvl = @MinLvl AND MaxLvl = @MaxLvl AND AllianceStartLoc = @AllianceStartLoc AND HordeStartLoc = @HordeStartLoc AND StartMaxDist = @StartMaxDist AND Weight = @Weight AND ScriptName = @ScriptName AND Comment = @Comment;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_minplayersperteamParameter = new MySqlParameter("@MinPlayersPerTeam", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_maxplayersperteamParameter = new MySqlParameter("@MaxPlayersPerTeam", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_minlvlParameter = new MySqlParameter("@MinLvl", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_maxlvlParameter = new MySqlParameter("@MaxLvl", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_alliancestartlocParameter = new MySqlParameter("@AllianceStartLoc", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_hordestartlocParameter = new MySqlParameter("@HordeStartLoc", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_startmaxdistParameter = new MySqlParameter("@StartMaxDist", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_weightParameter = new MySqlParameter("@Weight", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_scriptnameParameter = new MySqlParameter("@ScriptName", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_commentParameter = new MySqlParameter("@Comment", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newID", MySqlDbType.VarChar, 0);
			MySqlParameter minplayersperteamParameter = new MySqlParameter("@newMinPlayersPerTeam", MySqlDbType.VarChar, 0);
			MySqlParameter maxplayersperteamParameter = new MySqlParameter("@newMaxPlayersPerTeam", MySqlDbType.VarChar, 0);
			MySqlParameter minlvlParameter = new MySqlParameter("@newMinLvl", MySqlDbType.VarChar, 0);
			MySqlParameter maxlvlParameter = new MySqlParameter("@newMaxLvl", MySqlDbType.VarChar, 0);
			MySqlParameter alliancestartlocParameter = new MySqlParameter("@newAllianceStartLoc", MySqlDbType.VarChar, 0);
			MySqlParameter hordestartlocParameter = new MySqlParameter("@newHordeStartLoc", MySqlDbType.VarChar, 0);
			MySqlParameter startmaxdistParameter = new MySqlParameter("@newStartMaxDist", MySqlDbType.VarChar, 0);
			MySqlParameter weightParameter = new MySqlParameter("@newWeight", MySqlDbType.VarChar, 0);
			MySqlParameter scriptnameParameter = new MySqlParameter("@newScriptName", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@newComment", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			minplayersperteamParameter.Value = MinPlayersPerTeam;
			maxplayersperteamParameter.Value = MaxPlayersPerTeam;
			minlvlParameter.Value = MinLvl;
			maxlvlParameter.Value = MaxLvl;
			alliancestartlocParameter.Value = AllianceStartLoc;
			hordestartlocParameter.Value = HordeStartLoc;
			startmaxdistParameter.Value = StartMaxDist;
			weightParameter.Value = Weight;
			scriptnameParameter.Value = ScriptName;
			commentParameter.Value = Comment;
			OLD_idParameter.Value = OLD_ID;
			OLD_minplayersperteamParameter.Value = OLD_MinPlayersPerTeam;
			OLD_maxplayersperteamParameter.Value = OLD_MaxPlayersPerTeam;
			OLD_minlvlParameter.Value = OLD_MinLvl;
			OLD_maxlvlParameter.Value = OLD_MaxLvl;
			OLD_alliancestartlocParameter.Value = OLD_AllianceStartLoc;
			OLD_hordestartlocParameter.Value = OLD_HordeStartLoc;
			OLD_startmaxdistParameter.Value = OLD_StartMaxDist;
			OLD_weightParameter.Value = OLD_Weight;
			OLD_scriptnameParameter.Value = OLD_ScriptName;
			OLD_commentParameter.Value = OLD_Comment;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(minplayersperteamParameter);
			cmd.Parameters.Add(maxplayersperteamParameter);
			cmd.Parameters.Add(minlvlParameter);
			cmd.Parameters.Add(maxlvlParameter);
			cmd.Parameters.Add(alliancestartlocParameter);
			cmd.Parameters.Add(hordestartlocParameter);
			cmd.Parameters.Add(startmaxdistParameter);
			cmd.Parameters.Add(weightParameter);
			cmd.Parameters.Add(scriptnameParameter);
			cmd.Parameters.Add(commentParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_minplayersperteamParameter);
			cmd.Parameters.Add(OLD_maxplayersperteamParameter);
			cmd.Parameters.Add(OLD_minlvlParameter);
			cmd.Parameters.Add(OLD_maxlvlParameter);
			cmd.Parameters.Add(OLD_alliancestartlocParameter);
			cmd.Parameters.Add(OLD_hordestartlocParameter);
			cmd.Parameters.Add(OLD_startmaxdistParameter);
			cmd.Parameters.Add(OLD_weightParameter);
			cmd.Parameters.Add(OLD_scriptnameParameter);
			cmd.Parameters.Add(OLD_commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_ID = ID;
			OLD_MinPlayersPerTeam = MinPlayersPerTeam;
			OLD_MaxPlayersPerTeam = MaxPlayersPerTeam;
			OLD_MinLvl = MinLvl;
			OLD_MaxLvl = MaxLvl;
			OLD_AllianceStartLoc = AllianceStartLoc;
			OLD_HordeStartLoc = HordeStartLoc;
			OLD_StartMaxDist = StartMaxDist;
			OLD_Weight = Weight;
			OLD_ScriptName = ScriptName;
			OLD_Comment = Comment;
		}
	}
}
