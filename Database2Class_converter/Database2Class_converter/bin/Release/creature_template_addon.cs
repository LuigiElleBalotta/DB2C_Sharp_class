using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Creature_template_addon
	{
		int entry = 0; //Comment: 
		int OLD_entry = 0;

		int path_id = 0; //Comment: 
		int OLD_path_id = 0;

		int mount = 0; //Comment: 
		int OLD_mount = 0;

		int bytes1 = 0; //Comment: 
		int OLD_bytes1 = 0;

		int bytes2 = 0; //Comment: 
		int OLD_bytes2 = 0;

		int emote = 0; //Comment: 
		int OLD_emote = 0;

		string auras = null; //Comment: 
		string OLD_auras = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Creature_template_addon(int _entry, int _path_id, int _mount, int _bytes1, int _bytes2, int _emote, string _auras)
		{
			entry = _entry;
			path_id = _path_id;
			mount = _mount;
			bytes1 = _bytes1;
			bytes2 = _bytes2;
			emote = _emote;
			auras = _auras;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM creature_template_addon WHERE entry = @entry AND path_id = @path_id AND mount = @mount AND bytes1 = @bytes1 AND bytes2 = @bytes2 AND emote = @emote AND auras = @auras;";
			MySqlParameter entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter path_idParameter = new MySqlParameter("@path_id", MySqlDbType.VarChar, 0);
			MySqlParameter mountParameter = new MySqlParameter("@mount", MySqlDbType.VarChar, 0);
			MySqlParameter bytes1Parameter = new MySqlParameter("@bytes1", MySqlDbType.VarChar, 0);
			MySqlParameter bytes2Parameter = new MySqlParameter("@bytes2", MySqlDbType.VarChar, 0);
			MySqlParameter emoteParameter = new MySqlParameter("@emote", MySqlDbType.VarChar, 0);
			MySqlParameter aurasParameter = new MySqlParameter("@auras", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			path_idParameter.Value = path_id;
			mountParameter.Value = mount;
			bytes1Parameter.Value = bytes1;
			bytes2Parameter.Value = bytes2;
			emoteParameter.Value = emote;
			aurasParameter.Value = auras;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(path_idParameter);
			cmd.Parameters.Add(mountParameter);
			cmd.Parameters.Add(bytes1Parameter);
			cmd.Parameters.Add(bytes2Parameter);
			cmd.Parameters.Add(emoteParameter);
			cmd.Parameters.Add(aurasParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE creature_template_addon SET entry = @newentry, path_id = @newpath_id, mount = @newmount, bytes1 = @newbytes1, bytes2 = @newbytes2, emote = @newemote, auras = @newauras WHERE entry = @entry AND path_id = @path_id AND mount = @mount AND bytes1 = @bytes1 AND bytes2 = @bytes2 AND emote = @emote AND auras = @auras;";
			MySqlParameter OLD_entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_path_idParameter = new MySqlParameter("@path_id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_mountParameter = new MySqlParameter("@mount", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_bytes1Parameter = new MySqlParameter("@bytes1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_bytes2Parameter = new MySqlParameter("@bytes2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_emoteParameter = new MySqlParameter("@emote", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_aurasParameter = new MySqlParameter("@auras", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@newentry", MySqlDbType.VarChar, 0);
			MySqlParameter path_idParameter = new MySqlParameter("@newpath_id", MySqlDbType.VarChar, 0);
			MySqlParameter mountParameter = new MySqlParameter("@newmount", MySqlDbType.VarChar, 0);
			MySqlParameter bytes1Parameter = new MySqlParameter("@newbytes1", MySqlDbType.VarChar, 0);
			MySqlParameter bytes2Parameter = new MySqlParameter("@newbytes2", MySqlDbType.VarChar, 0);
			MySqlParameter emoteParameter = new MySqlParameter("@newemote", MySqlDbType.VarChar, 0);
			MySqlParameter aurasParameter = new MySqlParameter("@newauras", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			path_idParameter.Value = path_id;
			mountParameter.Value = mount;
			bytes1Parameter.Value = bytes1;
			bytes2Parameter.Value = bytes2;
			emoteParameter.Value = emote;
			aurasParameter.Value = auras;
			OLD_entryParameter.Value = OLD_entry;
			OLD_path_idParameter.Value = OLD_path_id;
			OLD_mountParameter.Value = OLD_mount;
			OLD_bytes1Parameter.Value = OLD_bytes1;
			OLD_bytes2Parameter.Value = OLD_bytes2;
			OLD_emoteParameter.Value = OLD_emote;
			OLD_aurasParameter.Value = OLD_auras;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(path_idParameter);
			cmd.Parameters.Add(mountParameter);
			cmd.Parameters.Add(bytes1Parameter);
			cmd.Parameters.Add(bytes2Parameter);
			cmd.Parameters.Add(emoteParameter);
			cmd.Parameters.Add(aurasParameter);
			cmd.Parameters.Add(OLD_entryParameter);
			cmd.Parameters.Add(OLD_path_idParameter);
			cmd.Parameters.Add(OLD_mountParameter);
			cmd.Parameters.Add(OLD_bytes1Parameter);
			cmd.Parameters.Add(OLD_bytes2Parameter);
			cmd.Parameters.Add(OLD_emoteParameter);
			cmd.Parameters.Add(OLD_aurasParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_entry = entry;
			OLD_path_id = path_id;
			OLD_mount = mount;
			OLD_bytes1 = bytes1;
			OLD_bytes2 = bytes2;
			OLD_emote = emote;
			OLD_auras = auras;
		}
	}
}
