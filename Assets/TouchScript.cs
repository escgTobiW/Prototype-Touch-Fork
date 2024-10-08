using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TouchScript : MonoBehaviour
{


    public Vector3 position;
    private float width;
    private float height;

    public GameObject Sphere;
    public GameObject JoyStickBall;


    public Collider2D Collider;
    public bool inRange = true;

    void Start()
    {
        
    }

    
    void Update()
    {
        // Handle screen touches.
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);


            // Move the object if the screen has the finger moving.
            if (touch.phase == TouchPhase.Moved)
            {
                //print("touched");
                Vector2 pos = touch.position;
                //pos.x = (pos.x - width) / width;
                //pos.y = (pos.y - height) / height;
                position = new Vector3(pos.x, pos.y, 0.0f);
                /*
                if (inRange == true)
                {
                    print("TRUE!!!!!!!!");
                    // Position the object.
                    //JoyStickBall.transform.position = position;
                    transform.position = Vector3.MoveTowards(transform.position, position, 100 * Time.deltaTime);
                }
                else
                {

                }
              */

                //propel sphere in direction matching joystick
                // Sphere. etc 
            }

            /*
            if (Input.touchCount == 2) //second touch
            {
                touch = Input.GetTouch(1);

            }
            */
        }
    }
    
    private void OnColliderExit2D(Collision2D JoyStickBall)
    {
        
       
        

        print("FALSE!!!!!!!!!!!!!");
        inRange = false;
    }
    
    
    //—--------------------------

    /*
                   if (touch.phase == TouchPhase.Began)
                    {
                     //started touching screen 
                    }

                   if (touch.phase == TouchPhase.Ended)
                    {
                      //finished touching screen
                    }

    */

}

