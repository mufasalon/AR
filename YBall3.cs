using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YBall3 : MonoBehaviour
{

    public GameObject parent3;
    public GameObject spawnpoint3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < parent3.transform.position.y - 10)
        {
            transform.position = spawnpoint3.transform.position;
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

