﻿using Microsoft.Bot.Builder.AI.Luis;
using Microsoft.Bot.Builder.AI.QnA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPG.i3Hackathon.QnaBot.Services
{
    public interface IBotServices
    {
        Dictionary<string, QnAMaker> QnAMakerServiceList { get; }

        LuisRecognizer Dispatch { get; }

        QnAMaker GetServiceForIntent(string intent);
    }
}
