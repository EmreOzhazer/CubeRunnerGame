using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject groundTile;
    Vector3 nextSpawnpoint;
    private int length = 15;

    
    public void SpawnTile()
    {
       GameObject temp = Instantiate(groundTile, nextSpawnpoint, Quaternion.identity);
        nextSpawnpoint = temp.transform.GetChild(1).transform.position;
    }
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < length; i++)
        {
            SpawnTile();
            
        }
        
        
    }

   
}
