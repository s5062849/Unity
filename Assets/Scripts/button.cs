using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour {


    public GameObject deleteThis;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Domino (3)" || collision.gameObject.name == "Bell" || collision.gameObject.name == "Bell (1)" || collision.gameObject.name == "Domino (66)" || collision.gameObject.name == "Domino (81)")
        {
            Destroy(deleteThis);
        }
    }



}
