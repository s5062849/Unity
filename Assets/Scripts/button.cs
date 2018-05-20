using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour {


    public GameObject deleteThis;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Domino (3)")
        {
            Destroy(deleteThis);
        }
    }



}
