using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Pet_levelstats
	{
		int creature_entry = 0; //Comment: 
		int OLD_creature_entry = 0;

		int level = 0; //Comment: 
		int OLD_level = 0;

		int hp = 0; //Comment: 
		int OLD_hp = 0;

		int mana = 0; //Comment: 
		int OLD_mana = 0;

		int armor = 0; //Comment: 
		int OLD_armor = 0;

		int str = 0; //Comment: 
		int OLD_str = 0;

		int agi = 0; //Comment: 
		int OLD_agi = 0;

		int sta = 0; //Comment: 
		int OLD_sta = 0;

		int inte = 0; //Comment: 
		int OLD_inte = 0;

		int spi = 0; //Comment: 
		int OLD_spi = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Pet_levelstats(int _creature_entry, int _level, int _hp, int _mana, int _armor, int _str, int _agi, int _sta, int _inte, int _spi)
		{
			creature_entry = _creature_entry;
			level = _level;
			hp = _hp;
			mana = _mana;
			armor = _armor;
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
			cmd.CommandText = "DELETE FROM pet_levelstats WHERE creature_entry = @creature_entry AND level = @level AND hp = @hp AND mana = @mana AND armor = @armor AND str = @str AND agi = @agi AND sta = @sta AND inte = @inte AND spi = @spi;";
			MySqlParameter creature_entryParameter = new MySqlParameter("@creature_entry", MySqlDbType.VarChar, 0);
			MySqlParameter levelParameter = new MySqlParameter("@level", MySqlDbType.VarChar, 0);
			MySqlParameter hpParameter = new MySqlParameter("@hp", MySqlDbType.VarChar, 0);
			MySqlParameter manaParameter = new MySqlParameter("@mana", MySqlDbType.VarChar, 0);
			MySqlParameter armorParameter = new MySqlParameter("@armor", MySqlDbType.VarChar, 0);
			MySqlParameter strParameter = new MySqlParameter("@str", MySqlDbType.VarChar, 0);
			MySqlParameter agiParameter = new MySqlParameter("@agi", MySqlDbType.VarChar, 0);
			MySqlParameter staParameter = new MySqlParameter("@sta", MySqlDbType.VarChar, 0);
			MySqlParameter inteParameter = new MySqlParameter("@inte", MySqlDbType.VarChar, 0);
			MySqlParameter spiParameter = new MySqlParameter("@spi", MySqlDbType.VarChar, 0);
			creature_entryParameter.Value = creature_entry;
			levelParameter.Value = level;
			hpParameter.Value = hp;
			manaParameter.Value = mana;
			armorParameter.Value = armor;
			strParameter.Value = str;
			agiParameter.Value = agi;
			staParameter.Value = sta;
			inteParameter.Value = inte;
			spiParameter.Value = spi;
			cmd.Parameters.Add(creature_entryParameter);
			cmd.Parameters.Add(levelParameter);
			cmd.Parameters.Add(hpParameter);
			cmd.Parameters.Add(manaParameter);
			cmd.Parameters.Add(armorParameter);
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
			cmd.CommandText = "UPDATE pet_levelstats SET creature_entry = @newcreature_entry, level = @newlevel, hp = @newhp, mana = @newmana, armor = @newarmor, str = @newstr, agi = @newagi, sta = @newsta, inte = @newinte, spi = @newspi WHERE creature_entry = @creature_entry AND level = @level AND hp = @hp AND mana = @mana AND armor = @armor AND str = @str AND agi = @agi AND sta = @sta AND inte = @inte AND spi = @spi;";
			MySqlParameter OLD_creature_entryParameter = new MySqlParameter("@creature_entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_levelParameter = new MySqlParameter("@level", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_hpParameter = new MySqlParameter("@hp", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_manaParameter = new MySqlParameter("@mana", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_armorParameter = new MySqlParameter("@armor", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_strParameter = new MySqlParameter("@str", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_agiParameter = new MySqlParameter("@agi", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_staParameter = new MySqlParameter("@sta", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_inteParameter = new MySqlParameter("@inte", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spiParameter = new MySqlParameter("@spi", MySqlDbType.VarChar, 0);
			MySqlParameter creature_entryParameter = new MySqlParameter("@newcreature_entry", MySqlDbType.VarChar, 0);
			MySqlParameter levelParameter = new MySqlParameter("@newlevel", MySqlDbType.VarChar, 0);
			MySqlParameter hpParameter = new MySqlParameter("@newhp", MySqlDbType.VarChar, 0);
			MySqlParameter manaParameter = new MySqlParameter("@newmana", MySqlDbType.VarChar, 0);
			MySqlParameter armorParameter = new MySqlParameter("@newarmor", MySqlDbType.VarChar, 0);
			MySqlParameter strParameter = new MySqlParameter("@newstr", MySqlDbType.VarChar, 0);
			MySqlParameter agiParameter = new MySqlParameter("@newagi", MySqlDbType.VarChar, 0);
			MySqlParameter staParameter = new MySqlParameter("@newsta", MySqlDbType.VarChar, 0);
			MySqlParameter inteParameter = new MySqlParameter("@newinte", MySqlDbType.VarChar, 0);
			MySqlParameter spiParameter = new MySqlParameter("@newspi", MySqlDbType.VarChar, 0);
			creature_entryParameter.Value = creature_entry;
			levelParameter.Value = level;
			hpParameter.Value = hp;
			manaParameter.Value = mana;
			armorParameter.Value = armor;
			strParameter.Value = str;
			agiParameter.Value = agi;
			staParameter.Value = sta;
			inteParameter.Value = inte;
			spiParameter.Value = spi;
			OLD_creature_entryParameter.Value = OLD_creature_entry;
			OLD_levelParameter.Value = OLD_level;
			OLD_hpParameter.Value = OLD_hp;
			OLD_manaParameter.Value = OLD_mana;
			OLD_armorParameter.Value = OLD_armor;
			OLD_strParameter.Value = OLD_str;
			OLD_agiParameter.Value = OLD_agi;
			OLD_staParameter.Value = OLD_sta;
			OLD_inteParameter.Value = OLD_inte;
			OLD_spiParameter.Value = OLD_spi;
			cmd.Parameters.Add(creature_entryParameter);
			cmd.Parameters.Add(levelParameter);
			cmd.Parameters.Add(hpParameter);
			cmd.Parameters.Add(manaParameter);
			cmd.Parameters.Add(armorParameter);
			cmd.Parameters.Add(strParameter);
			cmd.Parameters.Add(agiParameter);
			cmd.Parameters.Add(staParameter);
			cmd.Parameters.Add(inteParameter);
			cmd.Parameters.Add(spiParameter);
			cmd.Parameters.Add(OLD_creature_entryParameter);
			cmd.Parameters.Add(OLD_levelParameter);
			cmd.Parameters.Add(OLD_hpParameter);
			cmd.Parameters.Add(OLD_manaParameter);
			cmd.Parameters.Add(OLD_armorParameter);
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
			OLD_creature_entry = creature_entry;
			OLD_level = level;
			OLD_hp = hp;
			OLD_mana = mana;
			OLD_armor = armor;
			OLD_str = str;
			OLD_agi = agi;
			OLD_sta = sta;
			OLD_inte = inte;
			OLD_spi = spi;
		}
	}
}
