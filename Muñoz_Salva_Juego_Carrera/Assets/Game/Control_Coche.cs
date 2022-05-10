using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_Coche : MonoBehaviour{

    //public Camera FPSCamera;

    public float horizontalSpeed;
    private float verticalSpeed = 0.3f;

    float h;
    float v;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        h = horizontalSpeed * Input.GetAxis("Horizontal");
        v = verticalSpeed * Input.GetAxis("Vertical");

        transform.Rotate(0, h, 0);

        if (Input.GetButton("Fire1"))
        {
            v *= 1.5f;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, v);
        } else {

            if
                (Input.GetKey(KeyCode.DownArrow)){
                transform.Translate(0, 0, -0.10f);
            }
        }



    }
}
      
