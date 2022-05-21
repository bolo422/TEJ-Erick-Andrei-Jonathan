using System.Collections;
using System.Collections.Generic;
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

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator PM_testHPWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
