using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flashlight_script : MonoBehaviour
{
    public GameObject light;
    public bool isClicked;
    public float flashbattery = 100;
    public Text flashtext;
    public float flashbatteryleft;
    public float flashlevel;
    public float flashdecrese = 1;
    public Light myLight;
    public Light myLight2;
    private void Update()
    {
    if (myLight.enabled)
        {
                isClicked = true;   
        }
    if (!myLight.enabled)
        {  
                isClicked = false;
        }
        flashtext.text = flashlevel.ToString("F0") + "%";
        if (flashbatteryleft > 0 && isClicked)
        {
            flashbatteryleft = flashbatteryleft - flashdecrese;
            
        }
        flashlevel = (flashbatteryleft / flashbattery) * 100;
        if (flashlevel <= 0)
        {
            light.SetActive(false);
            isClicked = false;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            myLight.enabled = !myLight.enabled;
            myLight2.enabled = !myLight2.enabled;
        }
    }
    private void Start()
    {
        flashbatteryleft = flashbattery;   
        
    }
    

}
