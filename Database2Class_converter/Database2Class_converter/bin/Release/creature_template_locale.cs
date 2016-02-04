using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Creature_template_locale
	{
		int entry = 0; //Comment: 
		int OLD_entry = 0;

		string locale = null; //Comment: 
		string OLD_locale = null;

		string Name = null; //Comment: 
		string OLD_Name = null;

		string NameAlt = null; //Comment: 
		string OLD_NameAlt = null;

		string Title = null; //Comment: 
		string OLD_Title = null;

		string TitleAlt = null; //Comment: 
		string OLD_TitleAlt = null;

		int VerifiedBuild = 0; //Comment: 
		int OLD_VerifiedBuild = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Creature_template_locale(int _entry, string _locale, string _Name, string _NameAlt, string _Title, string _TitleAlt, int _VerifiedBuild)
		{
			entry = _entry;
			locale = _locale;
			Name = _Name;
			NameAlt = _NameAlt;
			Title = _Title;
			TitleAlt = _TitleAlt;
			VerifiedBuild = _VerifiedBuild;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM creature_template_locale WHERE entry = @entry AND locale = @locale AND Name = @Name AND NameAlt = @NameAlt AND Title = @Title AND TitleAlt = @TitleAlt AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter localeParameter = new MySqlParameter("@locale", MySqlDbType.VarChar, 0);
			MySqlParameter nameParameter = new MySqlParameter("@Name", MySqlDbType.VarChar, 0);
			MySqlParameter namealtParameter = new MySqlParameter("@NameAlt", MySqlDbType.VarChar, 0);
			MySqlParameter titleParameter = new MySqlParameter("@Title", MySqlDbType.VarChar, 0);
			MySqlParameter titlealtParameter = new MySqlParameter("@TitleAlt", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			localeParameter.Value = locale;
			nameParameter.Value = Name;
			namealtParameter.Value = NameAlt;
			titleParameter.Value = Title;
			titlealtParameter.Value = TitleAlt;
			verifiedbuildParameter.Value = VerifiedBuild;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(localeParameter);
			cmd.Parameters.Add(nameParameter);
			cmd.Parameters.Add(namealtParameter);
			cmd.Parameters.Add(titleParameter);
			cmd.Parameters.Add(titlealtParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE creature_template_locale SET entry = @newentry, locale = @newlocale, Name = @newName, NameAlt = @newNameAlt, Title = @newTitle, TitleAlt = @newTitleAlt, VerifiedBuild = @newVerifiedBuild WHERE entry = @entry AND locale = @locale AND Name = @Name AND NameAlt = @NameAlt AND Title = @Title AND TitleAlt = @TitleAlt AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter OLD_entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_localeParameter = new MySqlParameter("@locale", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_nameParameter = new MySqlParameter("@Name", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_namealtParameter = new MySqlParameter("@NameAlt", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_titleParameter = new MySqlParameter("@Title", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_titlealtParameter = new MySqlParameter("@TitleAlt", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@newentry", MySqlDbType.VarChar, 0);
			MySqlParameter localeParameter = new MySqlParameter("@newlocale", MySqlDbType.VarChar, 0);
			MySqlParameter nameParameter = new MySqlParameter("@newName", MySqlDbType.VarChar, 0);
			MySqlParameter namealtParameter = new MySqlParameter("@newNameAlt", MySqlDbType.VarChar, 0);
			MySqlParameter titleParameter = new MySqlParameter("@newTitle", MySqlDbType.VarChar, 0);
			MySqlParameter titlealtParameter = new MySqlParameter("@newTitleAlt", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@newVerifiedBuild", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			localeParameter.Value = locale;
			nameParameter.Value = Name;
			namealtParameter.Value = NameAlt;
			titleParameter.Value = Title;
			titlealtParameter.Value = TitleAlt;
			verifiedbuildParameter.Value = VerifiedBuild;
			OLD_entryParameter.Value = OLD_entry;
			OLD_localeParameter.Value = OLD_locale;
			OLD_nameParameter.Value = OLD_Name;
			OLD_namealtParameter.Value = OLD_NameAlt;
			OLD_titleParameter.Value = OLD_Title;
			OLD_titlealtParameter.Value = OLD_TitleAlt;
			OLD_verifiedbuildParameter.Value = OLD_VerifiedBuild;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(localeParameter);
			cmd.Parameters.Add(nameParameter);
			cmd.Parameters.Add(namealtParameter);
			cmd.Parameters.Add(titleParameter);
			cmd.Parameters.Add(titlealtParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.Parameters.Add(OLD_entryParameter);
			cmd.Parameters.Add(OLD_localeParameter);
			cmd.Parameters.Add(OLD_nameParameter);
			cmd.Parameters.Add(OLD_namealtParameter);
			cmd.Parameters.Add(OLD_titleParameter);
			cmd.Parameters.Add(OLD_titlealtParameter);
			cmd.Parameters.Add(OLD_verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_entry = entry;
			OLD_locale = locale;
			OLD_Name = Name;
			OLD_NameAlt = NameAlt;
			OLD_Title = Title;
			OLD_TitleAlt = TitleAlt;
			OLD_VerifiedBuild = VerifiedBuild;
		}
	}
}
