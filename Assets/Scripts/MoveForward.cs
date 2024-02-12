using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 200.0f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("kil", 4f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
    void kil()
    {
        Destroy(gameObject);
    }
}
