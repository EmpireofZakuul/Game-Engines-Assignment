using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour
{
    public int spawnRateEnemies = 5;
    public int enemyAmound = 10;
    public TextMeshProUGUI Enemys;


    void Spawn()
    {
       
        
      
       
    }
    // Start is called before the first frame update
    void Start()
    {
        //Invoke("Spawn", 5);
    }

    void OnEnable()
    {
        StartCoroutine(SpawnCoroutine());
    }

    int count = 0;

    System.Collections.IEnumerator SpawnCoroutine()
    {
        while (true)
        {
            Spawn();

            
            count ++;
            if (transform.childCount == enemyAmound)
            {
                break;
            }
            
            GameObject[] Enemy =
                GameObject.FindGameObjectsWithTag("Enemy");
            if (Enemy.Length == enemyAmound)
            {
                break;
            }
            yield return new WaitForSeconds(1.0f / (float)spawnRate);
        }
    }

}
