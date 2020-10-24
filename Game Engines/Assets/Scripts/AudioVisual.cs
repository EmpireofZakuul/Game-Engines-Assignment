using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioVisual : MonoBehaviour
{
    public GameObject cubesPrefab;
    GameObject[] cubes = new GameObject[512];
    public float scaleMax;
    public  const float sampleAngle = 360.0f/512;


    // Start is called before the first frame update
    void Start()
    {
       for( int i = 0; i < 512; i++)
       {
           GameObject SpawnCube = (GameObject)Instantiate(cubesPrefab);
          
            SpawnCube.transform.position = this.transform.position;
            SpawnCube.transform.parent = this.transform;
            this.transform.eulerAngles = new Vector3(0, sampleAngle * i, 0);
            //this.transform.eulerAngles = new Vector3(0, -0.703125f * i, 0);
            SpawnCube.transform.position = Vector3.forward * 100;
            cubes[i] = SpawnCube;
        }
        //Grid();
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < 512; i++)
        {
            if(cubes != null)
            {
                cubes[i].transform.localScale = new Vector3(10, (Audio.AudioSamples [i] * scaleMax) + 2, 10);
            }
        }
    }


 
    
}
