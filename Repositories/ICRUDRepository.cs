namespace OlimpiadasUCU.Repositories;

public interface ICRUDRepository<DTO>
{
  DTO Create(DTO dto);
  List<DTO> GetAll();
  DTO Update(DTO dto);
  void Delete(int id);
}