using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour {

    private bool play;



	// Use this for initialization
	void Start () {
        play = true;
	}
	
	// Update is called once per frame
	void Update () {
		
        if (play == true)
        {
            var rb = gameObject.GetComponent<Rigidbody>();

            var force = gameObject.transform.forward * 100 * Time.deltaTime;

            var posision = GameObject.Find("ForcePosision").transform.position;

            rb.AddForceAtPosition(force, posision, ForceMode.VelocityChange);


        }

	}
}
