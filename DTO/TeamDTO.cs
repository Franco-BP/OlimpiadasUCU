using System;
using System.Collections.Generic;

namespace OlimpiadasUCU.DTO;
public class TeamDTO
{
    public int Id { get; set; }
    public int Number { get; set; }
    public String Country { get; set; }
    public int ParticipantsAmount { get; set; }
    public List<ParticipantDto> Participants { get; set; }
}
