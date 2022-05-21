using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    private Text scoreText;
    
    

    public static GameManager Instance { get; private set; }

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

        scoreText = GameObject.FindGameObjectWithTag("HUD").GetComponentInChildren<Text>();

        if(Player.Instance.gameObject == null)
        {
            Instantiate(Resources.Load<GameObject>("Player"));
        }


    }



    void Start()
    {
        scoreText.text = "SCORE: " + score;
    }

    void Update()
    {
        
    }

    public void addScore(int _score)
    {
        score += _score;
        scoreText.text = "SCORE: " + score;

    }
}
