using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Transform firePoint;

    public static Player Instance { get; private set; }

    private float bulletForce = 20f;
    private GameObject bulletPrefab;
    private bool canShoot = false;
    private bool isShooting = false;

    private IPlayerInput input { get; set; }


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }

        bulletPrefab = Resources.Load<GameObject>("Bullet");

        if(input == null)
            input = new PlayerInput();
    }


    void Update()
    {
        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);


        if (input.m1_down)
            canShoot = true;
        else if (input.m1_up)
            canShoot = false;

        if (canShoot)
            Shoot();
    }

    void Shoot()
    {
        if (isShooting)
            return;
        StartCoroutine(ShootingCooldown());

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }

    IEnumerator ShootingCooldown()
    {
        isShooting = true;
        yield return new WaitForSeconds(0.1f);
        isShooting = false;
    }

}

class PlayerInput : IPlayerInput
{

}