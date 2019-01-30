using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{                                                       //なかったことになったカメラジャイロ

    float Right_maxRotate = 20;//回転角の最大値
    float Left_maxRotate = 20;
    float tmpRotate = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

        //Gyro.x = 0.01f; // Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float C = Input.GetAxis("Vertical");
        //float v = Input.acceleration.x; // Input.acceleration.y;
        //float C = Input.acceleration.x

        if (v >= 0.51f)
        {
            v = 0.5f;
        }

        if (v <= -0.51f)
        {
            v = -0.5f;
        }
         transform.localRotation *= Quaternion.Euler(0, 0, -C / 2f);

        
        if (C >= 0.9f)
        {
            Debug.Log("migi");
            
            this.transform.rotation *= Quaternion.Euler(0, 0, C);



        }


        if (C <= -0.9f)
        {
            Debug.Log("hidari");
            
            this.transform.rotation *= Quaternion.Euler(0, 0, C);

        }

        Debug.Log(C);
        
    }
}
