using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Creature_text
	{
		int entry = 0; //Comment: 
		int OLD_entry = 0;

		int groupid = 0; //Comment: 
		int OLD_groupid = 0;

		int id = 0; //Comment: 
		int OLD_id = 0;

		string text = null; //Comment: 
		string OLD_text = null;

		int type = 0; //Comment: 
		int OLD_type = 0;

		int language = 0; //Comment: 
		int OLD_language = 0;

		float probability = 0f; //Comment: 
		float OLD_probability = 0f;

		int emote = 0; //Comment: 
		int OLD_emote = 0;

		int duration = 0; //Comment: 
		int OLD_duration = 0;

		int sound = 0; //Comment: 
		int OLD_sound = 0;

		int BroadcastTextId = 0; //Comment: 
		int OLD_BroadcastTextId = 0;

		int TextRange = 0; //Comment: 
		int OLD_TextRange = 0;

		string comment = null; //Comment: 
		string OLD_comment = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Creature_text(int _entry, int _groupid, int _id, string _text, int _type, int _language, float _probability, int _emote, int _duration, int _sound, int _BroadcastTextId, int _TextRange, string _comment)
		{
			entry = _entry;
			groupid = _groupid;
			id = _id;
			text = _text;
			type = _type;
			language = _language;
			probability = _probability;
			emote = _emote;
			duration = _duration;
			sound = _sound;
			BroadcastTextId = _BroadcastTextId;
			TextRange = _TextRange;
			comment = _comment;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM creature_text WHERE entry = @entry AND groupid = @groupid AND id = @id AND text = @text AND type = @type AND language = @language AND probability = @probability AND emote = @emote AND duration = @duration AND sound = @sound AND BroadcastTextId = @BroadcastTextId AND TextRange = @TextRange AND comment = @comment;";
			MySqlParameter entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter groupidParameter = new MySqlParameter("@groupid", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@id", MySqlDbType.VarChar, 0);
			MySqlParameter textParameter = new MySqlParameter("@text", MySqlDbType.VarChar, 0);
			MySqlParameter typeParameter = new MySqlParameter("@type", MySqlDbType.VarChar, 0);
			MySqlParameter languageParameter = new MySqlParameter("@language", MySqlDbType.VarChar, 0);
			MySqlParameter probabilityParameter = new MySqlParameter("@probability", MySqlDbType.VarChar, 0);
			MySqlParameter emoteParameter = new MySqlParameter("@emote", MySqlDbType.VarChar, 0);
			MySqlParameter durationParameter = new MySqlParameter("@duration", MySqlDbType.VarChar, 0);
			MySqlParameter soundParameter = new MySqlParameter("@sound", MySqlDbType.VarChar, 0);
			MySqlParameter broadcasttextidParameter = new MySqlParameter("@BroadcastTextId", MySqlDbType.VarChar, 0);
			MySqlParameter textrangeParameter = new MySqlParameter("@TextRange", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@comment", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			groupidParameter.Value = groupid;
			idParameter.Value = id;
			textParameter.Value = text;
			typeParameter.Value = type;
			languageParameter.Value = language;
			probabilityParameter.Value = probability;
			emoteParameter.Value = emote;
			durationParameter.Value = duration;
			soundParameter.Value = sound;
			broadcasttextidParameter.Value = BroadcastTextId;
			textrangeParameter.Value = TextRange;
			commentParameter.Value = comment;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(groupidParameter);
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(textParameter);
			cmd.Parameters.Add(typeParameter);
			cmd.Parameters.Add(languageParameter);
			cmd.Parameters.Add(probabilityParameter);
			cmd.Parameters.Add(emoteParameter);
			cmd.Parameters.Add(durationParameter);
			cmd.Parameters.Add(soundParameter);
			cmd.Parameters.Add(broadcasttextidParameter);
			cmd.Parameters.Add(textrangeParameter);
			cmd.Parameters.Add(commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE creature_text SET entry = @newentry, groupid = @newgroupid, id = @newid, text = @newtext, type = @newtype, language = @newlanguage, probability = @newprobability, emote = @newemote, duration = @newduration, sound = @newsound, BroadcastTextId = @newBroadcastTextId, TextRange = @newTextRange, comment = @newcomment WHERE entry = @entry AND groupid = @groupid AND id = @id AND text = @text AND type = @type AND language = @language AND probability = @probability AND emote = @emote AND duration = @duration AND sound = @sound AND BroadcastTextId = @BroadcastTextId AND TextRange = @TextRange AND comment = @comment;";
			MySqlParameter OLD_entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_groupidParameter = new MySqlParameter("@groupid", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_idParameter = new MySqlParameter("@id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_textParameter = new MySqlParameter("@text", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_typeParameter = new MySqlParameter("@type", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_languageParameter = new MySqlParameter("@language", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_probabilityParameter = new MySqlParameter("@probability", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_emoteParameter = new MySqlParameter("@emote", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_durationParameter = new MySqlParameter("@duration", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_soundParameter = new MySqlParameter("@sound", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_broadcasttextidParameter = new MySqlParameter("@BroadcastTextId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_textrangeParameter = new MySqlParameter("@TextRange", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_commentParameter = new MySqlParameter("@comment", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@newentry", MySqlDbType.VarChar, 0);
			MySqlParameter groupidParameter = new MySqlParameter("@newgroupid", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newid", MySqlDbType.VarChar, 0);
			MySqlParameter textParameter = new MySqlParameter("@newtext", MySqlDbType.VarChar, 0);
			MySqlParameter typeParameter = new MySqlParameter("@newtype", MySqlDbType.VarChar, 0);
			MySqlParameter languageParameter = new MySqlParameter("@newlanguage", MySqlDbType.VarChar, 0);
			MySqlParameter probabilityParameter = new MySqlParameter("@newprobability", MySqlDbType.VarChar, 0);
			MySqlParameter emoteParameter = new MySqlParameter("@newemote", MySqlDbType.VarChar, 0);
			MySqlParameter durationParameter = new MySqlParameter("@newduration", MySqlDbType.VarChar, 0);
			MySqlParameter soundParameter = new MySqlParameter("@newsound", MySqlDbType.VarChar, 0);
			MySqlParameter broadcasttextidParameter = new MySqlParameter("@newBroadcastTextId", MySqlDbType.VarChar, 0);
			MySqlParameter textrangeParameter = new MySqlParameter("@newTextRange", MySqlDbType.VarChar, 0);
			MySqlParameter commentParameter = new MySqlParameter("@newcomment", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			groupidParameter.Value = groupid;
			idParameter.Value = id;
			textParameter.Value = text;
			typeParameter.Value = type;
			languageParameter.Value = language;
			probabilityParameter.Value = probability;
			emoteParameter.Value = emote;
			durationParameter.Value = duration;
			soundParameter.Value = sound;
			broadcasttextidParameter.Value = BroadcastTextId;
			textrangeParameter.Value = TextRange;
			commentParameter.Value = comment;
			OLD_entryParameter.Value = OLD_entry;
			OLD_groupidParameter.Value = OLD_groupid;
			OLD_idParameter.Value = OLD_id;
			OLD_textParameter.Value = OLD_text;
			OLD_typeParameter.Value = OLD_type;
			OLD_languageParameter.Value = OLD_language;
			OLD_probabilityParameter.Value = OLD_probability;
			OLD_emoteParameter.Value = OLD_emote;
			OLD_durationParameter.Value = OLD_duration;
			OLD_soundParameter.Value = OLD_sound;
			OLD_broadcasttextidParameter.Value = OLD_BroadcastTextId;
			OLD_textrangeParameter.Value = OLD_TextRange;
			OLD_commentParameter.Value = OLD_comment;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(groupidParameter);
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(textParameter);
			cmd.Parameters.Add(typeParameter);
			cmd.Parameters.Add(languageParameter);
			cmd.Parameters.Add(probabilityParameter);
			cmd.Parameters.Add(emoteParameter);
			cmd.Parameters.Add(durationParameter);
			cmd.Parameters.Add(soundParameter);
			cmd.Parameters.Add(broadcasttextidParameter);
			cmd.Parameters.Add(textrangeParameter);
			cmd.Parameters.Add(commentParameter);
			cmd.Parameters.Add(OLD_entryParameter);
			cmd.Parameters.Add(OLD_groupidParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_textParameter);
			cmd.Parameters.Add(OLD_typeParameter);
			cmd.Parameters.Add(OLD_languageParameter);
			cmd.Parameters.Add(OLD_probabilityParameter);
			cmd.Parameters.Add(OLD_emoteParameter);
			cmd.Parameters.Add(OLD_durationParameter);
			cmd.Parameters.Add(OLD_soundParameter);
			cmd.Parameters.Add(OLD_broadcasttextidParameter);
			cmd.Parameters.Add(OLD_textrangeParameter);
			cmd.Parameters.Add(OLD_commentParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_entry = entry;
			OLD_groupid = groupid;
			OLD_id = id;
			OLD_text = text;
			OLD_type = type;
			OLD_language = language;
			OLD_probability = probability;
			OLD_emote = emote;
			OLD_duration = duration;
			OLD_sound = sound;
			OLD_BroadcastTextId = BroadcastTextId;
			OLD_TextRange = TextRange;
			OLD_comment = comment;
		}
	}
}
