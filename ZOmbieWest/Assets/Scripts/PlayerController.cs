using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    public GameObject projectilePrefab;
    public bool gameOver;
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
      
      if(Input.GetKeyDown(KeyCode.Space))
      {
        //Launch a projectile from player
        Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
      }
    }
     private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("Obstacle")){
        gameOver = true;
        Debug.Log("Game Over");
        }
     }
      
    
}
