using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Page_text_locale
	{
		int ID = 0; //Comment: 
		int OLD_ID = 0;

		string locale = null; //Comment: 
		string OLD_locale = null;

		string Text = null; //Comment: 
		string OLD_Text = null;

		int VerifiedBuild = 0; //Comment: 
		int OLD_VerifiedBuild = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Page_text_locale(int _ID, string _locale, string _Text, int _VerifiedBuild)
		{
			ID = _ID;
			locale = _locale;
			Text = _Text;
			VerifiedBuild = _VerifiedBuild;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM page_text_locale WHERE ID = @ID AND locale = @locale AND Text = @Text AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter localeParameter = new MySqlParameter("@locale", MySqlDbType.VarChar, 0);
			MySqlParameter textParameter = new MySqlParameter("@Text", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			localeParameter.Value = locale;
			textParameter.Value = Text;
			verifiedbuildParameter.Value = VerifiedBuild;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(localeParameter);
			cmd.Parameters.Add(textParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE page_text_locale SET ID = @newID, locale = @newlocale, Text = @newText, VerifiedBuild = @newVerifiedBuild WHERE ID = @ID AND locale = @locale AND Text = @Text AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_localeParameter = new MySqlParameter("@locale", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_textParameter = new MySqlParameter("@Text", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newID", MySqlDbType.VarChar, 0);
			MySqlParameter localeParameter = new MySqlParameter("@newlocale", MySqlDbType.VarChar, 0);
			MySqlParameter textParameter = new MySqlParameter("@newText", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@newVerifiedBuild", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			localeParameter.Value = locale;
			textParameter.Value = Text;
			verifiedbuildParameter.Value = VerifiedBuild;
			OLD_idParameter.Value = OLD_ID;
			OLD_localeParameter.Value = OLD_locale;
			OLD_textParameter.Value = OLD_Text;
			OLD_verifiedbuildParameter.Value = OLD_VerifiedBuild;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(localeParameter);
			cmd.Parameters.Add(textParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_localeParameter);
			cmd.Parameters.Add(OLD_textParameter);
			cmd.Parameters.Add(OLD_verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_ID = ID;
			OLD_locale = locale;
			OLD_Text = Text;
			OLD_VerifiedBuild = VerifiedBuild;
		}
	}
}
