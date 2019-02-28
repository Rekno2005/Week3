using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trianglemove : MonoBehaviour
{

    public float corners;
    public float size;
    public float speed;

    private Vector3 movement;

    // Use this for initialization
    void Start()
    {


        speed = .1f;

    }

    // Update is called once per frame
    void Update()
    {
        movement = transform.position;

        if (movement.x <= 0 && movement.y <= 0)
        {
            corners = 1;
        }

        if (movement.x > size)
        {
            corners = 2;
        }


        if (movement.x < 0 && movement.y > size)
        {
            corners = 4;
        }

        if (corners == 1)
        {
            movement = movement + new Vector3(speed, 0.0f, 0.0f);
        }

        if (corners == 2)
        {
            movement = movement + new Vector3(-speed, speed, 0.0f);
        }

        if (corners == 4)
        {
            movement = movement + new Vector3(0.0f, -speed, 0.0f);
        }
        transform.position = movement;

    }
}
