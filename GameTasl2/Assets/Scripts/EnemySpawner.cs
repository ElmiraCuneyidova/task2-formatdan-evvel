using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
  

    void Start()
    {

        StartCoroutine(Spawner());

    }

    IEnumerator Spawner()
    {

            float x = Random.Range(49.5f,-49.5f);
            float z = Random.Range(49.5f, -49.5f);

            yield return new WaitForSeconds(2f);
          
            Instantiate(enemyPrefab, new Vector3(x, 0.58f,z), Quaternion.identity);
        
        
    }



}



