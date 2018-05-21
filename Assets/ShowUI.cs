using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUI : MonoBehaviour {

    public HideShow show;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "cannon_ball (1)")
        {
            show.Show();
        }
    }


}
