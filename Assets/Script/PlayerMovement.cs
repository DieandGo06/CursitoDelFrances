using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            //transform.Translate(new Vector3(speed, 0, 0));
            transform.Rotate(new Vector3(0, rotationSpeed, 0));

        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            //transform.Translate(new Vector3(-speed, 0, 0));
            transform.Rotate(new Vector3(0, -rotationSpeed, 0));

        }
        if (Input.GetAxis("Vertical") > 0)
        {
            transform.Translate(new Vector3(0, 0, speed));
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            transform.Translate(new Vector3(0, 0, -speed));
        }

    }
}
