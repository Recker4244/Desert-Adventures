using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{private Rigidbody playerRb;
public float jumpForce;    
public float gravityModifier; 
public bool gameover;
public bool isonground=true;
private Animator anim;
public ParticleSystem collisionsmoke;
public ParticleSystem dirt;
private AudioSource playerAudio;
public AudioClip jumpsound;
public AudioClip crashsound;

// Start is called before the first frame update
    void Start()
    {    anim=GetComponent<Animator>();
         playerRb = GetComponent<Rigidbody>();
    playerAudio = GetComponent<AudioSource>();
Physics.gravity *= gravityModifier;    
}

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)&& isonground)
         {playerRb.AddForce(Vector3.up*jumpForce,ForceMode.Impulse);
          anim.SetTrigger("Jump_trig");
         playerAudio.PlayOneShot(jumpsound,1.0f); 
          isonground=false;
         }
}
private void OnCollisionEnter(Collision collision)
{if(collision.gameObject.CompareTag("Ground"))
  {isonground=true;
   dirt.Play();
   }
else if(collision.gameObject.CompareTag("Obstacle"))
      {Debug.Log("Game Over");
           gameover=true;
         anim.SetBool("Death_b",true);
       collisionsmoke.Play();
      dirt.Stop(); 
      
         playerAudio.PlayOneShot(crashsound,1.0f);
        }
}
}