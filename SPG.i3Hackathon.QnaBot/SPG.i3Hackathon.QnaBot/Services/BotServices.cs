using Microsoft.Bot.Builder.AI.QnA;
using Microsoft.Extensions.Configuration;

namespace SPG.i3Hackathon.QnaBot.Services
{
    public class BotServices : IBotServices
    {
        public BotServices(IConfiguration configuration)
        {
            QnAMakerService = new QnAMaker(new QnAMakerEndpoint
            {
                KnowledgeBaseId = configuration["QnAKnowledgebaseId"],
                EndpointKey = configuration["QnAEndpointKey"],
                Host = GetHostname(configuration["QnAEndpointHostName"])
            });
        }

        public QnAMaker QnAMakerService { get; private set; }

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
