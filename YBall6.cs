using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YBall6 : MonoBehaviour
{

    public GameObject parent6;
    public GameObject spawnpoint6;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < parent6.transform.position.y - 10)
        {
            transform.position = spawnpoint6.transform.position;
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

