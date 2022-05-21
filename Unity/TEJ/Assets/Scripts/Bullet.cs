using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [HideInInspector]
    public Vector3 direction;
    [HideInInspector]
    public float speed;

    private void Start()
    {
        Destroy(gameObject, 3.0f);
    }

    void Update()
    {
           
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<Enemy>() != null)
            col.GetComponent<Enemy>().TakeDamage(1);
            

        Destroy(gameObject);
      
    }

}
