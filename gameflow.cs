using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class gameflow : MonoBehaviour
{

    public Transform tile1Obj;
    private Vector3 nextTileSpawn;
    public Transform rocks1Obj;
    private Vector3 nextRock1Spawn;
    private int randX;
    public Transform mushroom1Obj;
    private Vector3 nextMushroomSpawn;
    public Transform earthyRockObj;
    private Vector3 nextErSpawn;
    public Transform carObj;
    private Vector3 nextCarSpawn;
    private int randChoice;

    void Start()
    {
        nextTileSpawn.z = 18;
        StartCoroutine(spawnTile());

    }

    
    void Update()
    {
        
    }

    IEnumerator spawnTile()
    {
        yield return new WaitForSeconds(1);
        randX = Random.Range(-1, 2);
        nextRock1Spawn = nextTileSpawn;
        nextRock1Spawn.x = randX;
        Instantiate(tile1Obj, nextTileSpawn, tile1Obj.rotation);
        Instantiate(rocks1Obj, nextRock1Spawn, rocks1Obj.rotation);

        
        
        
        nextTileSpawn.z += 3;
        randX = Random.Range(-1, 2);
        nextMushroomSpawn.z = nextTileSpawn.z;
        nextMushroomSpawn.x = randX;
        Instantiate(tile1Obj, nextTileSpawn, tile1Obj.rotation);
        Instantiate(mushroom1Obj, nextMushroomSpawn, mushroom1Obj.rotation);

        if(randX == 0)
        {
            randX = 1;
        }
        else if (randX == 1)
        {
            randX = -1;
        }
        else
        {
            randX = 0;
        }

        randChoice = Random.Range(0, 2);
        if (randChoice == 0)
        {
            nextErSpawn.z = nextTileSpawn.z;
            nextErSpawn.x = randX;
            Instantiate(earthyRockObj, nextErSpawn, earthyRockObj.rotation);
        }
        else
        {
            nextCarSpawn.z = nextTileSpawn.z;
            nextCarSpawn.y = 0.25f;
            nextCarSpawn.x = randX;
            Instantiate(carObj, nextCarSpawn, carObj.rotation);

        }

        nextTileSpawn.z += 3;
        StartCoroutine(spawnTile());

        

       
        
        
       
    }
}
