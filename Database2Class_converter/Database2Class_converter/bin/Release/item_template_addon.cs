using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Item_template_addon
	{
		int Id = 0; //Comment: 
		int OLD_Id = 0;

		int FlagsCu = 0; //Comment: 
		int OLD_FlagsCu = 0;

		int FoodType = 0; //Comment: 
		int OLD_FoodType = 0;

		int MinMoneyLoot = 0; //Comment: 
		int OLD_MinMoneyLoot = 0;

		int MaxMoneyLoot = 0; //Comment: 
		int OLD_MaxMoneyLoot = 0;

		float SpellPPMChance = 0f; //Comment: 
		float OLD_SpellPPMChance = 0f;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Item_template_addon(int _Id, int _FlagsCu, int _FoodType, int _MinMoneyLoot, int _MaxMoneyLoot, float _SpellPPMChance)
		{
			Id = _Id;
			FlagsCu = _FlagsCu;
			FoodType = _FoodType;
			MinMoneyLoot = _MinMoneyLoot;
			MaxMoneyLoot = _MaxMoneyLoot;
			SpellPPMChance = _SpellPPMChance;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM item_template_addon WHERE Id = @Id AND FlagsCu = @FlagsCu AND FoodType = @FoodType AND MinMoneyLoot = @MinMoneyLoot AND MaxMoneyLoot = @MaxMoneyLoot AND SpellPPMChance = @SpellPPMChance;";
			MySqlParameter idParameter = new MySqlParameter("@Id", MySqlDbType.VarChar, 0);
			MySqlParameter flagscuParameter = new MySqlParameter("@FlagsCu", MySqlDbType.VarChar, 0);
			MySqlParameter foodtypeParameter = new MySqlParameter("@FoodType", MySqlDbType.VarChar, 0);
			MySqlParameter minmoneylootParameter = new MySqlParameter("@MinMoneyLoot", MySqlDbType.VarChar, 0);
			MySqlParameter maxmoneylootParameter = new MySqlParameter("@MaxMoneyLoot", MySqlDbType.VarChar, 0);
			MySqlParameter spellppmchanceParameter = new MySqlParameter("@SpellPPMChance", MySqlDbType.VarChar, 0);
			idParameter.Value = Id;
			flagscuParameter.Value = FlagsCu;
			foodtypeParameter.Value = FoodType;
			minmoneylootParameter.Value = MinMoneyLoot;
			maxmoneylootParameter.Value = MaxMoneyLoot;
			spellppmchanceParameter.Value = SpellPPMChance;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(flagscuParameter);
			cmd.Parameters.Add(foodtypeParameter);
			cmd.Parameters.Add(minmoneylootParameter);
			cmd.Parameters.Add(maxmoneylootParameter);
			cmd.Parameters.Add(spellppmchanceParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE item_template_addon SET Id = @newId, FlagsCu = @newFlagsCu, FoodType = @newFoodType, MinMoneyLoot = @newMinMoneyLoot, MaxMoneyLoot = @newMaxMoneyLoot, SpellPPMChance = @newSpellPPMChance WHERE Id = @Id AND FlagsCu = @FlagsCu AND FoodType = @FoodType AND MinMoneyLoot = @MinMoneyLoot AND MaxMoneyLoot = @MaxMoneyLoot AND SpellPPMChance = @SpellPPMChance;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@Id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_flagscuParameter = new MySqlParameter("@FlagsCu", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_foodtypeParameter = new MySqlParameter("@FoodType", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_minmoneylootParameter = new MySqlParameter("@MinMoneyLoot", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_maxmoneylootParameter = new MySqlParameter("@MaxMoneyLoot", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spellppmchanceParameter = new MySqlParameter("@SpellPPMChance", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newId", MySqlDbType.VarChar, 0);
			MySqlParameter flagscuParameter = new MySqlParameter("@newFlagsCu", MySqlDbType.VarChar, 0);
			MySqlParameter foodtypeParameter = new MySqlParameter("@newFoodType", MySqlDbType.VarChar, 0);
			MySqlParameter minmoneylootParameter = new MySqlParameter("@newMinMoneyLoot", MySqlDbType.VarChar, 0);
			MySqlParameter maxmoneylootParameter = new MySqlParameter("@newMaxMoneyLoot", MySqlDbType.VarChar, 0);
			MySqlParameter spellppmchanceParameter = new MySqlParameter("@newSpellPPMChance", MySqlDbType.VarChar, 0);
			idParameter.Value = Id;
			flagscuParameter.Value = FlagsCu;
			foodtypeParameter.Value = FoodType;
			minmoneylootParameter.Value = MinMoneyLoot;
			maxmoneylootParameter.Value = MaxMoneyLoot;
			spellppmchanceParameter.Value = SpellPPMChance;
			OLD_idParameter.Value = OLD_Id;
			OLD_flagscuParameter.Value = OLD_FlagsCu;
			OLD_foodtypeParameter.Value = OLD_FoodType;
			OLD_minmoneylootParameter.Value = OLD_MinMoneyLoot;
			OLD_maxmoneylootParameter.Value = OLD_MaxMoneyLoot;
			OLD_spellppmchanceParameter.Value = OLD_SpellPPMChance;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(flagscuParameter);
			cmd.Parameters.Add(foodtypeParameter);
			cmd.Parameters.Add(minmoneylootParameter);
			cmd.Parameters.Add(maxmoneylootParameter);
			cmd.Parameters.Add(spellppmchanceParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_flagscuParameter);
			cmd.Parameters.Add(OLD_foodtypeParameter);
			cmd.Parameters.Add(OLD_minmoneylootParameter);
			cmd.Parameters.Add(OLD_maxmoneylootParameter);
			cmd.Parameters.Add(OLD_spellppmchanceParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_Id = Id;
			OLD_FlagsCu = FlagsCu;
			OLD_FoodType = FoodType;
			OLD_MinMoneyLoot = MinMoneyLoot;
			OLD_MaxMoneyLoot = MaxMoneyLoot;
			OLD_SpellPPMChance = SpellPPMChance;
		}
	}
}
