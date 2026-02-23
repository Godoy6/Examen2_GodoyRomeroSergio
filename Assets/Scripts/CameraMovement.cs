using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform playerTransform;
    public float mouseSensitivity = 2000f;
    private float verticalRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void LateUpdate() 
    {
        float mouseDeltaX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseDeltaY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        verticalRotation -= mouseDeltaY;
        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);

        playerTransform.Rotate(Vector3.up * mouseDeltaX);
    }
}