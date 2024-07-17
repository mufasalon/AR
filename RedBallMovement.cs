using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBallMovement : MonoBehaviour
{

    public GameObject parent;
    public GameObject spawnpoint;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < parent.transform.position.y - 10)
        {
            transform.position = spawnpoint.transform.position;
        }


    }
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object has the tag "RandomObject"
        if (collision.gameObject.CompareTag("RandomObject"))
        {
            // Destroy the ball
            Destroy(gameObject);
        }
    }
}
