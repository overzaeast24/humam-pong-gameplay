using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolapong : MonoBehaviour
{
    public Vector2 speed;

    public Rigidbody2D rig;

    // Start is called before the first frame update
    public void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }
}
