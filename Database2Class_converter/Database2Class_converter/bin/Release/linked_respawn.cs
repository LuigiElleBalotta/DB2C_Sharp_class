using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Linked_respawn
	{
		int guid = 0; //Comment: 
		int OLD_guid = 0;

		int linkedGuid = 0; //Comment: 
		int OLD_linkedGuid = 0;

		int linkType = 0; //Comment: 
		int OLD_linkType = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Linked_respawn(int _guid, int _linkedGuid, int _linkType)
		{
			guid = _guid;
			linkedGuid = _linkedGuid;
			linkType = _linkType;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM linked_respawn WHERE guid = @guid AND linkedGuid = @linkedGuid AND linkType = @linkType;";
			MySqlParameter guidParameter = new MySqlParameter("@guid", MySqlDbType.VarChar, 0);
			MySqlParameter linkedguidParameter = new MySqlParameter("@linkedGuid", MySqlDbType.VarChar, 0);
			MySqlParameter linktypeParameter = new MySqlParameter("@linkType", MySqlDbType.VarChar, 0);
			guidParameter.Value = guid;
			linkedguidParameter.Value = linkedGuid;
			linktypeParameter.Value = linkType;
			cmd.Parameters.Add(guidParameter);
			cmd.Parameters.Add(linkedguidParameter);
			cmd.Parameters.Add(linktypeParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE linked_respawn SET guid = @newguid, linkedGuid = @newlinkedGuid, linkType = @newlinkType WHERE guid = @guid AND linkedGuid = @linkedGuid AND linkType = @linkType;";
			MySqlParameter OLD_guidParameter = new MySqlParameter("@guid", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_linkedguidParameter = new MySqlParameter("@linkedGuid", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_linktypeParameter = new MySqlParameter("@linkType", MySqlDbType.VarChar, 0);
			MySqlParameter guidParameter = new MySqlParameter("@newguid", MySqlDbType.VarChar, 0);
			MySqlParameter linkedguidParameter = new MySqlParameter("@newlinkedGuid", MySqlDbType.VarChar, 0);
			MySqlParameter linktypeParameter = new MySqlParameter("@newlinkType", MySqlDbType.VarChar, 0);
			guidParameter.Value = guid;
			linkedguidParameter.Value = linkedGuid;
			linktypeParameter.Value = linkType;
			OLD_guidParameter.Value = OLD_guid;
			OLD_linkedguidParameter.Value = OLD_linkedGuid;
			OLD_linktypeParameter.Value = OLD_linkType;
			cmd.Parameters.Add(guidParameter);
			cmd.Parameters.Add(linkedguidParameter);
			cmd.Parameters.Add(linktypeParameter);
			cmd.Parameters.Add(OLD_guidParameter);
			cmd.Parameters.Add(OLD_linkedguidParameter);
			cmd.Parameters.Add(OLD_linktypeParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_guid = guid;
			OLD_linkedGuid = linkedGuid;
			OLD_linkType = linkType;
		}
	}
}
