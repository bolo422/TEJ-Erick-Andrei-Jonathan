using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highscore
{
    public int HighScore(IEnemyCounter count)
    {
        return count.BigEnemyCount * 50 + count.MediumEnemyCount * 100 + count.SmallEnemyCount * 200;
    }

    public int TotalHighScore(IEnemyCounter count)
    {
        int big = count.BigEnemyCount;
        int medium = count.MediumEnemyCount + (big * 2);
        int small = count.SmallEnemyCount + (medium * 4);

        int bigScore = big * 50;
        int medScore = medium * 100;
        int smallScore = small * 200;

        int total = bigScore + medScore + smallScore;

        return total;
    }
}
