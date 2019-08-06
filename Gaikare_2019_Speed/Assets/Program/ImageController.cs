using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageController : MonoBehaviour {

    public GameObject Image;
    float time;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;

		if(time >= 2)
        {
            Image.SetActive(true);
        }
        if(time < 2)
        {
            Image.SetActive(false);
        }
	}
}
