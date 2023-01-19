using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    InputSystem inputSystem;
    Transform playerPos;
    Rigidbody2D playerRigidbody;

    Vector3 move;

    [Range(10, 100)]public float playerSpeed = 10f;

    private void Awake()
    {
        playerPos = GetComponent<Transform>();
        inputSystem = GetComponent<InputSystem>();
        playerRigidbody = GetComponent<Rigidbody2D>();
    }


    public void HandleAllMovements()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        move = playerPos.up * inputSystem.verticalInput;
        move = move + playerPos.right * inputSystem.horizontalInput;
        move.Normalize();
        move.z = 0;

        move = (move * playerSpeed) * Time.deltaTime;

        Vector2 moveVelocity = new Vector2(move.x, move.y);

        playerRigidbody.velocity = moveVelocity;

    }










}
