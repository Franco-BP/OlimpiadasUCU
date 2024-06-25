namespace OlimpiadasUCU.Services;

public interface ICRUDService<DTO>
{
  DTO Create(DTO dto);
  List<DTO> GetAll();
  DTO Update(DTO dto);
  void Delete(int id);
}