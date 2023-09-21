using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxInput : MonoBehaviour
{

    bool canPress;
    GameObject dot;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") && canPress)
        {
            Debug.Log("DESTROY");
            Destroy(dot);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        canPress = true;
        if (collision.gameObject.CompareTag("Dot"))
        {
            Debug.Log("DOT DETECTED");
            dot = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("DOT LEFT");
        canPress = false;
    }
}
