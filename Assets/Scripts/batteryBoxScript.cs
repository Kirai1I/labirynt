using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class batteryBoxScript : MonoBehaviour
{
    public Text pressEtext;
    bool colision;
    // Start is called before the first frame update
    void Start()
    {
        pressEtext.enabled = false;   
    }

    // Update is called once per frame
    void Update()
    {
        colision = false;
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            pressEtext.enabled = true;
            colision = true;
           
        }
        




    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            pressEtext.enabled=false;
        }
    }
  


}

