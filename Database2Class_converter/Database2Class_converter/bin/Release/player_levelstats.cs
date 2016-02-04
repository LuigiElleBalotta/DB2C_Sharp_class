using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Player_levelstats
	{
		int race = 0; //Comment: 
		int OLD_race = 0;

		int class_var = 0; //Comment: 
		int OLD_class_var = 0;

		int level = 0; //Comment: 
		int OLD_level = 0;

		int str = 0; //Comment: strength
		int OLD_str = 0;

		int agi = 0; //Comment: agility
		int OLD_agi = 0;

		int sta = 0; //Comment: stamina
		int OLD_sta = 0;

		int inte = 0; //Comment: intellect
		int OLD_inte = 0;

		int spi = 0; //Comment: spirit
		int OLD_spi = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Player_levelstats(int _race, int _class_var, int _level, int _str, int _agi, int _sta, int _inte, int _spi)
		{
			race = _race;
			class_var = _class_var;
			level = _level;
			str = _str;
			agi = _agi;
			sta = _sta;
			inte = _inte;
			spi = _spi;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM player_levelstats WHERE race = @race AND class_var = @class_var AND level = @level AND str = @str AND agi = @agi AND sta = @sta AND inte = @inte AND spi = @spi;";
			MySqlParameter raceParameter = new MySqlParameter("@race", MySqlDbType.VarChar, 0);
			MySqlParameter class_varParameter = new MySqlParameter("@class_var", MySqlDbType.VarChar, 0);
			MySqlParameter levelParameter = new MySqlParameter("@level", MySqlDbType.VarChar, 0);
			MySqlParameter strParameter = new MySqlParameter("@str", MySqlDbType.VarChar, 0);
			MySqlParameter agiParameter = new MySqlParameter("@agi", MySqlDbType.VarChar, 0);
			MySqlParameter staParameter = new MySqlParameter("@sta", MySqlDbType.VarChar, 0);
			MySqlParameter inteParameter = new MySqlParameter("@inte", MySqlDbType.VarChar, 0);
			MySqlParameter spiParameter = new MySqlParameter("@spi", MySqlDbType.VarChar, 0);
			raceParameter.Value = race;
			class_varParameter.Value = class_var;
			levelParameter.Value = level;
			strParameter.Value = str;
			agiParameter.Value = agi;
			staParameter.Value = sta;
			inteParameter.Value = inte;
			spiParameter.Value = spi;
			cmd.Parameters.Add(raceParameter);
			cmd.Parameters.Add(class_varParameter);
			cmd.Parameters.Add(levelParameter);
			cmd.Parameters.Add(strParameter);
			cmd.Parameters.Add(agiParameter);
			cmd.Parameters.Add(staParameter);
			cmd.Parameters.Add(inteParameter);
			cmd.Parameters.Add(spiParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE player_levelstats SET race = @newrace, class_var = @newclass_var, level = @newlevel, str = @newstr, agi = @newagi, sta = @newsta, inte = @newinte, spi = @newspi WHERE race = @race AND class_var = @class_var AND level = @level AND str = @str AND agi = @agi AND sta = @sta AND inte = @inte AND spi = @spi;";
			MySqlParameter OLD_raceParameter = new MySqlParameter("@race", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_class_varParameter = new MySqlParameter("@class_var", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_levelParameter = new MySqlParameter("@level", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_strParameter = new MySqlParameter("@str", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_agiParameter = new MySqlParameter("@agi", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_staParameter = new MySqlParameter("@sta", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_inteParameter = new MySqlParameter("@inte", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spiParameter = new MySqlParameter("@spi", MySqlDbType.VarChar, 0);
			MySqlParameter raceParameter = new MySqlParameter("@newrace", MySqlDbType.VarChar, 0);
			MySqlParameter class_varParameter = new MySqlParameter("@newclass_var", MySqlDbType.VarChar, 0);
			MySqlParameter levelParameter = new MySqlParameter("@newlevel", MySqlDbType.VarChar, 0);
			MySqlParameter strParameter = new MySqlParameter("@newstr", MySqlDbType.VarChar, 0);
			MySqlParameter agiParameter = new MySqlParameter("@newagi", MySqlDbType.VarChar, 0);
			MySqlParameter staParameter = new MySqlParameter("@newsta", MySqlDbType.VarChar, 0);
			MySqlParameter inteParameter = new MySqlParameter("@newinte", MySqlDbType.VarChar, 0);
			MySqlParameter spiParameter = new MySqlParameter("@newspi", MySqlDbType.VarChar, 0);
			raceParameter.Value = race;
			class_varParameter.Value = class_var;
			levelParameter.Value = level;
			strParameter.Value = str;
			agiParameter.Value = agi;
			staParameter.Value = sta;
			inteParameter.Value = inte;
			spiParameter.Value = spi;
			OLD_raceParameter.Value = OLD_race;
			OLD_class_varParameter.Value = OLD_class_var;
			OLD_levelParameter.Value = OLD_level;
			OLD_strParameter.Value = OLD_str;
			OLD_agiParameter.Value = OLD_agi;
			OLD_staParameter.Value = OLD_sta;
			OLD_inteParameter.Value = OLD_inte;
			OLD_spiParameter.Value = OLD_spi;
			cmd.Parameters.Add(raceParameter);
			cmd.Parameters.Add(class_varParameter);
			cmd.Parameters.Add(levelParameter);
			cmd.Parameters.Add(strParameter);
			cmd.Parameters.Add(agiParameter);
			cmd.Parameters.Add(staParameter);
			cmd.Parameters.Add(inteParameter);
			cmd.Parameters.Add(spiParameter);
			cmd.Parameters.Add(OLD_raceParameter);
			cmd.Parameters.Add(OLD_class_varParameter);
			cmd.Parameters.Add(OLD_levelParameter);
			cmd.Parameters.Add(OLD_strParameter);
			cmd.Parameters.Add(OLD_agiParameter);
			cmd.Parameters.Add(OLD_staParameter);
			cmd.Parameters.Add(OLD_inteParameter);
			cmd.Parameters.Add(OLD_spiParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_race = race;
			OLD_class_var = class_var;
			OLD_level = level;
			OLD_str = str;
			OLD_agi = agi;
			OLD_sta = sta;
			OLD_inte = inte;
			OLD_spi = spi;
		}
	}
}
