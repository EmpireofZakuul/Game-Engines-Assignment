using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDie : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if(gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject, 1f);
        }
        else
        {
            Destroy(gameObject, 2f);
        }
    }
}
