using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    InputSystem inputSystem;
    PlayerMovement playerMovement;



    void Awake()
    {
        inputSystem = GetComponent<InputSystem>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        inputSystem.HandleAllInput();
    }

    private void FixedUpdate()
    {
        playerMovement.HandleAllMovements();
    }
}
