using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Quest_objectives
	{
		int ID = 0; //Comment: 
		int OLD_ID = 0;

		int QuestID = 0; //Comment: 
		int OLD_QuestID = 0;

		int Type = 0; //Comment: 
		int OLD_Type = 0;

		int StorageIndex = 0; //Comment: 
		int OLD_StorageIndex = 0;

		int ObjectID = 0; //Comment: 
		int OLD_ObjectID = 0;

		int Amount = 0; //Comment: 
		int OLD_Amount = 0;

		int Flags = 0; //Comment: 
		int OLD_Flags = 0;

		float UnkFloat = 0f; //Comment: 
		float OLD_UnkFloat = 0f;

		string Description = null; //Comment: 
		string OLD_Description = null;

		int VerifiedBuild = 0; //Comment: 
		int OLD_VerifiedBuild = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Quest_objectives(int _ID, int _QuestID, int _Type, int _StorageIndex, int _ObjectID, int _Amount, int _Flags, float _UnkFloat, string _Description, int _VerifiedBuild)
		{
			ID = _ID;
			QuestID = _QuestID;
			Type = _Type;
			StorageIndex = _StorageIndex;
			ObjectID = _ObjectID;
			Amount = _Amount;
			Flags = _Flags;
			UnkFloat = _UnkFloat;
			Description = _Description;
			VerifiedBuild = _VerifiedBuild;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM quest_objectives WHERE ID = @ID AND QuestID = @QuestID AND Type = @Type AND StorageIndex = @StorageIndex AND ObjectID = @ObjectID AND Amount = @Amount AND Flags = @Flags AND UnkFloat = @UnkFloat AND Description = @Description AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter questidParameter = new MySqlParameter("@QuestID", MySqlDbType.VarChar, 0);
			MySqlParameter typeParameter = new MySqlParameter("@Type", MySqlDbType.VarChar, 0);
			MySqlParameter storageindexParameter = new MySqlParameter("@StorageIndex", MySqlDbType.VarChar, 0);
			MySqlParameter objectidParameter = new MySqlParameter("@ObjectID", MySqlDbType.VarChar, 0);
			MySqlParameter amountParameter = new MySqlParameter("@Amount", MySqlDbType.VarChar, 0);
			MySqlParameter flagsParameter = new MySqlParameter("@Flags", MySqlDbType.VarChar, 0);
			MySqlParameter unkfloatParameter = new MySqlParameter("@UnkFloat", MySqlDbType.VarChar, 0);
			MySqlParameter descriptionParameter = new MySqlParameter("@Description", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			questidParameter.Value = QuestID;
			typeParameter.Value = Type;
			storageindexParameter.Value = StorageIndex;
			objectidParameter.Value = ObjectID;
			amountParameter.Value = Amount;
			flagsParameter.Value = Flags;
			unkfloatParameter.Value = UnkFloat;
			descriptionParameter.Value = Description;
			verifiedbuildParameter.Value = VerifiedBuild;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(questidParameter);
			cmd.Parameters.Add(typeParameter);
			cmd.Parameters.Add(storageindexParameter);
			cmd.Parameters.Add(objectidParameter);
			cmd.Parameters.Add(amountParameter);
			cmd.Parameters.Add(flagsParameter);
			cmd.Parameters.Add(unkfloatParameter);
			cmd.Parameters.Add(descriptionParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE quest_objectives SET ID = @newID, QuestID = @newQuestID, Type = @newType, StorageIndex = @newStorageIndex, ObjectID = @newObjectID, Amount = @newAmount, Flags = @newFlags, UnkFloat = @newUnkFloat, Description = @newDescription, VerifiedBuild = @newVerifiedBuild WHERE ID = @ID AND QuestID = @QuestID AND Type = @Type AND StorageIndex = @StorageIndex AND ObjectID = @ObjectID AND Amount = @Amount AND Flags = @Flags AND UnkFloat = @UnkFloat AND Description = @Description AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter OLD_idParameter = new MySqlParameter("@ID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_questidParameter = new MySqlParameter("@QuestID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_typeParameter = new MySqlParameter("@Type", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_storageindexParameter = new MySqlParameter("@StorageIndex", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_objectidParameter = new MySqlParameter("@ObjectID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_amountParameter = new MySqlParameter("@Amount", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_flagsParameter = new MySqlParameter("@Flags", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_unkfloatParameter = new MySqlParameter("@UnkFloat", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_descriptionParameter = new MySqlParameter("@Description", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newID", MySqlDbType.VarChar, 0);
			MySqlParameter questidParameter = new MySqlParameter("@newQuestID", MySqlDbType.VarChar, 0);
			MySqlParameter typeParameter = new MySqlParameter("@newType", MySqlDbType.VarChar, 0);
			MySqlParameter storageindexParameter = new MySqlParameter("@newStorageIndex", MySqlDbType.VarChar, 0);
			MySqlParameter objectidParameter = new MySqlParameter("@newObjectID", MySqlDbType.VarChar, 0);
			MySqlParameter amountParameter = new MySqlParameter("@newAmount", MySqlDbType.VarChar, 0);
			MySqlParameter flagsParameter = new MySqlParameter("@newFlags", MySqlDbType.VarChar, 0);
			MySqlParameter unkfloatParameter = new MySqlParameter("@newUnkFloat", MySqlDbType.VarChar, 0);
			MySqlParameter descriptionParameter = new MySqlParameter("@newDescription", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@newVerifiedBuild", MySqlDbType.VarChar, 0);
			idParameter.Value = ID;
			questidParameter.Value = QuestID;
			typeParameter.Value = Type;
			storageindexParameter.Value = StorageIndex;
			objectidParameter.Value = ObjectID;
			amountParameter.Value = Amount;
			flagsParameter.Value = Flags;
			unkfloatParameter.Value = UnkFloat;
			descriptionParameter.Value = Description;
			verifiedbuildParameter.Value = VerifiedBuild;
			OLD_idParameter.Value = OLD_ID;
			OLD_questidParameter.Value = OLD_QuestID;
			OLD_typeParameter.Value = OLD_Type;
			OLD_storageindexParameter.Value = OLD_StorageIndex;
			OLD_objectidParameter.Value = OLD_ObjectID;
			OLD_amountParameter.Value = OLD_Amount;
			OLD_flagsParameter.Value = OLD_Flags;
			OLD_unkfloatParameter.Value = OLD_UnkFloat;
			OLD_descriptionParameter.Value = OLD_Description;
			OLD_verifiedbuildParameter.Value = OLD_VerifiedBuild;
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(questidParameter);
			cmd.Parameters.Add(typeParameter);
			cmd.Parameters.Add(storageindexParameter);
			cmd.Parameters.Add(objectidParameter);
			cmd.Parameters.Add(amountParameter);
			cmd.Parameters.Add(flagsParameter);
			cmd.Parameters.Add(unkfloatParameter);
			cmd.Parameters.Add(descriptionParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_questidParameter);
			cmd.Parameters.Add(OLD_typeParameter);
			cmd.Parameters.Add(OLD_storageindexParameter);
			cmd.Parameters.Add(OLD_objectidParameter);
			cmd.Parameters.Add(OLD_amountParameter);
			cmd.Parameters.Add(OLD_flagsParameter);
			cmd.Parameters.Add(OLD_unkfloatParameter);
			cmd.Parameters.Add(OLD_descriptionParameter);
			cmd.Parameters.Add(OLD_verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_ID = ID;
			OLD_QuestID = QuestID;
			OLD_Type = Type;
			OLD_StorageIndex = StorageIndex;
			OLD_ObjectID = ObjectID;
			OLD_Amount = Amount;
			OLD_Flags = Flags;
			OLD_UnkFloat = UnkFloat;
			OLD_Description = Description;
			OLD_VerifiedBuild = VerifiedBuild;
		}
	}
}
