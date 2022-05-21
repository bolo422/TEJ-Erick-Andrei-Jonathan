using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigEnemy : Enemy
{
    public static int count = 0;
    protected void Awake()
    {
        count++;
        hp = 10;
        speed = 1.0f;
        score = 50;
        quantity = 2;
        path = "MediumEnemy";
        Debug.LogWarning("BigEnemy Spawned- path:" + path);
        base.Awake();
    }
}
