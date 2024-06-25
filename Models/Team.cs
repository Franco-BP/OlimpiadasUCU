using System;
using System.Collections.Generic;

namespace OlimpiadasUCU.Models
{
    public class Team
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Country { get; set; }
        public int ParticipantsAmount { get; set; }
        public List<Participant> Participants { get; set; }
    }
}