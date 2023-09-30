// See https://aka.ms/new-console-template for more information


Console.WriteLine("Starting...");

//Load sample data
var sampleData = new SentimentModel.ModelInput()
{
    Col0 = @"Crust is not good.",
};

//Load model and predict output
var result = SentimentModel.Predict(sampleData);

// If Prediction is 1, sentiment is "Positive"; otherwise, sentiment is "Negative"
var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";
Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");

// ******************************************

//Load sample data
var sampleData2 = new SentimentModel.ModelInput()
{
    Col0 = @"This restaurant was wonderful.",
};

//Load model and predict output
var result2 = SentimentModel.Predict(sampleData2);

// If Prediction is 1, sentiment is "Positive"; otherwise, sentiment is "Negative"
var sentiment2 = result2.PredictedLabel == 1 ? "Positive" : "Negative";
Console.WriteLine($"Text: {sampleData2.Col0}\nSentiment: {sentiment2}");

Console.ReadKey();