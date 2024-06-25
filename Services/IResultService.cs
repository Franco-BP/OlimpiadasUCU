using OlimpiadasUCU.DTO;

namespace OlimpiadasUCU.Services
{
    public interface IResultService
    {
        ResultDTO Get(int competitionNumber);
        List<ResultDTO> GetAll();
        ResultDTO Create(ResultDTO resultDto);
        ResultDTO Update(int competitionNumber, ResultDTO resultDto);
        bool Delete(int competitionNumber);
    }

    public class ResultService : IResultService
    {
        private readonly List<ResultDTO> _results = new List<ResultDTO>();

        public ResultDTO Get(int competitionNumber)
        {
            return _results.FirstOrDefault(r => r.CompetitionNumber == competitionNumber);
        }

        public List<ResultDTO> GetAll()
        {
            return _results;
        }

        public ResultDTO Create(ResultDTO resultDto)
        {
            _results.Add(resultDto);
            return resultDto;
        }

        public ResultDTO Update(int competitionNumber, ResultDTO resultDto)
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


