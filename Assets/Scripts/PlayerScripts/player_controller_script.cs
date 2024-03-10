using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller_script : MonoBehaviour
{
    [SerializeField]
    float speed = 12;

    CharacterController characterController;

    public Transform groundCheck;

    public LayerMask groundMask;

    float startSpeed;
    void Start()
    {
    characterController = GetComponent<CharacterController>();
        startSpeed = speed;
    }


    void Update()
    {
        prMove();    
    }

    private void prMove()
    {
        float x = Input.GetAxis("Horizontal");   
        float z = Input.GetAxis("Vertical");


        RaycastHit hit;
        if (Physics.Raycast(groundCheck.position,
            transform.TransformDirection(Vector3.down), out hit, 1, groundMask))
        {
        switch (hit.collider.gameObject.tag) {
                default: 
                    speed = startSpeed; 
                    break;
                case "LowSpeed":
                    speed = startSpeed / 4;
                    break;
                case "HighSpeed":
                        speed = startSpeed *2;
                    break;
            }
        }
       

        Vector3 move = transform.forward * z + transform.right * x;
        characterController.Move(move * speed * Time.deltaTime);

        
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
    if(hit.collider.tag == "Pickup")
        {
            hit.collider.GetComponent<PickUp>().Picked();
        }
        if (hit.collider.tag == "Box")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                print("charge");
                flashlight_script.Instance.flashbatteryleft += 70;
            }
        }
    }
   
}
