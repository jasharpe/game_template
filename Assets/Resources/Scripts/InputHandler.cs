using UnityEngine.InputSystem;

public class InputHandler {
  private InputAction escAction;
  private InputAction entAction;
  private InputAction upAction;
  private InputAction downAction;


  public bool escPressed { get; private set; }
  public bool entPressed { get; private set; }
  public bool upPressed { get; private set; }
  public bool downPressed { get; private set; }

  public InputHandler() {
    escAction = new InputAction("esc", binding: "<Keyboard>/escape");
    escAction.Enable();
    escAction.performed += ctx => {
      escPressed = true;
    };
    entAction = new InputAction("ent", binding: "<Keyboard>/enter");
    entAction.Enable();
    entAction.performed += ctx => {
      entPressed = true;
    };
    upAction = new InputAction("up", binding: "<Keyboard>/upArrow");
    upAction.Enable();
    upAction.performed += ctx => {
      upPressed = true;
    };
    downAction = new InputAction("down", binding: "<Keyboard>/downArrow");
    downAction.Enable();
    downAction.performed += ctx => {
      downPressed = true;
    };
  }

  public void Reset() {
    escPressed = false;
    entPressed = false;
    upPressed = false;
    downPressed = false;
  }
}
