using System.Collections;
using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PM_testHP : ScriptableObject
{
    // A Test behaves as an ordinary method
    [Test]
    public void testHP()
    {
        GameObject prefab = Resources.Load<GameObject>("BigEnemy");
        prefab = Instantiate(prefab, Vector3.zero, Quaternion.identity);
        int hp = prefab.GetComponent<Enemy>().hp;

        Assert.AreEqual(10, hp);
    }

    //[UnityTest]
    //public IEnumerator ShootMoqTest()
    //{
    //    var inputMoq = new Mock<IPlayerInput>();
    //    inputMoq.Setup(b => b.m1_down).Returns(true);
    //    inputMoq.Setup(b => b.m1_up).Returns(false);

    //    var player = new MockPlayerShoot(inputMoq.Object);
    //    player.ShootUpdate();

    //    yield return new WaitForSeconds(0.1f);
    //    Debug.Log("TestMoqShoot");
    //    GameObject[] bullets = GameObject.FindGameObjectsWithTag("Bullet");

    //    Assert.Greater(bullets.Length, 0);

    //    //atirar
    //    // get all tag bullet
    //    // bullets > 0

    //}
}
