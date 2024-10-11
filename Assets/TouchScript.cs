using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TouchScript : MonoBehaviour
{
    // Game Object Refrences
    public GameObject joyStickCentre;
    public GameObject joyStickOrigin;

    // Vector Variables
    public Vector2 touchPosition;
    public Vector2 touchStartPosition;
    public float joyStickOriginDistance;

    float originX;
    float originY;

    void Start()
    {
        originX = joyStickOrigin.transform.position.x;
        originY = joyStickOrigin.transform.position.y;

        touchStartPosition = new Vector2(originX, originY);
    }


    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                print("Begin");
                //started touching screen 
            }

            if (touch.phase == TouchPhase.Ended)
            {
                print("Ended");
                //finished touching screen
            }

            // Move the object if the screen has the finger moving.
            if (touch.phase == TouchPhase.Moved)
            {
                Debug.Log("Screen Touched");

                
                touchPosition = touch.position;



                // Moves The Joystick Centre
                //joyStickCentre.transform.position = Vector3.MoveTowards(joyStickOrigin.transform.position, (Mathf.Clamp(touchPosition.x, 80f, 160f), Mathf.Clamp(touchPosition.y, 80f, 160f), 100f));

                

            }
            //Ray ray = Camera.main.ScreenPointToRay(touchPosition);
            
            

            print("start=" + touchStartPosition);
            print("end=" + touchPosition);

            

        }

        Ray ray = Camera.main.ScreenPointToRay(touchPosition);

        // Debug.DrawLine(Vector3.zero, ray.new Vector3(touchPosition.x, 5, 0), Color.red);

    }

    private void OnGUI()
    {
        GUI.skin.label.fontSize = Screen.width / 20;

        GUILayout.Label("X Pos:" + touchPosition.x);
        GUILayout.Label("Y Pos:" + touchPosition.y);

        Debug.DrawLine(Vector3.zero, Vector3.down * 13, Color.red);
    }










    /*

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


                    //propel sphere in direction matching joystick
                    // Sphere. etc 
                }


                if (Input.touchCount == 2) //second touch
                {
                    touch = Input.GetTouch(1);

                }

            }
        }

        private void OnColliderExit2D(Collision2D JoyStickBall)
        {




            print("FALSE!!!!!!!!!!!!!");
            inRange = false;
        }


        //—--------------------------


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

