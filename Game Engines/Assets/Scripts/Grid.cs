using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public int theXAxisGrid = 4;
    public int theYAxisGrid = 4;
    public GameObject spawnBuildingPrefab;
    public Vector3 OriginOfTheGrid = Vector3.zero;

    public float spaceBetweenTheBuildings = 2f;
    public bool generateOnEnableGame;
    public GameObject NavMeshSurface;


    void OnEnable()
    {
        if (generateOnEnableGame)
        {
            GeneratePlay();

        }
    }

    public void GeneratePlay()
    {
        SpawnGridCity();
        
    }


    void SpawnGridCity()
    {
        for (int x = 0; x < theXAxisGrid; x++)
        {
            for (int z = 0; z < theYAxisGrid; z++)
            {
                GameObject Prefabclone = Instantiate(spawnBuildingPrefab,
                    transform.position + OriginOfTheGrid + new Vector3(spaceBetweenTheBuildings * x, 0, spaceBetweenTheBuildings * z), transform.rotation);
                Prefabclone.transform.SetParent(this.transform);
            }
        }


    }

    


}
