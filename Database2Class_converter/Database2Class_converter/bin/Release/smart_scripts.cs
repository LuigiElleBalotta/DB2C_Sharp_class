using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Smart_scripts
	{
		int entryorguid = 0; //Comment: 
		int OLD_entryorguid = 0;

		int source_type = 0; //Comment: 
		int OLD_source_type = 0;

		int id = 0; //Comment: 
		int OLD_id = 0;

		int link = 0; //Comment: 
		int OLD_link = 0;

		int event_type = 0; //Comment: 
		int OLD_event_type = 0;

		int event_phase_mask = 0; //Comment: 
		int OLD_event_phase_mask = 0;

		int event_chance = 100; //Comment: 
		int OLD_event_chance = 100;

		int event_flags = 0; //Comment: 
		int OLD_event_flags = 0;

		int event_param1 = 0; //Comment: 
		int OLD_event_param1 = 0;

		int event_param2 = 0; //Comment: 
		int OLD_event_param2 = 0;

		int event_param3 = 0; //Comment: 
		int OLD_event_param3 = 0;

		int event_param4 = 0; //Comment: 
		int OLD_event_param4 = 0;

		int action_type = 0; //Comment: 
		int OLD_action_type = 0;

		int action_param1 = 0; //Comment: 
		int OLD_action_param1 = 0;

		int action_param2 = 0; //Comment: 
		int OLD_action_param2 = 0;

		int action_param3 = 0; //Comment: 
		int OLD_action_param3 = 0;

		int action_param4 = 0; //Comment: 
		int OLD_action_param4 = 0;

		int action_param5 = 0; //Comment: 
		int OLD_action_param5 = 0;

		int action_param6 = 0; //Comment: 
		int OLD_action_param6 = 0;

		int target_type = 0; //Comment: 
		int OLD_target_type = 0;

		int target_param1 = 0; //Comment: 
		int OLD_target_param1 = 0;

		int target_param2 = 0; //Comment: 
		int OLD_target_param2 = 0;

		int target_param3 = 0; //Comment: 
		int OLD_target_param3 = 0;

		float target_x = 0f; //Comment: 
		float OLD_target_x = 0f;

		float target_y = 0f; //Comment: 
		float OLD_target_y = 0f;

		float target_z = 0f; //Comment: 
		float OLD_target_z = 0f;

		float target_o = 0f; //Comment: 
		float OLD_target_o = 0f;

		string comment = null; //Comment: Event Comment
		string OLD_comment = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Smart_scripts(int _entryorguid, int _source_type, int _id, int _link, int _event_type, int _event_phase_mask, int _event_chance, int _event_flags, int _event_param1, int _event_param2, int _event_param3, int _event_param4, int _action_type, int _action_param1, int _action_param2, int _action_param3, int _action_param4, int _action_param5, int _action_param6, int _target_type, int _target_param1, int _target_param2, int _target_param3, float _target_x, float _target_y, float _target_z, float _target_o, string _comment)
		{
			entryorguid = _entryorguid;
			source_type = _source_type;
			id = _id;
			link = _link;
			event_type = _event_type;
			event_phase_mask = _event_phase_mask;
			event_chance = _event_chance;
			event_flags = _event_flags;
			event_param1 = _event_param1;
			event_param2 = _event_param2;
			event_param3 = _event_param3;
			event_param4 = _event_param4;
			action_type = _action_type;
			action_param1 = _action_param1;
			action_param2 = _action_param2;
			action_param3 = _action_param3;
			action_param4 = _action_param4;
			action_param5 = _action_param5;
			action_param6 = _action_param6;
			target_type = _target_type;
			target_param1 = _target_param1;
			target_param2 = _target_param2;
			target_param3 = _target_param3;
			target_x = _target_x;
			target_y = _target_y;
			target_z = _target_z;
			target_o = _target_o;
			comment = _comment;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM smart_scripts WHERE entryorguid = @entryorguid AND source_type = @source_type AND id = @id AND link = @link AND event_type = @event_type AND event_phase_mask = @event_phase_mask AND event_chance = @event_chance AND event_flags = @event_flags AND event_param1 = @event_param1 AND event_param2 = @event_param2 AND event_param3 = @event_param3 AND event_param4 = @event_param4 AND action_type = @action_type AND action_param1 = @action_param1 AND action_param2 = @action_param2 AND action_param3 = @action_param3 AND action_param4 = @action_param4 AND action_param5 = @action_param5 AND action_param6 = @action_param6 AND target_type = @target_type AND target_param1 = @target_param1 AND target_param2 = @target_param2 AND target_param3 = @target_param3 AND target_x = @target_x AND target_y = @target_y AND target_z = @target_z AND target_o = @target_o AND comment = @comment;";
			MySqlParameter entryorguidParameter = new MySqlParameter("@entryorguid", MySqlDbType.VarChar, 0);
			MySqlParameter source_typeParameter = new MySqlParameter("@source_type", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@id", MySqlDbType.VarChar, 0);
			MySqlParameter linkParameter = new MySqlParameter("@link", MySqlDbType.VarChar, 0);
			MySqlParameter event_typeParameter = new MySqlParameter("@event_type", MySqlDbType.VarChar, 0);
			MySqlParameter event_phase_maskParameter = new MySqlParameter("@event_phase_mask", MySqlDbType.VarChar, 0);
			MySqlParameter event_chanceParameter = new MySqlParameter("@event_chance", MySqlDbType.VarChar, 0);
			MySqlParameter event_flagsParameter = new MySqlParameter("@event_flags", MySqlDbType.VarChar, 0);
			MySqlParameter event_param1Parameter = new MySqlParameter("@event_param1", MySqlDbType.VarChar, 0);
			MySqlParameter event_param2Parameter = new MySqlParameter("@event_param2", MySqlDbType.VarChar, 0);
			MySqlParameter event_param3Parameter = new MySqlParameter("@event_param3", MySqlDbType.VarChar, 0);
			MySqlParameter event_param4Parameter = new MySqlParameter("@event_param4", MySqlDbType.VarChar, 0);
			MySqlParameter action_typeParameter = new MySqlParameter("@action_type", MySqlDbType.VarChar, 0);
			MySqlParameter action_param1Parameter = new MySqlParameter("@action_param1", MySqlDbType.VarChar, 0);
			MySqlParameter action_param2Parameter = new MySqlParameter("@action_param2", MySqlDbType.VarChar, 0);
			MySqlParameter action_param3Parameter = new MySqlParameter("@action_param3", MySqlDbType.VarChar, 0);
			MySqlParameter action_param4Parameter = new MySqlParameter("@action_param4", MySqlDbType.VarChar, 0);
			MySqlParameter action_param5Parameter = new MySqlParameter("@action_param5", MySqlDbType.VarChar, 0);
			MySqlParameter action_param6Parameter = new MySqlParameter("@action_param6", MySqlDbType.VarChar, 0);
			MySqlParameter target_typeParameter = new MySqlParameter("@target_type", MySqlDbType.VarChar, 0);
			MySqlParameter target_param1Parameter = new MySqlParameter("@target_param1", MySqlDbType.VarChar, 0);
			MySqlParameter target_param2Parameter = new MySqlParameter("@target_param2", MySqlDbType.VarChar, 0);
			MySqlParameter target_param3Parameter = new MySqlParameter("@target_param3", MySqlDbType.VarChar, 0);
			MySqlParameter target_xParameter = new MySqlParameter("@target_x", MySqlDbType.VarChar, 0);
			MySqlParameter target_yParameter = new MySqlParameter("@target_y", MySqlDbType.VarChar, 0);
			MySqlParameter target_zParameter = new MySqlParameter("@target_z", MySqlDbType.VarChar, 0);
			MySqlParameter target_oParameter = new MySqlParameter("@target_o", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@comment", MySqlDbType.VarChar, 0);
			entryorguidParameter.Value = entryorguid;
			source_typeParameter.Value = source_type;
			idParameter.Value = id;
			linkParameter.Value = link;
			event_typeParameter.Value = event_type;
			event_phase_maskParameter.Value = event_phase_mask;
			event_chanceParameter.Value = event_chance;
			event_flagsParameter.Value = event_flags;
			event_param1Parameter.Value = event_param1;
			event_param2Parameter.Value = event_param2;
			event_param3Parameter.Value = event_param3;
			event_param4Parameter.Value = event_param4;
			action_typeParameter.Value = action_type;
			action_param1Parameter.Value = action_param1;
			action_param2Parameter.Value = action_param2;
			action_param3Parameter.Value = action_param3;
			action_param4Parameter.Value = action_param4;
			action_param5Parameter.Value = action_param5;
			action_param6Parameter.Value = action_param6;
			target_typeParameter.Value = target_type;
			target_param1Parameter.Value = target_param1;
			target_param2Parameter.Value = target_param2;
			target_param3Parameter.Value = target_param3;
			target_xParameter.Value = target_x;
			target_yParameter.Value = target_y;
			target_zParameter.Value = target_z;
			target_oParameter.Value = target_o;
			commentParameter.Value = comment;
			cmd.Parameters.Add(entryorguidParameter);
			cmd.Parameters.Add(source_typeParameter);
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(linkParameter);
			cmd.Parameters.Add(event_typeParameter);
			cmd.Parameters.Add(event_phase_maskParameter);
			cmd.Parameters.Add(event_chanceParameter);
			cmd.Parameters.Add(event_flagsParameter);
			cmd.Parameters.Add(event_param1Parameter);
			cmd.Parameters.Add(event_param2Parameter);
			cmd.Parameters.Add(event_param3Parameter);
			cmd.Parameters.Add(event_param4Parameter);
			cmd.Parameters.Add(action_typeParameter);
			cmd.Parameters.Add(action_param1Parameter);
			cmd.Parameters.Add(action_param2Parameter);
			cmd.Parameters.Add(action_param3Parameter);
			cmd.Parameters.Add(action_param4Parameter);
			cmd.Parameters.Add(action_param5Parameter);
			cmd.Parameters.Add(action_param6Parameter);
			cmd.Parameters.Add(target_typeParameter);
			cmd.Parameters.Add(target_param1Parameter);
			cmd.Parameters.Add(target_param2Parameter);
			cmd.Parameters.Add(target_param3Parameter);
			cmd.Parameters.Add(target_xParameter);
			cmd.Parameters.Add(target_yParameter);
			cmd.Parameters.Add(target_zParameter);
			cmd.Parameters.Add(target_oParameter);
			cmd.Parameters.Add(commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE smart_scripts SET entryorguid = @newentryorguid, source_type = @newsource_type, id = @newid, link = @newlink, event_type = @newevent_type, event_phase_mask = @newevent_phase_mask, event_chance = @newevent_chance, event_flags = @newevent_flags, event_param1 = @newevent_param1, event_param2 = @newevent_param2, event_param3 = @newevent_param3, event_param4 = @newevent_param4, action_type = @newaction_type, action_param1 = @newaction_param1, action_param2 = @newaction_param2, action_param3 = @newaction_param3, action_param4 = @newaction_param4, action_param5 = @newaction_param5, action_param6 = @newaction_param6, target_type = @newtarget_type, target_param1 = @newtarget_param1, target_param2 = @newtarget_param2, target_param3 = @newtarget_param3, target_x = @newtarget_x, target_y = @newtarget_y, target_z = @newtarget_z, target_o = @newtarget_o, comment = @newcomment WHERE entryorguid = @entryorguid AND source_type = @source_type AND id = @id AND link = @link AND event_type = @event_type AND event_phase_mask = @event_phase_mask AND event_chance = @event_chance AND event_flags = @event_flags AND event_param1 = @event_param1 AND event_param2 = @event_param2 AND event_param3 = @event_param3 AND event_param4 = @event_param4 AND action_type = @action_type AND action_param1 = @action_param1 AND action_param2 = @action_param2 AND action_param3 = @action_param3 AND action_param4 = @action_param4 AND action_param5 = @action_param5 AND action_param6 = @action_param6 AND target_type = @target_type AND target_param1 = @target_param1 AND target_param2 = @target_param2 AND target_param3 = @target_param3 AND target_x = @target_x AND target_y = @target_y AND target_z = @target_z AND target_o = @target_o AND comment = @comment;";
			MySqlParameter OLD_entryorguidParameter = new MySqlParameter("@entryorguid", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_source_typeParameter = new MySqlParameter("@source_type", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_idParameter = new MySqlParameter("@id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_linkParameter = new MySqlParameter("@link", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_event_typeParameter = new MySqlParameter("@event_type", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_event_phase_maskParameter = new MySqlParameter("@event_phase_mask", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_event_chanceParameter = new MySqlParameter("@event_chance", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_event_flagsParameter = new MySqlParameter("@event_flags", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_event_param1Parameter = new MySqlParameter("@event_param1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_event_param2Parameter = new MySqlParameter("@event_param2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_event_param3Parameter = new MySqlParameter("@event_param3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_event_param4Parameter = new MySqlParameter("@event_param4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_action_typeParameter = new MySqlParameter("@action_type", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_action_param1Parameter = new MySqlParameter("@action_param1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_action_param2Parameter = new MySqlParameter("@action_param2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_action_param3Parameter = new MySqlParameter("@action_param3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_action_param4Parameter = new MySqlParameter("@action_param4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_action_param5Parameter = new MySqlParameter("@action_param5", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_action_param6Parameter = new MySqlParameter("@action_param6", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_target_typeParameter = new MySqlParameter("@target_type", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_target_param1Parameter = new MySqlParameter("@target_param1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_target_param2Parameter = new MySqlParameter("@target_param2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_target_param3Parameter = new MySqlParameter("@target_param3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_target_xParameter = new MySqlParameter("@target_x", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_target_yParameter = new MySqlParameter("@target_y", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_target_zParameter = new MySqlParameter("@target_z", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_target_oParameter = new MySqlParameter("@target_o", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_commentParameter = new MySqlParameter("@comment", MySqlDbType.VarChar, 0);
			MySqlParameter entryorguidParameter = new MySqlParameter("@newentryorguid", MySqlDbType.VarChar, 0);
			MySqlParameter source_typeParameter = new MySqlParameter("@newsource_type", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newid", MySqlDbType.VarChar, 0);
			MySqlParameter linkParameter = new MySqlParameter("@newlink", MySqlDbType.VarChar, 0);
			MySqlParameter event_typeParameter = new MySqlParameter("@newevent_type", MySqlDbType.VarChar, 0);
			MySqlParameter event_phase_maskParameter = new MySqlParameter("@newevent_phase_mask", MySqlDbType.VarChar, 0);
			MySqlParameter event_chanceParameter = new MySqlParameter("@newevent_chance", MySqlDbType.VarChar, 0);
			MySqlParameter event_flagsParameter = new MySqlParameter("@newevent_flags", MySqlDbType.VarChar, 0);
			MySqlParameter event_param1Parameter = new MySqlParameter("@newevent_param1", MySqlDbType.VarChar, 0);
			MySqlParameter event_param2Parameter = new MySqlParameter("@newevent_param2", MySqlDbType.VarChar, 0);
			MySqlParameter event_param3Parameter = new MySqlParameter("@newevent_param3", MySqlDbType.VarChar, 0);
			MySqlParameter event_param4Parameter = new MySqlParameter("@newevent_param4", MySqlDbType.VarChar, 0);
			MySqlParameter action_typeParameter = new MySqlParameter("@newaction_type", MySqlDbType.VarChar, 0);
			MySqlParameter action_param1Parameter = new MySqlParameter("@newaction_param1", MySqlDbType.VarChar, 0);
			MySqlParameter action_param2Parameter = new MySqlParameter("@newaction_param2", MySqlDbType.VarChar, 0);
			MySqlParameter action_param3Parameter = new MySqlParameter("@newaction_param3", MySqlDbType.VarChar, 0);
			MySqlParameter action_param4Parameter = new MySqlParameter("@newaction_param4", MySqlDbType.VarChar, 0);
			MySqlParameter action_param5Parameter = new MySqlParameter("@newaction_param5", MySqlDbType.VarChar, 0);
			MySqlParameter action_param6Parameter = new MySqlParameter("@newaction_param6", MySqlDbType.VarChar, 0);
			MySqlParameter target_typeParameter = new MySqlParameter("@newtarget_type", MySqlDbType.VarChar, 0);
			MySqlParameter target_param1Parameter = new MySqlParameter("@newtarget_param1", MySqlDbType.VarChar, 0);
			MySqlParameter target_param2Parameter = new MySqlParameter("@newtarget_param2", MySqlDbType.VarChar, 0);
			MySqlParameter target_param3Parameter = new MySqlParameter("@newtarget_param3", MySqlDbType.VarChar, 0);
			MySqlParameter target_xParameter = new MySqlParameter("@newtarget_x", MySqlDbType.VarChar, 0);
			MySqlParameter target_yParameter = new MySqlParameter("@newtarget_y", MySqlDbType.VarChar, 0);
			MySqlParameter target_zParameter = new MySqlParameter("@newtarget_z", MySqlDbType.VarChar, 0);
			MySqlParameter target_oParameter = new MySqlParameter("@newtarget_o", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@newcomment", MySqlDbType.VarChar, 0);
			entryorguidParameter.Value = entryorguid;
			source_typeParameter.Value = source_type;
			idParameter.Value = id;
			linkParameter.Value = link;
			event_typeParameter.Value = event_type;
			event_phase_maskParameter.Value = event_phase_mask;
			event_chanceParameter.Value = event_chance;
			event_flagsParameter.Value = event_flags;
			event_param1Parameter.Value = event_param1;
			event_param2Parameter.Value = event_param2;
			event_param3Parameter.Value = event_param3;
			event_param4Parameter.Value = event_param4;
			action_typeParameter.Value = action_type;
			action_param1Parameter.Value = action_param1;
			action_param2Parameter.Value = action_param2;
			action_param3Parameter.Value = action_param3;
			action_param4Parameter.Value = action_param4;
			action_param5Parameter.Value = action_param5;
			action_param6Parameter.Value = action_param6;
			target_typeParameter.Value = target_type;
			target_param1Parameter.Value = target_param1;
			target_param2Parameter.Value = target_param2;
			target_param3Parameter.Value = target_param3;
			target_xParameter.Value = target_x;
			target_yParameter.Value = target_y;
			target_zParameter.Value = target_z;
			target_oParameter.Value = target_o;
			commentParameter.Value = comment;
			OLD_entryorguidParameter.Value = OLD_entryorguid;
			OLD_source_typeParameter.Value = OLD_source_type;
			OLD_idParameter.Value = OLD_id;
			OLD_linkParameter.Value = OLD_link;
			OLD_event_typeParameter.Value = OLD_event_type;
			OLD_event_phase_maskParameter.Value = OLD_event_phase_mask;
			OLD_event_chanceParameter.Value = OLD_event_chance;
			OLD_event_flagsParameter.Value = OLD_event_flags;
			OLD_event_param1Parameter.Value = OLD_event_param1;
			OLD_event_param2Parameter.Value = OLD_event_param2;
			OLD_event_param3Parameter.Value = OLD_event_param3;
			OLD_event_param4Parameter.Value = OLD_event_param4;
			OLD_action_typeParameter.Value = OLD_action_type;
			OLD_action_param1Parameter.Value = OLD_action_param1;
			OLD_action_param2Parameter.Value = OLD_action_param2;
			OLD_action_param3Parameter.Value = OLD_action_param3;
			OLD_action_param4Parameter.Value = OLD_action_param4;
			OLD_action_param5Parameter.Value = OLD_action_param5;
			OLD_action_param6Parameter.Value = OLD_action_param6;
			OLD_target_typeParameter.Value = OLD_target_type;
			OLD_target_param1Parameter.Value = OLD_target_param1;
			OLD_target_param2Parameter.Value = OLD_target_param2;
			OLD_target_param3Parameter.Value = OLD_target_param3;
			OLD_target_xParameter.Value = OLD_target_x;
			OLD_target_yParameter.Value = OLD_target_y;
			OLD_target_zParameter.Value = OLD_target_z;
			OLD_target_oParameter.Value = OLD_target_o;
			OLD_commentParameter.Value = OLD_comment;
			cmd.Parameters.Add(entryorguidParameter);
			cmd.Parameters.Add(source_typeParameter);
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(linkParameter);
			cmd.Parameters.Add(event_typeParameter);
			cmd.Parameters.Add(event_phase_maskParameter);
			cmd.Parameters.Add(event_chanceParameter);
			cmd.Parameters.Add(event_flagsParameter);
			cmd.Parameters.Add(event_param1Parameter);
			cmd.Parameters.Add(event_param2Parameter);
			cmd.Parameters.Add(event_param3Parameter);
			cmd.Parameters.Add(event_param4Parameter);
			cmd.Parameters.Add(action_typeParameter);
			cmd.Parameters.Add(action_param1Parameter);
			cmd.Parameters.Add(action_param2Parameter);
			cmd.Parameters.Add(action_param3Parameter);
			cmd.Parameters.Add(action_param4Parameter);
			cmd.Parameters.Add(action_param5Parameter);
			cmd.Parameters.Add(action_param6Parameter);
			cmd.Parameters.Add(target_typeParameter);
			cmd.Parameters.Add(target_param1Parameter);
			cmd.Parameters.Add(target_param2Parameter);
			cmd.Parameters.Add(target_param3Parameter);
			cmd.Parameters.Add(target_xParameter);
			cmd.Parameters.Add(target_yParameter);
			cmd.Parameters.Add(target_zParameter);
			cmd.Parameters.Add(target_oParameter);
			cmd.Parameters.Add(commentParameter);
			cmd.Parameters.Add(OLD_entryorguidParameter);
			cmd.Parameters.Add(OLD_source_typeParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_linkParameter);
			cmd.Parameters.Add(OLD_event_typeParameter);
			cmd.Parameters.Add(OLD_event_phase_maskParameter);
			cmd.Parameters.Add(OLD_event_chanceParameter);
			cmd.Parameters.Add(OLD_event_flagsParameter);
			cmd.Parameters.Add(OLD_event_param1Parameter);
			cmd.Parameters.Add(OLD_event_param2Parameter);
			cmd.Parameters.Add(OLD_event_param3Parameter);
			cmd.Parameters.Add(OLD_event_param4Parameter);
			cmd.Parameters.Add(OLD_action_typeParameter);
			cmd.Parameters.Add(OLD_action_param1Parameter);
			cmd.Parameters.Add(OLD_action_param2Parameter);
			cmd.Parameters.Add(OLD_action_param3Parameter);
			cmd.Parameters.Add(OLD_action_param4Parameter);
			cmd.Parameters.Add(OLD_action_param5Parameter);
			cmd.Parameters.Add(OLD_action_param6Parameter);
			cmd.Parameters.Add(OLD_target_typeParameter);
			cmd.Parameters.Add(OLD_target_param1Parameter);
			cmd.Parameters.Add(OLD_target_param2Parameter);
			cmd.Parameters.Add(OLD_target_param3Parameter);
			cmd.Parameters.Add(OLD_target_xParameter);
			cmd.Parameters.Add(OLD_target_yParameter);
			cmd.Parameters.Add(OLD_target_zParameter);
			cmd.Parameters.Add(OLD_target_oParameter);
			cmd.Parameters.Add(OLD_commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_entryorguid = entryorguid;
			OLD_source_type = source_type;
			OLD_id = id;
			OLD_link = link;
			OLD_event_type = event_type;
			OLD_event_phase_mask = event_phase_mask;
			OLD_event_chance = event_chance;
			OLD_event_flags = event_flags;
			OLD_event_param1 = event_param1;
			OLD_event_param2 = event_param2;
			OLD_event_param3 = event_param3;
			OLD_event_param4 = event_param4;
			OLD_action_type = action_type;
			OLD_action_param1 = action_param1;
			OLD_action_param2 = action_param2;
			OLD_action_param3 = action_param3;
			OLD_action_param4 = action_param4;
			OLD_action_param5 = action_param5;
			OLD_action_param6 = action_param6;
			OLD_target_type = target_type;
			OLD_target_param1 = target_param1;
			OLD_target_param2 = target_param2;
			OLD_target_param3 = target_param3;
			OLD_target_x = target_x;
			OLD_target_y = target_y;
			OLD_target_z = target_z;
			OLD_target_o = target_o;
			OLD_comment = comment;
		}
	}
}
