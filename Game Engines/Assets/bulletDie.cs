using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDie : MonoBehaviour
{


    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            EnemyHealth.health -= 3f;
            Destroy(gameObject, 1f);
        }
        else
        {
            Destroy(gameObject, 2f);
        }
    }
}
