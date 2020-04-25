using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{   public float speed=15;
    public static int score=0;
private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript=GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    { if(playerControllerScript.gameover==false)
        transform.Translate(Vector3.left*Time.deltaTime*speed);
   if(transform.position.x<-6 && gameObject.CompareTag("Obstacle"))
   {Destroy(gameObject);
    score+=10;
    }
   
   }
}
