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
    // Start is called before the first frame update
    void Start()
    {
        enemyHealth = GetComponentInParent<EnemyHealth>();
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth.health <= 0 && !explode)
        {
            source.Play();
            Instantiate(effect, transform.position, transform.rotation);
            explode = true;
        }
    }
}
