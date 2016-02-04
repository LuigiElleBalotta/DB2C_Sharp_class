using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Command
	{
		string name = null; //Comment: 
		string OLD_name = null;

		int permission = 0; //Comment: 
		int OLD_permission = 0;

		string help = null; //Comment: 
		string OLD_help = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Command(string _name, int _permission, string _help)
		{
			name = _name;
			permission = _permission;
			help = _help;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM command WHERE name = @name AND permission = @permission AND help = @help;";
			MySqlParameter nameParameter = new MySqlParameter("@name", MySqlDbType.VarChar, 0);
			MySqlParameter permissionParameter = new MySqlParameter("@permission", MySqlDbType.VarChar, 0);
			MySqlParameter helpParameter = new MySqlParameter("@help", MySqlDbType.VarChar, 0);
			nameParameter.Value = name;
			permissionParameter.Value = permission;
			helpParameter.Value = help;
			cmd.Parameters.Add(nameParameter);
			cmd.Parameters.Add(permissionParameter);
			cmd.Parameters.Add(helpParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE command SET name = @newname, permission = @newpermission, help = @newhelp WHERE name = @name AND permission = @permission AND help = @help;";
			MySqlParameter OLD_nameParameter = new MySqlParameter("@name", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_permissionParameter = new MySqlParameter("@permission", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_helpParameter = new MySqlParameter("@help", MySqlDbType.VarChar, 0);
			MySqlParameter nameParameter = new MySqlParameter("@newname", MySqlDbType.VarChar, 0);
			MySqlParameter permissionParameter = new MySqlParameter("@newpermission", MySqlDbType.VarChar, 0);
			MySqlParameter helpParameter = new MySqlParameter("@newhelp", MySqlDbType.VarChar, 0);
			nameParameter.Value = name;
			permissionParameter.Value = permission;
			helpParameter.Value = help;
			OLD_nameParameter.Value = OLD_name;
			OLD_permissionParameter.Value = OLD_permission;
			OLD_helpParameter.Value = OLD_help;
			cmd.Parameters.Add(nameParameter);
			cmd.Parameters.Add(permissionParameter);
			cmd.Parameters.Add(helpParameter);
			cmd.Parameters.Add(OLD_nameParameter);
			cmd.Parameters.Add(OLD_permissionParameter);
			cmd.Parameters.Add(OLD_helpParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_name = name;
			OLD_permission = permission;
			OLD_help = help;
		}
	}
}
