using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxInput : MonoBehaviour
{

    bool canPressdot;
    bool canPressDash;
    bool holdReady = false;
    GameObject dot;
    GameObject Dash;
    public float holdTime = 0.75f;
    float downTime, upTime, pressTime = 0;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    // Checking if dot is in the hitbox & with space press
    // canPress is true when anything enters hitbox
    void Update()
    {
        if(Input.GetKeyDown("space") && canPressdot)
        {
            Debug.Log("DESTROY");
            dot.GetComponent<Animator>().SetTrigger("Expand");
            StartCoroutine(HitAnimation(1f, dot));
        }

        if (Input.GetKeyDown("space") && canPressDash && holdReady == false)
        {
            downTime = Time.time;

            pressTime = downTime + holdTime;

            holdReady = true;
              
        }

        if (Input.GetKeyUp("space"))
        {
            holdReady = false;
        }
       
        if (Time.time >= pressTime && holdReady == true)
        {
            holdReady = false;
            Destroy(Dash);
        }
       
       
  

    
    }

    // Detecting trigger collision in hitbox
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.CompareTag("Dot"))
        { 
            canPressdot = true;
            Debug.Log("DOT DETECTED");
            dot = collision.gameObject;
        }

        if (collision.gameObject.CompareTag("Dash"))
        {
            canPressDash = true;
            Debug.Log("DASH DETECTED");
            Dash = collision.gameObject;
        }
    }

    // Detecting dot leaving hitbox collision
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Dot"))
        {
            canPressdot = false;
            Debug.Log("DOT LEFT");
        }

        if (collision.gameObject.CompareTag("Dash"))
        {
            canPressDash = false;
            Debug.Log("DASH LEFT");
        }
    }
    IEnumerator HitAnimation(float AnimationTime, GameObject Object)
    {
        yield return new WaitForSeconds(AnimationTime);
        Destroy(Object);

    }
}
