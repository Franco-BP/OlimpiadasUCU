using System;
using System.Collections.Generic;

namespace OlimpiadasUCU.Models
{
    public abstract class Competition
    {
        public int Id { get; set; }
        public int Round { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public List<Participant> Ranking { get; set; }
        public abstract List<Participant> CalculateWinner();
    }
}
