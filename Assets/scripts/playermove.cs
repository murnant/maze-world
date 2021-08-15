using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public float maxspeed = 15.0f;
    public float speed;
    public float turnSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        if (speed > maxspeed)
        {
            speed = maxspeed;
        }
        if(speed < 5.0f)
        {
            speed = 5;
        }
        gameObject.transform.position += transform.forward * (v * speed) * Time.deltaTime;
        speed += v * 0.03f;
        speed -= 0.007f;

        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * h);

    }
}
