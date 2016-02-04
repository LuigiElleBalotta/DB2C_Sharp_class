using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Gameobject_template
	{
		int entry = 0; //Comment: 
		int OLD_entry = 0;

		int type = 0; //Comment: 
		int OLD_type = 0;

		int displayId = 0; //Comment: 
		int OLD_displayId = 0;

		string name = null; //Comment: 
		string OLD_name = null;

		string IconName = null; //Comment: 
		string OLD_IconName = null;

		string castBarCaption = null; //Comment: 
		string OLD_castBarCaption = null;

		string unk1 = null; //Comment: 
		string OLD_unk1 = null;

		int faction = 0; //Comment: 
		int OLD_faction = 0;

		int flags = 0; //Comment: 
		int OLD_flags = 0;

		float size = 1f; //Comment: 
		float OLD_size = 1f;

		int Data0 = 0; //Comment: 
		int OLD_Data0 = 0;

		int Data1 = 0; //Comment: 
		int OLD_Data1 = 0;

		int Data2 = 0; //Comment: 
		int OLD_Data2 = 0;

		int Data3 = 0; //Comment: 
		int OLD_Data3 = 0;

		int Data4 = 0; //Comment: 
		int OLD_Data4 = 0;

		int Data5 = 0; //Comment: 
		int OLD_Data5 = 0;

		int Data6 = 0; //Comment: 
		int OLD_Data6 = 0;

		int Data7 = 0; //Comment: 
		int OLD_Data7 = 0;

		int Data8 = 0; //Comment: 
		int OLD_Data8 = 0;

		int Data9 = 0; //Comment: 
		int OLD_Data9 = 0;

		int Data10 = 0; //Comment: 
		int OLD_Data10 = 0;

		int Data11 = 0; //Comment: 
		int OLD_Data11 = 0;

		int Data12 = 0; //Comment: 
		int OLD_Data12 = 0;

		int Data13 = 0; //Comment: 
		int OLD_Data13 = 0;

		int Data14 = 0; //Comment: 
		int OLD_Data14 = 0;

		int Data15 = 0; //Comment: 
		int OLD_Data15 = 0;

		int Data16 = 0; //Comment: 
		int OLD_Data16 = 0;

		int Data17 = 0; //Comment: 
		int OLD_Data17 = 0;

		int Data18 = 0; //Comment: 
		int OLD_Data18 = 0;

		int Data19 = 0; //Comment: 
		int OLD_Data19 = 0;

		int Data20 = 0; //Comment: 
		int OLD_Data20 = 0;

		int Data21 = 0; //Comment: 
		int OLD_Data21 = 0;

		int Data22 = 0; //Comment: 
		int OLD_Data22 = 0;

		int Data23 = 0; //Comment: 
		int OLD_Data23 = 0;

		int Data24 = 0; //Comment: 
		int OLD_Data24 = 0;

		int Data25 = 0; //Comment: 
		int OLD_Data25 = 0;

		int Data26 = 0; //Comment: 
		int OLD_Data26 = 0;

		int Data27 = 0; //Comment: 
		int OLD_Data27 = 0;

		int Data28 = 0; //Comment: 
		int OLD_Data28 = 0;

		int Data29 = 0; //Comment: 
		int OLD_Data29 = 0;

		int Data30 = 0; //Comment: 
		int OLD_Data30 = 0;

		int Data31 = 0; //Comment: 
		int OLD_Data31 = 0;

		int Data32 = 0; //Comment: 
		int OLD_Data32 = 0;

		int unkInt32 = 0; //Comment: 
		int OLD_unkInt32 = 0;

		char AIName = Char.MinValue; //Comment: 
		char OLD_AIName = Char.MinValue;

		string ScriptName = null; //Comment: 
		string OLD_ScriptName = null;

		int VerifiedBuild = 0; //Comment: 
		int OLD_VerifiedBuild = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Gameobject_template(int _entry, int _type, int _displayId, string _name, string _IconName, string _castBarCaption, string _unk1, int _faction, int _flags, float _size, int _Data0, int _Data1, int _Data2, int _Data3, int _Data4, int _Data5, int _Data6, int _Data7, int _Data8, int _Data9, int _Data10, int _Data11, int _Data12, int _Data13, int _Data14, int _Data15, int _Data16, int _Data17, int _Data18, int _Data19, int _Data20, int _Data21, int _Data22, int _Data23, int _Data24, int _Data25, int _Data26, int _Data27, int _Data28, int _Data29, int _Data30, int _Data31, int _Data32, int _unkInt32, char _AIName, string _ScriptName, int _VerifiedBuild)
		{
			entry = _entry;
			type = _type;
			displayId = _displayId;
			name = _name;
			IconName = _IconName;
			castBarCaption = _castBarCaption;
			unk1 = _unk1;
			faction = _faction;
			flags = _flags;
			size = _size;
			Data0 = _Data0;
			Data1 = _Data1;
			Data2 = _Data2;
			Data3 = _Data3;
			Data4 = _Data4;
			Data5 = _Data5;
			Data6 = _Data6;
			Data7 = _Data7;
			Data8 = _Data8;
			Data9 = _Data9;
			Data10 = _Data10;
			Data11 = _Data11;
			Data12 = _Data12;
			Data13 = _Data13;
			Data14 = _Data14;
			Data15 = _Data15;
			Data16 = _Data16;
			Data17 = _Data17;
			Data18 = _Data18;
			Data19 = _Data19;
			Data20 = _Data20;
			Data21 = _Data21;
			Data22 = _Data22;
			Data23 = _Data23;
			Data24 = _Data24;
			Data25 = _Data25;
			Data26 = _Data26;
			Data27 = _Data27;
			Data28 = _Data28;
			Data29 = _Data29;
			Data30 = _Data30;
			Data31 = _Data31;
			Data32 = _Data32;
			unkInt32 = _unkInt32;
			AIName = _AIName;
			ScriptName = _ScriptName;
			VerifiedBuild = _VerifiedBuild;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM gameobject_template WHERE entry = @entry AND type = @type AND displayId = @displayId AND name = @name AND IconName = @IconName AND castBarCaption = @castBarCaption AND unk1 = @unk1 AND faction = @faction AND flags = @flags AND size = @size AND Data0 = @Data0 AND Data1 = @Data1 AND Data2 = @Data2 AND Data3 = @Data3 AND Data4 = @Data4 AND Data5 = @Data5 AND Data6 = @Data6 AND Data7 = @Data7 AND Data8 = @Data8 AND Data9 = @Data9 AND Data10 = @Data10 AND Data11 = @Data11 AND Data12 = @Data12 AND Data13 = @Data13 AND Data14 = @Data14 AND Data15 = @Data15 AND Data16 = @Data16 AND Data17 = @Data17 AND Data18 = @Data18 AND Data19 = @Data19 AND Data20 = @Data20 AND Data21 = @Data21 AND Data22 = @Data22 AND Data23 = @Data23 AND Data24 = @Data24 AND Data25 = @Data25 AND Data26 = @Data26 AND Data27 = @Data27 AND Data28 = @Data28 AND Data29 = @Data29 AND Data30 = @Data30 AND Data31 = @Data31 AND Data32 = @Data32 AND unkInt32 = @unkInt32 AND AIName = @AIName AND ScriptName = @ScriptName AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter typeParameter = new MySqlParameter("@type", MySqlDbType.VarChar, 0);
			MySqlParameter displayidParameter = new MySqlParameter("@displayId", MySqlDbType.VarChar, 0);
			MySqlParameter nameParameter = new MySqlParameter("@name", MySqlDbType.VarChar, 0);
			MySqlParameter iconnameParameter = new MySqlParameter("@IconName", MySqlDbType.VarChar, 0);
			MySqlParameter castbarcaptionParameter = new MySqlParameter("@castBarCaption", MySqlDbType.VarChar, 0);
			MySqlParameter unk1Parameter = new MySqlParameter("@unk1", MySqlDbType.VarChar, 0);
			MySqlParameter factionParameter = new MySqlParameter("@faction", MySqlDbType.VarChar, 0);
			MySqlParameter flagsParameter = new MySqlParameter("@flags", MySqlDbType.VarChar, 0);
			MySqlParameter sizeParameter = new MySqlParameter("@size", MySqlDbType.VarChar, 0);
			MySqlParameter data0Parameter = new MySqlParameter("@Data0", MySqlDbType.VarChar, 0);
			MySqlParameter data1Parameter = new MySqlParameter("@Data1", MySqlDbType.VarChar, 0);
			MySqlParameter data2Parameter = new MySqlParameter("@Data2", MySqlDbType.VarChar, 0);
			MySqlParameter data3Parameter = new MySqlParameter("@Data3", MySqlDbType.VarChar, 0);
			MySqlParameter data4Parameter = new MySqlParameter("@Data4", MySqlDbType.VarChar, 0);
			MySqlParameter data5Parameter = new MySqlParameter("@Data5", MySqlDbType.VarChar, 0);
			MySqlParameter data6Parameter = new MySqlParameter("@Data6", MySqlDbType.VarChar, 0);
			MySqlParameter data7Parameter = new MySqlParameter("@Data7", MySqlDbType.VarChar, 0);
			MySqlParameter data8Parameter = new MySqlParameter("@Data8", MySqlDbType.VarChar, 0);
			MySqlParameter data9Parameter = new MySqlParameter("@Data9", MySqlDbType.VarChar, 0);
			MySqlParameter data10Parameter = new MySqlParameter("@Data10", MySqlDbType.VarChar, 0);
			MySqlParameter data11Parameter = new MySqlParameter("@Data11", MySqlDbType.VarChar, 0);
			MySqlParameter data12Parameter = new MySqlParameter("@Data12", MySqlDbType.VarChar, 0);
			MySqlParameter data13Parameter = new MySqlParameter("@Data13", MySqlDbType.VarChar, 0);
			MySqlParameter data14Parameter = new MySqlParameter("@Data14", MySqlDbType.VarChar, 0);
			MySqlParameter data15Parameter = new MySqlParameter("@Data15", MySqlDbType.VarChar, 0);
			MySqlParameter data16Parameter = new MySqlParameter("@Data16", MySqlDbType.VarChar, 0);
			MySqlParameter data17Parameter = new MySqlParameter("@Data17", MySqlDbType.VarChar, 0);
			MySqlParameter data18Parameter = new MySqlParameter("@Data18", MySqlDbType.VarChar, 0);
			MySqlParameter data19Parameter = new MySqlParameter("@Data19", MySqlDbType.VarChar, 0);
			MySqlParameter data20Parameter = new MySqlParameter("@Data20", MySqlDbType.VarChar, 0);
			MySqlParameter data21Parameter = new MySqlParameter("@Data21", MySqlDbType.VarChar, 0);
			MySqlParameter data22Parameter = new MySqlParameter("@Data22", MySqlDbType.VarChar, 0);
			MySqlParameter data23Parameter = new MySqlParameter("@Data23", MySqlDbType.VarChar, 0);
			MySqlParameter data24Parameter = new MySqlParameter("@Data24", MySqlDbType.VarChar, 0);
			MySqlParameter data25Parameter = new MySqlParameter("@Data25", MySqlDbType.VarChar, 0);
			MySqlParameter data26Parameter = new MySqlParameter("@Data26", MySqlDbType.VarChar, 0);
			MySqlParameter data27Parameter = new MySqlParameter("@Data27", MySqlDbType.VarChar, 0);
			MySqlParameter data28Parameter = new MySqlParameter("@Data28", MySqlDbType.VarChar, 0);
			MySqlParameter data29Parameter = new MySqlParameter("@Data29", MySqlDbType.VarChar, 0);
			MySqlParameter data30Parameter = new MySqlParameter("@Data30", MySqlDbType.VarChar, 0);
			MySqlParameter data31Parameter = new MySqlParameter("@Data31", MySqlDbType.VarChar, 0);
			MySqlParameter data32Parameter = new MySqlParameter("@Data32", MySqlDbType.VarChar, 0);
			MySqlParameter unkint32Parameter = new MySqlParameter("@unkInt32", MySqlDbType.VarChar, 0);
			MySqlParameter ainameParameter = new MySqlParameter("@AIName", MySqlDbType.VarChar, 0);
			MySqlParameter scriptnameParameter = new MySqlParameter("@ScriptName", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			typeParameter.Value = type;
			displayidParameter.Value = displayId;
			nameParameter.Value = name;
			iconnameParameter.Value = IconName;
			castbarcaptionParameter.Value = castBarCaption;
			unk1Parameter.Value = unk1;
			factionParameter.Value = faction;
			flagsParameter.Value = flags;
			sizeParameter.Value = size;
			data0Parameter.Value = Data0;
			data1Parameter.Value = Data1;
			data2Parameter.Value = Data2;
			data3Parameter.Value = Data3;
			data4Parameter.Value = Data4;
			data5Parameter.Value = Data5;
			data6Parameter.Value = Data6;
			data7Parameter.Value = Data7;
			data8Parameter.Value = Data8;
			data9Parameter.Value = Data9;
			data10Parameter.Value = Data10;
			data11Parameter.Value = Data11;
			data12Parameter.Value = Data12;
			data13Parameter.Value = Data13;
			data14Parameter.Value = Data14;
			data15Parameter.Value = Data15;
			data16Parameter.Value = Data16;
			data17Parameter.Value = Data17;
			data18Parameter.Value = Data18;
			data19Parameter.Value = Data19;
			data20Parameter.Value = Data20;
			data21Parameter.Value = Data21;
			data22Parameter.Value = Data22;
			data23Parameter.Value = Data23;
			data24Parameter.Value = Data24;
			data25Parameter.Value = Data25;
			data26Parameter.Value = Data26;
			data27Parameter.Value = Data27;
			data28Parameter.Value = Data28;
			data29Parameter.Value = Data29;
			data30Parameter.Value = Data30;
			data31Parameter.Value = Data31;
			data32Parameter.Value = Data32;
			unkint32Parameter.Value = unkInt32;
			ainameParameter.Value = AIName;
			scriptnameParameter.Value = ScriptName;
			verifiedbuildParameter.Value = VerifiedBuild;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(typeParameter);
			cmd.Parameters.Add(displayidParameter);
			cmd.Parameters.Add(nameParameter);
			cmd.Parameters.Add(iconnameParameter);
			cmd.Parameters.Add(castbarcaptionParameter);
			cmd.Parameters.Add(unk1Parameter);
			cmd.Parameters.Add(factionParameter);
			cmd.Parameters.Add(flagsParameter);
			cmd.Parameters.Add(sizeParameter);
			cmd.Parameters.Add(data0Parameter);
			cmd.Parameters.Add(data1Parameter);
			cmd.Parameters.Add(data2Parameter);
			cmd.Parameters.Add(data3Parameter);
			cmd.Parameters.Add(data4Parameter);
			cmd.Parameters.Add(data5Parameter);
			cmd.Parameters.Add(data6Parameter);
			cmd.Parameters.Add(data7Parameter);
			cmd.Parameters.Add(data8Parameter);
			cmd.Parameters.Add(data9Parameter);
			cmd.Parameters.Add(data10Parameter);
			cmd.Parameters.Add(data11Parameter);
			cmd.Parameters.Add(data12Parameter);
			cmd.Parameters.Add(data13Parameter);
			cmd.Parameters.Add(data14Parameter);
			cmd.Parameters.Add(data15Parameter);
			cmd.Parameters.Add(data16Parameter);
			cmd.Parameters.Add(data17Parameter);
			cmd.Parameters.Add(data18Parameter);
			cmd.Parameters.Add(data19Parameter);
			cmd.Parameters.Add(data20Parameter);
			cmd.Parameters.Add(data21Parameter);
			cmd.Parameters.Add(data22Parameter);
			cmd.Parameters.Add(data23Parameter);
			cmd.Parameters.Add(data24Parameter);
			cmd.Parameters.Add(data25Parameter);
			cmd.Parameters.Add(data26Parameter);
			cmd.Parameters.Add(data27Parameter);
			cmd.Parameters.Add(data28Parameter);
			cmd.Parameters.Add(data29Parameter);
			cmd.Parameters.Add(data30Parameter);
			cmd.Parameters.Add(data31Parameter);
			cmd.Parameters.Add(data32Parameter);
			cmd.Parameters.Add(unkint32Parameter);
			cmd.Parameters.Add(ainameParameter);
			cmd.Parameters.Add(scriptnameParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE gameobject_template SET entry = @newentry, type = @newtype, displayId = @newdisplayId, name = @newname, IconName = @newIconName, castBarCaption = @newcastBarCaption, unk1 = @newunk1, faction = @newfaction, flags = @newflags, size = @newsize, Data0 = @newData0, Data1 = @newData1, Data2 = @newData2, Data3 = @newData3, Data4 = @newData4, Data5 = @newData5, Data6 = @newData6, Data7 = @newData7, Data8 = @newData8, Data9 = @newData9, Data10 = @newData10, Data11 = @newData11, Data12 = @newData12, Data13 = @newData13, Data14 = @newData14, Data15 = @newData15, Data16 = @newData16, Data17 = @newData17, Data18 = @newData18, Data19 = @newData19, Data20 = @newData20, Data21 = @newData21, Data22 = @newData22, Data23 = @newData23, Data24 = @newData24, Data25 = @newData25, Data26 = @newData26, Data27 = @newData27, Data28 = @newData28, Data29 = @newData29, Data30 = @newData30, Data31 = @newData31, Data32 = @newData32, unkInt32 = @newunkInt32, AIName = @newAIName, ScriptName = @newScriptName, VerifiedBuild = @newVerifiedBuild WHERE entry = @entry AND type = @type AND displayId = @displayId AND name = @name AND IconName = @IconName AND castBarCaption = @castBarCaption AND unk1 = @unk1 AND faction = @faction AND flags = @flags AND size = @size AND Data0 = @Data0 AND Data1 = @Data1 AND Data2 = @Data2 AND Data3 = @Data3 AND Data4 = @Data4 AND Data5 = @Data5 AND Data6 = @Data6 AND Data7 = @Data7 AND Data8 = @Data8 AND Data9 = @Data9 AND Data10 = @Data10 AND Data11 = @Data11 AND Data12 = @Data12 AND Data13 = @Data13 AND Data14 = @Data14 AND Data15 = @Data15 AND Data16 = @Data16 AND Data17 = @Data17 AND Data18 = @Data18 AND Data19 = @Data19 AND Data20 = @Data20 AND Data21 = @Data21 AND Data22 = @Data22 AND Data23 = @Data23 AND Data24 = @Data24 AND Data25 = @Data25 AND Data26 = @Data26 AND Data27 = @Data27 AND Data28 = @Data28 AND Data29 = @Data29 AND Data30 = @Data30 AND Data31 = @Data31 AND Data32 = @Data32 AND unkInt32 = @unkInt32 AND AIName = @AIName AND ScriptName = @ScriptName AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter OLD_entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_typeParameter = new MySqlParameter("@type", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_displayidParameter = new MySqlParameter("@displayId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_nameParameter = new MySqlParameter("@name", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_iconnameParameter = new MySqlParameter("@IconName", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_castbarcaptionParameter = new MySqlParameter("@castBarCaption", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_unk1Parameter = new MySqlParameter("@unk1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_factionParameter = new MySqlParameter("@faction", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_flagsParameter = new MySqlParameter("@flags", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_sizeParameter = new MySqlParameter("@size", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data0Parameter = new MySqlParameter("@Data0", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data1Parameter = new MySqlParameter("@Data1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data2Parameter = new MySqlParameter("@Data2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data3Parameter = new MySqlParameter("@Data3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data4Parameter = new MySqlParameter("@Data4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data5Parameter = new MySqlParameter("@Data5", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data6Parameter = new MySqlParameter("@Data6", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data7Parameter = new MySqlParameter("@Data7", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data8Parameter = new MySqlParameter("@Data8", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data9Parameter = new MySqlParameter("@Data9", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data10Parameter = new MySqlParameter("@Data10", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data11Parameter = new MySqlParameter("@Data11", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data12Parameter = new MySqlParameter("@Data12", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data13Parameter = new MySqlParameter("@Data13", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data14Parameter = new MySqlParameter("@Data14", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data15Parameter = new MySqlParameter("@Data15", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data16Parameter = new MySqlParameter("@Data16", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data17Parameter = new MySqlParameter("@Data17", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data18Parameter = new MySqlParameter("@Data18", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data19Parameter = new MySqlParameter("@Data19", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data20Parameter = new MySqlParameter("@Data20", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data21Parameter = new MySqlParameter("@Data21", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data22Parameter = new MySqlParameter("@Data22", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data23Parameter = new MySqlParameter("@Data23", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data24Parameter = new MySqlParameter("@Data24", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data25Parameter = new MySqlParameter("@Data25", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data26Parameter = new MySqlParameter("@Data26", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data27Parameter = new MySqlParameter("@Data27", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data28Parameter = new MySqlParameter("@Data28", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data29Parameter = new MySqlParameter("@Data29", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data30Parameter = new MySqlParameter("@Data30", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data31Parameter = new MySqlParameter("@Data31", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_data32Parameter = new MySqlParameter("@Data32", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_unkint32Parameter = new MySqlParameter("@unkInt32", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_ainameParameter = new MySqlParameter("@AIName", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_scriptnameParameter = new MySqlParameter("@ScriptName", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@newentry", MySqlDbType.VarChar, 0);
			MySqlParameter typeParameter = new MySqlParameter("@newtype", MySqlDbType.VarChar, 0);
			MySqlParameter displayidParameter = new MySqlParameter("@newdisplayId", MySqlDbType.VarChar, 0);
			MySqlParameter nameParameter = new MySqlParameter("@newname", MySqlDbType.VarChar, 0);
			MySqlParameter iconnameParameter = new MySqlParameter("@newIconName", MySqlDbType.VarChar, 0);
			MySqlParameter castbarcaptionParameter = new MySqlParameter("@newcastBarCaption", MySqlDbType.VarChar, 0);
			MySqlParameter unk1Parameter = new MySqlParameter("@newunk1", MySqlDbType.VarChar, 0);
			MySqlParameter factionParameter = new MySqlParameter("@newfaction", MySqlDbType.VarChar, 0);
			MySqlParameter flagsParameter = new MySqlParameter("@newflags", MySqlDbType.VarChar, 0);
			MySqlParameter sizeParameter = new MySqlParameter("@newsize", MySqlDbType.VarChar, 0);
			MySqlParameter data0Parameter = new MySqlParameter("@newData0", MySqlDbType.VarChar, 0);
			MySqlParameter data1Parameter = new MySqlParameter("@newData1", MySqlDbType.VarChar, 0);
			MySqlParameter data2Parameter = new MySqlParameter("@newData2", MySqlDbType.VarChar, 0);
			MySqlParameter data3Parameter = new MySqlParameter("@newData3", MySqlDbType.VarChar, 0);
			MySqlParameter data4Parameter = new MySqlParameter("@newData4", MySqlDbType.VarChar, 0);
			MySqlParameter data5Parameter = new MySqlParameter("@newData5", MySqlDbType.VarChar, 0);
			MySqlParameter data6Parameter = new MySqlParameter("@newData6", MySqlDbType.VarChar, 0);
			MySqlParameter data7Parameter = new MySqlParameter("@newData7", MySqlDbType.VarChar, 0);
			MySqlParameter data8Parameter = new MySqlParameter("@newData8", MySqlDbType.VarChar, 0);
			MySqlParameter data9Parameter = new MySqlParameter("@newData9", MySqlDbType.VarChar, 0);
			MySqlParameter data10Parameter = new MySqlParameter("@newData10", MySqlDbType.VarChar, 0);
			MySqlParameter data11Parameter = new MySqlParameter("@newData11", MySqlDbType.VarChar, 0);
			MySqlParameter data12Parameter = new MySqlParameter("@newData12", MySqlDbType.VarChar, 0);
			MySqlParameter data13Parameter = new MySqlParameter("@newData13", MySqlDbType.VarChar, 0);
			MySqlParameter data14Parameter = new MySqlParameter("@newData14", MySqlDbType.VarChar, 0);
			MySqlParameter data15Parameter = new MySqlParameter("@newData15", MySqlDbType.VarChar, 0);
			MySqlParameter data16Parameter = new MySqlParameter("@newData16", MySqlDbType.VarChar, 0);
			MySqlParameter data17Parameter = new MySqlParameter("@newData17", MySqlDbType.VarChar, 0);
			MySqlParameter data18Parameter = new MySqlParameter("@newData18", MySqlDbType.VarChar, 0);
			MySqlParameter data19Parameter = new MySqlParameter("@newData19", MySqlDbType.VarChar, 0);
			MySqlParameter data20Parameter = new MySqlParameter("@newData20", MySqlDbType.VarChar, 0);
			MySqlParameter data21Parameter = new MySqlParameter("@newData21", MySqlDbType.VarChar, 0);
			MySqlParameter data22Parameter = new MySqlParameter("@newData22", MySqlDbType.VarChar, 0);
			MySqlParameter data23Parameter = new MySqlParameter("@newData23", MySqlDbType.VarChar, 0);
			MySqlParameter data24Parameter = new MySqlParameter("@newData24", MySqlDbType.VarChar, 0);
			MySqlParameter data25Parameter = new MySqlParameter("@newData25", MySqlDbType.VarChar, 0);
			MySqlParameter data26Parameter = new MySqlParameter("@newData26", MySqlDbType.VarChar, 0);
			MySqlParameter data27Parameter = new MySqlParameter("@newData27", MySqlDbType.VarChar, 0);
			MySqlParameter data28Parameter = new MySqlParameter("@newData28", MySqlDbType.VarChar, 0);
			MySqlParameter data29Parameter = new MySqlParameter("@newData29", MySqlDbType.VarChar, 0);
			MySqlParameter data30Parameter = new MySqlParameter("@newData30", MySqlDbType.VarChar, 0);
			MySqlParameter data31Parameter = new MySqlParameter("@newData31", MySqlDbType.VarChar, 0);
			MySqlParameter data32Parameter = new MySqlParameter("@newData32", MySqlDbType.VarChar, 0);
			MySqlParameter unkint32Parameter = new MySqlParameter("@newunkInt32", MySqlDbType.VarChar, 0);
			MySqlParameter ainameParameter = new MySqlParameter("@newAIName", MySqlDbType.VarChar, 0);
			MySqlParameter scriptnameParameter = new MySqlParameter("@newScriptName", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@newVerifiedBuild", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			typeParameter.Value = type;
			displayidParameter.Value = displayId;
			nameParameter.Value = name;
			iconnameParameter.Value = IconName;
			castbarcaptionParameter.Value = castBarCaption;
			unk1Parameter.Value = unk1;
			factionParameter.Value = faction;
			flagsParameter.Value = flags;
			sizeParameter.Value = size;
			data0Parameter.Value = Data0;
			data1Parameter.Value = Data1;
			data2Parameter.Value = Data2;
			data3Parameter.Value = Data3;
			data4Parameter.Value = Data4;
			data5Parameter.Value = Data5;
			data6Parameter.Value = Data6;
			data7Parameter.Value = Data7;
			data8Parameter.Value = Data8;
			data9Parameter.Value = Data9;
			data10Parameter.Value = Data10;
			data11Parameter.Value = Data11;
			data12Parameter.Value = Data12;
			data13Parameter.Value = Data13;
			data14Parameter.Value = Data14;
			data15Parameter.Value = Data15;
			data16Parameter.Value = Data16;
			data17Parameter.Value = Data17;
			data18Parameter.Value = Data18;
			data19Parameter.Value = Data19;
			data20Parameter.Value = Data20;
			data21Parameter.Value = Data21;
			data22Parameter.Value = Data22;
			data23Parameter.Value = Data23;
			data24Parameter.Value = Data24;
			data25Parameter.Value = Data25;
			data26Parameter.Value = Data26;
			data27Parameter.Value = Data27;
			data28Parameter.Value = Data28;
			data29Parameter.Value = Data29;
			data30Parameter.Value = Data30;
			data31Parameter.Value = Data31;
			data32Parameter.Value = Data32;
			unkint32Parameter.Value = unkInt32;
			ainameParameter.Value = AIName;
			scriptnameParameter.Value = ScriptName;
			verifiedbuildParameter.Value = VerifiedBuild;
			OLD_entryParameter.Value = OLD_entry;
			OLD_typeParameter.Value = OLD_type;
			OLD_displayidParameter.Value = OLD_displayId;
			OLD_nameParameter.Value = OLD_name;
			OLD_iconnameParameter.Value = OLD_IconName;
			OLD_castbarcaptionParameter.Value = OLD_castBarCaption;
			OLD_unk1Parameter.Value = OLD_unk1;
			OLD_factionParameter.Value = OLD_faction;
			OLD_flagsParameter.Value = OLD_flags;
			OLD_sizeParameter.Value = OLD_size;
			OLD_data0Parameter.Value = OLD_Data0;
			OLD_data1Parameter.Value = OLD_Data1;
			OLD_data2Parameter.Value = OLD_Data2;
			OLD_data3Parameter.Value = OLD_Data3;
			OLD_data4Parameter.Value = OLD_Data4;
			OLD_data5Parameter.Value = OLD_Data5;
			OLD_data6Parameter.Value = OLD_Data6;
			OLD_data7Parameter.Value = OLD_Data7;
			OLD_data8Parameter.Value = OLD_Data8;
			OLD_data9Parameter.Value = OLD_Data9;
			OLD_data10Parameter.Value = OLD_Data10;
			OLD_data11Parameter.Value = OLD_Data11;
			OLD_data12Parameter.Value = OLD_Data12;
			OLD_data13Parameter.Value = OLD_Data13;
			OLD_data14Parameter.Value = OLD_Data14;
			OLD_data15Parameter.Value = OLD_Data15;
			OLD_data16Parameter.Value = OLD_Data16;
			OLD_data17Parameter.Value = OLD_Data17;
			OLD_data18Parameter.Value = OLD_Data18;
			OLD_data19Parameter.Value = OLD_Data19;
			OLD_data20Parameter.Value = OLD_Data20;
			OLD_data21Parameter.Value = OLD_Data21;
			OLD_data22Parameter.Value = OLD_Data22;
			OLD_data23Parameter.Value = OLD_Data23;
			OLD_data24Parameter.Value = OLD_Data24;
			OLD_data25Parameter.Value = OLD_Data25;
			OLD_data26Parameter.Value = OLD_Data26;
			OLD_data27Parameter.Value = OLD_Data27;
			OLD_data28Parameter.Value = OLD_Data28;
			OLD_data29Parameter.Value = OLD_Data29;
			OLD_data30Parameter.Value = OLD_Data30;
			OLD_data31Parameter.Value = OLD_Data31;
			OLD_data32Parameter.Value = OLD_Data32;
			OLD_unkint32Parameter.Value = OLD_unkInt32;
			OLD_ainameParameter.Value = OLD_AIName;
			OLD_scriptnameParameter.Value = OLD_ScriptName;
			OLD_verifiedbuildParameter.Value = OLD_VerifiedBuild;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(typeParameter);
			cmd.Parameters.Add(displayidParameter);
			cmd.Parameters.Add(nameParameter);
			cmd.Parameters.Add(iconnameParameter);
			cmd.Parameters.Add(castbarcaptionParameter);
			cmd.Parameters.Add(unk1Parameter);
			cmd.Parameters.Add(factionParameter);
			cmd.Parameters.Add(flagsParameter);
			cmd.Parameters.Add(sizeParameter);
			cmd.Parameters.Add(data0Parameter);
			cmd.Parameters.Add(data1Parameter);
			cmd.Parameters.Add(data2Parameter);
			cmd.Parameters.Add(data3Parameter);
			cmd.Parameters.Add(data4Parameter);
			cmd.Parameters.Add(data5Parameter);
			cmd.Parameters.Add(data6Parameter);
			cmd.Parameters.Add(data7Parameter);
			cmd.Parameters.Add(data8Parameter);
			cmd.Parameters.Add(data9Parameter);
			cmd.Parameters.Add(data10Parameter);
			cmd.Parameters.Add(data11Parameter);
			cmd.Parameters.Add(data12Parameter);
			cmd.Parameters.Add(data13Parameter);
			cmd.Parameters.Add(data14Parameter);
			cmd.Parameters.Add(data15Parameter);
			cmd.Parameters.Add(data16Parameter);
			cmd.Parameters.Add(data17Parameter);
			cmd.Parameters.Add(data18Parameter);
			cmd.Parameters.Add(data19Parameter);
			cmd.Parameters.Add(data20Parameter);
			cmd.Parameters.Add(data21Parameter);
			cmd.Parameters.Add(data22Parameter);
			cmd.Parameters.Add(data23Parameter);
			cmd.Parameters.Add(data24Parameter);
			cmd.Parameters.Add(data25Parameter);
			cmd.Parameters.Add(data26Parameter);
			cmd.Parameters.Add(data27Parameter);
			cmd.Parameters.Add(data28Parameter);
			cmd.Parameters.Add(data29Parameter);
			cmd.Parameters.Add(data30Parameter);
			cmd.Parameters.Add(data31Parameter);
			cmd.Parameters.Add(data32Parameter);
			cmd.Parameters.Add(unkint32Parameter);
			cmd.Parameters.Add(ainameParameter);
			cmd.Parameters.Add(scriptnameParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.Parameters.Add(OLD_entryParameter);
			cmd.Parameters.Add(OLD_typeParameter);
			cmd.Parameters.Add(OLD_displayidParameter);
			cmd.Parameters.Add(OLD_nameParameter);
			cmd.Parameters.Add(OLD_iconnameParameter);
			cmd.Parameters.Add(OLD_castbarcaptionParameter);
			cmd.Parameters.Add(OLD_unk1Parameter);
			cmd.Parameters.Add(OLD_factionParameter);
			cmd.Parameters.Add(OLD_flagsParameter);
			cmd.Parameters.Add(OLD_sizeParameter);
			cmd.Parameters.Add(OLD_data0Parameter);
			cmd.Parameters.Add(OLD_data1Parameter);
			cmd.Parameters.Add(OLD_data2Parameter);
			cmd.Parameters.Add(OLD_data3Parameter);
			cmd.Parameters.Add(OLD_data4Parameter);
			cmd.Parameters.Add(OLD_data5Parameter);
			cmd.Parameters.Add(OLD_data6Parameter);
			cmd.Parameters.Add(OLD_data7Parameter);
			cmd.Parameters.Add(OLD_data8Parameter);
			cmd.Parameters.Add(OLD_data9Parameter);
			cmd.Parameters.Add(OLD_data10Parameter);
			cmd.Parameters.Add(OLD_data11Parameter);
			cmd.Parameters.Add(OLD_data12Parameter);
			cmd.Parameters.Add(OLD_data13Parameter);
			cmd.Parameters.Add(OLD_data14Parameter);
			cmd.Parameters.Add(OLD_data15Parameter);
			cmd.Parameters.Add(OLD_data16Parameter);
			cmd.Parameters.Add(OLD_data17Parameter);
			cmd.Parameters.Add(OLD_data18Parameter);
			cmd.Parameters.Add(OLD_data19Parameter);
			cmd.Parameters.Add(OLD_data20Parameter);
			cmd.Parameters.Add(OLD_data21Parameter);
			cmd.Parameters.Add(OLD_data22Parameter);
			cmd.Parameters.Add(OLD_data23Parameter);
			cmd.Parameters.Add(OLD_data24Parameter);
			cmd.Parameters.Add(OLD_data25Parameter);
			cmd.Parameters.Add(OLD_data26Parameter);
			cmd.Parameters.Add(OLD_data27Parameter);
			cmd.Parameters.Add(OLD_data28Parameter);
			cmd.Parameters.Add(OLD_data29Parameter);
			cmd.Parameters.Add(OLD_data30Parameter);
			cmd.Parameters.Add(OLD_data31Parameter);
			cmd.Parameters.Add(OLD_data32Parameter);
			cmd.Parameters.Add(OLD_unkint32Parameter);
			cmd.Parameters.Add(OLD_ainameParameter);
			cmd.Parameters.Add(OLD_scriptnameParameter);
			cmd.Parameters.Add(OLD_verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_entry = entry;
			OLD_type = type;
			OLD_displayId = displayId;
			OLD_name = name;
			OLD_IconName = IconName;
			OLD_castBarCaption = castBarCaption;
			OLD_unk1 = unk1;
			OLD_faction = faction;
			OLD_flags = flags;
			OLD_size = size;
			OLD_Data0 = Data0;
			OLD_Data1 = Data1;
			OLD_Data2 = Data2;
			OLD_Data3 = Data3;
			OLD_Data4 = Data4;
			OLD_Data5 = Data5;
			OLD_Data6 = Data6;
			OLD_Data7 = Data7;
			OLD_Data8 = Data8;
			OLD_Data9 = Data9;
			OLD_Data10 = Data10;
			OLD_Data11 = Data11;
			OLD_Data12 = Data12;
			OLD_Data13 = Data13;
			OLD_Data14 = Data14;
			OLD_Data15 = Data15;
			OLD_Data16 = Data16;
			OLD_Data17 = Data17;
			OLD_Data18 = Data18;
			OLD_Data19 = Data19;
			OLD_Data20 = Data20;
			OLD_Data21 = Data21;
			OLD_Data22 = Data22;
			OLD_Data23 = Data23;
			OLD_Data24 = Data24;
			OLD_Data25 = Data25;
			OLD_Data26 = Data26;
			OLD_Data27 = Data27;
			OLD_Data28 = Data28;
			OLD_Data29 = Data29;
			OLD_Data30 = Data30;
			OLD_Data31 = Data31;
			OLD_Data32 = Data32;
			OLD_unkInt32 = unkInt32;
			OLD_AIName = AIName;
			OLD_ScriptName = ScriptName;
			OLD_VerifiedBuild = VerifiedBuild;
		}
	}
}
