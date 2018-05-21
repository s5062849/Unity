using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour {

    private bool play;

    public HideShow hideShow;

	// Use this for initialization
	void Start () {
        play = true;
        hideShow.Hide();
	}
	
	// Update is called once per frame
	void Update () {
		
        if (play == true)
        {
            var rb = gameObject.GetComponent<Rigidbody>();

            var force = gameObject.transform.forward * 50 * Time.deltaTime;

            var posision = GameObject.Find("ForcePosision").transform.position;

            rb.AddForceAtPosition(force, posision, ForceMode.VelocityChange);


        }

	}
}
