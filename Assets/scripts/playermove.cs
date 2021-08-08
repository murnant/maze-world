using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
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
   
        gameObject.transform.position += transform.forward * (v * speed) * Time.deltaTime;

        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * h);

    }
}
