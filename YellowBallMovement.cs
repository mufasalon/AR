using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBallMovement : MonoBehaviour
{

    public GameObject Yparent;
    public GameObject Yspawnpoint;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < Yparent.transform.position.y - 10)
        {
            transform.position = Yspawnpoint.transform.position;
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
