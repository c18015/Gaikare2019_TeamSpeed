using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceItem : MonoBehaviour {

    public Timer timer;
    public int plasTime;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            timer.PlusTime(plasTime);
            Invoke("OdjDes", 0.1f);
        }

        
    }

    void OdjDes()
    {
        Destroy(this.gameObject);
    }
}
