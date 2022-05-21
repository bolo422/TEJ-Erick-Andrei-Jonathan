using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemyCounter
{
    public int BigEnemyCount
    {
        get{ return BigEnemy.count; }
    }

    public int MediumEnemyCount
    {
        get { return MediumEnemy.count; }
    }

    public int SmallEnemyCount
    {
        get { return SmallEnemy.count; }
    }
}
