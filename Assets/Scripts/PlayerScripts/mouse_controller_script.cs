using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_controller_script : MonoBehaviour
{
    [SerializeField] 
    float mouse_Sensitivity = 20000;
    Transform playerBody;
    float xRotation = 0;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        playerBody = transform.parent;
    }

    
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouse_Sensitivity * Time.deltaTime;    
        float mouseY = Input.GetAxis("Mouse Y") * mouse_Sensitivity * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -70, 50);

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        playerBody.Rotate(Vector3.up * mouseX);

    }
}
