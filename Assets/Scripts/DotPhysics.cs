using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotPhysics : MonoBehaviour
{
    Rigidbody2D rb;

    public float speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Start is called before the first frame update
    void Start()
    {     
        rb.velocity = new Vector2(0, -speed);
    }

    void PauseMovement()
    {
        rb.velocity = new Vector2(0,0);
    }


}

