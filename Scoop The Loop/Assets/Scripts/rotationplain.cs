using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationplain : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    Quaternion rotat;

    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FixedUpdate()
    {
        //rotat  = Quaternion.Euler(Input.GetAxis("Mouse Y") * speed*Time.fixedDeltaTime, 0, -Input.GetAxis("Mouse X") * speed*Time.fixedDeltaTime);
        //Debug.Log(rotat);
        //transform.rotation = Quaternion.Lerp(rotat, transform.rotation, Time.fixedDeltaTime);

        transform.Rotate(Vector3.right, Input.GetAxis("Mouse Y") * speed);
        transform.Rotate(Vector3.forward, Input.GetAxis("Mouse X") * speed);
    }
}
