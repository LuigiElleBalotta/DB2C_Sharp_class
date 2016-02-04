using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Conditions
	{
		int SourceTypeOrReferenceId = 0; //Comment: 
		int OLD_SourceTypeOrReferenceId = 0;

		int SourceGroup = 0; //Comment: 
		int OLD_SourceGroup = 0;

		int SourceEntry = 0; //Comment: 
		int OLD_SourceEntry = 0;

		int SourceId = 0; //Comment: 
		int OLD_SourceId = 0;

		int ElseGroup = 0; //Comment: 
		int OLD_ElseGroup = 0;

		int ConditionTypeOrReference = 0; //Comment: 
		int OLD_ConditionTypeOrReference = 0;

		int ConditionTarget = 0; //Comment: 
		int OLD_ConditionTarget = 0;

		int ConditionValue1 = 0; //Comment: 
		int OLD_ConditionValue1 = 0;

		int ConditionValue2 = 0; //Comment: 
		int OLD_ConditionValue2 = 0;

		int ConditionValue3 = 0; //Comment: 
		int OLD_ConditionValue3 = 0;

		int NegativeCondition = 0; //Comment: 
		int OLD_NegativeCondition = 0;

		int ErrorType = 0; //Comment: 
		int OLD_ErrorType = 0;

		int ErrorTextId = 0; //Comment: 
		int OLD_ErrorTextId = 0;

		char ScriptName = Char.MinValue; //Comment: 
		char OLD_ScriptName = Char.MinValue;

		string Comment = null; //Comment: 
		string OLD_Comment = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Conditions(int _SourceTypeOrReferenceId, int _SourceGroup, int _SourceEntry, int _SourceId, int _ElseGroup, int _ConditionTypeOrReference, int _ConditionTarget, int _ConditionValue1, int _ConditionValue2, int _ConditionValue3, int _NegativeCondition, int _ErrorType, int _ErrorTextId, char _ScriptName, string _Comment)
		{
			SourceTypeOrReferenceId = _SourceTypeOrReferenceId;
			SourceGroup = _SourceGroup;
			SourceEntry = _SourceEntry;
			SourceId = _SourceId;
			ElseGroup = _ElseGroup;
			ConditionTypeOrReference = _ConditionTypeOrReference;
			ConditionTarget = _ConditionTarget;
			ConditionValue1 = _ConditionValue1;
			ConditionValue2 = _ConditionValue2;
			ConditionValue3 = _ConditionValue3;
			NegativeCondition = _NegativeCondition;
			ErrorType = _ErrorType;
			ErrorTextId = _ErrorTextId;
			ScriptName = _ScriptName;
			Comment = _Comment;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM conditions WHERE SourceTypeOrReferenceId = @SourceTypeOrReferenceId AND SourceGroup = @SourceGroup AND SourceEntry = @SourceEntry AND SourceId = @SourceId AND ElseGroup = @ElseGroup AND ConditionTypeOrReference = @ConditionTypeOrReference AND ConditionTarget = @ConditionTarget AND ConditionValue1 = @ConditionValue1 AND ConditionValue2 = @ConditionValue2 AND ConditionValue3 = @ConditionValue3 AND NegativeCondition = @NegativeCondition AND ErrorType = @ErrorType AND ErrorTextId = @ErrorTextId AND ScriptName = @ScriptName AND Comment = @Comment;";
			MySqlParameter sourcetypeorreferenceidParameter = new MySqlParameter("@SourceTypeOrReferenceId", MySqlDbType.VarChar, 0);
			MySqlParameter sourcegroupParameter = new MySqlParameter("@SourceGroup", MySqlDbType.VarChar, 0);
			MySqlParameter sourceentryParameter = new MySqlParameter("@SourceEntry", MySqlDbType.VarChar, 0);
			MySqlParameter sourceidParameter = new MySqlParameter("@SourceId", MySqlDbType.VarChar, 0);
			MySqlParameter elsegroupParameter = new MySqlParameter("@ElseGroup", MySqlDbType.VarChar, 0);
			MySqlParameter conditiontypeorreferenceParameter = new MySqlParameter("@ConditionTypeOrReference", MySqlDbType.VarChar, 0);
			MySqlParameter conditiontargetParameter = new MySqlParameter("@ConditionTarget", MySqlDbType.VarChar, 0);
			MySqlParameter conditionvalue1Parameter = new MySqlParameter("@ConditionValue1", MySqlDbType.VarChar, 0);
			MySqlParameter conditionvalue2Parameter = new MySqlParameter("@ConditionValue2", MySqlDbType.VarChar, 0);
			MySqlParameter conditionvalue3Parameter = new MySqlParameter("@ConditionValue3", MySqlDbType.VarChar, 0);
			MySqlParameter negativeconditionParameter = new MySqlParameter("@NegativeCondition", MySqlDbType.VarChar, 0);
			MySqlParameter errortypeParameter = new MySqlParameter("@ErrorType", MySqlDbType.VarChar, 0);
			MySqlParameter errortextidParameter = new MySqlParameter("@ErrorTextId", MySqlDbType.VarChar, 0);
			MySqlParameter scriptnameParameter = new MySqlParameter("@ScriptName", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@Comment", MySqlDbType.VarChar, 0);
			sourcetypeorreferenceidParameter.Value = SourceTypeOrReferenceId;
			sourcegroupParameter.Value = SourceGroup;
			sourceentryParameter.Value = SourceEntry;
			sourceidParameter.Value = SourceId;
			elsegroupParameter.Value = ElseGroup;
			conditiontypeorreferenceParameter.Value = ConditionTypeOrReference;
			conditiontargetParameter.Value = ConditionTarget;
			conditionvalue1Parameter.Value = ConditionValue1;
			conditionvalue2Parameter.Value = ConditionValue2;
			conditionvalue3Parameter.Value = ConditionValue3;
			negativeconditionParameter.Value = NegativeCondition;
			errortypeParameter.Value = ErrorType;
			errortextidParameter.Value = ErrorTextId;
			scriptnameParameter.Value = ScriptName;
			commentParameter.Value = Comment;
			cmd.Parameters.Add(sourcetypeorreferenceidParameter);
			cmd.Parameters.Add(sourcegroupParameter);
			cmd.Parameters.Add(sourceentryParameter);
			cmd.Parameters.Add(sourceidParameter);
			cmd.Parameters.Add(elsegroupParameter);
			cmd.Parameters.Add(conditiontypeorreferenceParameter);
			cmd.Parameters.Add(conditiontargetParameter);
			cmd.Parameters.Add(conditionvalue1Parameter);
			cmd.Parameters.Add(conditionvalue2Parameter);
			cmd.Parameters.Add(conditionvalue3Parameter);
			cmd.Parameters.Add(negativeconditionParameter);
			cmd.Parameters.Add(errortypeParameter);
			cmd.Parameters.Add(errortextidParameter);
			cmd.Parameters.Add(scriptnameParameter);
			cmd.Parameters.Add(commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE conditions SET SourceTypeOrReferenceId = @newSourceTypeOrReferenceId, SourceGroup = @newSourceGroup, SourceEntry = @newSourceEntry, SourceId = @newSourceId, ElseGroup = @newElseGroup, ConditionTypeOrReference = @newConditionTypeOrReference, ConditionTarget = @newConditionTarget, ConditionValue1 = @newConditionValue1, ConditionValue2 = @newConditionValue2, ConditionValue3 = @newConditionValue3, NegativeCondition = @newNegativeCondition, ErrorType = @newErrorType, ErrorTextId = @newErrorTextId, ScriptName = @newScriptName, Comment = @newComment WHERE SourceTypeOrReferenceId = @SourceTypeOrReferenceId AND SourceGroup = @SourceGroup AND SourceEntry = @SourceEntry AND SourceId = @SourceId AND ElseGroup = @ElseGroup AND ConditionTypeOrReference = @ConditionTypeOrReference AND ConditionTarget = @ConditionTarget AND ConditionValue1 = @ConditionValue1 AND ConditionValue2 = @ConditionValue2 AND ConditionValue3 = @ConditionValue3 AND NegativeCondition = @NegativeCondition AND ErrorType = @ErrorType AND ErrorTextId = @ErrorTextId AND ScriptName = @ScriptName AND Comment = @Comment;";
			MySqlParameter OLD_sourcetypeorreferenceidParameter = new MySqlParameter("@SourceTypeOrReferenceId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_sourcegroupParameter = new MySqlParameter("@SourceGroup", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_sourceentryParameter = new MySqlParameter("@SourceEntry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_sourceidParameter = new MySqlParameter("@SourceId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_elsegroupParameter = new MySqlParameter("@ElseGroup", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_conditiontypeorreferenceParameter = new MySqlParameter("@ConditionTypeOrReference", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_conditiontargetParameter = new MySqlParameter("@ConditionTarget", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_conditionvalue1Parameter = new MySqlParameter("@ConditionValue1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_conditionvalue2Parameter = new MySqlParameter("@ConditionValue2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_conditionvalue3Parameter = new MySqlParameter("@ConditionValue3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_negativeconditionParameter = new MySqlParameter("@NegativeCondition", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_errortypeParameter = new MySqlParameter("@ErrorType", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_errortextidParameter = new MySqlParameter("@ErrorTextId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_scriptnameParameter = new MySqlParameter("@ScriptName", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_commentParameter = new MySqlParameter("@Comment", MySqlDbType.VarChar, 0);
			MySqlParameter sourcetypeorreferenceidParameter = new MySqlParameter("@newSourceTypeOrReferenceId", MySqlDbType.VarChar, 0);
			MySqlParameter sourcegroupParameter = new MySqlParameter("@newSourceGroup", MySqlDbType.VarChar, 0);
			MySqlParameter sourceentryParameter = new MySqlParameter("@newSourceEntry", MySqlDbType.VarChar, 0);
			MySqlParameter sourceidParameter = new MySqlParameter("@newSourceId", MySqlDbType.VarChar, 0);
			MySqlParameter elsegroupParameter = new MySqlParameter("@newElseGroup", MySqlDbType.VarChar, 0);
			MySqlParameter conditiontypeorreferenceParameter = new MySqlParameter("@newConditionTypeOrReference", MySqlDbType.VarChar, 0);
			MySqlParameter conditiontargetParameter = new MySqlParameter("@newConditionTarget", MySqlDbType.VarChar, 0);
			MySqlParameter conditionvalue1Parameter = new MySqlParameter("@newConditionValue1", MySqlDbType.VarChar, 0);
			MySqlParameter conditionvalue2Parameter = new MySqlParameter("@newConditionValue2", MySqlDbType.VarChar, 0);
			MySqlParameter conditionvalue3Parameter = new MySqlParameter("@newConditionValue3", MySqlDbType.VarChar, 0);
			MySqlParameter negativeconditionParameter = new MySqlParameter("@newNegativeCondition", MySqlDbType.VarChar, 0);
			MySqlParameter errortypeParameter = new MySqlParameter("@newErrorType", MySqlDbType.VarChar, 0);
			MySqlParameter errortextidParameter = new MySqlParameter("@newErrorTextId", MySqlDbType.VarChar, 0);
			MySqlParameter scriptnameParameter = new MySqlParameter("@newScriptName", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@newComment", MySqlDbType.VarChar, 0);
			sourcetypeorreferenceidParameter.Value = SourceTypeOrReferenceId;
			sourcegroupParameter.Value = SourceGroup;
			sourceentryParameter.Value = SourceEntry;
			sourceidParameter.Value = SourceId;
			elsegroupParameter.Value = ElseGroup;
			conditiontypeorreferenceParameter.Value = ConditionTypeOrReference;
			conditiontargetParameter.Value = ConditionTarget;
			conditionvalue1Parameter.Value = ConditionValue1;
			conditionvalue2Parameter.Value = ConditionValue2;
			conditionvalue3Parameter.Value = ConditionValue3;
			negativeconditionParameter.Value = NegativeCondition;
			errortypeParameter.Value = ErrorType;
			errortextidParameter.Value = ErrorTextId;
			scriptnameParameter.Value = ScriptName;
			commentParameter.Value = Comment;
			OLD_sourcetypeorreferenceidParameter.Value = OLD_SourceTypeOrReferenceId;
			OLD_sourcegroupParameter.Value = OLD_SourceGroup;
			OLD_sourceentryParameter.Value = OLD_SourceEntry;
			OLD_sourceidParameter.Value = OLD_SourceId;
			OLD_elsegroupParameter.Value = OLD_ElseGroup;
			OLD_conditiontypeorreferenceParameter.Value = OLD_ConditionTypeOrReference;
			OLD_conditiontargetParameter.Value = OLD_ConditionTarget;
			OLD_conditionvalue1Parameter.Value = OLD_ConditionValue1;
			OLD_conditionvalue2Parameter.Value = OLD_ConditionValue2;
			OLD_conditionvalue3Parameter.Value = OLD_ConditionValue3;
			OLD_negativeconditionParameter.Value = OLD_NegativeCondition;
			OLD_errortypeParameter.Value = OLD_ErrorType;
			OLD_errortextidParameter.Value = OLD_ErrorTextId;
			OLD_scriptnameParameter.Value = OLD_ScriptName;
			OLD_commentParameter.Value = OLD_Comment;
			cmd.Parameters.Add(sourcetypeorreferenceidParameter);
			cmd.Parameters.Add(sourcegroupParameter);
			cmd.Parameters.Add(sourceentryParameter);
			cmd.Parameters.Add(sourceidParameter);
			cmd.Parameters.Add(elsegroupParameter);
			cmd.Parameters.Add(conditiontypeorreferenceParameter);
			cmd.Parameters.Add(conditiontargetParameter);
			cmd.Parameters.Add(conditionvalue1Parameter);
			cmd.Parameters.Add(conditionvalue2Parameter);
			cmd.Parameters.Add(conditionvalue3Parameter);
			cmd.Parameters.Add(negativeconditionParameter);
			cmd.Parameters.Add(errortypeParameter);
			cmd.Parameters.Add(errortextidParameter);
			cmd.Parameters.Add(scriptnameParameter);
			cmd.Parameters.Add(commentParameter);
			cmd.Parameters.Add(OLD_sourcetypeorreferenceidParameter);
			cmd.Parameters.Add(OLD_sourcegroupParameter);
			cmd.Parameters.Add(OLD_sourceentryParameter);
			cmd.Parameters.Add(OLD_sourceidParameter);
			cmd.Parameters.Add(OLD_elsegroupParameter);
			cmd.Parameters.Add(OLD_conditiontypeorreferenceParameter);
			cmd.Parameters.Add(OLD_conditiontargetParameter);
			cmd.Parameters.Add(OLD_conditionvalue1Parameter);
			cmd.Parameters.Add(OLD_conditionvalue2Parameter);
			cmd.Parameters.Add(OLD_conditionvalue3Parameter);
			cmd.Parameters.Add(OLD_negativeconditionParameter);
			cmd.Parameters.Add(OLD_errortypeParameter);
			cmd.Parameters.Add(OLD_errortextidParameter);
			cmd.Parameters.Add(OLD_scriptnameParameter);
			cmd.Parameters.Add(OLD_commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_SourceTypeOrReferenceId = SourceTypeOrReferenceId;
			OLD_SourceGroup = SourceGroup;
			OLD_SourceEntry = SourceEntry;
			OLD_SourceId = SourceId;
			OLD_ElseGroup = ElseGroup;
			OLD_ConditionTypeOrReference = ConditionTypeOrReference;
			OLD_ConditionTarget = ConditionTarget;
			OLD_ConditionValue1 = ConditionValue1;
			OLD_ConditionValue2 = ConditionValue2;
			OLD_ConditionValue3 = ConditionValue3;
			OLD_NegativeCondition = NegativeCondition;
			OLD_ErrorType = ErrorType;
			OLD_ErrorTextId = ErrorTextId;
			OLD_ScriptName = ScriptName;
			OLD_Comment = Comment;
		}
	}
}
