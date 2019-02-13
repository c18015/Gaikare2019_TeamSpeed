using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSpawn : MonoBehaviour {

    public GameObject[] EnemyS;
    public int number = 0;
    public float FirstSpawnTime = 0.1f;
    

    // Use this for initialization
    void Start () {

        Invoke("SpawnEnemy", FirstSpawnTime);
        Invoke("Desobject", 3f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnDrawGizmos()
    {
        Vector3 offset = new Vector3(0, 0.5f, 0);

        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawSphere(transform.position + offset, 1f);

        
    }

    void SpawnEnemy()
    {
        number = Random.Range(0, EnemyS.Length);
        Instantiate(EnemyS[number], transform.position, transform.rotation);
    }

    void Desobject()
    {
        Destroy(this.gameObject);
    }

}
