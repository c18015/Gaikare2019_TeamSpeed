using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBaria : MonoBehaviour {

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
            other.gameObject.transform.position = new Vector3(-8, 3, 1550);
        }
    }
}
