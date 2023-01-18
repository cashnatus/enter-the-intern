using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystem : MonoBehaviour
{

    PlayerInput playerInput;

    public Vector2 movementInput;
    public float verticalInput;
    public float horizontalInput;

    private void OnEnable()
    {
        if (playerInput == null)
        {
            playerInput = new PlayerInput();

            playerInput.Locomotion.Movement.performed += i => movementInput = i.ReadValue<Vector2>();
        }
        playerInput.Enable();

    }

    private void OnDisable()
    {
        playerInput.Disable();
    }

    public void HandleAllInput()
    {
        HandleMovementInput();
    }

    void HandleMovementInput()
    {
        verticalInput = movementInput.y;
        horizontalInput = movementInput.x;
    }






}
