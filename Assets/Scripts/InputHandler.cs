using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    public PlayerController controller;

    private InputAction _moveAction;

    void Start()
    {
        _moveAction = InputSystem.actions.FindAction("Move");
    }

    void Update()
    {
        Vector2 movementVector = _moveAction.ReadValue<Vector2>();
        controller.Move(movementVector);
    }

}
