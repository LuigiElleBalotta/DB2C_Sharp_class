using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Spell_group_stack_rules
	{
		int group_id = 0; //Comment: 
		int OLD_group_id = 0;

		int stack_rule = 0; //Comment: 
		int OLD_stack_rule = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Spell_group_stack_rules(int _group_id, int _stack_rule)
		{
			group_id = _group_id;
			stack_rule = _stack_rule;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM spell_group_stack_rules WHERE group_id = @group_id AND stack_rule = @stack_rule;";
			MySqlParameter group_idParameter = new MySqlParameter("@group_id", MySqlDbType.VarChar, 0);
			MySqlParameter stack_ruleParameter = new MySqlParameter("@stack_rule", MySqlDbType.VarChar, 0);
			group_idParameter.Value = group_id;
			stack_ruleParameter.Value = stack_rule;
			cmd.Parameters.Add(group_idParameter);
			cmd.Parameters.Add(stack_ruleParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE spell_group_stack_rules SET group_id = @newgroup_id, stack_rule = @newstack_rule WHERE group_id = @group_id AND stack_rule = @stack_rule;";
			MySqlParameter OLD_group_idParameter = new MySqlParameter("@group_id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_stack_ruleParameter = new MySqlParameter("@stack_rule", MySqlDbType.VarChar, 0);
			MySqlParameter group_idParameter = new MySqlParameter("@newgroup_id", MySqlDbType.VarChar, 0);
			MySqlParameter stack_ruleParameter = new MySqlParameter("@newstack_rule", MySqlDbType.VarChar, 0);
			group_idParameter.Value = group_id;
			stack_ruleParameter.Value = stack_rule;
			OLD_group_idParameter.Value = OLD_group_id;
			OLD_stack_ruleParameter.Value = OLD_stack_rule;
			cmd.Parameters.Add(group_idParameter);
			cmd.Parameters.Add(stack_ruleParameter);
			cmd.Parameters.Add(OLD_group_idParameter);
			cmd.Parameters.Add(OLD_stack_ruleParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_group_id = group_id;
			OLD_stack_rule = stack_rule;
		}
	}
}
