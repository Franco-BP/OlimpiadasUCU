using System;
using System.Collections.Generic;

namespace OlimpiadasUCU.Models
{
    public class Points : IWinnerStrategy
    {
        public List<Participant> CalculateWinner(List<Participant> participants)
        {
            return participants.OrderByDescending(p => p.Medals.Max(m => m.ResultValue)).Take(1).ToList();
        }
    }
}