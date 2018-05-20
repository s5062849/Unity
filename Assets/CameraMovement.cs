using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public List<GameObject> Targets;

    private int cameraPos = 0;

    private Transform obj;

    public float smoothspeed = 0.125f;

    public Vector3 offset;



    private void FixedUpdate()
    {
        //switch case that smooths the camera movement and ensures it looks at the correct object
        switch (cameraPos)
        {
            case 0:

                offset.x = 3;

                CameraTarget();
                Vector3 targetpos = obj.position + offset;
                Vector3 smoothedPos = Vector3.Lerp(transform.position, targetpos, smoothspeed);
                transform.position = smoothedPos;
                transform.LookAt(obj);

                break;
            case 1:

                offset.x = 3;

                CameraTarget();
                 targetpos = obj.position + offset;
                 smoothedPos = Vector3.Lerp(transform.position, targetpos, smoothspeed);
                transform.position = smoothedPos;
                transform.LookAt(obj);

                break;
            case 2:

                offset.x = 3;

                CameraTarget();
                targetpos = obj.position + offset;
                smoothedPos = Vector3.Lerp(transform.position, targetpos, smoothspeed);
                transform.position = smoothedPos;
                transform.LookAt(obj);

                break;
            case 3:

                offset.x = 3;

                CameraTarget();
                targetpos = obj.position + offset;
                smoothedPos = Vector3.Lerp(transform.position, targetpos, smoothspeed);
                transform.position = smoothedPos;
                transform.LookAt(obj);

                break;
            case 4:

                offset.x = 3;

                CameraTarget();
                targetpos = obj.position + offset;
                smoothedPos = Vector3.Lerp(transform.position, targetpos, smoothspeed);
                transform.position = smoothedPos;
                transform.LookAt(obj);

                break;
            case 5:

                offset.x = 3;

                CameraTarget();
                targetpos = obj.position + offset;
                smoothedPos = Vector3.Lerp(transform.position, targetpos, smoothspeed);
                transform.position = smoothedPos;
                transform.LookAt(obj);

                break;
            case 6:

                offset.x = 3;

                CameraTarget();
                targetpos = obj.position + offset;
                smoothedPos = Vector3.Lerp(transform.position, targetpos, smoothspeed);
                transform.position = smoothedPos;
                transform.LookAt(obj);

                break;
            case 7:

                offset.x = 3;

                CameraTarget();
                targetpos = obj.position + offset;
                smoothedPos = Vector3.Lerp(transform.position, targetpos, smoothspeed);
                transform.position = smoothedPos;
                transform.LookAt(obj);

                break;
            case 8:

                offset.x = 3;

                CameraTarget();
                targetpos = obj.position + offset;
                smoothedPos = Vector3.Lerp(transform.position, targetpos, smoothspeed);
                transform.position = smoothedPos;
                transform.LookAt(obj);

                break;
            case 9:

                offset.x = 3;

                CameraTarget();
                targetpos = obj.position + offset;
                smoothedPos = Vector3.Lerp(transform.position, targetpos, smoothspeed);
                transform.position = smoothedPos;
                transform.LookAt(obj);

                break;
            case 10:

                offset.x = 3;

                CameraTarget();
                targetpos = obj.position + offset;
                smoothedPos = Vector3.Lerp(transform.position, targetpos, smoothspeed);
                transform.position = smoothedPos;
                transform.LookAt(obj);

                break;
            case 11:

                offset.x = 3;

                CameraTarget();
                targetpos = obj.position + offset;
                smoothedPos = Vector3.Lerp(transform.position, targetpos, smoothspeed);
                transform.position = smoothedPos;
                transform.LookAt(obj);

                break;
            case 12:

                offset.x = 3;

                CameraTarget();
                targetpos = obj.position + offset;
                smoothedPos = Vector3.Lerp(transform.position, targetpos, smoothspeed);
                transform.position = smoothedPos;
                transform.LookAt(obj);

                break;
            case 13:

                offset.x = 3;

                CameraTarget();
                targetpos = obj.position + offset;
                smoothedPos = Vector3.Lerp(transform.position, targetpos, smoothspeed);
                transform.position = smoothedPos;
                transform.LookAt(obj);

                break;
            case 14:

                offset.x = 3;

                CameraTarget();
                targetpos = obj.position + offset;
                smoothedPos = Vector3.Lerp(transform.position, targetpos, smoothspeed);
                transform.position = smoothedPos;
                transform.LookAt(obj);

                break;
            case 15:

                offset.x = 3;

                CameraTarget();
                targetpos = obj.position + offset;
                smoothedPos = Vector3.Lerp(transform.position, targetpos, smoothspeed);
                transform.position = smoothedPos;
                transform.LookAt(obj);

                break;
            case 16:

                offset.x = 3;

                CameraTarget();
                targetpos = obj.position + offset;
                smoothedPos = Vector3.Lerp(transform.position, targetpos, smoothspeed);
                transform.position = smoothedPos;
                transform.LookAt(obj);

                break;
            case 17:

                offset.x = 3;

                CameraTarget();
                targetpos = obj.position + offset;
                smoothedPos = Vector3.Lerp(transform.position, targetpos, smoothspeed);
                transform.position = smoothedPos;
                transform.LookAt(obj);

                break;
            case 18:

                offset.x = 3;

                CameraTarget();
                targetpos = obj.position + offset;
                smoothedPos = Vector3.Lerp(transform.position, targetpos, smoothspeed);
                transform.position = smoothedPos;
                transform.LookAt(obj);

                break;
            case 19:

                offset.x = 3;

                CameraTarget();
                targetpos = obj.position + offset;
                smoothedPos = Vector3.Lerp(transform.position, targetpos, smoothspeed);
                transform.position = smoothedPos;
                transform.LookAt(obj);

                break;
            case 20:

                offset.x = 3;

                CameraTarget();
                targetpos = obj.position + offset;
                smoothedPos = Vector3.Lerp(transform.position, targetpos, smoothspeed);
                transform.position = smoothedPos;
                transform.LookAt(obj);

                break;
            default:
                Debug.Log("Camera Movments Error");
                break;
 

        }



    }

    //means that the camera knows which target to look at
    private void CameraTarget()
    {
        obj = Targets[cameraPos].transform;
    }

    //this increases camerapos by one meaning that the camera switches
    public void ChangeCam()
    {
        cameraPos += 1;
        Debug.Log(cameraPos);
    }


}
