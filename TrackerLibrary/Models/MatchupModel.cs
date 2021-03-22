﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Reprsents one match in the tournament.
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// The set of teams involved in this match.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// The winnner of the match.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents which round this match is a part of.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
