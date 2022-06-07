using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();

        GetComponent<Renderer>().material.color=Color.red;
    
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.K)){
            Destroy(gameObject);   //created so that player can kil himself when
                                   //k is pressed.
        }*/

        if(Input.GetKeyDown(KeyCode.UpArrow)){ /*Moving gameObject 
                                                using velocity rather
                                                than adding force to 
                                                gameObject*/
            rb.velocity = (Vector3.forward*5f);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)){ /*Moving gameObject 
                                                using velocity rather
                                                than adding force to 
                                                gameObject*/
            rb.velocity  = (Vector3.back*5f);
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow)){ /*Moving gameObject 
                                                using velocity rather
                                                than adding force to 
                                                gameObject*/
            rb.velocity = (Vector3.left*5f);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow)){ /*Moving gameObject 
                                                using velocity rather
                                                than adding force to 
                                                gameObject*/
            rb.velocity=(Vector3.right*5f);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            rb.velocity = (Vector3.up*5f);
        }

        
                     
    }
    private void OnMouseDown(){
        Destroy(gameObject);
    }


    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag=="Enemy"){  /*Destroy gameObject 
                                                if collided
                                                by another gameObject 
                                                with tag "enemy*/
            Destroy(gameObject);
        }

    }   

    
}
