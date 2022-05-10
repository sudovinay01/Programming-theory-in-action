using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 10,
        rotationAngle = 45,
        movingSpeed = 25,
        horizontalInput,
        ZRange = 10,
        moveDistance = 5;

    [SerializeField] private bool isGameActive = true;

    [SerializeField] private GameObject playerPrefab;

    // Start is called before the first frame update
    void Start()
    {
        playerPrefab = GameObject.Find("player");
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void StartGame()
    {
        
    }

    void MovePlayer()
    {
        if (isGameActive)
        {
            playerPrefab.transform.Rotate(Vector3.forward, rotationAngle * rotationSpeed * Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.Translate(new Vector3(0, 0, moveDistance));
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.Translate(new Vector3(0, 0, -moveDistance));
            }

            if (transform.position.z < -ZRange)
            {
                transform.position = new Vector3(0, transform.position.y, -ZRange);
            }

            if (transform.position.z > ZRange)
            {
                transform.position = new Vector3(0, transform.position.y,  ZRange);
            }
        }
    }


}
