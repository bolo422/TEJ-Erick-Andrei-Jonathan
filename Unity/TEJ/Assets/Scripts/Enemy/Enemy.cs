using System.Transactions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    #region private atributes
    private GameObject child;
    private GameObject player;

    #endregion

    #region protected atributes
    public int hp { get; protected set; }
    protected int score;
    protected string path;
    protected float speed;
    protected int quantity;

    #endregion

    protected void Awake()
    {
        if(path != null)
            child = Resources.Load<GameObject>(path);

        Debug.LogWarning("Enemy Spawned- path:" + path);

        //Debug.Log("Enemy");
    }

    void Start()
    {
        player = Player.Instance.gameObject;
    }

    void Update()
    {
        Vector2 target = player.transform.position;
        float step = (speed/3) * Time.deltaTime;

        // move sprite towards the target location
        transform.position = Vector2.MoveTowards(transform.position, target, step);
    }

    private void Die()
    {
        GameManager.Instance.addScore(score);

        if(child != null)
        {
            for (int i = 0; i < quantity; i++)
            {
                //Vector3 pos = new Vector3(transform.position.x+(Random.Range(-1.0f, 1.0f)), transform.position.y+(Random.Range(-1.0f, 1.0f)), transform.position.z);
                Instantiate(child, transform.position, transform.rotation);
            }
            
        }

        Destroy(gameObject);
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
        if(hp <= 0)
            Die();
    }



}
