using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters : MonoBehaviour
{
    private float speed = 1000;

    private Rigidbody charcterRb;

    private GameObject spawnManager;
    // Start is called before the first frame update
    void Start()
    {
        charcterRb = GetComponent<Rigidbody>();
        spawnManager = GameObject.Find("Spawn Objects");
        Vector3 lookDirection = (spawnManager.transform.position - transform.position).normalized;
        charcterRb.AddForce(lookDirection * speed);
    }

    // Update is called once per frame
    void Update()
    {
        if (charcterRb.velocity.x == 0)
        {
            Destroy(gameObject);
        }
        if (gameObject.transform.position.y < 0)
        {
            Destroy(gameObject);
        }
    }
}
