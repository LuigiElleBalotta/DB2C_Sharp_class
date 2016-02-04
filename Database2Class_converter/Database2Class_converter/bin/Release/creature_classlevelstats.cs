using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Creature_classlevelstats
	{
		int level = 0; //Comment: 
		int OLD_level = 0;

		int class_var = 0; //Comment: 
		int OLD_class_var = 0;

		int basemana = 1; //Comment: 
		int OLD_basemana = 1;

		int basearmor = 1; //Comment: 
		int OLD_basearmor = 1;

		int attackpower = 0; //Comment: 
		int OLD_attackpower = 0;

		int rangedattackpower = 0; //Comment: 
		int OLD_rangedattackpower = 0;

		float damage_base = 0f; //Comment: 
		float OLD_damage_base = 0f;

		float damage_exp1 = 0f; //Comment: 
		float OLD_damage_exp1 = 0f;

		float damage_exp2 = 0f; //Comment: 
		float OLD_damage_exp2 = 0f;

		float damage_exp3 = 0f; //Comment: 
		float OLD_damage_exp3 = 0f;

		float damage_exp4 = 0f; //Comment: 
		float OLD_damage_exp4 = 0f;

		float damage_exp5 = 0f; //Comment: 
		float OLD_damage_exp5 = 0f;

		string comment = null; //Comment: 
		string OLD_comment = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Creature_classlevelstats(int _level, int _class_var, int _basemana, int _basearmor, int _attackpower, int _rangedattackpower, float _damage_base, float _damage_exp1, float _damage_exp2, float _damage_exp3, float _damage_exp4, float _damage_exp5, string _comment)
		{
			level = _level;
			class_var = _class_var;
			basemana = _basemana;
			basearmor = _basearmor;
			attackpower = _attackpower;
			rangedattackpower = _rangedattackpower;
			damage_base = _damage_base;
			damage_exp1 = _damage_exp1;
			damage_exp2 = _damage_exp2;
			damage_exp3 = _damage_exp3;
			damage_exp4 = _damage_exp4;
			damage_exp5 = _damage_exp5;
			comment = _comment;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM creature_classlevelstats WHERE level = @level AND class_var = @class_var AND basemana = @basemana AND basearmor = @basearmor AND attackpower = @attackpower AND rangedattackpower = @rangedattackpower AND damage_base = @damage_base AND damage_exp1 = @damage_exp1 AND damage_exp2 = @damage_exp2 AND damage_exp3 = @damage_exp3 AND damage_exp4 = @damage_exp4 AND damage_exp5 = @damage_exp5 AND comment = @comment;";
			MySqlParameter levelParameter = new MySqlParameter("@level", MySqlDbType.VarChar, 0);
			MySqlParameter class_varParameter = new MySqlParameter("@class_var", MySqlDbType.VarChar, 0);
			MySqlParameter basemanaParameter = new MySqlParameter("@basemana", MySqlDbType.VarChar, 0);
			MySqlParameter basearmorParameter = new MySqlParameter("@basearmor", MySqlDbType.VarChar, 0);
			MySqlParameter attackpowerParameter = new MySqlParameter("@attackpower", MySqlDbType.VarChar, 0);
			MySqlParameter rangedattackpowerParameter = new MySqlParameter("@rangedattackpower", MySqlDbType.VarChar, 0);
			MySqlParameter damage_baseParameter = new MySqlParameter("@damage_base", MySqlDbType.VarChar, 0);
			MySqlParameter damage_exp1Parameter = new MySqlParameter("@damage_exp1", MySqlDbType.VarChar, 0);
			MySqlParameter damage_exp2Parameter = new MySqlParameter("@damage_exp2", MySqlDbType.VarChar, 0);
			MySqlParameter damage_exp3Parameter = new MySqlParameter("@damage_exp3", MySqlDbType.VarChar, 0);
			MySqlParameter damage_exp4Parameter = new MySqlParameter("@damage_exp4", MySqlDbType.VarChar, 0);
			MySqlParameter damage_exp5Parameter = new MySqlParameter("@damage_exp5", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@comment", MySqlDbType.VarChar, 0);
			levelParameter.Value = level;
			class_varParameter.Value = class_var;
			basemanaParameter.Value = basemana;
			basearmorParameter.Value = basearmor;
			attackpowerParameter.Value = attackpower;
			rangedattackpowerParameter.Value = rangedattackpower;
			damage_baseParameter.Value = damage_base;
			damage_exp1Parameter.Value = damage_exp1;
			damage_exp2Parameter.Value = damage_exp2;
			damage_exp3Parameter.Value = damage_exp3;
			damage_exp4Parameter.Value = damage_exp4;
			damage_exp5Parameter.Value = damage_exp5;
			commentParameter.Value = comment;
			cmd.Parameters.Add(levelParameter);
			cmd.Parameters.Add(class_varParameter);
			cmd.Parameters.Add(basemanaParameter);
			cmd.Parameters.Add(basearmorParameter);
			cmd.Parameters.Add(attackpowerParameter);
			cmd.Parameters.Add(rangedattackpowerParameter);
			cmd.Parameters.Add(damage_baseParameter);
			cmd.Parameters.Add(damage_exp1Parameter);
			cmd.Parameters.Add(damage_exp2Parameter);
			cmd.Parameters.Add(damage_exp3Parameter);
			cmd.Parameters.Add(damage_exp4Parameter);
			cmd.Parameters.Add(damage_exp5Parameter);
			cmd.Parameters.Add(commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE creature_classlevelstats SET level = @newlevel, class_var = @newclass_var, basemana = @newbasemana, basearmor = @newbasearmor, attackpower = @newattackpower, rangedattackpower = @newrangedattackpower, damage_base = @newdamage_base, damage_exp1 = @newdamage_exp1, damage_exp2 = @newdamage_exp2, damage_exp3 = @newdamage_exp3, damage_exp4 = @newdamage_exp4, damage_exp5 = @newdamage_exp5, comment = @newcomment WHERE level = @level AND class_var = @class_var AND basemana = @basemana AND basearmor = @basearmor AND attackpower = @attackpower AND rangedattackpower = @rangedattackpower AND damage_base = @damage_base AND damage_exp1 = @damage_exp1 AND damage_exp2 = @damage_exp2 AND damage_exp3 = @damage_exp3 AND damage_exp4 = @damage_exp4 AND damage_exp5 = @damage_exp5 AND comment = @comment;";
			MySqlParameter OLD_levelParameter = new MySqlParameter("@level", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_class_varParameter = new MySqlParameter("@class_var", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_basemanaParameter = new MySqlParameter("@basemana", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_basearmorParameter = new MySqlParameter("@basearmor", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_attackpowerParameter = new MySqlParameter("@attackpower", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rangedattackpowerParameter = new MySqlParameter("@rangedattackpower", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_damage_baseParameter = new MySqlParameter("@damage_base", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_damage_exp1Parameter = new MySqlParameter("@damage_exp1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_damage_exp2Parameter = new MySqlParameter("@damage_exp2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_damage_exp3Parameter = new MySqlParameter("@damage_exp3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_damage_exp4Parameter = new MySqlParameter("@damage_exp4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_damage_exp5Parameter = new MySqlParameter("@damage_exp5", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_commentParameter = new MySqlParameter("@comment", MySqlDbType.VarChar, 0);
			MySqlParameter levelParameter = new MySqlParameter("@newlevel", MySqlDbType.VarChar, 0);
			MySqlParameter class_varParameter = new MySqlParameter("@newclass_var", MySqlDbType.VarChar, 0);
			MySqlParameter basemanaParameter = new MySqlParameter("@newbasemana", MySqlDbType.VarChar, 0);
			MySqlParameter basearmorParameter = new MySqlParameter("@newbasearmor", MySqlDbType.VarChar, 0);
			MySqlParameter attackpowerParameter = new MySqlParameter("@newattackpower", MySqlDbType.VarChar, 0);
			MySqlParameter rangedattackpowerParameter = new MySqlParameter("@newrangedattackpower", MySqlDbType.VarChar, 0);
			MySqlParameter damage_baseParameter = new MySqlParameter("@newdamage_base", MySqlDbType.VarChar, 0);
			MySqlParameter damage_exp1Parameter = new MySqlParameter("@newdamage_exp1", MySqlDbType.VarChar, 0);
			MySqlParameter damage_exp2Parameter = new MySqlParameter("@newdamage_exp2", MySqlDbType.VarChar, 0);
			MySqlParameter damage_exp3Parameter = new MySqlParameter("@newdamage_exp3", MySqlDbType.VarChar, 0);
			MySqlParameter damage_exp4Parameter = new MySqlParameter("@newdamage_exp4", MySqlDbType.VarChar, 0);
			MySqlParameter damage_exp5Parameter = new MySqlParameter("@newdamage_exp5", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@newcomment", MySqlDbType.VarChar, 0);
			levelParameter.Value = level;
			class_varParameter.Value = class_var;
			basemanaParameter.Value = basemana;
			basearmorParameter.Value = basearmor;
			attackpowerParameter.Value = attackpower;
			rangedattackpowerParameter.Value = rangedattackpower;
			damage_baseParameter.Value = damage_base;
			damage_exp1Parameter.Value = damage_exp1;
			damage_exp2Parameter.Value = damage_exp2;
			damage_exp3Parameter.Value = damage_exp3;
			damage_exp4Parameter.Value = damage_exp4;
			damage_exp5Parameter.Value = damage_exp5;
			commentParameter.Value = comment;
			OLD_levelParameter.Value = OLD_level;
			OLD_class_varParameter.Value = OLD_class_var;
			OLD_basemanaParameter.Value = OLD_basemana;
			OLD_basearmorParameter.Value = OLD_basearmor;
			OLD_attackpowerParameter.Value = OLD_attackpower;
			OLD_rangedattackpowerParameter.Value = OLD_rangedattackpower;
			OLD_damage_baseParameter.Value = OLD_damage_base;
			OLD_damage_exp1Parameter.Value = OLD_damage_exp1;
			OLD_damage_exp2Parameter.Value = OLD_damage_exp2;
			OLD_damage_exp3Parameter.Value = OLD_damage_exp3;
			OLD_damage_exp4Parameter.Value = OLD_damage_exp4;
			OLD_damage_exp5Parameter.Value = OLD_damage_exp5;
			OLD_commentParameter.Value = OLD_comment;
			cmd.Parameters.Add(levelParameter);
			cmd.Parameters.Add(class_varParameter);
			cmd.Parameters.Add(basemanaParameter);
			cmd.Parameters.Add(basearmorParameter);
			cmd.Parameters.Add(attackpowerParameter);
			cmd.Parameters.Add(rangedattackpowerParameter);
			cmd.Parameters.Add(damage_baseParameter);
			cmd.Parameters.Add(damage_exp1Parameter);
			cmd.Parameters.Add(damage_exp2Parameter);
			cmd.Parameters.Add(damage_exp3Parameter);
			cmd.Parameters.Add(damage_exp4Parameter);
			cmd.Parameters.Add(damage_exp5Parameter);
			cmd.Parameters.Add(commentParameter);
			cmd.Parameters.Add(OLD_levelParameter);
			cmd.Parameters.Add(OLD_class_varParameter);
			cmd.Parameters.Add(OLD_basemanaParameter);
			cmd.Parameters.Add(OLD_basearmorParameter);
			cmd.Parameters.Add(OLD_attackpowerParameter);
			cmd.Parameters.Add(OLD_rangedattackpowerParameter);
			cmd.Parameters.Add(OLD_damage_baseParameter);
			cmd.Parameters.Add(OLD_damage_exp1Parameter);
			cmd.Parameters.Add(OLD_damage_exp2Parameter);
			cmd.Parameters.Add(OLD_damage_exp3Parameter);
			cmd.Parameters.Add(OLD_damage_exp4Parameter);
			cmd.Parameters.Add(OLD_damage_exp5Parameter);
			cmd.Parameters.Add(OLD_commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_level = level;
			OLD_class_var = class_var;
			OLD_basemana = basemana;
			OLD_basearmor = basearmor;
			OLD_attackpower = attackpower;
			OLD_rangedattackpower = rangedattackpower;
			OLD_damage_base = damage_base;
			OLD_damage_exp1 = damage_exp1;
			OLD_damage_exp2 = damage_exp2;
			OLD_damage_exp3 = damage_exp3;
			OLD_damage_exp4 = damage_exp4;
			OLD_damage_exp5 = damage_exp5;
			OLD_comment = comment;
		}
	}
}
