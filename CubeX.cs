using UnityEngine;

public class CubeX : MonoBehaviour

{
    //Variables
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sidewaysForce = 100f;


    void Start()
    {
        rb.useGravity = false;
        // Ship not subject to gravity
        rb.AddForce(0, 0, 300);
        //Player receives a Forward push along Z axis
    }

    void Update()
    {

        rb.AddForce(0, 0, (300 * Time.deltaTime));
        //adds a forward force on PLAYER per frame


        if (Input.GetKey("d"))
        {
            rb.AddForce(35, 0, 0);
        }
        //right

        if (Input.GetKey("a"))
        {
            rb.AddForce(-35, 0, 0);
            //left
        }
        if (Input.GetKey("q"))

        {
            rb.AddForce(0, 20, 0);
            //Fly Up
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -300);
            //Reverse
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, 301);
            //Forward
        }
        if (Input.GetKey("e"))

        {
            rb.AddForce(0, -20, 0);
        }
        //Fly Down
    }
}
