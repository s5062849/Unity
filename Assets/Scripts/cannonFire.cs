using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonFire : MonoBehaviour {

    public Cannonball cannonBall;

    


    private void OnCollisionEnter(Collision collision)
    {
        

        if (collision.gameObject.name == "Domino (36)" || collision.gameObject.name == "Ball (5)")
        {
            cannonBall.Fire();
        }
    }



}
