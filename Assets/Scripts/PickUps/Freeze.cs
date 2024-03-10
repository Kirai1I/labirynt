using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze : PickUp
{
    public int TimeToFreeze = 10;
    public override void Picked()
    {
        GameManager.Instance.FreezeTime(TimeToFreeze);





        base.Picked();
    }
}
