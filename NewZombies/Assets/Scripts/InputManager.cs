using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{

    private PlayerInput playerInput;

    private void Awake()
    {
        playerInput = new PlayerInput();
    }
    
    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }

    public Vector2 GetPlayerMovement()
    {
        return playerInput.Player.Move.ReadValue<Vector2>();
    }

    public Vector2 GetMouseDelta()
    {
        return playerInput.Player.Look.ReadValue<Vector2>();
    }

    public bool PlayerJumped() {
        return playerInput.Player.Jump.triggered;
    }

    public bool PlayerShot() {
        return playerInput.Player.Shoot.triggered;
    }


}
