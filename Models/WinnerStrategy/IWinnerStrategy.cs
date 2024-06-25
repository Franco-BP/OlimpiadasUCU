using System;
using System.Collections.Generic;

namespace OlimpiadasUCU.Models
{
    public interface IWinnerStrategy
    {
        List<Participant> CalculateWinner(List<Participant> participants);
    }
}