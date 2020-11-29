using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    float _sensitivity = 200;

    float xRotation;

    // Start is called before the first frame update
    void Start()
    {
            Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void Update()
    {
            float mouseX = Input.GetAxis("Mouse X") * _sensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * _sensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            transform.parent.Rotate(Vector3.up * mouseX);
    }
}
