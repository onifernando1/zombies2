using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraLook : MonoBehaviour
{

    [SerializeField] private InputManager inputManager;
    [SerializeField] private float mouseSensitivity = 5f;
    [SerializeField] private Transform playerTransform;
    private float xRotation = 0f;


    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        HandlePlayerLook();
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

    }

    private void HandlePlayerLook()
    {
        Vector2 playerLookVector = inputManager.GetMouseDelta();
        float mouseX = playerLookVector.x;
        float mouseY = playerLookVector.y;  
        mouseX = mouseX * mouseSensitivity * Time.deltaTime;
        mouseY = mouseY * mouseSensitivity * Time.deltaTime;
        playerTransform.Rotate(Vector3.up * mouseX);
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);  



    }
}
