using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyiro_Test: MonoBehaviour {

    Quaternion Gyro;




    void Start()
    {

    }


    void Update()
    {

            //float x = Input.GetAxis("Horizontal");
            float y = -1;

        float x = Input.GetAxis("Horizontal");
        //float x = Input.acceleration. x;
        




        this.transform.Rotate(0f,0f,x * 3);
        //transform.rotation = Gyro;
        //Debug.Log(Gyro);


        /*
        if( x <= -0.6)
        {
            x = 0.1f;
            this.transform.Rotate(0f, 0f, -2f);
            Debug.Log("左");

        }

        if( x >= 0.6)
        {
            x = -0.1f;
            this.transform.Rotate(0f, 0f, 2f);
            Debug.Log("右");
        }
        */


    }



}


/*
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
*/
