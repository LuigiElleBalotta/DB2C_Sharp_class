using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Points_of_interest
	{
		int ID = 0; //Comment: 
		int OLD_ID = 0;

		float PositionX = 0f; //Comment: 
		float OLD_PositionX = 0f;

		float PositionY = 0f; //Comment: 
		float OLD_PositionY = 0f;

		int Icon = 0; //Comment: 
		int OLD_Icon = 0;

		int Flags = 0; //Comment: 
		int OLD_Flags = 0;

		int Importance = 0; //Comment: 
		int OLD_Importance = 0;

		string Name = null; //Comment: 
		string OLD_Name = null;

		int VerifiedBuild = 0; //Comment: 
		int OLD_VerifiedBuild = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Points_of_interest(int _ID, float _PositionX, float _PositionY, int _Icon, int _Flags, int _Importance, string _Name, int _VerifiedBuild)
		{
			ID = _ID;
			PositionX = _PositionX;
			PositionY = _PositionY;
			Icon = _Icon;
			Flags = _Flags;
			Importance = _Importance;
			Name = _Name;
			VerifiedBuild = _VerifiedBuild;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM points_of_interest WHERE ID = @ID AND PositionX = @PositionX AND PositionY = @PositionY AND Icon = @Icon AND Flags = @Flags AND Importance = @Importance AND Name = @Name AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter positionxParameter = new MySqlParameter("@PositionX", MySqlDbType.VarChar, 0);
			MySqlParameter positionyParameter = new MySqlParameter("@PositionY", MySqlDbType.VarChar, 0);
			MySqlParameter iconParameter = new MySqlParameter("@Icon", MySqlDbType.VarChar, 0);
			MySqlParameter flagsParameter = new MySqlParameter("@Flags", MySqlDbType.VarChar, 0);
			MySqlParameter importanceParameter = new MySqlParameter("@Importance", MySqlDbType.VarChar, 0);
			MySqlParameter nameParameter = new MySqlParameter("@Name", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			positionxParameter.Value = PositionX;
			positionyParameter.Value = PositionY;
			iconParameter.Value = Icon;
			flagsParameter.Value = Flags;
			importanceParameter.Value = Importance;
			nameParameter.Value = Name;
			verifiedbuildParameter.Value = VerifiedBuild;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(positionxParameter);
			cmd.Parameters.Add(positionyParameter);
			cmd.Parameters.Add(iconParameter);
			cmd.Parameters.Add(flagsParameter);
			cmd.Parameters.Add(importanceParameter);
			cmd.Parameters.Add(nameParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE points_of_interest SET ID = @newID, PositionX = @newPositionX, PositionY = @newPositionY, Icon = @newIcon, Flags = @newFlags, Importance = @newImportance, Name = @newName, VerifiedBuild = @newVerifiedBuild WHERE ID = @ID AND PositionX = @PositionX AND PositionY = @PositionY AND Icon = @Icon AND Flags = @Flags AND Importance = @Importance AND Name = @Name AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_positionxParameter = new MySqlParameter("@PositionX", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_positionyParameter = new MySqlParameter("@PositionY", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_iconParameter = new MySqlParameter("@Icon", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_flagsParameter = new MySqlParameter("@Flags", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_importanceParameter = new MySqlParameter("@Importance", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_nameParameter = new MySqlParameter("@Name", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newID", MySqlDbType.VarChar, 0);
			MySqlParameter positionxParameter = new MySqlParameter("@newPositionX", MySqlDbType.VarChar, 0);
			MySqlParameter positionyParameter = new MySqlParameter("@newPositionY", MySqlDbType.VarChar, 0);
			MySqlParameter iconParameter = new MySqlParameter("@newIcon", MySqlDbType.VarChar, 0);
			MySqlParameter flagsParameter = new MySqlParameter("@newFlags", MySqlDbType.VarChar, 0);
			MySqlParameter importanceParameter = new MySqlParameter("@newImportance", MySqlDbType.VarChar, 0);
			MySqlParameter nameParameter = new MySqlParameter("@newName", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@newVerifiedBuild", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			positionxParameter.Value = PositionX;
			positionyParameter.Value = PositionY;
			iconParameter.Value = Icon;
			flagsParameter.Value = Flags;
			importanceParameter.Value = Importance;
			nameParameter.Value = Name;
			verifiedbuildParameter.Value = VerifiedBuild;
			OLD_idParameter.Value = OLD_ID;
			OLD_positionxParameter.Value = OLD_PositionX;
			OLD_positionyParameter.Value = OLD_PositionY;
			OLD_iconParameter.Value = OLD_Icon;
			OLD_flagsParameter.Value = OLD_Flags;
			OLD_importanceParameter.Value = OLD_Importance;
			OLD_nameParameter.Value = OLD_Name;
			OLD_verifiedbuildParameter.Value = OLD_VerifiedBuild;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(positionxParameter);
			cmd.Parameters.Add(positionyParameter);
			cmd.Parameters.Add(iconParameter);
			cmd.Parameters.Add(flagsParameter);
			cmd.Parameters.Add(importanceParameter);
			cmd.Parameters.Add(nameParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_positionxParameter);
			cmd.Parameters.Add(OLD_positionyParameter);
			cmd.Parameters.Add(OLD_iconParameter);
			cmd.Parameters.Add(OLD_flagsParameter);
			cmd.Parameters.Add(OLD_importanceParameter);
			cmd.Parameters.Add(OLD_nameParameter);
			cmd.Parameters.Add(OLD_verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_ID = ID;
			OLD_PositionX = PositionX;
			OLD_PositionY = PositionY;
			OLD_Icon = Icon;
			OLD_Flags = Flags;
			OLD_Importance = Importance;
			OLD_Name = Name;
			OLD_VerifiedBuild = VerifiedBuild;
		}
	}
}
