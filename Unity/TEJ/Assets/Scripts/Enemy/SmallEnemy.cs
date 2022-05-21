using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallEnemy : Enemy
{
    public static int count = 0;
    protected void Awake()
    {
        count++;
        hp = 2;
        speed = 2.2f;
        score = 200;
        base.Awake();
    }

}
