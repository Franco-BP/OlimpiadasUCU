using System;
using System.Collections.Generic;

namespace OlimpiadasUCU.Models
{
    public abstract class Discipline
    {
        public int Id { get; set; }
        public string Sex { get; set; }
        public string Variation { get; set; }
        public abstract List<Participant> CalculateWinner(List<Participant> participants);
    }
}
