using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_Con : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Go_Main_Scene()
    {
        Application.LoadLevel("Debug_Scene");
        //Application.LoadLevel("Title");
    }
}
