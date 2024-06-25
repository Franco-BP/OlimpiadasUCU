using System;
using System.Collections.Generic;

namespace OlimpiadasUCU.Models
{
    public class Time : IWinnerStrategy
    {
        public List<Participant> CalculateWinner(List<Participant> participants)
        {
            // Implementación de ejemplo: selecciona al participante con el menor resultado en tiempo
            return participants.OrderBy(p => p.Medals.Min(m => m.ResultValue)).Take(1).ToList();
        }
    }
}