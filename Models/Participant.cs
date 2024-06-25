using System;
using System.Collections.Generic;

namespace OlimpiadasUCU.Models
{
    public class Participant
    {
        public int Id { get; set; }
        public int DocumentNumber { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string BloodType { get; set; }
        public List<Result> Medals { get; set; }
        public List<Competition> Competitions { get; set; }
    }
}
