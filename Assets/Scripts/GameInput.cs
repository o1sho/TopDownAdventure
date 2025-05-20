using UnityEngine;
using UnityEngine.InputSystem;

public class GameInput : MonoBehaviour
{
    public static GameInput Instance { get; private set; }

    private InputSystem_Actions inputSystem;

    private void Awake() {
        Instance = this;

        inputSystem = new InputSystem_Actions();
        inputSystem.Enable();
    }

    public Vector2 GetMovementVector() {
        Vector2 inputVector = inputSystem.Player.Move.ReadValue<Vector2>();
        return inputVector;
    }

    public Vector3 GetMousePosition() {
        Vector3 mousePos = Mouse.current.position.ReadValue();
        return mousePos;
    }
}
