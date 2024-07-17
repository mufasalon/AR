using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YBall4 : MonoBehaviour
{

    public GameObject parent4;
    public GameObject spawnpoint4;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < parent4.transform.position.y - 10)
        {
            transform.position = spawnpoint4.transform.position;
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
