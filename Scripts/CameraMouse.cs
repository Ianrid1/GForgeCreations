using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMouse : MonoBehaviour
{
    private float speedh = 2f;
    private float speedv = 2f;
    private float yaw = 0f;
    private float pitch = 0f;
    public GameObject aPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yaw += speedh * Input.GetAxis("Mouse Y");
        pitch -= speedv * Input.GetAxis("Mouse X");

        transform.eulerAngles = new Vector3 (yaw, pitch, 0.0f);
    }
    
}
