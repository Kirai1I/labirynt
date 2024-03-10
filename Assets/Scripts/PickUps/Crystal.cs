using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : PickUp
{
    public int PointToAdd = 100;
    public override void Picked()
    {
        GameManager.Instance.AddPoints(PointToAdd);





        base.Picked();
    }
}
