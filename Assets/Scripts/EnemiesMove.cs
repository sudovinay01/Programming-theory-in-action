using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesMove : MonoBehaviour
{
    [SerializeField] private float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
        if (transform.position.x > 15)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Debug.Log("collided with :" + collision.gameObject.name + " ,\ntag : " + collision.gameObject.tag);
            Destroy(gameObject);
            GameManager.Instance.SetScore(1);

            Debug.Log(GameManager.Instance.GetScore());
        }

    }
}
