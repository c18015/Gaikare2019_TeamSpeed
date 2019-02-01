using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kyu_sai : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "L_Wall")
        {
            float x = -5;
            this.transform.Rotate(0f, x, 0f);
            
            //Debug.Log("ooowwa");
        }

        if(collider.gameObject.tag == "R_Wall")
        {
            float x = 5;
            this.transform.Rotate(0f, x, 0f);

            //Debug.Log("ooowwa22222222");
        }
    }
}
