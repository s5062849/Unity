using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bellMovement : MonoBehaviour {

    public bool hit;

	// Use this for initialization
	void Start () {
        hit = false;
	}
	
	// Update is called once per frame
	void Update () {
        
        
        if (hit == true)
        {
            transform.Translate(Vector3.right * 3f * Time.deltaTime) ;
        }



	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Struct (10)" )
        {
            
            hit = false;
            gameObject.transform.position = gameObject.transform.position;
           
        }
        else if (collision.gameObject.name == "Struct (15)")
            
        {
            Debug.Log("Should Stop");
            hit = false;
            gameObject.transform.position = gameObject.transform.position;
            Debug.Log(hit);
        }
    }



}
