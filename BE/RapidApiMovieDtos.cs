// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

using System.Text.Json.Serialization;

public class Image
{
    public int height { get; set; }
    public string id { get; set; }
    public string url { get; set; }
    public int width { get; set; }
}

public class Meta
{
    public string operation { get; set; }
    public string requestId { get; set; }
    public double serviceTimeMs { get; set; }
}

public class ParentTitle
{
    public string id { get; set; }
    public Image image { get; set; }
    public string title { get; set; }
    public string titleType { get; set; }
    public int year { get; set; }
}

public class Principal
{
    public string id { get; set; }
    public string legacyNameText { get; set; }
    public string name { get; set; }
    public string category { get; set; }
    public List<string> characters { get; set; }
    public int endYear { get; set; }
    public int episodeCount { get; set; }
    public List<Role> roles { get; set; }
    public int startYear { get; set; }
    public string disambiguation { get; set; }
    public List<string> attr { get; set; }
    public int? billing { get; set; }
    public string @as { get; set; }
}

public class Result
{
    public string id { get; set; }
    public Image image { get; set; }
    public int runningTimeInMinutes { get; set; }
    public string nextEpisode { get; set; }
    public int numberOfEpisodes { get; set; }
    public int seriesEndYear { get; set; }
    public int seriesStartYear { get; set; }
    public string title { get; set; }
    public string titleType { get; set; }
    public int year { get; set; }
    public List<Principal> principals { get; set; }
    public int? episode { get; set; }
    public int? season { get; set; }
    public ParentTitle parentTitle { get; set; }
    public string previousEpisode { get; set; }
}

public class Role
{
    public string character { get; set; }
    public string characterId { get; set; }
}

public class Root
{
    [JsonPropertyName("@meta")]
    public Meta Meta { get; set; }

    [JsonPropertyName("@type")]
    public string Type { get; set; }
    public string query { get; set; }
    public List<Result> results { get; set; }
    public List<string> types { get; set; }
}

