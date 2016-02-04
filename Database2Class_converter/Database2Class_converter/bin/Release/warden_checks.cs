using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Warden_checks
	{
		int id = 0; //Comment: 
		int OLD_id = 0;

		int type = 0; //Comment: 
		int OLD_type = 0;

		string data = null; //Comment: 
		string OLD_data = null;

		string str = null; //Comment: 
		string OLD_str = null;

		int address = 0; //Comment: 
		int OLD_address = 0;

		int length = 0; //Comment: 
		int OLD_length = 0;

		string result = null; //Comment: 
		string OLD_result = null;

		string comment = null; //Comment: 
		string OLD_comment = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Warden_checks(int _id, int _type, string _data, string _str, int _address, int _length, string _result, string _comment)
		{
			id = _id;
			type = _type;
			data = _data;
			str = _str;
			address = _address;
			length = _length;
			result = _result;
			comment = _comment;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM warden_checks WHERE id = @id AND type = @type AND data = @data AND str = @str AND address = @address AND length = @length AND result = @result AND comment = @comment;";
			MySqlParameter idParameter = new MySqlParameter("@id", MySqlDbType.VarChar, 0);
			MySqlParameter typeParameter = new MySqlParameter("@type", MySqlDbType.VarChar, 0);
			MySqlParameter dataParameter = new MySqlParameter("@data", MySqlDbType.VarChar, 0);
			MySqlParameter strParameter = new MySqlParameter("@str", MySqlDbType.VarChar, 0);
			MySqlParameter addressParameter = new MySqlParameter("@address", MySqlDbType.VarChar, 0);
			MySqlParameter lengthParameter = new MySqlParameter("@length", MySqlDbType.VarChar, 0);
			MySqlParameter resultParameter = new MySqlParameter("@result", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@comment", MySqlDbType.VarChar, 0);
			idParameter.Value = id;
			typeParameter.Value = type;
			dataParameter.Value = data;
			strParameter.Value = str;
			addressParameter.Value = address;
			lengthParameter.Value = length;
			resultParameter.Value = result;
			commentParameter.Value = comment;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(typeParameter);
			cmd.Parameters.Add(dataParameter);
			cmd.Parameters.Add(strParameter);
			cmd.Parameters.Add(addressParameter);
			cmd.Parameters.Add(lengthParameter);
			cmd.Parameters.Add(resultParameter);
			cmd.Parameters.Add(commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE warden_checks SET id = @newid, type = @newtype, data = @newdata, str = @newstr, address = @newaddress, length = @newlength, result = @newresult, comment = @newcomment WHERE id = @id AND type = @type AND data = @data AND str = @str AND address = @address AND length = @length AND result = @result AND comment = @comment;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_typeParameter = new MySqlParameter("@type", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_dataParameter = new MySqlParameter("@data", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_strParameter = new MySqlParameter("@str", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_addressParameter = new MySqlParameter("@address", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_lengthParameter = new MySqlParameter("@length", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_resultParameter = new MySqlParameter("@result", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_commentParameter = new MySqlParameter("@comment", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newid", MySqlDbType.VarChar, 0);
			MySqlParameter typeParameter = new MySqlParameter("@newtype", MySqlDbType.VarChar, 0);
			MySqlParameter dataParameter = new MySqlParameter("@newdata", MySqlDbType.VarChar, 0);
			MySqlParameter strParameter = new MySqlParameter("@newstr", MySqlDbType.VarChar, 0);
			MySqlParameter addressParameter = new MySqlParameter("@newaddress", MySqlDbType.VarChar, 0);
			MySqlParameter lengthParameter = new MySqlParameter("@newlength", MySqlDbType.VarChar, 0);
			MySqlParameter resultParameter = new MySqlParameter("@newresult", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@newcomment", MySqlDbType.VarChar, 0);
			idParameter.Value = id;
			typeParameter.Value = type;
			dataParameter.Value = data;
			strParameter.Value = str;
			addressParameter.Value = address;
			lengthParameter.Value = length;
			resultParameter.Value = result;
			commentParameter.Value = comment;
			OLD_idParameter.Value = OLD_id;
			OLD_typeParameter.Value = OLD_type;
			OLD_dataParameter.Value = OLD_data;
			OLD_strParameter.Value = OLD_str;
			OLD_addressParameter.Value = OLD_address;
			OLD_lengthParameter.Value = OLD_length;
			OLD_resultParameter.Value = OLD_result;
			OLD_commentParameter.Value = OLD_comment;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(typeParameter);
			cmd.Parameters.Add(dataParameter);
			cmd.Parameters.Add(strParameter);
			cmd.Parameters.Add(addressParameter);
			cmd.Parameters.Add(lengthParameter);
			cmd.Parameters.Add(resultParameter);
			cmd.Parameters.Add(commentParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_typeParameter);
			cmd.Parameters.Add(OLD_dataParameter);
			cmd.Parameters.Add(OLD_strParameter);
			cmd.Parameters.Add(OLD_addressParameter);
			cmd.Parameters.Add(OLD_lengthParameter);
			cmd.Parameters.Add(OLD_resultParameter);
			cmd.Parameters.Add(OLD_commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_id = id;
			OLD_type = type;
			OLD_data = data;
			OLD_str = str;
			OLD_address = address;
			OLD_length = length;
			OLD_result = result;
			OLD_comment = comment;
		}
	}
}
