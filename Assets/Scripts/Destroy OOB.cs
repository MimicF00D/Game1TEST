using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOOB : MonoBehaviour
{
    private float topBound = -61;
    private float bottomBound = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.z < topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z > bottomBound)
        {
            Destroy(gameObject);

        }
    }
     
}
