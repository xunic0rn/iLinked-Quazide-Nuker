using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Quazide
{
	// Token: 0x02000003 RID: 3
	public class Config
	{

		[JsonProperty("token")]
		public string Token { get; private set; }

		[JsonProperty("create_channels_amount")]
		public int CreateChannelsAmount { get; private set; }

		[JsonProperty("create_channels_name")]
		public string CreateChannelsName { get; private set; }
    
		[JsonProperty("cmd_mode")]
		public bool UseCommand { get; private set; }

		[JsonProperty("prefix")]
		public string Prefix { get; private set; }
    
		[JsonProperty("command")]
		public string Command { get; private set; }

		[JsonProperty("cmd_whitelist")]
		public List<ulong> CmdWhitelist { get; private set; }

		// Token: 0x0600001A RID: 26 RVA: 0x0000278F File Offset: 0x0000098F
		public static Config Load()
		{
			return JsonConvert.DeserializeObject<Config>(File.ReadAllText("Config.json"));
		}
	}
}
