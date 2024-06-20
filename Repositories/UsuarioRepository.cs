namespace OlimpiadasUCU.Repositories;

public class UsuarioRepository
{
  private static UsuarioRepository Instance {
    get {
      if (UsuarioRepository.Instance == null) {
        UsuarioRepository.Instance = new UsuarioRepository();
      }
      return UsuarioRepository.Instance;
    }
    set {
      UsuarioRepository.Instance = value;
    }
  }

  private UsuarioRepository(){}
}