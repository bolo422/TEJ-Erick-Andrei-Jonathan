using System;
using System.Collections;
using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class EditModeTests : ScriptableObject
{
    #region Moq
    [Test]
    [TestCase(1, 0, 0, 50)]
    [TestCase(1, 1, 1, 350)]
    [TestCase(13, 46, 134, 32050)]
    //[TestCase(13, -1, 134, 92250)]
    public void HighScoreTest
        (int big,
        int med,
        int small,
        int expectedHighScore)
    {
        var enemyCounter = new Mock<IEnemyCounter>();
        enemyCounter.Setup(c => c.BigEnemyCount).Returns(big);
        enemyCounter.Setup(c => c.MediumEnemyCount).Returns(med);
        enemyCounter.Setup(c => c.SmallEnemyCount).Returns(small);

        var highScore = new Highscore();

        var result_highScore = highScore.HighScore(enemyCounter.Object);

        Assert.AreEqual(expectedHighScore, result_highScore);

        //enemyCounter.VerifyGet(c => c.BigEnemyCount);
        //enemyCounter.VerifyGet(c => c.MediumEnemyCount);
        //enemyCounter.VerifyGet(c => c.SmallEnemyCount);
    }

    [Test]
    [TestCase(1, 0, 0, 1850)]
    [TestCase(1, 1, 1, 2950)]
    [TestCase(13, 46, 134, 92250)]
    //[TestCase(13, -1, 134, 92250)]
    public void TotalHighScoreTest
    (int big,
    int med,
    int small,
    int expectedTotalHighScore)
    {
        var enemyCounter = new Mock<IEnemyCounter>();
        enemyCounter.Setup(c => c.BigEnemyCount).Returns(big);
        enemyCounter.Setup(c => c.MediumEnemyCount).Returns(med);
        enemyCounter.Setup(c => c.SmallEnemyCount).Returns(small);

        var highScore = new Highscore();

        var result_totalHighScore = highScore.TotalHighScore(enemyCounter.Object);

        Assert.AreEqual(expectedTotalHighScore, result_totalHighScore);

        //enemyCounter.VerifyGet(c => c.BigEnemyCount);
        //enemyCounter.VerifyGet(c => c.MediumEnemyCount);
        //enemyCounter.VerifyGet(c => c.SmallEnemyCount);
    }

    [Test]
    [TestCase(true, false)]
    [TestCase(true, true)]
    [TestCase(false, false)]
    [TestCase(false, true)]
    public void ShootMoqTest(bool up, bool down)
    {
        var inputMoq = new Mock<IPlayerInput>();
        inputMoq.Setup(b => b.m1_down).Returns(down);
        inputMoq.Setup(b => b.m1_up).Returns(up);

        var player = new MockPlayerShoot(inputMoq.Object);
        player.ShootUpdate();

        Debug.Log("TestMoqShoot");

        GameObject[] bullets = GameObject.FindGameObjectsWithTag("Bullet");

        if(down)
            Assert.Greater(bullets.Length, 0);
        else if(up)
            Assert.AreEqual(bullets.Length, 0);
    }


    #endregion


}

