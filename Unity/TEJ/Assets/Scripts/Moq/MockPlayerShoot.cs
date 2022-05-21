using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MockPlayerShoot : ScriptableObject
{
    private GameObject bulletPrefab;
    private IPlayerInput input = null;
    private bool canShoot = false;

    public MockPlayerShoot(IPlayerInput input)
    {
        this.input = input;
        bulletPrefab = Resources.Load<GameObject>("Bullet");

    }

    public void ShootUpdate()
    {
        if (input.m1_down)
            canShoot = true;
        else if (input.m1_up)
            canShoot = false;

        if (canShoot)
            Shoot();

        Debug.Log("m1_down: " + input.m1_down);
        Debug.Log("m1_up: " + input.m1_up);
        Debug.Log("canShoot: " + canShoot);

    }

    void Shoot()
    {
        Debug.Log("MoqShoot-Instantiate");
        Instantiate(bulletPrefab);
    }

}
