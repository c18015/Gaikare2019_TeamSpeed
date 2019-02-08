using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopSpawn : MonoBehaviour {

    public GameObject[] EnemyS;
    public int number = 0;
    public float FirstSpawnTime = 3;
    public float loopSpawnTime = 3;


    // Use this for initialization
    void Start () {

        
        InvokeRepeating("SpawnEne",FirstSpawnTime , loopSpawnTime);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
     
    public void SpawnEne()
    {
        number = Random.Range(0, EnemyS.Length);
        Instantiate(EnemyS[number], transform.position, transform.rotation);
        
    }
}
