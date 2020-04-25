using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{public GameObject obstacleprefab;
private Vector3 spawnPos=new Vector3(25,0,0);   
private float startdelay=2;
private float repeatrate=2;
private PlayerController playerControllerScript;
 // Start is called before the first frame update
    void Start()
    {
     InvokeRepeating("SpawnObstacle",startdelay,repeatrate);   
    playerControllerScript=GameObject.Find("Player").GetComponent<PlayerController>();
     }

    // Update is called once per frame
    void Update()
    {
        
    }
void SpawnObstacle()
{if(playerControllerScript.gameover==false)
Instantiate(obstacleprefab,spawnPos,obstacleprefab.transform.rotation);
}
}
