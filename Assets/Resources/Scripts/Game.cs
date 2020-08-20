using UnityEngine;

public class Game {

  public InputHandler inputHandler;

  public void Init() {
    Reset();
  }

  public void Destroy() {

  }

  private void Reset() {
    Destroy();
  }

  public Main.State OnUpdate() {
    if (inputHandler.escPressed) {
      inputHandler.Reset();
      return new Main.MenuState { };
    }
    return null;
  }
}
