using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBellMove : MonoBehaviour {

    public bellMovement BellMovement;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Domino (21)" || collision.gameObject.name == "Bell (1)")
        {
            BellMovement.hit = true;
        }
    }
}
