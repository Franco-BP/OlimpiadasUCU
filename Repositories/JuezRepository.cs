namespace OlimpiadasUCU.Repositories;

public class JuezRepository
{
  private static JuezRepository Instance {
    get {
      if (JuezRepository.Instance == null) {
        JuezRepository.Instance = new JuezRepository();
      }
      return JuezRepository.Instance;
    }
    set {
      JuezRepository.Instance = value;
    }
  }

  private JuezRepository(){}
}