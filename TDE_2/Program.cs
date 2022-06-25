using IBM.Cloud.SDK.Core.Authentication.Iam;
using IBM.Watson.NaturalLanguageUnderstanding.v1;
using IBM.Watson.NaturalLanguageUnderstanding.v1.Model;


IamAuthenticator authenticator = new IamAuthenticator(
    apikey: "qi4b61NCLqbjAyubISqKy9kYu3gaUFsrkAfo9UhdbUc4"
    );



NaturalLanguageUnderstandingService naturalLanguageUnderstanding = new NaturalLanguageUnderstandingService("2022-04-07", authenticator);
naturalLanguageUnderstanding.SetServiceUrl("https://api.us-south.natural-language-understanding.watson.cloud.ibm.com/instances/38d41435-95f1-44c2-be41-40f02121825a");

var texto = System.IO.File.ReadAllText(Path.Combine("C:\\Users\\Gabriel\\Desktop\\TDE_2\\TDE_2\\conteudo\\", "texto3.html"));


var result = naturalLanguageUnderstanding.Analyze(
    html: texto,
    features: new Features()
    {
        Keywords = new KeywordsOptions()
        {
            Sentiment = true,
            Emotion = true,
            Limit = 2
        }
    }
    );

Console.WriteLine(result.Response);
