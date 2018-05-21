using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundFX : MonoBehaviour {


    private AudioSource source;
    [SerializeField] private AudioClip hitSound;

    private void Awake()
    {
        {
            source = gameObject.GetComponent<AudioSource>();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Untagged" || collision.gameObject.tag == "CamChange")
        {
            source.Play();
        }


    }
    private void OnCollisionExit(Collision collision)
    {
        source.Stop();
    }
}
