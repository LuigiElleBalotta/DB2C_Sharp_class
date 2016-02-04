using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Npc_trainer
	{
		int ID = 0; //Comment: 
		int OLD_ID = 0;

		int SpellID = 0; //Comment: 
		int OLD_SpellID = 0;

		int MoneyCost = 0; //Comment: 
		int OLD_MoneyCost = 0;

		int ReqSkillLine = 0; //Comment: 
		int OLD_ReqSkillLine = 0;

		int ReqSkillRank = 0; //Comment: 
		int OLD_ReqSkillRank = 0;

		int ReqLevel = 0; //Comment: 
		int OLD_ReqLevel = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Npc_trainer(int _ID, int _SpellID, int _MoneyCost, int _ReqSkillLine, int _ReqSkillRank, int _ReqLevel)
		{
			ID = _ID;
			SpellID = _SpellID;
			MoneyCost = _MoneyCost;
			ReqSkillLine = _ReqSkillLine;
			ReqSkillRank = _ReqSkillRank;
			ReqLevel = _ReqLevel;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM npc_trainer WHERE ID = @ID AND SpellID = @SpellID AND MoneyCost = @MoneyCost AND ReqSkillLine = @ReqSkillLine AND ReqSkillRank = @ReqSkillRank AND ReqLevel = @ReqLevel;";
			MySqlParameter idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter spellidParameter = new MySqlParameter("@SpellID", MySqlDbType.VarChar, 0);
			MySqlParameter moneycostParameter = new MySqlParameter("@MoneyCost", MySqlDbType.VarChar, 0);
			MySqlParameter reqskilllineParameter = new MySqlParameter("@ReqSkillLine", MySqlDbType.VarChar, 0);
			MySqlParameter reqskillrankParameter = new MySqlParameter("@ReqSkillRank", MySqlDbType.VarChar, 0);
			MySqlParameter reqlevelParameter = new MySqlParameter("@ReqLevel", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			spellidParameter.Value = SpellID;
			moneycostParameter.Value = MoneyCost;
			reqskilllineParameter.Value = ReqSkillLine;
			reqskillrankParameter.Value = ReqSkillRank;
			reqlevelParameter.Value = ReqLevel;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(spellidParameter);
			cmd.Parameters.Add(moneycostParameter);
			cmd.Parameters.Add(reqskilllineParameter);
			cmd.Parameters.Add(reqskillrankParameter);
			cmd.Parameters.Add(reqlevelParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE npc_trainer SET ID = @newID, SpellID = @newSpellID, MoneyCost = @newMoneyCost, ReqSkillLine = @newReqSkillLine, ReqSkillRank = @newReqSkillRank, ReqLevel = @newReqLevel WHERE ID = @ID AND SpellID = @SpellID AND MoneyCost = @MoneyCost AND ReqSkillLine = @ReqSkillLine AND ReqSkillRank = @ReqSkillRank AND ReqLevel = @ReqLevel;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spellidParameter = new MySqlParameter("@SpellID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_moneycostParameter = new MySqlParameter("@MoneyCost", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_reqskilllineParameter = new MySqlParameter("@ReqSkillLine", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_reqskillrankParameter = new MySqlParameter("@ReqSkillRank", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_reqlevelParameter = new MySqlParameter("@ReqLevel", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newID", MySqlDbType.VarChar, 0);
			MySqlParameter spellidParameter = new MySqlParameter("@newSpellID", MySqlDbType.VarChar, 0);
			MySqlParameter moneycostParameter = new MySqlParameter("@newMoneyCost", MySqlDbType.VarChar, 0);
			MySqlParameter reqskilllineParameter = new MySqlParameter("@newReqSkillLine", MySqlDbType.VarChar, 0);
			MySqlParameter reqskillrankParameter = new MySqlParameter("@newReqSkillRank", MySqlDbType.VarChar, 0);
			MySqlParameter reqlevelParameter = new MySqlParameter("@newReqLevel", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			spellidParameter.Value = SpellID;
			moneycostParameter.Value = MoneyCost;
			reqskilllineParameter.Value = ReqSkillLine;
			reqskillrankParameter.Value = ReqSkillRank;
			reqlevelParameter.Value = ReqLevel;
			OLD_idParameter.Value = OLD_ID;
			OLD_spellidParameter.Value = OLD_SpellID;
			OLD_moneycostParameter.Value = OLD_MoneyCost;
			OLD_reqskilllineParameter.Value = OLD_ReqSkillLine;
			OLD_reqskillrankParameter.Value = OLD_ReqSkillRank;
			OLD_reqlevelParameter.Value = OLD_ReqLevel;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(spellidParameter);
			cmd.Parameters.Add(moneycostParameter);
			cmd.Parameters.Add(reqskilllineParameter);
			cmd.Parameters.Add(reqskillrankParameter);
			cmd.Parameters.Add(reqlevelParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_spellidParameter);
			cmd.Parameters.Add(OLD_moneycostParameter);
			cmd.Parameters.Add(OLD_reqskilllineParameter);
			cmd.Parameters.Add(OLD_reqskillrankParameter);
			cmd.Parameters.Add(OLD_reqlevelParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_ID = ID;
			OLD_SpellID = SpellID;
			OLD_MoneyCost = MoneyCost;
			OLD_ReqSkillLine = ReqSkillLine;
			OLD_ReqSkillRank = ReqSkillRank;
			OLD_ReqLevel = ReqLevel;
		}
	}
}
