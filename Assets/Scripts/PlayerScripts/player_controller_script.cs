using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller_script : MonoBehaviour
{
    [SerializeField]
    float speed = 12;
    CharacterController characterController;
   
    void Start()
    {
    characterController = GetComponent<CharacterController>();    
    }


    void Update()
    {
        prMove();    
    }

    private void prMove()
    {
        float x = Input.GetAxis("Horizontal");   
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.forward * z + transform.right * x;
        characterController.Move(move * speed * Time.deltaTime);
        
    }
}
