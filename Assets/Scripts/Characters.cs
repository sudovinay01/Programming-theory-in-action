using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters : MonoBehaviour
{
    private float speedrangeMin = 500,
        speedRangeMax = 2000,
        fallZone = -2;

    private Rigidbody charcterRb;

    private GameObject spawnManager;
    // Start is called before the first frame update
    void Start()
    {
        float spawnSpeed = Random.Range(speedrangeMin, speedRangeMax);
        charcterRb = GetComponent<Rigidbody>();
        spawnManager = GameObject.Find("Spawn Objects");
        Vector3 lookDirection = (spawnManager.transform.position - transform.position).normalized;
        charcterRb.AddForce(lookDirection * spawnSpeed);
        StartCoroutine(DestroyIfNotMoving());
        //Debug.Log(gameObject.name+":"+Time.deltaTime);

        //Debug.Log(gameObject.name + ":" + Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DestroyIfNotMoving()
    {
        while (true)
        {
            Debug.Log("Looping");
            yield return new WaitForSeconds(2);
            if (charcterRb.velocity.x == 0)
            {
                Destroy(gameObject);
            }
            if (gameObject.transform.position.y < fallZone)
            {
                Destroy(gameObject);
            }
        }

    }
}
