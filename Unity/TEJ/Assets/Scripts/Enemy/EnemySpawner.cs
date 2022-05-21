using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private List<Transform> spawnPoints;

    GameObject bigEnemy;

    private void Awake()
    {
        bigEnemy = Resources.Load<GameObject>("BigEnemy");
    }

    void Start()
    {
        StartCoroutine(spawnBigEnemy());
    }

    IEnumerator spawnBigEnemy()
    {
        yield return new WaitForSeconds(5);
        
        int qtd = Random.Range(2, 5);
        for (int i = 0; i < qtd; i++)
        {
            Instantiate(bigEnemy, spawnPoints[Random.Range(0, spawnPoints.Count)].position, Quaternion.identity);

        }
        
        yield return new WaitForSeconds(5);
        StartCoroutine(spawnBigEnemy());
    }
}
