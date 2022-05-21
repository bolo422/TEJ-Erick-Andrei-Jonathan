using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediumEnemy : Enemy
{
    public static int count = 0;
    protected void Awake()
    {
        count++;
        hp = 5;
        speed = 1.8f;
        score = 100;
        quantity = 4;
        path = "SmallEnemy";
        base.Awake();
    }

    
}
