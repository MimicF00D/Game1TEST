using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllor : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
  

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * -horizontalInput * Time.deltaTime* speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }
        //Left and right berrier
        if(transform.position.x < -26) 
        {
            transform.position = new Vector3(-26, transform.position.y, transform.position.z);
        }
        //left right berrier
        if(transform.position.x > 11)
        {
            transform.position =new Vector3(11, transform.position.y, transform.position.z);
        }
        //side berrier
        if (transform.position.z < -8)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -8);
        }
        //side berrier 
        if (transform.position.z > 10)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 10);
        }
        if (Input.GetKeyDown(KeyCode.Q)) 
            {
            transform.Rotate(new Vector3(0, -90, 0));
            }
    }
}
