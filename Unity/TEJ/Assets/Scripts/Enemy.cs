using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    private int hp;
    private int score;
    private GameObject child;
    protected string path;

    protected void Awake()
    {
        child = Resources.Load<GameObject>(path);
        //Debug.Log("Enemy");
    }

    protected virtual void Die()
    {
        GameManager.Instance.addScore(score);
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
        if(hp <= 0)
            Die();
    }

    //instancia child quando morre

}
