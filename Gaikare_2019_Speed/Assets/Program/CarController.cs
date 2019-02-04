using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {


    public float speed = 0.2f;
    public float MaxSpeed = 0.9f;

    // Use this for initialization
    void Start () {
     
	}
	
	// Update is called once per frame
	void Update () {
        speed = speed + Time.deltaTime / 60f;
        if (speed >= MaxSpeed)
        {
            speed = 0.8f;
        }


        Rigidbody rigidbody = GetComponent<Rigidbody>();
        //float h = Input.GetAxis("Horizontal");
        float v = 1;

        Debug.Log(speed);
        
        
        float h = Input.acceleration.x;
        //float v = Input.acceleration.y;


        
        if (h >= 0.6f)
        {
            h = 0.3f;
        }

        if (h <= -0.6f)
        {
            h = -0.3f;
        }


        transform.Translate(-h / 1.5f, 0, -v * speed );
        this.transform.Rotate(0f, h * 3f, 0f);


    }
}
