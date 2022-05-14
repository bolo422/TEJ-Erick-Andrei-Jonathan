using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector3 direction;
    public float speed;

    private void Start()
    {
        Destroy(gameObject, 3.0f);
    }

    void Update()
    {
           
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //destruir inimigo (deve dar pontos)

        Destroy(gameObject);

    }
}
