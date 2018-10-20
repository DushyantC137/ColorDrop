using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour {

    public float thrust;
    public Rigidbody rb;
    public float t = 0.0f;
    public int counter = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {

        rb.velocity = new Vector3(2.2f*counter , 0, 0);
        t = t + Time.deltaTime;
        if (t > 3.25f)
        {
            counter = counter * -1;
            rb.velocity = new Vector3(2.2f*counter, 0, 0);
            t = 0.0f;
        }
    }
}
