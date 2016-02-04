using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Creature_onkill_reputation
	{
		int creature_id = 0; //Comment: Creature Identifier
		int OLD_creature_id = 0;

		int RewOnKillRepFaction1 = 0; //Comment: 
		int OLD_RewOnKillRepFaction1 = 0;

		int RewOnKillRepFaction2 = 0; //Comment: 
		int OLD_RewOnKillRepFaction2 = 0;

		int MaxStanding1 = 0; //Comment: 
		int OLD_MaxStanding1 = 0;

		int IsTeamAward1 = 0; //Comment: 
		int OLD_IsTeamAward1 = 0;

		int RewOnKillRepValue1 = 0; //Comment: 
		int OLD_RewOnKillRepValue1 = 0;

		int MaxStanding2 = 0; //Comment: 
		int OLD_MaxStanding2 = 0;

		int IsTeamAward2 = 0; //Comment: 
		int OLD_IsTeamAward2 = 0;

		int RewOnKillRepValue2 = 0; //Comment: 
		int OLD_RewOnKillRepValue2 = 0;

		int TeamDependent = 0; //Comment: 
		int OLD_TeamDependent = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Creature_onkill_reputation(int _creature_id, int _RewOnKillRepFaction1, int _RewOnKillRepFaction2, int _MaxStanding1, int _IsTeamAward1, int _RewOnKillRepValue1, int _MaxStanding2, int _IsTeamAward2, int _RewOnKillRepValue2, int _TeamDependent)
		{
			creature_id = _creature_id;
			RewOnKillRepFaction1 = _RewOnKillRepFaction1;
			RewOnKillRepFaction2 = _RewOnKillRepFaction2;
			MaxStanding1 = _MaxStanding1;
			IsTeamAward1 = _IsTeamAward1;
			RewOnKillRepValue1 = _RewOnKillRepValue1;
			MaxStanding2 = _MaxStanding2;
			IsTeamAward2 = _IsTeamAward2;
			RewOnKillRepValue2 = _RewOnKillRepValue2;
			TeamDependent = _TeamDependent;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM creature_onkill_reputation WHERE creature_id = @creature_id AND RewOnKillRepFaction1 = @RewOnKillRepFaction1 AND RewOnKillRepFaction2 = @RewOnKillRepFaction2 AND MaxStanding1 = @MaxStanding1 AND IsTeamAward1 = @IsTeamAward1 AND RewOnKillRepValue1 = @RewOnKillRepValue1 AND MaxStanding2 = @MaxStanding2 AND IsTeamAward2 = @IsTeamAward2 AND RewOnKillRepValue2 = @RewOnKillRepValue2 AND TeamDependent = @TeamDependent;";
			MySqlParameter creature_idParameter = new MySqlParameter("@creature_id", MySqlDbType.VarChar, 0);
			MySqlParameter rewonkillrepfaction1Parameter = new MySqlParameter("@RewOnKillRepFaction1", MySqlDbType.VarChar, 0);
			MySqlParameter rewonkillrepfaction2Parameter = new MySqlParameter("@RewOnKillRepFaction2", MySqlDbType.VarChar, 0);
			MySqlParameter maxstanding1Parameter = new MySqlParameter("@MaxStanding1", MySqlDbType.VarChar, 0);
			MySqlParameter isteamaward1Parameter = new MySqlParameter("@IsTeamAward1", MySqlDbType.VarChar, 0);
			MySqlParameter rewonkillrepvalue1Parameter = new MySqlParameter("@RewOnKillRepValue1", MySqlDbType.VarChar, 0);
			MySqlParameter maxstanding2Parameter = new MySqlParameter("@MaxStanding2", MySqlDbType.VarChar, 0);
			MySqlParameter isteamaward2Parameter = new MySqlParameter("@IsTeamAward2", MySqlDbType.VarChar, 0);
			MySqlParameter rewonkillrepvalue2Parameter = new MySqlParameter("@RewOnKillRepValue2", MySqlDbType.VarChar, 0);
			MySqlParameter teamdependentParameter = new MySqlParameter("@TeamDependent", MySqlDbType.VarChar, 0);
			creature_idParameter.Value = creature_id;
			rewonkillrepfaction1Parameter.Value = RewOnKillRepFaction1;
			rewonkillrepfaction2Parameter.Value = RewOnKillRepFaction2;
			maxstanding1Parameter.Value = MaxStanding1;
			isteamaward1Parameter.Value = IsTeamAward1;
			rewonkillrepvalue1Parameter.Value = RewOnKillRepValue1;
			maxstanding2Parameter.Value = MaxStanding2;
			isteamaward2Parameter.Value = IsTeamAward2;
			rewonkillrepvalue2Parameter.Value = RewOnKillRepValue2;
			teamdependentParameter.Value = TeamDependent;
			cmd.Parameters.Add(creature_idParameter);
			cmd.Parameters.Add(rewonkillrepfaction1Parameter);
			cmd.Parameters.Add(rewonkillrepfaction2Parameter);
			cmd.Parameters.Add(maxstanding1Parameter);
			cmd.Parameters.Add(isteamaward1Parameter);
			cmd.Parameters.Add(rewonkillrepvalue1Parameter);
			cmd.Parameters.Add(maxstanding2Parameter);
			cmd.Parameters.Add(isteamaward2Parameter);
			cmd.Parameters.Add(rewonkillrepvalue2Parameter);
			cmd.Parameters.Add(teamdependentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE creature_onkill_reputation SET creature_id = @newcreature_id, RewOnKillRepFaction1 = @newRewOnKillRepFaction1, RewOnKillRepFaction2 = @newRewOnKillRepFaction2, MaxStanding1 = @newMaxStanding1, IsTeamAward1 = @newIsTeamAward1, RewOnKillRepValue1 = @newRewOnKillRepValue1, MaxStanding2 = @newMaxStanding2, IsTeamAward2 = @newIsTeamAward2, RewOnKillRepValue2 = @newRewOnKillRepValue2, TeamDependent = @newTeamDependent WHERE creature_id = @creature_id AND RewOnKillRepFaction1 = @RewOnKillRepFaction1 AND RewOnKillRepFaction2 = @RewOnKillRepFaction2 AND MaxStanding1 = @MaxStanding1 AND IsTeamAward1 = @IsTeamAward1 AND RewOnKillRepValue1 = @RewOnKillRepValue1 AND MaxStanding2 = @MaxStanding2 AND IsTeamAward2 = @IsTeamAward2 AND RewOnKillRepValue2 = @RewOnKillRepValue2 AND TeamDependent = @TeamDependent;";
			MySqlParameter OLD_creature_idParameter = new MySqlParameter("@creature_id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewonkillrepfaction1Parameter = new MySqlParameter("@RewOnKillRepFaction1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewonkillrepfaction2Parameter = new MySqlParameter("@RewOnKillRepFaction2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_maxstanding1Parameter = new MySqlParameter("@MaxStanding1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_isteamaward1Parameter = new MySqlParameter("@IsTeamAward1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewonkillrepvalue1Parameter = new MySqlParameter("@RewOnKillRepValue1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_maxstanding2Parameter = new MySqlParameter("@MaxStanding2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_isteamaward2Parameter = new MySqlParameter("@IsTeamAward2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rewonkillrepvalue2Parameter = new MySqlParameter("@RewOnKillRepValue2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_teamdependentParameter = new MySqlParameter("@TeamDependent", MySqlDbType.VarChar, 0);
			MySqlParameter creature_idParameter = new MySqlParameter("@newcreature_id", MySqlDbType.VarChar, 0);
			MySqlParameter rewonkillrepfaction1Parameter = new MySqlParameter("@newRewOnKillRepFaction1", MySqlDbType.VarChar, 0);
			MySqlParameter rewonkillrepfaction2Parameter = new MySqlParameter("@newRewOnKillRepFaction2", MySqlDbType.VarChar, 0);
			MySqlParameter maxstanding1Parameter = new MySqlParameter("@newMaxStanding1", MySqlDbType.VarChar, 0);
			MySqlParameter isteamaward1Parameter = new MySqlParameter("@newIsTeamAward1", MySqlDbType.VarChar, 0);
			MySqlParameter rewonkillrepvalue1Parameter = new MySqlParameter("@newRewOnKillRepValue1", MySqlDbType.VarChar, 0);
			MySqlParameter maxstanding2Parameter = new MySqlParameter("@newMaxStanding2", MySqlDbType.VarChar, 0);
			MySqlParameter isteamaward2Parameter = new MySqlParameter("@newIsTeamAward2", MySqlDbType.VarChar, 0);
			MySqlParameter rewonkillrepvalue2Parameter = new MySqlParameter("@newRewOnKillRepValue2", MySqlDbType.VarChar, 0);
			MySqlParameter teamdependentParameter = new MySqlParameter("@newTeamDependent", MySqlDbType.VarChar, 0);
			creature_idParameter.Value = creature_id;
			rewonkillrepfaction1Parameter.Value = RewOnKillRepFaction1;
			rewonkillrepfaction2Parameter.Value = RewOnKillRepFaction2;
			maxstanding1Parameter.Value = MaxStanding1;
			isteamaward1Parameter.Value = IsTeamAward1;
			rewonkillrepvalue1Parameter.Value = RewOnKillRepValue1;
			maxstanding2Parameter.Value = MaxStanding2;
			isteamaward2Parameter.Value = IsTeamAward2;
			rewonkillrepvalue2Parameter.Value = RewOnKillRepValue2;
			teamdependentParameter.Value = TeamDependent;
			OLD_creature_idParameter.Value = OLD_creature_id;
			OLD_rewonkillrepfaction1Parameter.Value = OLD_RewOnKillRepFaction1;
			OLD_rewonkillrepfaction2Parameter.Value = OLD_RewOnKillRepFaction2;
			OLD_maxstanding1Parameter.Value = OLD_MaxStanding1;
			OLD_isteamaward1Parameter.Value = OLD_IsTeamAward1;
			OLD_rewonkillrepvalue1Parameter.Value = OLD_RewOnKillRepValue1;
			OLD_maxstanding2Parameter.Value = OLD_MaxStanding2;
			OLD_isteamaward2Parameter.Value = OLD_IsTeamAward2;
			OLD_rewonkillrepvalue2Parameter.Value = OLD_RewOnKillRepValue2;
			OLD_teamdependentParameter.Value = OLD_TeamDependent;
			cmd.Parameters.Add(creature_idParameter);
			cmd.Parameters.Add(rewonkillrepfaction1Parameter);
			cmd.Parameters.Add(rewonkillrepfaction2Parameter);
			cmd.Parameters.Add(maxstanding1Parameter);
			cmd.Parameters.Add(isteamaward1Parameter);
			cmd.Parameters.Add(rewonkillrepvalue1Parameter);
			cmd.Parameters.Add(maxstanding2Parameter);
			cmd.Parameters.Add(isteamaward2Parameter);
			cmd.Parameters.Add(rewonkillrepvalue2Parameter);
			cmd.Parameters.Add(teamdependentParameter);
			cmd.Parameters.Add(OLD_creature_idParameter);
			cmd.Parameters.Add(OLD_rewonkillrepfaction1Parameter);
			cmd.Parameters.Add(OLD_rewonkillrepfaction2Parameter);
			cmd.Parameters.Add(OLD_maxstanding1Parameter);
			cmd.Parameters.Add(OLD_isteamaward1Parameter);
			cmd.Parameters.Add(OLD_rewonkillrepvalue1Parameter);
			cmd.Parameters.Add(OLD_maxstanding2Parameter);
			cmd.Parameters.Add(OLD_isteamaward2Parameter);
			cmd.Parameters.Add(OLD_rewonkillrepvalue2Parameter);
			cmd.Parameters.Add(OLD_teamdependentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_creature_id = creature_id;
			OLD_RewOnKillRepFaction1 = RewOnKillRepFaction1;
			OLD_RewOnKillRepFaction2 = RewOnKillRepFaction2;
			OLD_MaxStanding1 = MaxStanding1;
			OLD_IsTeamAward1 = IsTeamAward1;
			OLD_RewOnKillRepValue1 = RewOnKillRepValue1;
			OLD_MaxStanding2 = MaxStanding2;
			OLD_IsTeamAward2 = IsTeamAward2;
			OLD_RewOnKillRepValue2 = RewOnKillRepValue2;
			OLD_TeamDependent = TeamDependent;
		}
	}
}
