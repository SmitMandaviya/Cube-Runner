using UnityEngine;
using UnityEngine.Scripting.APIUpdating;



public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float forward=2000f;
    public float move=500f;
    public Rigidbody rb;

    public float movement;
    void Start()
    {
        
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        
        rb.AddForce(0 , 0 , movement * Time.deltaTime);
        // rb.AddForce(0 , 0 , forward * Time.deltaTime);
        // if (Input.GetKey("w"))
        // {
        //     rb.AddForce(0 , 0 , move *Time.deltaTime , ForceMode.VelocityChange);
        // }
         if (Input.GetKey("a"))
        {
            rb.AddForce(-move *Time.deltaTime , 0 , 0 , ForceMode.VelocityChange);
        }
        // if (Input.GetKey("s"))
        // {
        //     rb.AddForce(0 , 0 , -move *Time.deltaTime , ForceMode.VelocityChange);
        // }
        if (Input.GetKey("d"))
        {
            rb.AddForce(move *Time.deltaTime , 0 , 0 , ForceMode.VelocityChange);
        }
        // if (Input.GetKey("space")
        // {
        //     rb.AddForce(0 , move *Time.deltaTime, 0 , ForceMode.VelocityChange);
        // }
         if (rb.position.y < -1f)
        {
            FindObjectOfType<Gamemanager>().Endgame();
        }
       
    }
}
