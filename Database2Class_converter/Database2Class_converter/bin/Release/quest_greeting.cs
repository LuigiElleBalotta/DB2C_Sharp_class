using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Quest_greeting
	{
		int ID = 0; //Comment: 
		int OLD_ID = 0;

		int Type = 0; //Comment: 
		int OLD_Type = 0;

		int GreetEmoteType = 0; //Comment: 
		int OLD_GreetEmoteType = 0;

		int GreetEmoteDelay = 0; //Comment: 
		int OLD_GreetEmoteDelay = 0;

		string Greeting = null; //Comment: 
		string OLD_Greeting = null;

		int VerifiedBuild = 0; //Comment: 
		int OLD_VerifiedBuild = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Quest_greeting(int _ID, int _Type, int _GreetEmoteType, int _GreetEmoteDelay, string _Greeting, int _VerifiedBuild)
		{
			ID = _ID;
			Type = _Type;
			GreetEmoteType = _GreetEmoteType;
			GreetEmoteDelay = _GreetEmoteDelay;
			Greeting = _Greeting;
			VerifiedBuild = _VerifiedBuild;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM quest_greeting WHERE ID = @ID AND Type = @Type AND GreetEmoteType = @GreetEmoteType AND GreetEmoteDelay = @GreetEmoteDelay AND Greeting = @Greeting AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter typeParameter = new MySqlParameter("@Type", MySqlDbType.VarChar, 0);
			MySqlParameter greetemotetypeParameter = new MySqlParameter("@GreetEmoteType", MySqlDbType.VarChar, 0);
			MySqlParameter greetemotedelayParameter = new MySqlParameter("@GreetEmoteDelay", MySqlDbType.VarChar, 0);
			MySqlParameter greetingParameter = new MySqlParameter("@Greeting", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			typeParameter.Value = Type;
			greetemotetypeParameter.Value = GreetEmoteType;
			greetemotedelayParameter.Value = GreetEmoteDelay;
			greetingParameter.Value = Greeting;
			verifiedbuildParameter.Value = VerifiedBuild;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(typeParameter);
			cmd.Parameters.Add(greetemotetypeParameter);
			cmd.Parameters.Add(greetemotedelayParameter);
			cmd.Parameters.Add(greetingParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE quest_greeting SET ID = @newID, Type = @newType, GreetEmoteType = @newGreetEmoteType, GreetEmoteDelay = @newGreetEmoteDelay, Greeting = @newGreeting, VerifiedBuild = @newVerifiedBuild WHERE ID = @ID AND Type = @Type AND GreetEmoteType = @GreetEmoteType AND GreetEmoteDelay = @GreetEmoteDelay AND Greeting = @Greeting AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_typeParameter = new MySqlParameter("@Type", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_greetemotetypeParameter = new MySqlParameter("@GreetEmoteType", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_greetemotedelayParameter = new MySqlParameter("@GreetEmoteDelay", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_greetingParameter = new MySqlParameter("@Greeting", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newID", MySqlDbType.VarChar, 0);
			MySqlParameter typeParameter = new MySqlParameter("@newType", MySqlDbType.VarChar, 0);
			MySqlParameter greetemotetypeParameter = new MySqlParameter("@newGreetEmoteType", MySqlDbType.VarChar, 0);
			MySqlParameter greetemotedelayParameter = new MySqlParameter("@newGreetEmoteDelay", MySqlDbType.VarChar, 0);
			MySqlParameter greetingParameter = new MySqlParameter("@newGreeting", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@newVerifiedBuild", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			typeParameter.Value = Type;
			greetemotetypeParameter.Value = GreetEmoteType;
			greetemotedelayParameter.Value = GreetEmoteDelay;
			greetingParameter.Value = Greeting;
			verifiedbuildParameter.Value = VerifiedBuild;
			OLD_idParameter.Value = OLD_ID;
			OLD_typeParameter.Value = OLD_Type;
			OLD_greetemotetypeParameter.Value = OLD_GreetEmoteType;
			OLD_greetemotedelayParameter.Value = OLD_GreetEmoteDelay;
			OLD_greetingParameter.Value = OLD_Greeting;
			OLD_verifiedbuildParameter.Value = OLD_VerifiedBuild;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(typeParameter);
			cmd.Parameters.Add(greetemotetypeParameter);
			cmd.Parameters.Add(greetemotedelayParameter);
			cmd.Parameters.Add(greetingParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_typeParameter);
			cmd.Parameters.Add(OLD_greetemotetypeParameter);
			cmd.Parameters.Add(OLD_greetemotedelayParameter);
			cmd.Parameters.Add(OLD_greetingParameter);
			cmd.Parameters.Add(OLD_verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_ID = ID;
			OLD_Type = Type;
			OLD_GreetEmoteType = GreetEmoteType;
			OLD_GreetEmoteDelay = GreetEmoteDelay;
			OLD_Greeting = Greeting;
			OLD_VerifiedBuild = VerifiedBuild;
		}
	}
}
