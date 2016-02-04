using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Gameobject_template_locale
	{
		int entry = 0; //Comment: 
		int OLD_entry = 0;

		string locale = null; //Comment: 
		string OLD_locale = null;

		string name = null; //Comment: 
		string OLD_name = null;

		string castBarCaption = null; //Comment: 
		string OLD_castBarCaption = null;

		string unk1 = null; //Comment: 
		string OLD_unk1 = null;

		int VerifiedBuild = 0; //Comment: 
		int OLD_VerifiedBuild = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Gameobject_template_locale(int _entry, string _locale, string _name, string _castBarCaption, string _unk1, int _VerifiedBuild)
		{
			entry = _entry;
			locale = _locale;
			name = _name;
			castBarCaption = _castBarCaption;
			unk1 = _unk1;
			VerifiedBuild = _VerifiedBuild;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM gameobject_template_locale WHERE entry = @entry AND locale = @locale AND name = @name AND castBarCaption = @castBarCaption AND unk1 = @unk1 AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter localeParameter = new MySqlParameter("@locale", MySqlDbType.VarChar, 0);
			MySqlParameter nameParameter = new MySqlParameter("@name", MySqlDbType.VarChar, 0);
			MySqlParameter castbarcaptionParameter = new MySqlParameter("@castBarCaption", MySqlDbType.VarChar, 0);
			MySqlParameter unk1Parameter = new MySqlParameter("@unk1", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			localeParameter.Value = locale;
			nameParameter.Value = name;
			castbarcaptionParameter.Value = castBarCaption;
			unk1Parameter.Value = unk1;
			verifiedbuildParameter.Value = VerifiedBuild;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(localeParameter);
			cmd.Parameters.Add(nameParameter);
			cmd.Parameters.Add(castbarcaptionParameter);
			cmd.Parameters.Add(unk1Parameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE gameobject_template_locale SET entry = @newentry, locale = @newlocale, name = @newname, castBarCaption = @newcastBarCaption, unk1 = @newunk1, VerifiedBuild = @newVerifiedBuild WHERE entry = @entry AND locale = @locale AND name = @name AND castBarCaption = @castBarCaption AND unk1 = @unk1 AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter OLD_entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_localeParameter = new MySqlParameter("@locale", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_nameParameter = new MySqlParameter("@name", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_castbarcaptionParameter = new MySqlParameter("@castBarCaption", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_unk1Parameter = new MySqlParameter("@unk1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@newentry", MySqlDbType.VarChar, 0);
			MySqlParameter localeParameter = new MySqlParameter("@newlocale", MySqlDbType.VarChar, 0);
			MySqlParameter nameParameter = new MySqlParameter("@newname", MySqlDbType.VarChar, 0);
			MySqlParameter castbarcaptionParameter = new MySqlParameter("@newcastBarCaption", MySqlDbType.VarChar, 0);
			MySqlParameter unk1Parameter = new MySqlParameter("@newunk1", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@newVerifiedBuild", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			localeParameter.Value = locale;
			nameParameter.Value = name;
			castbarcaptionParameter.Value = castBarCaption;
			unk1Parameter.Value = unk1;
			verifiedbuildParameter.Value = VerifiedBuild;
			OLD_entryParameter.Value = OLD_entry;
			OLD_localeParameter.Value = OLD_locale;
			OLD_nameParameter.Value = OLD_name;
			OLD_castbarcaptionParameter.Value = OLD_castBarCaption;
			OLD_unk1Parameter.Value = OLD_unk1;
			OLD_verifiedbuildParameter.Value = OLD_VerifiedBuild;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(localeParameter);
			cmd.Parameters.Add(nameParameter);
			cmd.Parameters.Add(castbarcaptionParameter);
			cmd.Parameters.Add(unk1Parameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.Parameters.Add(OLD_entryParameter);
			cmd.Parameters.Add(OLD_localeParameter);
			cmd.Parameters.Add(OLD_nameParameter);
			cmd.Parameters.Add(OLD_castbarcaptionParameter);
			cmd.Parameters.Add(OLD_unk1Parameter);
			cmd.Parameters.Add(OLD_verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_entry = entry;
			OLD_locale = locale;
			OLD_name = name;
			OLD_castBarCaption = castBarCaption;
			OLD_unk1 = unk1;
			OLD_VerifiedBuild = VerifiedBuild;
		}
	}
}
