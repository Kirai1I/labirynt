using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : PickUp
{
    public KeyColor Keys;

    public override void Picked()
    {
        GameManager.Instance.AddKey(Keys);
        base.Picked();
    }
}
