using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : PickUp 
{
    public int TimeToAdd = 10;
    public override void Picked()
    {
        GameManager.Instance.AddTime(TimeToAdd);





        base.Picked();
    }
}
