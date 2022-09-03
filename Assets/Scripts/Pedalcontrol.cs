using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedalcontrol : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;

    public Rigidbody2D rig;

    public void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        // get input 
        Vector3 movement = GetInput();

        // move object 
        MoveObject(movement);
    }

    public Vector2 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    public void MoveObject(Vector2 movement)
    {
        rig.velocity = movement;
    }
}
