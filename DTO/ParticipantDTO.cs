using System;
using System.Collections.Generic;
using OlimpiadasUCU.Models;

namespace OlimpiadasUCU.DTO;

public class ParticipantDTO
{
    public int Id { get; set; }
    public int DocumentNumber { get; set; }
    public string Name { get; set; }
    public string Country { get; set; }
    public string BloodType { get; set; }
    public List<Result> Medals { get; set; }
    public List<Competition> Competitions { get; set; }
}
