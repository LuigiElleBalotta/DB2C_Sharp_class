using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Version
	{
		string core_version = null; //Comment: Core revision dumped at startup.
		string OLD_core_version = null;

		string core_revision = null; //Comment: 
		string OLD_core_revision = null;

		string db_version = null; //Comment: Version of world DB.
		string OLD_db_version = null;

		int cache_id = 0; //Comment: 
		int OLD_cache_id = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Version(string _core_version, string _core_revision, string _db_version, int _cache_id)
		{
			core_version = _core_version;
			core_revision = _core_revision;
			db_version = _db_version;
			cache_id = _cache_id;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM version WHERE core_version = @core_version AND core_revision = @core_revision AND db_version = @db_version AND cache_id = @cache_id;";
			MySqlParameter core_versionParameter = new MySqlParameter("@core_version", MySqlDbType.VarChar, 0);
			MySqlParameter core_revisionParameter = new MySqlParameter("@core_revision", MySqlDbType.VarChar, 0);
			MySqlParameter db_versionParameter = new MySqlParameter("@db_version", MySqlDbType.VarChar, 0);
			MySqlParameter cache_idParameter = new MySqlParameter("@cache_id", MySqlDbType.VarChar, 0);
			core_versionParameter.Value = core_version;
			core_revisionParameter.Value = core_revision;
			db_versionParameter.Value = db_version;
			cache_idParameter.Value = cache_id;
			cmd.Parameters.Add(core_versionParameter);
			cmd.Parameters.Add(core_revisionParameter);
			cmd.Parameters.Add(db_versionParameter);
			cmd.Parameters.Add(cache_idParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE version SET core_version = @newcore_version, core_revision = @newcore_revision, db_version = @newdb_version, cache_id = @newcache_id WHERE core_version = @core_version AND core_revision = @core_revision AND db_version = @db_version AND cache_id = @cache_id;";
			MySqlParameter OLD_core_versionParameter = new MySqlParameter("@core_version", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_core_revisionParameter = new MySqlParameter("@core_revision", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_db_versionParameter = new MySqlParameter("@db_version", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_cache_idParameter = new MySqlParameter("@cache_id", MySqlDbType.VarChar, 0);
			MySqlParameter core_versionParameter = new MySqlParameter("@newcore_version", MySqlDbType.VarChar, 0);
			MySqlParameter core_revisionParameter = new MySqlParameter("@newcore_revision", MySqlDbType.VarChar, 0);
			MySqlParameter db_versionParameter = new MySqlParameter("@newdb_version", MySqlDbType.VarChar, 0);
			MySqlParameter cache_idParameter = new MySqlParameter("@newcache_id", MySqlDbType.VarChar, 0);
			core_versionParameter.Value = core_version;
			core_revisionParameter.Value = core_revision;
			db_versionParameter.Value = db_version;
			cache_idParameter.Value = cache_id;
			OLD_core_versionParameter.Value = OLD_core_version;
			OLD_core_revisionParameter.Value = OLD_core_revision;
			OLD_db_versionParameter.Value = OLD_db_version;
			OLD_cache_idParameter.Value = OLD_cache_id;
			cmd.Parameters.Add(core_versionParameter);
			cmd.Parameters.Add(core_revisionParameter);
			cmd.Parameters.Add(db_versionParameter);
			cmd.Parameters.Add(cache_idParameter);
			cmd.Parameters.Add(OLD_core_versionParameter);
			cmd.Parameters.Add(OLD_core_revisionParameter);
			cmd.Parameters.Add(OLD_db_versionParameter);
			cmd.Parameters.Add(OLD_cache_idParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_core_version = core_version;
			OLD_core_revision = core_revision;
			OLD_db_version = db_version;
			OLD_cache_id = cache_id;
		}
	}
}
