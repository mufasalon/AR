using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YBall1 : MonoBehaviour
{

    public GameObject parent1;
    public GameObject spawnpoint1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < parent1.transform.position.y - 10)
        {
            transform.position = spawnpoint1.transform.position;
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "redBall")
        {
            Destroy(collision.gameObject);
        }
    }
}

