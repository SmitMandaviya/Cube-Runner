using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement move;

    public GameObject cube;

    public float min = -5;

    public float max = 5 ;

    private float time=0;

    public float heightoffset=10;

    public float moveob=500f;
    public Rigidbody rb;

    public float spawnrate;

    //  void Start() {
    //     spawn();
    // }

    void Update() {

        
            rb.AddForce(0 , 0 , -moveob * Time.deltaTime );
       
        //spawn
        // if ( time < spawnrate )
        // {
        //     time += Time.deltaTime;
        // }
        // else
        // {
        // spawn();
        // time = 0;
        // }

        
    }
     private void OnCollisionEnter(Collision col) {
        if(col.collider.tag == "Wall"){
         move.enabled=false;
         FindObjectOfType<Gamemanager>().Endgame();
        }
    }

    
    //spwan
    // public void spawn()
    // {
    //     float lowest = transform.position.y - heightoffset;
    //     float highest = transform.position.y + heightoffset;

    //     Instantiate(cube , new Vector3(transform.position.x , Random.Range(lowest , highest),0), transform.rotation);
    // }
}
