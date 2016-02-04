using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Page_text
	{
		int ID = 0; //Comment: 
		int OLD_ID = 0;

		string Text = null; //Comment: 
		string OLD_Text = null;

		int NextPageID = 0; //Comment: 
		int OLD_NextPageID = 0;

		int VerifiedBuild = 0; //Comment: 
		int OLD_VerifiedBuild = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Page_text(int _ID, string _Text, int _NextPageID, int _VerifiedBuild)
		{
			ID = _ID;
			Text = _Text;
			NextPageID = _NextPageID;
			VerifiedBuild = _VerifiedBuild;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM page_text WHERE ID = @ID AND Text = @Text AND NextPageID = @NextPageID AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter textParameter = new MySqlParameter("@Text", MySqlDbType.VarChar, 0);
			MySqlParameter nextpageidParameter = new MySqlParameter("@NextPageID", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			textParameter.Value = Text;
			nextpageidParameter.Value = NextPageID;
			verifiedbuildParameter.Value = VerifiedBuild;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(textParameter);
			cmd.Parameters.Add(nextpageidParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE page_text SET ID = @newID, Text = @newText, NextPageID = @newNextPageID, VerifiedBuild = @newVerifiedBuild WHERE ID = @ID AND Text = @Text AND NextPageID = @NextPageID AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_textParameter = new MySqlParameter("@Text", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_nextpageidParameter = new MySqlParameter("@NextPageID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newID", MySqlDbType.VarChar, 0);
			MySqlParameter textParameter = new MySqlParameter("@newText", MySqlDbType.VarChar, 0);
			MySqlParameter nextpageidParameter = new MySqlParameter("@newNextPageID", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@newVerifiedBuild", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			textParameter.Value = Text;
			nextpageidParameter.Value = NextPageID;
			verifiedbuildParameter.Value = VerifiedBuild;
			OLD_idParameter.Value = OLD_ID;
			OLD_textParameter.Value = OLD_Text;
			OLD_nextpageidParameter.Value = OLD_NextPageID;
			OLD_verifiedbuildParameter.Value = OLD_VerifiedBuild;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(textParameter);
			cmd.Parameters.Add(nextpageidParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_textParameter);
			cmd.Parameters.Add(OLD_nextpageidParameter);
			cmd.Parameters.Add(OLD_verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_ID = ID;
			OLD_Text = Text;
			OLD_NextPageID = NextPageID;
			OLD_VerifiedBuild = VerifiedBuild;
		}
	}
}
