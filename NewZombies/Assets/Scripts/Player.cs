using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private InputManager inputManager;
    [SerializeField] private float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandlePlayerMovement();
    }

    void HandlePlayerMovement()
    {
        Vector2 playerMovementVector = inputManager.GetPlayerMovement();
        Debug.Log(playerMovementVector);
        playerMovementVector = playerMovementVector.normalized;
        Debug.Log(playerMovementVector);
        Vector3 movedir = transform.forward * playerMovementVector.y + transform.right * playerMovementVector.x;
        movedir.y = 0;
        transform.position += movedir * moveSpeed * Time.deltaTime;

    }
}
