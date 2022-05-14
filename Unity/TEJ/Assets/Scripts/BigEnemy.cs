using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigEnemy : Enemy
{
    protected void Awake()
    {
        path = "MediumEnemy";
        //Debug.Log("BIG");
        base.Awake();
    }

    protected override void Die()
    {
        base.Die();
    }
}
