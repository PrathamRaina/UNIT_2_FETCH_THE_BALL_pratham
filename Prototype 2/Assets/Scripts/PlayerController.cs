using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;   //creating the variable to get the horizontal input for player
    public float speed = 10.0f;
    public float xRange = 10.0f;

    public  GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange,transform.position.y,transform.position.z);
        }

        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange,transform.position.y,transform.position.z);
        }
        
        if((Input.GetKeyDown(KeyCode.Space)))
        {
            //launch the projectile
            Instantiate(projectilePrefab,transform.position,projectilePrefab.transform.rotation);
        }
        
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
   
    }
}
