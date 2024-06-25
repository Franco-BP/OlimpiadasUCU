using System;
using System.Collections.Generic;

namespace OlimpiadasUCU.Models
{
    public class Distance : IWinnerStrategy
    {
        public List<Participant> CalculateWinner(List<Participant> participants)
        {
            return participants.OrderBy(p => p.Medals.Min(m => m.ResultValue)).Take(1).ToList();
        }
    }
}