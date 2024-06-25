using System;
using System.Collections.Generic;

namespace OlimpiadasUCU.Models
{
    public class Result
    {
        public int CompetitionNumber { get; set; }
        public float ResultValue { get; set; }
        public string Comment { get; set; }
        public int Position { get; set; }
        public Participant Participant { get; set; }
        public Competition Competition { get; set; }
    }
}