using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Controller : MonoBehaviour {

    public float Speed;
    


    // Use this for initialization
    void Start () {
       
    }

    // Update is called once per frame
    void Update () {

        transform.Translate(0, 0, 1 * Speed * Time.deltaTime);
        

    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "RotaCurves")
        {

            M_Rota();


        }
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Baria")
        {
          

            Destroy(this.gameObject);
        }
    }

    void M_Rota()
    {
        float x = 90;
        this.transform.Rotate(0f, x, 0f);
    }

}
