using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f; // variable for moving the mouse
    public Transform playerBody; // player transform reference
    public float xRotation = 0f; // up/down rotation variable
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // move the cursor from the game screen
    }
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        playerBody.Rotate(Vector3.up * mouseX); // code for moving the camera left/right
        xRotation -= mouseY; // code for moving the camera up/down
        xRotation = Mathf.Clamp(xRotation, -10f, 10f); // limit rotation so it is only 90 deg up and down
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0); // used to set the local rotation of an object
    }
}
