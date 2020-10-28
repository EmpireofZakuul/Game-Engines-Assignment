using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioVisual : MonoBehaviour
{
    public GameObject cubesPrefab;
    GameObject[] cubes = new GameObject[64];
    public float scaleMax;
    public  const float sampleAngle = 360.0f/64;
    public int multiply = 15;


    // Start is called before the first frame update
    void Start()
    {
       for( int i = 0; i < 64; i++)
       {
          // GameObject SpawnCube = (GameObject)Instantiate(cubesPrefab);
          
           // SpawnCube.transform.position = this.transform.position;
            
            GameObject SpawnCube = (GameObject)Instantiate(cubesPrefab, transform.position, cubesPrefab.transform.rotation) as GameObject;
            SpawnCube.transform.Rotate(0f, 180f, 0f);
            SpawnCube.transform.parent = this.transform;

            this.transform.eulerAngles = new Vector3(0, sampleAngle * i, 0);
            SpawnCube.transform.position = Vector3.forward * multiply;
            cubes[i] = SpawnCube;
        }
        //Grid();
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < 64; i++)
        {
            if(cubes != null)
            {
                cubes[i].transform.localScale = new Vector3(10, (Audio.AudioSamples [i] * scaleMax) + 2, 10);
            }
        }
    }


 
    
}
