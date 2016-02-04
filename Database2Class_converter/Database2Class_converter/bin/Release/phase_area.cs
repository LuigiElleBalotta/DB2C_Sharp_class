using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Phase_area
	{
		int AreaId = 0; //Comment: 
		int OLD_AreaId = 0;

		int PhaseId = 0; //Comment: 
		int OLD_PhaseId = 0;

		string Comment = null; //Comment: 
		string OLD_Comment = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Phase_area(int _AreaId, int _PhaseId, string _Comment)
		{
			AreaId = _AreaId;
			PhaseId = _PhaseId;
			Comment = _Comment;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM phase_area WHERE AreaId = @AreaId AND PhaseId = @PhaseId AND Comment = @Comment;";
			MySqlParameter areaidParameter = new MySqlParameter("@AreaId", MySqlDbType.VarChar, 0);
			MySqlParameter phaseidParameter = new MySqlParameter("@PhaseId", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@Comment", MySqlDbType.VarChar, 0);
			areaidParameter.Value = AreaId;
			phaseidParameter.Value = PhaseId;
			commentParameter.Value = Comment;
			cmd.Parameters.Add(areaidParameter);
			cmd.Parameters.Add(phaseidParameter);
			cmd.Parameters.Add(commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE phase_area SET AreaId = @newAreaId, PhaseId = @newPhaseId, Comment = @newComment WHERE AreaId = @AreaId AND PhaseId = @PhaseId AND Comment = @Comment;";
			MySqlParameter OLD_areaidParameter = new MySqlParameter("@AreaId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_phaseidParameter = new MySqlParameter("@PhaseId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_commentParameter = new MySqlParameter("@Comment", MySqlDbType.VarChar, 0);
			MySqlParameter areaidParameter = new MySqlParameter("@newAreaId", MySqlDbType.VarChar, 0);
			MySqlParameter phaseidParameter = new MySqlParameter("@newPhaseId", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@newComment", MySqlDbType.VarChar, 0);
			areaidParameter.Value = AreaId;
			phaseidParameter.Value = PhaseId;
			commentParameter.Value = Comment;
			OLD_areaidParameter.Value = OLD_AreaId;
			OLD_phaseidParameter.Value = OLD_PhaseId;
			OLD_commentParameter.Value = OLD_Comment;
			cmd.Parameters.Add(areaidParameter);
			cmd.Parameters.Add(phaseidParameter);
			cmd.Parameters.Add(commentParameter);
			cmd.Parameters.Add(OLD_areaidParameter);
			cmd.Parameters.Add(OLD_phaseidParameter);
			cmd.Parameters.Add(OLD_commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_AreaId = AreaId;
			OLD_PhaseId = PhaseId;
			OLD_Comment = Comment;
		}
	}
}
