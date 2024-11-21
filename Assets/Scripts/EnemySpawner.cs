using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject Prefab;

    [SerializeField]
    private float Interval = 3.5f;

    void Start()
    {
        StartCoroutine(spawnEnemy(Interval, Prefab));
        
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(0,5f ), 1, Random.Range(1,6)), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}