using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5.0f;
    private Rigidbody playerRb;
    private float xBound =10;
 

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {   float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
      
        
        playerRb.AddForce(Vector3.forward * speed * verticalInput);
        playerRb.AddForce(Vector3.right * speed * horizontalInput);
        
      if (transform.position.x < -xBound){
      transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);
      }
        if (transform.position.x > xBound){
      transform.position = new Vector3(xBound, transform.position.y, transform.position.z);
      }
      
     
      
    }
}
