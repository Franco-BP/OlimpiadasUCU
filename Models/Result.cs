using System;
using System.Collections.Generic;

namespace OlimpiadasUCU.Models
{
    public class Result
    {
        public int Id { get; set; }
        public float ResultValue { get; set; }
        public string Comment { get; set; }
        public int Position { get; set; }
        public int ParticipantId { get; set; }
        public int CompetitionId { get; set; }
    }
}