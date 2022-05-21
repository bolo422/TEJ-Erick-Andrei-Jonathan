using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoqEnemy
{
    #region private atributes
    private GameObject child;
    private Vector2 player = new Vector2(0, 0);
    private bool isDead = false;

    #endregion

    #region protected atributes
    public Vector3 position { get; set; }
    public int hp { get; set; }
    public int score { get; set; }
    protected string path = "MoqEnemy";
    protected float speed = 1.0f;
    protected int quantity;

    #endregion


    public void Move(float velocity = 1.0f)
    {
        speed *= velocity;
        Vector2 target = player;
        float step = (speed / 3) * Time.deltaTime;

        position = Vector2.MoveTowards(position, target, step);
    }

    public void Die(bool killChildren = false)
    {
        isDead = true;

        GameManager.Instance.addScore(score);

        if(killChildren)
        {
            


        }

        if (child != null)
        {
            for (int i = 0; i < quantity; i++)
            {
                //Instantiate(child, transform.position, transform.rotation);

            }

        }

        //Destroy(gameObject);
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0 && !isDead)
        {
            isDead = true;
            Die();
        }
    }

}
