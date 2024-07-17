using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YBall5 : MonoBehaviour
{

    public GameObject parent5;
    public GameObject spawnpoint5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < parent5.transform.position.y - 10)
        {
            transform.position = spawnpoint5.transform.position;
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

