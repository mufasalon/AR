using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YBall2 : MonoBehaviour
{

    public GameObject parent2;
    public GameObject spawnpoint2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < parent2.transform.position.y - 10)
        {
            transform.position = spawnpoint2.transform.position;
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

