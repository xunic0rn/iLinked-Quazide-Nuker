public static Config Load()
{
	return JsonConvert.DeserializeObject<Config>(File.ReadAllText("Config.json"));
}
