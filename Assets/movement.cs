using UnityEngine;

public class movement : MonoBehaviour
{
    //rigid body is RB
    public Rigidbody rb; 

    public float forwardForce = 2000f;
    public float sidewaysForce = 2000f;
    public float backwardsForce = -2000f;

    void FixedUpdate ()
    {
        //add forward Force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); 

        if ( Input.GetKey("d") ) 
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, 500 * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, backwardsForce *Time.deltaTime);
        }
    }
}
