using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Playercreateinfo_action
	{
		int race = 0; //Comment: 
		int OLD_race = 0;

		int class_var = 0; //Comment: 
		int OLD_class_var = 0;

		int button = 0; //Comment: 
		int OLD_button = 0;

		int action = 0; //Comment: 
		int OLD_action = 0;

		int type = 0; //Comment: 
		int OLD_type = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Playercreateinfo_action(int _race, int _class_var, int _button, int _action, int _type)
		{
			race = _race;
			class_var = _class_var;
			button = _button;
			action = _action;
			type = _type;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM playercreateinfo_action WHERE race = @race AND class_var = @class_var AND button = @button AND action = @action AND type = @type;";
			MySqlParameter raceParameter = new MySqlParameter("@race", MySqlDbType.VarChar, 0);
			MySqlParameter class_varParameter = new MySqlParameter("@class_var", MySqlDbType.VarChar, 0);
			MySqlParameter buttonParameter = new MySqlParameter("@button", MySqlDbType.VarChar, 0);
			MySqlParameter actionParameter = new MySqlParameter("@action", MySqlDbType.VarChar, 0);
			MySqlParameter typeParameter = new MySqlParameter("@type", MySqlDbType.VarChar, 0);
			raceParameter.Value = race;
			class_varParameter.Value = class_var;
			buttonParameter.Value = button;
			actionParameter.Value = action;
			typeParameter.Value = type;
			cmd.Parameters.Add(raceParameter);
			cmd.Parameters.Add(class_varParameter);
			cmd.Parameters.Add(buttonParameter);
			cmd.Parameters.Add(actionParameter);
			cmd.Parameters.Add(typeParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE playercreateinfo_action SET race = @newrace, class_var = @newclass_var, button = @newbutton, action = @newaction, type = @newtype WHERE race = @race AND class_var = @class_var AND button = @button AND action = @action AND type = @type;";
			MySqlParameter OLD_raceParameter = new MySqlParameter("@race", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_class_varParameter = new MySqlParameter("@class_var", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_buttonParameter = new MySqlParameter("@button", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_actionParameter = new MySqlParameter("@action", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_typeParameter = new MySqlParameter("@type", MySqlDbType.VarChar, 0);
			MySqlParameter raceParameter = new MySqlParameter("@newrace", MySqlDbType.VarChar, 0);
			MySqlParameter class_varParameter = new MySqlParameter("@newclass_var", MySqlDbType.VarChar, 0);
			MySqlParameter buttonParameter = new MySqlParameter("@newbutton", MySqlDbType.VarChar, 0);
			MySqlParameter actionParameter = new MySqlParameter("@newaction", MySqlDbType.VarChar, 0);
			MySqlParameter typeParameter = new MySqlParameter("@newtype", MySqlDbType.VarChar, 0);
			raceParameter.Value = race;
			class_varParameter.Value = class_var;
			buttonParameter.Value = button;
			actionParameter.Value = action;
			typeParameter.Value = type;
			OLD_raceParameter.Value = OLD_race;
			OLD_class_varParameter.Value = OLD_class_var;
			OLD_buttonParameter.Value = OLD_button;
			OLD_actionParameter.Value = OLD_action;
			OLD_typeParameter.Value = OLD_type;
			cmd.Parameters.Add(raceParameter);
			cmd.Parameters.Add(class_varParameter);
			cmd.Parameters.Add(buttonParameter);
			cmd.Parameters.Add(actionParameter);
			cmd.Parameters.Add(typeParameter);
			cmd.Parameters.Add(OLD_raceParameter);
			cmd.Parameters.Add(OLD_class_varParameter);
			cmd.Parameters.Add(OLD_buttonParameter);
			cmd.Parameters.Add(OLD_actionParameter);
			cmd.Parameters.Add(OLD_typeParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_race = race;
			OLD_class_var = class_var;
			OLD_button = button;
			OLD_action = action;
			OLD_type = type;
		}
	}
}
