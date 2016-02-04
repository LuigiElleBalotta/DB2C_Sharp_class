using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Points_of_interest_locale
	{
		int ID = 0; //Comment: 
		int OLD_ID = 0;

		string locale = null; //Comment: 
		string OLD_locale = null;

		string Name = null; //Comment: 
		string OLD_Name = null;

		int VerifiedBuild = 0; //Comment: 
		int OLD_VerifiedBuild = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Points_of_interest_locale(int _ID, string _locale, string _Name, int _VerifiedBuild)
		{
			ID = _ID;
			locale = _locale;
			Name = _Name;
			VerifiedBuild = _VerifiedBuild;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM points_of_interest_locale WHERE ID = @ID AND locale = @locale AND Name = @Name AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter localeParameter = new MySqlParameter("@locale", MySqlDbType.VarChar, 0);
			MySqlParameter nameParameter = new MySqlParameter("@Name", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			localeParameter.Value = locale;
			nameParameter.Value = Name;
			verifiedbuildParameter.Value = VerifiedBuild;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(localeParameter);
			cmd.Parameters.Add(nameParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE points_of_interest_locale SET ID = @newID, locale = @newlocale, Name = @newName, VerifiedBuild = @newVerifiedBuild WHERE ID = @ID AND locale = @locale AND Name = @Name AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_localeParameter = new MySqlParameter("@locale", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_nameParameter = new MySqlParameter("@Name", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newID", MySqlDbType.VarChar, 0);
			MySqlParameter localeParameter = new MySqlParameter("@newlocale", MySqlDbType.VarChar, 0);
			MySqlParameter nameParameter = new MySqlParameter("@newName", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@newVerifiedBuild", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			localeParameter.Value = locale;
			nameParameter.Value = Name;
			verifiedbuildParameter.Value = VerifiedBuild;
			OLD_idParameter.Value = OLD_ID;
			OLD_localeParameter.Value = OLD_locale;
			OLD_nameParameter.Value = OLD_Name;
			OLD_verifiedbuildParameter.Value = OLD_VerifiedBuild;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(localeParameter);
			cmd.Parameters.Add(nameParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_localeParameter);
			cmd.Parameters.Add(OLD_nameParameter);
			cmd.Parameters.Add(OLD_verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_ID = ID;
			OLD_locale = locale;
			OLD_Name = Name;
			OLD_VerifiedBuild = VerifiedBuild;
		}
	}
}
