using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Dash") || collision.gameObject.CompareTag("Dot"))
        {
            Destroy(collision.gameObject);
        }
    }
}
