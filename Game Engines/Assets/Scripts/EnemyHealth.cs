using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health = 3f;
    bool Death = true;
    public GameObject thisEnemy;
    public bool dead = true;

    void Update()
    {


        if (health <= 0 && dead == true)
        {
            Die();
        }
        
    }

    public void TakeDamage2(int damage)
    {
        health -= damage;
        dead = true;


        Debug.Log("damage Taken");
    }

    void Die()
    {
        
       // three_point_wavespawner.Enemiesalive--;
        Destroy(gameObject);
        dead = false;

    }

    


    
}
