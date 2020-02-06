using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballphysics : MonoBehaviour
{
    Rigidbody rb;
    Vector3 movement;
    public float speed;
    float axisX;
    float axisY;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        axisX = Input.GetAxisRaw("Horizontal");
        axisY = Input.GetAxisRaw("Vertical");
        movement = new Vector3(axisX * speed, 0, axisY * speed);
    }

    public void FixedUpdate()
    {
        rb.AddForce(movement);// rb.velocity+ movement*5 * Time.fixedDeltaTime;
    }
}
