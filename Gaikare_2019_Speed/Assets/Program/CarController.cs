using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

    public float ClearTime;
    public float speed = 0.4f;
    public float MaxSpeed = 1.8f;
    public AudioClip ATsound;
    public AudioClip IceSound;

    // Use this for initialization
    void Start () {
     
	}
	
	// Update is called once per frame
	void Update () {
        float T2 = 0 + Time.deltaTime;
        ClearTime = ClearTime + T2;

        speed = (speed + Time.deltaTime / 5) ;
        if (speed >= MaxSpeed)
        {
            speed = 1.75f;
        }


        Rigidbody rigidbody = GetComponent<Rigidbody>();
        //float h = Input.GetAxis("Horizontal");
        float v = 1;

        //Debug.Log(speed);
        
        
        float h = Input.acceleration.x;
        //float v = Input.acceleration.y;


        
        if (h >= 0.6f)
        {
            h = 0.3f;
        }

        if (h <= -0.6f)
        {
            h = -0.3f;
        }

    
        transform.Translate(-h / 1.5f, 0, -v * speed );
        this.transform.Rotate(0f, h * 5f, 0f);

        Debug.Log(ClearTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        


        if (collision.gameObject.tag == "Baria")
        {
            PlayerPrefs.SetFloat("StageClearTime",ClearTime);
            Invoke("TPclear",0.2f);

            

        }

        if (collision.gameObject.tag == "Baria2")
        {

            Application.LoadLevel("GameOver");

        }

        if (collision.gameObject.tag == "Enemy")
        {
            AudioSource.PlayClipAtPoint(ATsound, transform.position);
        }
        
    
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ice") AudioSource.PlayClipAtPoint(IceSound, transform.position);
    }

    void TPclear()
    {
        Application.LoadLevel("Clear");
    }
}
