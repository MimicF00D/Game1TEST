using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EliminateObjectcolider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    //Destroys objects that collied
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            
        }
    }
}
