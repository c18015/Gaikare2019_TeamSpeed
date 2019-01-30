using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Spawn : MonoBehaviour {

    public GameObject[] EnemyS;
    public int number = 0;


    // Use this for initialization
    void Start () {

        number = Random.Range(0, EnemyS.Length);
        Instantiate(EnemyS[number], transform.position, transform.rotation);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
