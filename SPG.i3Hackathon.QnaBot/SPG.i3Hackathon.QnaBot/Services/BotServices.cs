using Microsoft.Bot.Builder.AI.Luis;
using Microsoft.Bot.Builder.AI.QnA;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace SPG.i3Hackathon.QnaBot.Services
{
    public class BotServices : IBotServices
    {
        public BotServices(IConfiguration configuration)
        {
            QnAMakerServiceList = new Dictionary<string, QnAMaker>();

            Dispatch = new LuisRecognizer(new LuisApplication(
                configuration["LuisAppId"],
                configuration["LuisAPIKey"],
                $"https://{configuration["LuisAPIHostName"]}.api.cognitive.microsoft.com"),
                new LuisPredictionOptions { IncludeAllIntents = true, IncludeInstanceData = true },
                includeApiResults: true);

            foreach (var kbitem in KbLuisMap.GetMap())
            {
                QnAMakerServiceList.Add(kbitem.Key, new QnAMaker(new QnAMakerEndpoint
                {
                    KnowledgeBaseId = kbitem.Value,
                    EndpointKey = configuration["QnAEndpointKey"],
                    Host = GetHostname(configuration["QnAEndpointHostName"])
                }));
            }


        }

        public QnAMaker GetServiceForIntent(string intent)
        {
            return QnAMakerServiceList[intent];
        }

        public Dictionary<string, QnAMaker> QnAMakerServiceList { get; private set; }

        public LuisRecognizer Dispatch { get; private set; }

        private static string GetHostname(string hostname)
        {
            if (!hostname.StartsWith("https://"))
            {
                hostname = string.Concat("https://", hostname);
            }

            if (!hostname.EndsWith("/qnamaker"))
            {
                hostname = string.Concat(hostname, "/qnamaker");
            }

            return hostname;
        }
    }
}
