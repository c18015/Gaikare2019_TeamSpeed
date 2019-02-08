using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSpawn : MonoBehaviour {

    public GameObject Prefab;

	// Use this for initialization
	void Start () {

        Instantiate(Prefab, transform.position, transform.rotation);
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

        if (Prefab != null)
            Gizmos.DrawIcon(transform.position + offset, Prefab.name, true);
    }
    void Desobject()
    {
        Destroy(this.gameObject);
    }
}
