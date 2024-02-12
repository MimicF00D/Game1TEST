using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMannager : MonoBehaviour
{
    public GameObject Ghost;
    public Vector3 spawnPos;
    private float startDelay = 10;
    private float spawnInterval = 7.0f;
    public Transform RightLongHall;
    public Transform LeftLongHall;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomMonster", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void SpawnRandomMonster()
    {
        int spawnpointPicker = Random.Range(1, 6);

        if (spawnpointPicker == 2)
        {
            //come from left door
            spawnPos = new Vector3(2, -0, -60);
        }
        if (spawnpointPicker == 3) 
        {
            //come from right door
            spawnPos = new Vector3(-10, 1, -55);
        }
        Instantiate(Ghost, spawnPos, Ghost.transform.rotation);

        if (spawnpointPicker == 4)
        {
            spawnPos = new Vector3(-100, 0, 0);
        }
        Instantiate(Ghost, RightLongHall.position, RightLongHall.rotation);

        if (spawnpointPicker == 4)
        {
            spawnPos = new Vector3(-100, 0, 0);
        }
        Instantiate(Ghost, LeftLongHall.position, LeftLongHall.rotation);
    }
}
