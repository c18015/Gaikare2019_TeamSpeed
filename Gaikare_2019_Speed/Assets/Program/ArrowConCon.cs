using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowConCon : MonoBehaviour {

    Vector3 StatePos;

    public float MoveRange;
    public float Speed;

	// Use this for initialization
	void Start () {
        StatePos = transform.localPosition;
		
	}
	
	// Update is called once per frame
	void Update () {
        float y = MoveRange * Mathf.Sin(Time.time * Speed);
        transform.localPosition = StatePos + new Vector3(0, y, 0);
	}
}
