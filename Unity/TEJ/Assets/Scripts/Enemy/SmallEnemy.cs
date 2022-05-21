using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallEnemy : Enemy
{
    protected void Awake()
    {
        hp = 2;
        speed = 2.2f;
        score = 200;
        base.Awake();
    }

}
