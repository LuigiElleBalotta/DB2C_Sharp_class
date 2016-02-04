using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Skill_tiers
	{
		int ID = 0; //Comment: 
		int OLD_ID = 0;

		int Value1 = 0; //Comment: 
		int OLD_Value1 = 0;

		int Value2 = 0; //Comment: 
		int OLD_Value2 = 0;

		int Value3 = 0; //Comment: 
		int OLD_Value3 = 0;

		int Value4 = 0; //Comment: 
		int OLD_Value4 = 0;

		int Value5 = 0; //Comment: 
		int OLD_Value5 = 0;

		int Value6 = 0; //Comment: 
		int OLD_Value6 = 0;

		int Value7 = 0; //Comment: 
		int OLD_Value7 = 0;

		int Value8 = 0; //Comment: 
		int OLD_Value8 = 0;

		int Value9 = 0; //Comment: 
		int OLD_Value9 = 0;

		int Value10 = 0; //Comment: 
		int OLD_Value10 = 0;

		int Value11 = 0; //Comment: 
		int OLD_Value11 = 0;

		int Value12 = 0; //Comment: 
		int OLD_Value12 = 0;

		int Value13 = 0; //Comment: 
		int OLD_Value13 = 0;

		int Value14 = 0; //Comment: 
		int OLD_Value14 = 0;

		int Value15 = 0; //Comment: 
		int OLD_Value15 = 0;

		int Value16 = 0; //Comment: 
		int OLD_Value16 = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Skill_tiers(int _ID, int _Value1, int _Value2, int _Value3, int _Value4, int _Value5, int _Value6, int _Value7, int _Value8, int _Value9, int _Value10, int _Value11, int _Value12, int _Value13, int _Value14, int _Value15, int _Value16)
		{
			ID = _ID;
			Value1 = _Value1;
			Value2 = _Value2;
			Value3 = _Value3;
			Value4 = _Value4;
			Value5 = _Value5;
			Value6 = _Value6;
			Value7 = _Value7;
			Value8 = _Value8;
			Value9 = _Value9;
			Value10 = _Value10;
			Value11 = _Value11;
			Value12 = _Value12;
			Value13 = _Value13;
			Value14 = _Value14;
			Value15 = _Value15;
			Value16 = _Value16;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM skill_tiers WHERE ID = @ID AND Value1 = @Value1 AND Value2 = @Value2 AND Value3 = @Value3 AND Value4 = @Value4 AND Value5 = @Value5 AND Value6 = @Value6 AND Value7 = @Value7 AND Value8 = @Value8 AND Value9 = @Value9 AND Value10 = @Value10 AND Value11 = @Value11 AND Value12 = @Value12 AND Value13 = @Value13 AND Value14 = @Value14 AND Value15 = @Value15 AND Value16 = @Value16;";
			MySqlParameter idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter value1Parameter = new MySqlParameter("@Value1", MySqlDbType.VarChar, 0);
			MySqlParameter value2Parameter = new MySqlParameter("@Value2", MySqlDbType.VarChar, 0);
			MySqlParameter value3Parameter = new MySqlParameter("@Value3", MySqlDbType.VarChar, 0);
			MySqlParameter value4Parameter = new MySqlParameter("@Value4", MySqlDbType.VarChar, 0);
			MySqlParameter value5Parameter = new MySqlParameter("@Value5", MySqlDbType.VarChar, 0);
			MySqlParameter value6Parameter = new MySqlParameter("@Value6", MySqlDbType.VarChar, 0);
			MySqlParameter value7Parameter = new MySqlParameter("@Value7", MySqlDbType.VarChar, 0);
			MySqlParameter value8Parameter = new MySqlParameter("@Value8", MySqlDbType.VarChar, 0);
			MySqlParameter value9Parameter = new MySqlParameter("@Value9", MySqlDbType.VarChar, 0);
			MySqlParameter value10Parameter = new MySqlParameter("@Value10", MySqlDbType.VarChar, 0);
			MySqlParameter value11Parameter = new MySqlParameter("@Value11", MySqlDbType.VarChar, 0);
			MySqlParameter value12Parameter = new MySqlParameter("@Value12", MySqlDbType.VarChar, 0);
			MySqlParameter value13Parameter = new MySqlParameter("@Value13", MySqlDbType.VarChar, 0);
			MySqlParameter value14Parameter = new MySqlParameter("@Value14", MySqlDbType.VarChar, 0);
			MySqlParameter value15Parameter = new MySqlParameter("@Value15", MySqlDbType.VarChar, 0);
			MySqlParameter value16Parameter = new MySqlParameter("@Value16", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			value1Parameter.Value = Value1;
			value2Parameter.Value = Value2;
			value3Parameter.Value = Value3;
			value4Parameter.Value = Value4;
			value5Parameter.Value = Value5;
			value6Parameter.Value = Value6;
			value7Parameter.Value = Value7;
			value8Parameter.Value = Value8;
			value9Parameter.Value = Value9;
			value10Parameter.Value = Value10;
			value11Parameter.Value = Value11;
			value12Parameter.Value = Value12;
			value13Parameter.Value = Value13;
			value14Parameter.Value = Value14;
			value15Parameter.Value = Value15;
			value16Parameter.Value = Value16;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(value1Parameter);
			cmd.Parameters.Add(value2Parameter);
			cmd.Parameters.Add(value3Parameter);
			cmd.Parameters.Add(value4Parameter);
			cmd.Parameters.Add(value5Parameter);
			cmd.Parameters.Add(value6Parameter);
			cmd.Parameters.Add(value7Parameter);
			cmd.Parameters.Add(value8Parameter);
			cmd.Parameters.Add(value9Parameter);
			cmd.Parameters.Add(value10Parameter);
			cmd.Parameters.Add(value11Parameter);
			cmd.Parameters.Add(value12Parameter);
			cmd.Parameters.Add(value13Parameter);
			cmd.Parameters.Add(value14Parameter);
			cmd.Parameters.Add(value15Parameter);
			cmd.Parameters.Add(value16Parameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE skill_tiers SET ID = @newID, Value1 = @newValue1, Value2 = @newValue2, Value3 = @newValue3, Value4 = @newValue4, Value5 = @newValue5, Value6 = @newValue6, Value7 = @newValue7, Value8 = @newValue8, Value9 = @newValue9, Value10 = @newValue10, Value11 = @newValue11, Value12 = @newValue12, Value13 = @newValue13, Value14 = @newValue14, Value15 = @newValue15, Value16 = @newValue16 WHERE ID = @ID AND Value1 = @Value1 AND Value2 = @Value2 AND Value3 = @Value3 AND Value4 = @Value4 AND Value5 = @Value5 AND Value6 = @Value6 AND Value7 = @Value7 AND Value8 = @Value8 AND Value9 = @Value9 AND Value10 = @Value10 AND Value11 = @Value11 AND Value12 = @Value12 AND Value13 = @Value13 AND Value14 = @Value14 AND Value15 = @Value15 AND Value16 = @Value16;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_value1Parameter = new MySqlParameter("@Value1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_value2Parameter = new MySqlParameter("@Value2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_value3Parameter = new MySqlParameter("@Value3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_value4Parameter = new MySqlParameter("@Value4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_value5Parameter = new MySqlParameter("@Value5", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_value6Parameter = new MySqlParameter("@Value6", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_value7Parameter = new MySqlParameter("@Value7", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_value8Parameter = new MySqlParameter("@Value8", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_value9Parameter = new MySqlParameter("@Value9", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_value10Parameter = new MySqlParameter("@Value10", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_value11Parameter = new MySqlParameter("@Value11", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_value12Parameter = new MySqlParameter("@Value12", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_value13Parameter = new MySqlParameter("@Value13", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_value14Parameter = new MySqlParameter("@Value14", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_value15Parameter = new MySqlParameter("@Value15", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_value16Parameter = new MySqlParameter("@Value16", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newID", MySqlDbType.VarChar, 0);
			MySqlParameter value1Parameter = new MySqlParameter("@newValue1", MySqlDbType.VarChar, 0);
			MySqlParameter value2Parameter = new MySqlParameter("@newValue2", MySqlDbType.VarChar, 0);
			MySqlParameter value3Parameter = new MySqlParameter("@newValue3", MySqlDbType.VarChar, 0);
			MySqlParameter value4Parameter = new MySqlParameter("@newValue4", MySqlDbType.VarChar, 0);
			MySqlParameter value5Parameter = new MySqlParameter("@newValue5", MySqlDbType.VarChar, 0);
			MySqlParameter value6Parameter = new MySqlParameter("@newValue6", MySqlDbType.VarChar, 0);
			MySqlParameter value7Parameter = new MySqlParameter("@newValue7", MySqlDbType.VarChar, 0);
			MySqlParameter value8Parameter = new MySqlParameter("@newValue8", MySqlDbType.VarChar, 0);
			MySqlParameter value9Parameter = new MySqlParameter("@newValue9", MySqlDbType.VarChar, 0);
			MySqlParameter value10Parameter = new MySqlParameter("@newValue10", MySqlDbType.VarChar, 0);
			MySqlParameter value11Parameter = new MySqlParameter("@newValue11", MySqlDbType.VarChar, 0);
			MySqlParameter value12Parameter = new MySqlParameter("@newValue12", MySqlDbType.VarChar, 0);
			MySqlParameter value13Parameter = new MySqlParameter("@newValue13", MySqlDbType.VarChar, 0);
			MySqlParameter value14Parameter = new MySqlParameter("@newValue14", MySqlDbType.VarChar, 0);
			MySqlParameter value15Parameter = new MySqlParameter("@newValue15", MySqlDbType.VarChar, 0);
			MySqlParameter value16Parameter = new MySqlParameter("@newValue16", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			value1Parameter.Value = Value1;
			value2Parameter.Value = Value2;
			value3Parameter.Value = Value3;
			value4Parameter.Value = Value4;
			value5Parameter.Value = Value5;
			value6Parameter.Value = Value6;
			value7Parameter.Value = Value7;
			value8Parameter.Value = Value8;
			value9Parameter.Value = Value9;
			value10Parameter.Value = Value10;
			value11Parameter.Value = Value11;
			value12Parameter.Value = Value12;
			value13Parameter.Value = Value13;
			value14Parameter.Value = Value14;
			value15Parameter.Value = Value15;
			value16Parameter.Value = Value16;
			OLD_idParameter.Value = OLD_ID;
			OLD_value1Parameter.Value = OLD_Value1;
			OLD_value2Parameter.Value = OLD_Value2;
			OLD_value3Parameter.Value = OLD_Value3;
			OLD_value4Parameter.Value = OLD_Value4;
			OLD_value5Parameter.Value = OLD_Value5;
			OLD_value6Parameter.Value = OLD_Value6;
			OLD_value7Parameter.Value = OLD_Value7;
			OLD_value8Parameter.Value = OLD_Value8;
			OLD_value9Parameter.Value = OLD_Value9;
			OLD_value10Parameter.Value = OLD_Value10;
			OLD_value11Parameter.Value = OLD_Value11;
			OLD_value12Parameter.Value = OLD_Value12;
			OLD_value13Parameter.Value = OLD_Value13;
			OLD_value14Parameter.Value = OLD_Value14;
			OLD_value15Parameter.Value = OLD_Value15;
			OLD_value16Parameter.Value = OLD_Value16;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(value1Parameter);
			cmd.Parameters.Add(value2Parameter);
			cmd.Parameters.Add(value3Parameter);
			cmd.Parameters.Add(value4Parameter);
			cmd.Parameters.Add(value5Parameter);
			cmd.Parameters.Add(value6Parameter);
			cmd.Parameters.Add(value7Parameter);
			cmd.Parameters.Add(value8Parameter);
			cmd.Parameters.Add(value9Parameter);
			cmd.Parameters.Add(value10Parameter);
			cmd.Parameters.Add(value11Parameter);
			cmd.Parameters.Add(value12Parameter);
			cmd.Parameters.Add(value13Parameter);
			cmd.Parameters.Add(value14Parameter);
			cmd.Parameters.Add(value15Parameter);
			cmd.Parameters.Add(value16Parameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_value1Parameter);
			cmd.Parameters.Add(OLD_value2Parameter);
			cmd.Parameters.Add(OLD_value3Parameter);
			cmd.Parameters.Add(OLD_value4Parameter);
			cmd.Parameters.Add(OLD_value5Parameter);
			cmd.Parameters.Add(OLD_value6Parameter);
			cmd.Parameters.Add(OLD_value7Parameter);
			cmd.Parameters.Add(OLD_value8Parameter);
			cmd.Parameters.Add(OLD_value9Parameter);
			cmd.Parameters.Add(OLD_value10Parameter);
			cmd.Parameters.Add(OLD_value11Parameter);
			cmd.Parameters.Add(OLD_value12Parameter);
			cmd.Parameters.Add(OLD_value13Parameter);
			cmd.Parameters.Add(OLD_value14Parameter);
			cmd.Parameters.Add(OLD_value15Parameter);
			cmd.Parameters.Add(OLD_value16Parameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_ID = ID;
			OLD_Value1 = Value1;
			OLD_Value2 = Value2;
			OLD_Value3 = Value3;
			OLD_Value4 = Value4;
			OLD_Value5 = Value5;
			OLD_Value6 = Value6;
			OLD_Value7 = Value7;
			OLD_Value8 = Value8;
			OLD_Value9 = Value9;
			OLD_Value10 = Value10;
			OLD_Value11 = Value11;
			OLD_Value12 = Value12;
			OLD_Value13 = Value13;
			OLD_Value14 = Value14;
			OLD_Value15 = Value15;
			OLD_Value16 = Value16;
		}
	}
}
