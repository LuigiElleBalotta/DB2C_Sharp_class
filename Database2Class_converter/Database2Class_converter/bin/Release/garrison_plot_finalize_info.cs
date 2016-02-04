using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Garrison_plot_finalize_info
	{
		int garrPlotInstanceId = 0; //Comment: 
		int OLD_garrPlotInstanceId = 0;

		int hordeGameObjectId = 0; //Comment: 
		int OLD_hordeGameObjectId = 0;

		float hordeX = 0f; //Comment: 
		float OLD_hordeX = 0f;

		float hordeY = 0f; //Comment: 
		float OLD_hordeY = 0f;

		float hordeZ = 0f; //Comment: 
		float OLD_hordeZ = 0f;

		float hordeO = 0f; //Comment: 
		float OLD_hordeO = 0f;

		int hordeAnimKitId = 0; //Comment: 
		int OLD_hordeAnimKitId = 0;

		int allianceGameObjectId = 0; //Comment: 
		int OLD_allianceGameObjectId = 0;

		float allianceX = 0f; //Comment: 
		float OLD_allianceX = 0f;

		float allianceY = 0f; //Comment: 
		float OLD_allianceY = 0f;

		float allianceZ = 0f; //Comment: 
		float OLD_allianceZ = 0f;

		float allianceO = 0f; //Comment: 
		float OLD_allianceO = 0f;

		int allianceAnimKitId = 0; //Comment: 
		int OLD_allianceAnimKitId = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Garrison_plot_finalize_info(int _garrPlotInstanceId, int _hordeGameObjectId, float _hordeX, float _hordeY, float _hordeZ, float _hordeO, int _hordeAnimKitId, int _allianceGameObjectId, float _allianceX, float _allianceY, float _allianceZ, float _allianceO, int _allianceAnimKitId)
		{
			garrPlotInstanceId = _garrPlotInstanceId;
			hordeGameObjectId = _hordeGameObjectId;
			hordeX = _hordeX;
			hordeY = _hordeY;
			hordeZ = _hordeZ;
			hordeO = _hordeO;
			hordeAnimKitId = _hordeAnimKitId;
			allianceGameObjectId = _allianceGameObjectId;
			allianceX = _allianceX;
			allianceY = _allianceY;
			allianceZ = _allianceZ;
			allianceO = _allianceO;
			allianceAnimKitId = _allianceAnimKitId;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM garrison_plot_finalize_info WHERE garrPlotInstanceId = @garrPlotInstanceId AND hordeGameObjectId = @hordeGameObjectId AND hordeX = @hordeX AND hordeY = @hordeY AND hordeZ = @hordeZ AND hordeO = @hordeO AND hordeAnimKitId = @hordeAnimKitId AND allianceGameObjectId = @allianceGameObjectId AND allianceX = @allianceX AND allianceY = @allianceY AND allianceZ = @allianceZ AND allianceO = @allianceO AND allianceAnimKitId = @allianceAnimKitId;";
			MySqlParameter garrplotinstanceidParameter = new MySqlParameter("@garrPlotInstanceId", MySqlDbType.VarChar, 0);
			MySqlParameter hordegameobjectidParameter = new MySqlParameter("@hordeGameObjectId", MySqlDbType.VarChar, 0);
			MySqlParameter hordexParameter = new MySqlParameter("@hordeX", MySqlDbType.VarChar, 0);
			MySqlParameter hordeyParameter = new MySqlParameter("@hordeY", MySqlDbType.VarChar, 0);
			MySqlParameter hordezParameter = new MySqlParameter("@hordeZ", MySqlDbType.VarChar, 0);
			MySqlParameter hordeoParameter = new MySqlParameter("@hordeO", MySqlDbType.VarChar, 0);
			MySqlParameter hordeanimkitidParameter = new MySqlParameter("@hordeAnimKitId", MySqlDbType.VarChar, 0);
			MySqlParameter alliancegameobjectidParameter = new MySqlParameter("@allianceGameObjectId", MySqlDbType.VarChar, 0);
			MySqlParameter alliancexParameter = new MySqlParameter("@allianceX", MySqlDbType.VarChar, 0);
			MySqlParameter allianceyParameter = new MySqlParameter("@allianceY", MySqlDbType.VarChar, 0);
			MySqlParameter alliancezParameter = new MySqlParameter("@allianceZ", MySqlDbType.VarChar, 0);
			MySqlParameter allianceoParameter = new MySqlParameter("@allianceO", MySqlDbType.VarChar, 0);
			MySqlParameter allianceanimkitidParameter = new MySqlParameter("@allianceAnimKitId", MySqlDbType.VarChar, 0);
			garrplotinstanceidParameter.Value = garrPlotInstanceId;
			hordegameobjectidParameter.Value = hordeGameObjectId;
			hordexParameter.Value = hordeX;
			hordeyParameter.Value = hordeY;
			hordezParameter.Value = hordeZ;
			hordeoParameter.Value = hordeO;
			hordeanimkitidParameter.Value = hordeAnimKitId;
			alliancegameobjectidParameter.Value = allianceGameObjectId;
			alliancexParameter.Value = allianceX;
			allianceyParameter.Value = allianceY;
			alliancezParameter.Value = allianceZ;
			allianceoParameter.Value = allianceO;
			allianceanimkitidParameter.Value = allianceAnimKitId;
			cmd.Parameters.Add(garrplotinstanceidParameter);
			cmd.Parameters.Add(hordegameobjectidParameter);
			cmd.Parameters.Add(hordexParameter);
			cmd.Parameters.Add(hordeyParameter);
			cmd.Parameters.Add(hordezParameter);
			cmd.Parameters.Add(hordeoParameter);
			cmd.Parameters.Add(hordeanimkitidParameter);
			cmd.Parameters.Add(alliancegameobjectidParameter);
			cmd.Parameters.Add(alliancexParameter);
			cmd.Parameters.Add(allianceyParameter);
			cmd.Parameters.Add(alliancezParameter);
			cmd.Parameters.Add(allianceoParameter);
			cmd.Parameters.Add(allianceanimkitidParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE garrison_plot_finalize_info SET garrPlotInstanceId = @newgarrPlotInstanceId, hordeGameObjectId = @newhordeGameObjectId, hordeX = @newhordeX, hordeY = @newhordeY, hordeZ = @newhordeZ, hordeO = @newhordeO, hordeAnimKitId = @newhordeAnimKitId, allianceGameObjectId = @newallianceGameObjectId, allianceX = @newallianceX, allianceY = @newallianceY, allianceZ = @newallianceZ, allianceO = @newallianceO, allianceAnimKitId = @newallianceAnimKitId WHERE garrPlotInstanceId = @garrPlotInstanceId AND hordeGameObjectId = @hordeGameObjectId AND hordeX = @hordeX AND hordeY = @hordeY AND hordeZ = @hordeZ AND hordeO = @hordeO AND hordeAnimKitId = @hordeAnimKitId AND allianceGameObjectId = @allianceGameObjectId AND allianceX = @allianceX AND allianceY = @allianceY AND allianceZ = @allianceZ AND allianceO = @allianceO AND allianceAnimKitId = @allianceAnimKitId;";
			MySqlParameter OLD_garrplotinstanceidParameter = new MySqlParameter("@garrPlotInstanceId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_hordegameobjectidParameter = new MySqlParameter("@hordeGameObjectId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_hordexParameter = new MySqlParameter("@hordeX", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_hordeyParameter = new MySqlParameter("@hordeY", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_hordezParameter = new MySqlParameter("@hordeZ", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_hordeoParameter = new MySqlParameter("@hordeO", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_hordeanimkitidParameter = new MySqlParameter("@hordeAnimKitId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_alliancegameobjectidParameter = new MySqlParameter("@allianceGameObjectId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_alliancexParameter = new MySqlParameter("@allianceX", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_allianceyParameter = new MySqlParameter("@allianceY", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_alliancezParameter = new MySqlParameter("@allianceZ", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_allianceoParameter = new MySqlParameter("@allianceO", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_allianceanimkitidParameter = new MySqlParameter("@allianceAnimKitId", MySqlDbType.VarChar, 0);
			MySqlParameter garrplotinstanceidParameter = new MySqlParameter("@newgarrPlotInstanceId", MySqlDbType.VarChar, 0);
			MySqlParameter hordegameobjectidParameter = new MySqlParameter("@newhordeGameObjectId", MySqlDbType.VarChar, 0);
			MySqlParameter hordexParameter = new MySqlParameter("@newhordeX", MySqlDbType.VarChar, 0);
			MySqlParameter hordeyParameter = new MySqlParameter("@newhordeY", MySqlDbType.VarChar, 0);
			MySqlParameter hordezParameter = new MySqlParameter("@newhordeZ", MySqlDbType.VarChar, 0);
			MySqlParameter hordeoParameter = new MySqlParameter("@newhordeO", MySqlDbType.VarChar, 0);
			MySqlParameter hordeanimkitidParameter = new MySqlParameter("@newhordeAnimKitId", MySqlDbType.VarChar, 0);
			MySqlParameter alliancegameobjectidParameter = new MySqlParameter("@newallianceGameObjectId", MySqlDbType.VarChar, 0);
			MySqlParameter alliancexParameter = new MySqlParameter("@newallianceX", MySqlDbType.VarChar, 0);
			MySqlParameter allianceyParameter = new MySqlParameter("@newallianceY", MySqlDbType.VarChar, 0);
			MySqlParameter alliancezParameter = new MySqlParameter("@newallianceZ", MySqlDbType.VarChar, 0);
			MySqlParameter allianceoParameter = new MySqlParameter("@newallianceO", MySqlDbType.VarChar, 0);
			MySqlParameter allianceanimkitidParameter = new MySqlParameter("@newallianceAnimKitId", MySqlDbType.VarChar, 0);
			garrplotinstanceidParameter.Value = garrPlotInstanceId;
			hordegameobjectidParameter.Value = hordeGameObjectId;
			hordexParameter.Value = hordeX;
			hordeyParameter.Value = hordeY;
			hordezParameter.Value = hordeZ;
			hordeoParameter.Value = hordeO;
			hordeanimkitidParameter.Value = hordeAnimKitId;
			alliancegameobjectidParameter.Value = allianceGameObjectId;
			alliancexParameter.Value = allianceX;
			allianceyParameter.Value = allianceY;
			alliancezParameter.Value = allianceZ;
			allianceoParameter.Value = allianceO;
			allianceanimkitidParameter.Value = allianceAnimKitId;
			OLD_garrplotinstanceidParameter.Value = OLD_garrPlotInstanceId;
			OLD_hordegameobjectidParameter.Value = OLD_hordeGameObjectId;
			OLD_hordexParameter.Value = OLD_hordeX;
			OLD_hordeyParameter.Value = OLD_hordeY;
			OLD_hordezParameter.Value = OLD_hordeZ;
			OLD_hordeoParameter.Value = OLD_hordeO;
			OLD_hordeanimkitidParameter.Value = OLD_hordeAnimKitId;
			OLD_alliancegameobjectidParameter.Value = OLD_allianceGameObjectId;
			OLD_alliancexParameter.Value = OLD_allianceX;
			OLD_allianceyParameter.Value = OLD_allianceY;
			OLD_alliancezParameter.Value = OLD_allianceZ;
			OLD_allianceoParameter.Value = OLD_allianceO;
			OLD_allianceanimkitidParameter.Value = OLD_allianceAnimKitId;
			cmd.Parameters.Add(garrplotinstanceidParameter);
			cmd.Parameters.Add(hordegameobjectidParameter);
			cmd.Parameters.Add(hordexParameter);
			cmd.Parameters.Add(hordeyParameter);
			cmd.Parameters.Add(hordezParameter);
			cmd.Parameters.Add(hordeoParameter);
			cmd.Parameters.Add(hordeanimkitidParameter);
			cmd.Parameters.Add(alliancegameobjectidParameter);
			cmd.Parameters.Add(alliancexParameter);
			cmd.Parameters.Add(allianceyParameter);
			cmd.Parameters.Add(alliancezParameter);
			cmd.Parameters.Add(allianceoParameter);
			cmd.Parameters.Add(allianceanimkitidParameter);
			cmd.Parameters.Add(OLD_garrplotinstanceidParameter);
			cmd.Parameters.Add(OLD_hordegameobjectidParameter);
			cmd.Parameters.Add(OLD_hordexParameter);
			cmd.Parameters.Add(OLD_hordeyParameter);
			cmd.Parameters.Add(OLD_hordezParameter);
			cmd.Parameters.Add(OLD_hordeoParameter);
			cmd.Parameters.Add(OLD_hordeanimkitidParameter);
			cmd.Parameters.Add(OLD_alliancegameobjectidParameter);
			cmd.Parameters.Add(OLD_alliancexParameter);
			cmd.Parameters.Add(OLD_allianceyParameter);
			cmd.Parameters.Add(OLD_alliancezParameter);
			cmd.Parameters.Add(OLD_allianceoParameter);
			cmd.Parameters.Add(OLD_allianceanimkitidParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_garrPlotInstanceId = garrPlotInstanceId;
			OLD_hordeGameObjectId = hordeGameObjectId;
			OLD_hordeX = hordeX;
			OLD_hordeY = hordeY;
			OLD_hordeZ = hordeZ;
			OLD_hordeO = hordeO;
			OLD_hordeAnimKitId = hordeAnimKitId;
			OLD_allianceGameObjectId = allianceGameObjectId;
			OLD_allianceX = allianceX;
			OLD_allianceY = allianceY;
			OLD_allianceZ = allianceZ;
			OLD_allianceO = allianceO;
			OLD_allianceAnimKitId = allianceAnimKitId;
		}
	}
}
