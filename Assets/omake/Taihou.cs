using UnityEngine;
using System.Collections;

public class Taihou : MonoBehaviour
{

    public GameObject Ball;


    // Use this for initialization


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Rotate(0, 0, 1.0f);

        }
       if (Input.GetKey(KeyCode.DownArrow))
            {
                this.transform.Rotate(0, 0, -1.0f);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.transform.Rotate(0, 1.0f, 0);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                this.transform.Rotate(0, -1.0f, 0);

            }

        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(Ball, this.transform.position, Quaternion.identity);
            Ball.GetComponent<Rigidbody>().AddForce(0, 100, 100);

        }
        }
    }

