using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Spell_scripts
	{
		int id = 0; //Comment: 
		int OLD_id = 0;

		int effIndex = 0; //Comment: 
		int OLD_effIndex = 0;

		int delay = 0; //Comment: 
		int OLD_delay = 0;

		int command = 0; //Comment: 
		int OLD_command = 0;

		int datalong = 0; //Comment: 
		int OLD_datalong = 0;

		int datalong2 = 0; //Comment: 
		int OLD_datalong2 = 0;

		int dataint = 0; //Comment: 
		int OLD_dataint = 0;

		float x = 0f; //Comment: 
		float OLD_x = 0f;

		float y = 0f; //Comment: 
		float OLD_y = 0f;

		float z = 0f; //Comment: 
		float OLD_z = 0f;

		float o = 0f; //Comment: 
		float OLD_o = 0f;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Spell_scripts(int _id, int _effIndex, int _delay, int _command, int _datalong, int _datalong2, int _dataint, float _x, float _y, float _z, float _o)
		{
			id = _id;
			effIndex = _effIndex;
			delay = _delay;
			command = _command;
			datalong = _datalong;
			datalong2 = _datalong2;
			dataint = _dataint;
			x = _x;
			y = _y;
			z = _z;
			o = _o;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM spell_scripts WHERE id = @id AND effIndex = @effIndex AND delay = @delay AND command = @command AND datalong = @datalong AND datalong2 = @datalong2 AND dataint = @dataint AND x = @x AND y = @y AND z = @z AND o = @o;";
			MySqlParameter idParameter = new MySqlParameter("@id", MySqlDbType.VarChar, 0);
			MySqlParameter effindexParameter = new MySqlParameter("@effIndex", MySqlDbType.VarChar, 0);
			MySqlParameter delayParameter = new MySqlParameter("@delay", MySqlDbType.VarChar, 0);
			MySqlParameter commandParameter = new MySqlParameter("@command", MySqlDbType.VarChar, 0);
			MySqlParameter datalongParameter = new MySqlParameter("@datalong", MySqlDbType.VarChar, 0);
			MySqlParameter datalong2Parameter = new MySqlParameter("@datalong2", MySqlDbType.VarChar, 0);
			MySqlParameter dataintParameter = new MySqlParameter("@dataint", MySqlDbType.VarChar, 0);
			MySqlParameter xParameter = new MySqlParameter("@x", MySqlDbType.VarChar, 0);
			MySqlParameter yParameter = new MySqlParameter("@y", MySqlDbType.VarChar, 0);
			MySqlParameter zParameter = new MySqlParameter("@z", MySqlDbType.VarChar, 0);
			MySqlParameter oParameter = new MySqlParameter("@o", MySqlDbType.VarChar, 0);
			idParameter.Value = id;
			effindexParameter.Value = effIndex;
			delayParameter.Value = delay;
			commandParameter.Value = command;
			datalongParameter.Value = datalong;
			datalong2Parameter.Value = datalong2;
			dataintParameter.Value = dataint;
			xParameter.Value = x;
			yParameter.Value = y;
			zParameter.Value = z;
			oParameter.Value = o;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(effindexParameter);
			cmd.Parameters.Add(delayParameter);
			cmd.Parameters.Add(commandParameter);
			cmd.Parameters.Add(datalongParameter);
			cmd.Parameters.Add(datalong2Parameter);
			cmd.Parameters.Add(dataintParameter);
			cmd.Parameters.Add(xParameter);
			cmd.Parameters.Add(yParameter);
			cmd.Parameters.Add(zParameter);
			cmd.Parameters.Add(oParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE spell_scripts SET id = @newid, effIndex = @neweffIndex, delay = @newdelay, command = @newcommand, datalong = @newdatalong, datalong2 = @newdatalong2, dataint = @newdataint, x = @newx, y = @newy, z = @newz, o = @newo WHERE id = @id AND effIndex = @effIndex AND delay = @delay AND command = @command AND datalong = @datalong AND datalong2 = @datalong2 AND dataint = @dataint AND x = @x AND y = @y AND z = @z AND o = @o;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_effindexParameter = new MySqlParameter("@effIndex", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_delayParameter = new MySqlParameter("@delay", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_commandParameter = new MySqlParameter("@command", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_datalongParameter = new MySqlParameter("@datalong", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_datalong2Parameter = new MySqlParameter("@datalong2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_dataintParameter = new MySqlParameter("@dataint", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_xParameter = new MySqlParameter("@x", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_yParameter = new MySqlParameter("@y", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_zParameter = new MySqlParameter("@z", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_oParameter = new MySqlParameter("@o", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newid", MySqlDbType.VarChar, 0);
			MySqlParameter effindexParameter = new MySqlParameter("@neweffIndex", MySqlDbType.VarChar, 0);
			MySqlParameter delayParameter = new MySqlParameter("@newdelay", MySqlDbType.VarChar, 0);
			MySqlParameter commandParameter = new MySqlParameter("@newcommand", MySqlDbType.VarChar, 0);
			MySqlParameter datalongParameter = new MySqlParameter("@newdatalong", MySqlDbType.VarChar, 0);
			MySqlParameter datalong2Parameter = new MySqlParameter("@newdatalong2", MySqlDbType.VarChar, 0);
			MySqlParameter dataintParameter = new MySqlParameter("@newdataint", MySqlDbType.VarChar, 0);
			MySqlParameter xParameter = new MySqlParameter("@newx", MySqlDbType.VarChar, 0);
			MySqlParameter yParameter = new MySqlParameter("@newy", MySqlDbType.VarChar, 0);
			MySqlParameter zParameter = new MySqlParameter("@newz", MySqlDbType.VarChar, 0);
			MySqlParameter oParameter = new MySqlParameter("@newo", MySqlDbType.VarChar, 0);
			idParameter.Value = id;
			effindexParameter.Value = effIndex;
			delayParameter.Value = delay;
			commandParameter.Value = command;
			datalongParameter.Value = datalong;
			datalong2Parameter.Value = datalong2;
			dataintParameter.Value = dataint;
			xParameter.Value = x;
			yParameter.Value = y;
			zParameter.Value = z;
			oParameter.Value = o;
			OLD_idParameter.Value = OLD_id;
			OLD_effindexParameter.Value = OLD_effIndex;
			OLD_delayParameter.Value = OLD_delay;
			OLD_commandParameter.Value = OLD_command;
			OLD_datalongParameter.Value = OLD_datalong;
			OLD_datalong2Parameter.Value = OLD_datalong2;
			OLD_dataintParameter.Value = OLD_dataint;
			OLD_xParameter.Value = OLD_x;
			OLD_yParameter.Value = OLD_y;
			OLD_zParameter.Value = OLD_z;
			OLD_oParameter.Value = OLD_o;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(effindexParameter);
			cmd.Parameters.Add(delayParameter);
			cmd.Parameters.Add(commandParameter);
			cmd.Parameters.Add(datalongParameter);
			cmd.Parameters.Add(datalong2Parameter);
			cmd.Parameters.Add(dataintParameter);
			cmd.Parameters.Add(xParameter);
			cmd.Parameters.Add(yParameter);
			cmd.Parameters.Add(zParameter);
			cmd.Parameters.Add(oParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_effindexParameter);
			cmd.Parameters.Add(OLD_delayParameter);
			cmd.Parameters.Add(OLD_commandParameter);
			cmd.Parameters.Add(OLD_datalongParameter);
			cmd.Parameters.Add(OLD_datalong2Parameter);
			cmd.Parameters.Add(OLD_dataintParameter);
			cmd.Parameters.Add(OLD_xParameter);
			cmd.Parameters.Add(OLD_yParameter);
			cmd.Parameters.Add(OLD_zParameter);
			cmd.Parameters.Add(OLD_oParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_id = id;
			OLD_effIndex = effIndex;
			OLD_delay = delay;
			OLD_command = command;
			OLD_datalong = datalong;
			OLD_datalong2 = datalong2;
			OLD_dataint = dataint;
			OLD_x = x;
			OLD_y = y;
			OLD_z = z;
			OLD_o = o;
		}
	}
}
