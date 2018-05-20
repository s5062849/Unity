using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour {

    public CameraMovement cameraMovement;

    //runs the camchange function in CameraMovment, meaning that the camera changes target
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "CamChange")
        {
            cameraMovement.ChangeCam();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CamChange")
        {
            cameraMovement.ChangeCam();
        }
        
    }


}
