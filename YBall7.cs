using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YBall7 : MonoBehaviour
{

    public GameObject parent7;
    public GameObject spawnpoint7;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < parent7.transform.position.y - 10)
        {
            transform.position = spawnpoint7.transform.position;
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="redBall")
        {
            Destroy(collision.gameObject);
        }
    }

}

