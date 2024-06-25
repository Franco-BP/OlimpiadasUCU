using OlimpiadasUCU.Models;

namespace OlimpiadasUCU.DTO
{
    public class ResultDTO
    {
        public int Id { get; set; }
        public float ResultValue { get; set; }
        public string Comment { get; set; }
        public int Position { get; set; }
        public int ParticipantId { get; set; }
        public int CompetitionId { get; set; }
    }
}
