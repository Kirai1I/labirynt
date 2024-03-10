using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(100, 50, 12) * Time.deltaTime);
    }

    public virtual void Picked()
    {
        print("klasa bazowa Picked()");
        Destroy(gameObject);
    }

}
