using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Disables
	{
		int sourceType = 0; //Comment: 
		int OLD_sourceType = 0;

		int entry = 0; //Comment: 
		int OLD_entry = 0;

		int flags = 0; //Comment: 
		int OLD_flags = 0;

		string params_0 = null; //Comment: 
		string OLD_params_0 = null;

		string params_1 = null; //Comment: 
		string OLD_params_1 = null;

		string comment = null; //Comment: 
		string OLD_comment = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Disables(int _sourceType, int _entry, int _flags, string _params_0, string _params_1, string _comment)
		{
			sourceType = _sourceType;
			entry = _entry;
			flags = _flags;
			params_0 = _params_0;
			params_1 = _params_1;
			comment = _comment;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM disables WHERE sourceType = @sourceType AND entry = @entry AND flags = @flags AND params_0 = @params_0 AND params_1 = @params_1 AND comment = @comment;";
			MySqlParameter sourcetypeParameter = new MySqlParameter("@sourceType", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter flagsParameter = new MySqlParameter("@flags", MySqlDbType.VarChar, 0);
			MySqlParameter params_0Parameter = new MySqlParameter("@params_0", MySqlDbType.VarChar, 0);
			MySqlParameter params_1Parameter = new MySqlParameter("@params_1", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@comment", MySqlDbType.VarChar, 0);
			sourcetypeParameter.Value = sourceType;
			entryParameter.Value = entry;
			flagsParameter.Value = flags;
			params_0Parameter.Value = params_0;
			params_1Parameter.Value = params_1;
			commentParameter.Value = comment;
			cmd.Parameters.Add(sourcetypeParameter);
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(flagsParameter);
			cmd.Parameters.Add(params_0Parameter);
			cmd.Parameters.Add(params_1Parameter);
			cmd.Parameters.Add(commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE disables SET sourceType = @newsourceType, entry = @newentry, flags = @newflags, params_0 = @newparams_0, params_1 = @newparams_1, comment = @newcomment WHERE sourceType = @sourceType AND entry = @entry AND flags = @flags AND params_0 = @params_0 AND params_1 = @params_1 AND comment = @comment;";
			MySqlParameter OLD_sourcetypeParameter = new MySqlParameter("@sourceType", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_flagsParameter = new MySqlParameter("@flags", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_params_0Parameter = new MySqlParameter("@params_0", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_params_1Parameter = new MySqlParameter("@params_1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_commentParameter = new MySqlParameter("@comment", MySqlDbType.VarChar, 0);
			MySqlParameter sourcetypeParameter = new MySqlParameter("@newsourceType", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@newentry", MySqlDbType.VarChar, 0);
			MySqlParameter flagsParameter = new MySqlParameter("@newflags", MySqlDbType.VarChar, 0);
			MySqlParameter params_0Parameter = new MySqlParameter("@newparams_0", MySqlDbType.VarChar, 0);
			MySqlParameter params_1Parameter = new MySqlParameter("@newparams_1", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@newcomment", MySqlDbType.VarChar, 0);
			sourcetypeParameter.Value = sourceType;
			entryParameter.Value = entry;
			flagsParameter.Value = flags;
			params_0Parameter.Value = params_0;
			params_1Parameter.Value = params_1;
			commentParameter.Value = comment;
			OLD_sourcetypeParameter.Value = OLD_sourceType;
			OLD_entryParameter.Value = OLD_entry;
			OLD_flagsParameter.Value = OLD_flags;
			OLD_params_0Parameter.Value = OLD_params_0;
			OLD_params_1Parameter.Value = OLD_params_1;
			OLD_commentParameter.Value = OLD_comment;
			cmd.Parameters.Add(sourcetypeParameter);
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(flagsParameter);
			cmd.Parameters.Add(params_0Parameter);
			cmd.Parameters.Add(params_1Parameter);
			cmd.Parameters.Add(commentParameter);
			cmd.Parameters.Add(OLD_sourcetypeParameter);
			cmd.Parameters.Add(OLD_entryParameter);
			cmd.Parameters.Add(OLD_flagsParameter);
			cmd.Parameters.Add(OLD_params_0Parameter);
			cmd.Parameters.Add(OLD_params_1Parameter);
			cmd.Parameters.Add(OLD_commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_sourceType = sourceType;
			OLD_entry = entry;
			OLD_flags = flags;
			OLD_params_0 = params_0;
			OLD_params_1 = params_1;
			OLD_comment = comment;
		}
	}
}
