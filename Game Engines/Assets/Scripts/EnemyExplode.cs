using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyExplode : MonoBehaviour
{
    public EnemyHealth enemyHealth;
    public Transform effect;

    public bool explode = false;
    public AudioSource source;
    public AudioClip shot;
    public GameObject theObjectToBeUnParented;
    // Start is called before the first frame update
    void OnEnable()
    {
        enemyHealth = GetComponentInParent<EnemyHealth>();
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyHealth.health <= 0 && !explode)
        {
            source.Play();
            theObjectToBeUnParented.transform.SetParent(null);
            Instantiate(effect, transform.position, transform.rotation);
            explode = true;
            Destroy(gameObject,0.5f);
        }
    }

  
    
        
    
}
