using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    private float speed = 15.0f;
    private float horizontalInput;
    private float forwardInput;
    private float shift = 0.5f;
    private float shiftspeed = 0.65f;
    
    [SerializeField] Transform cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Cam Stuff
        Vector3 camForward = cam.forward;
        Vector3 camRight = cam.right;


        camForward.y = 0;
        camRight.y = 0;

        Vector3 forwardRelative = forwardInput * camForward;
        Vector3 rightRelative = horizontalInput * camRight;

        Vector3 moveDir = forwardRelative + rightRelative;
        // Axis Setup
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Moves the Character Forward Or Backward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * shift * moveDir.z);

        // Rotates The Character Left Or Right
        transform.Translate(Vector3.right * shift * speed *  moveDir.x * Time.deltaTime);

        //Sprint Script
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            shift = shift + shiftspeed;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            shift = shift - shiftspeed;
        }

       
        
    }
}
