using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannonball : MonoBehaviour {

    private void Update()
    {
        Debug.DrawRay(gameObject.transform.position, Vector3.forward, Color.red);
    }


    public void Fire()

    {
        if (gameObject.name == "cannonBall")
        {
            var rb = gameObject.GetComponent<Rigidbody>();
            var force = Vector3.right * 1000f * Time.deltaTime;
            var posision = gameObject.transform.position;

            rb.AddForceAtPosition(force, posision, ForceMode.VelocityChange);
        }

        if (gameObject.name == "cannonBall (1)")
        {
            var rb = gameObject.GetComponent<Rigidbody>();
            var force = Vector3.forward * 1500f * Time.deltaTime;
            var posision = gameObject.transform.position;

            rb.AddForceAtPosition(force, posision, ForceMode.VelocityChange);
        }



    }

}
