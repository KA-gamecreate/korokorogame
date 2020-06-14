using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public float power = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -10)
        {
            FadeManager.Instance.LoadLevel("GameOver",2.0f);
        }

        if (Input.GetKey("up"))
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(0, 0, power);
        }

        if (Input.GetKey("down"))
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(0,0,-power);
        }

        if (Input.GetKey("left"))
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(-power,0, 0);
        }
        if (Input.GetKey("right"))
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(power,0, 0);
        }

        
    }
}
