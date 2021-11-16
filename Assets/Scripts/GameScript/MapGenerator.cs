using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public Transform[] tileObjects;
    
    private Vector3 newTileSpawn;

    
    void Start()
    {
        newTileSpawn.z = 40;
        StartCoroutine(spawnTile());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnTile(){
        yield return new WaitForSeconds(1);
        var plane = Random.Range(0,tileObjects.Length);

        Instantiate(tileObjects[plane],newTileSpawn,tileObjects[plane].rotation);
        newTileSpawn.z +=10;
        StartCoroutine(spawnTile());
    }
}
