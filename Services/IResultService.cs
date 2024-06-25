using OlimpiadasUCU.DTO;

namespace OlimpiadasUCU.Services
{
    public interface IResultService
    {
        ResultDto Get(int competitionNumber);
        List<ResultDto> GetAll();
        ResultDto Create(ResultDto resultDto);
        ResultDto Update(int competitionNumber, ResultDto resultDto);
        bool Delete(int competitionNumber);
    }

    public class ResultService : IResultService
    {
        private readonly List<ResultDto> _results = new List<ResultDto>();

        public ResultDto Get(int competitionNumber)
        {
            return _results.FirstOrDefault(r => r.CompetitionNumber == competitionNumber);
        }

        public List<ResultDto> GetAll()
        {
            return _results;
        }

        public ResultDto Create(ResultDto resultDto)
        {
            _results.Add(resultDto);
            return resultDto;
        }

        public ResultDto Update(int competitionNumber, ResultDto resultDto)
        {
            var existingResult = Get(competitionNumber);
            if (existingResult == null)
            {
                return null;
            }
            existingResult.ResultValue = resultDto.ResultValue;
            existingResult.Comment = resultDto.Comment;
            existingResult.Position = resultDto.Position;
            existingResult.ParticipantId = resultDto.ParticipantId;
            existingResult.CompetitionId = resultDto.CompetitionId;
            return existingResult;
        }

        public bool Delete(int competitionNumber)
        {
            var result = Get(competitionNumber);
            if (result == null)
            {
                return false;
            }
            _results.Remove(result);
            return true;
        }
    }
}


