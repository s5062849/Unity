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




}
