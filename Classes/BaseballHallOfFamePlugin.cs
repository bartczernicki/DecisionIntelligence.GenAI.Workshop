
using Microsoft.Bing.WebSearch;
using System.ComponentModel;
using System.IO;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.SemanticKernel;
using Microsoft.Extensions.Configuration;

public class WebSearchResult
{
    public int Id { get; set; } = 0;
    public string Name { get; set; } = string.Empty;
    public string Snippet { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
}

public class MLBBaseballBatter
{
    [LoadColumn(0), ColumnName("InductedToHallOfFame")]
    public bool InductedToHallOfFame { get; set; }

    [LoadColumn(1), ColumnName("OnHallOfFameBallot")]
    public bool OnHallOfFameBallot { get; set; }

    [LoadColumn(2), ColumnName("FullPlayerName")]
    public string FullPlayerName { get; set; }

    [LoadColumn(3), ColumnName("YearsPlayed")]
    public float YearsPlayed { get; set; }

    [LoadColumn(4), ColumnName("AB")]
    public float AB { get; set; }

    [LoadColumn(5), ColumnName("R")]
    public float R { get; set; }

    [LoadColumn(6), ColumnName("H")]
    public float H { get; set; }

    [LoadColumn(7), ColumnName("Doubles")]
    public float Doubles { get; set; }

    [LoadColumn(8), ColumnName("Triples")]
    public float Triples { get; set; }

    [LoadColumn(9), ColumnName("HR")]
    public float HR { get; set; }

    [LoadColumn(10), ColumnName("RBI")]
    public float RBI { get; set; }

    [LoadColumn(11), ColumnName("SB")]
    public float SB { get; set; }

    [LoadColumn(12), ColumnName("BattingAverage")]
    public float BattingAverage { get; set; }

    [LoadColumn(13), ColumnName("SluggingPct")]
    public float SluggingPct { get; set; }

    [LoadColumn(14), ColumnName("AllStarAppearances")]
    public float AllStarAppearances { get; set; }

    [LoadColumn(15), ColumnName("TB")]
    public float TB { get; set; }

    [LoadColumn(16), ColumnName("TotalPlayerAwards")]
    public float TotalPlayerAwards { get; set; }

    [LoadColumn(17), ColumnName("LastYearPlayed")]
    public float LastYearPlayed { get; set; }

    [LoadColumn(18), ColumnName("ID")]
    public string ID { get; set; }

    public override string ToString()
    {
        var mlbBatterString = $@"FullPlayerName:{this.FullPlayerName}, YearPlayed:{this.YearsPlayed}, AB:{this.AB}
        R:{this.R}, H:{this.H}, Doubles:{this.Doubles}, Triples:{this.Triples}, HR:{this.HR}, RBI:{this.RBI}, SB:{this.SB},
        BattingAvg:{this.BattingAverage}, Slg:{this.SluggingPct}, AllStar:{this.AllStarAppearances},
        TB:{this.TB}, LastYearPlayed:{this.LastYearPlayed}, ID:{this.ID}";

        return mlbBatterString;
    }

    public static MLBBaseballBatter FromCsv(string csvLine)
    {
        string[] values = csvLine.Split(',');
        MLBBaseballBatter mlbBaseballBatter = new MLBBaseballBatter();

        mlbBaseballBatter.InductedToHallOfFame = Convert.ToBoolean(values[0]);
        mlbBaseballBatter.OnHallOfFameBallot = Convert.ToBoolean(values[1]);
        mlbBaseballBatter.FullPlayerName = Convert.ToString(values[2]);
        mlbBaseballBatter.YearsPlayed = float.Parse(values[3], System.Globalization.NumberStyles.Any);
        mlbBaseballBatter.AB = float.Parse(values[4], System.Globalization.NumberStyles.Any);
        mlbBaseballBatter.R = float.Parse(values[5], System.Globalization.NumberStyles.Any);
        mlbBaseballBatter.H = float.Parse(values[6], System.Globalization.NumberStyles.Any);
        mlbBaseballBatter.Doubles = float.Parse(values[7], System.Globalization.NumberStyles.Any);
        mlbBaseballBatter.Triples = float.Parse(values[8], System.Globalization.NumberStyles.Any);
        mlbBaseballBatter.HR = float.Parse(values[9], System.Globalization.NumberStyles.Any);
        mlbBaseballBatter.RBI = float.Parse(values[10], System.Globalization.NumberStyles.Any);
        mlbBaseballBatter.SB = float.Parse(values[11], System.Globalization.NumberStyles.Any);
        mlbBaseballBatter.BattingAverage = float.Parse(values[12], System.Globalization.NumberStyles.Any);
        mlbBaseballBatter.SluggingPct = float.Parse(values[13], System.Globalization.NumberStyles.Any);
        mlbBaseballBatter.AllStarAppearances = float.Parse(values[14]);
        mlbBaseballBatter.TB = float.Parse(values[15], System.Globalization.NumberStyles.Any);
        mlbBaseballBatter.TotalPlayerAwards = float.Parse(values[16], System.Globalization.NumberStyles.Any);
        mlbBaseballBatter.LastYearPlayed = float.Parse(values[17], System.Globalization.NumberStyles.Any);
        mlbBaseballBatter.ID = Convert.ToString(values[18]);

        return mlbBaseballBatter;
    }
}

public class MLBHOFPrediction
{
    [ColumnName("PredictedLabel")]
    public bool Prediction { get; set; }

    [ColumnName("Probability")]
    public float Probability { get; set; }

    [ColumnName("Score")]
    public float Score { get; set; }
}

public class BaseballHallOfFamePlugin
{
    [KernelFunction]
    [Description("Retrieves a Machine Learning probability of a player being Inducted to Hall Of Fame using a the player's baseball statistics.")]
    public async Task<float> GetPlayerProbabilityOfHallOfFame(
        [Description("The statistics of the baseball player.")]
        MLBBaseballBatter baseballStatistics)
    {
        string modelPath = Directory.GetParent(Directory.GetCurrentDirectory()) + "/Models/InductedToHoF-GeneralizedAdditiveModels.mlnet";
        var mlContext = new MLContext(seed: 100);
        ITransformer loadedModel;
        DataViewSchema schema;

        using (var stream = File.OpenRead(modelPath))
        {
            loadedModel = mlContext.Model.Load(stream, out schema);
        }
        TransformerChain<ITransformer> transfomerChain = (TransformerChain<ITransformer>)loadedModel;

        var predEngineInductedToHallOfFame = mlContext.Model.CreatePredictionEngine<MLBBaseballBatter, MLBHOFPrediction>(transfomerChain);
        var prediction = predEngineInductedToHallOfFame.Predict(baseballStatistics);

        return prediction.Probability;
    }

    [KernelFunction]
    [Description("Retrieves baseball statistics for a given baseball player.")]
    public async Task<MLBBaseballBatter> GetBaseballPlayerStats(
        [Description("The name of the baseball player to search for.")]
        string nameOfBaseballPlayer)
    {
        // Directory of the historical baseball data
        string filePathMLBBaseballBatters = Directory.GetParent(Directory.GetCurrentDirectory()) + "/Data/MLBBaseballBattersPositionPlayers.csv";
        // Read the batters data from the CSV file
        var batters = File.ReadAllLines(filePathMLBBaseballBatters)
            .Skip(1)
            .Select(v => MLBBaseballBatter.FromCsv(v))
            .ToList();

        var mikeTroutStats = batters.Where(b => b.FullPlayerName == "Mike Trout").FirstOrDefault();
        return mikeTroutStats;
    }

    [KernelFunction]
    [Description("Retrieves the web search results with identified URL sources for a given baseball player.")]
    public async Task<string> GetWebSearchResults(
        [Description("The name of the baseball player to search for.")]
        string nameOfBaseballPlayer)
    {
        var configurationBuilder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
            .AddJsonFile("secrets.settings.json", optional: true, reloadOnChange: true);
        var config = configurationBuilder.Build();
        var bingSearchAPIKey = config["BingSearch:APIKey"];

        var webSearchResultsString = "Web search results:\r\n\r\n";
        var footNotes = string.Empty;
        var bingSearchId = 0;
        var webSearchResults = new List<WebSearchResult>();

        var bingSearchClient = new WebSearchClient(new ApiKeyServiceClientCredentials(bingSearchAPIKey));
        var bingWebData = await bingSearchClient.Web.SearchAsync(query: "baseball hall of fame " + nameOfBaseballPlayer, count: 8);

        if (bingWebData?.WebPages?.Value?.Count > 0)
        {
            // Itertate over the Bing Web Pages (Non-Cache Results)
            foreach (var bingWebPage in bingWebData.WebPages.Value)
            {
                bingSearchId++;

                webSearchResultsString += string.Format("[{0}]: \"{1}: {2}\"\r\nURL: {3}\r\n\r\n",
                    bingSearchId, bingWebPage.Name, bingWebPage.Snippet, bingWebPage.Url);

                footNotes += string.Format("[{0}]: {1}: {2}  \r\n",
                    bingSearchId, bingWebPage.Name, bingWebPage.Url);

                webSearchResults.Add(new WebSearchResult
                {
                    Id = bingSearchId,
                    Name = bingWebPage.Name,
                    Snippet = bingWebPage.Snippet,
                    Url = bingWebPage.Url
                });
            }
        }

        return webSearchResultsString;
    }
}