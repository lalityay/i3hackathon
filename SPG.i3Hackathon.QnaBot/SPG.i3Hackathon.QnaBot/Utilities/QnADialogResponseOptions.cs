using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPG.i3Hackathon.QnaBot.Utilities
{
    public class QnADialogResponseOptions
    {
        /// <summary>
        /// Gets or sets get or set for No answer.
        /// </summary>
        public string NoAnswer { get; set; }

        /// <summary>
        /// Gets or sets get or set for Active learning card title.
        /// </summary>
        public string ActiveLearningCardTitle { get; set; }

        /// <summary>
        /// Gets or sets get or set for Card no match text.
        /// </summary>
        public string CardNoMatchText { get; set; }

        /// <summary>
        /// Gets or sets get or set for Card no match response.
        /// </summary>
        public string CardNoMatchResponse { get; set; }
    }
}
