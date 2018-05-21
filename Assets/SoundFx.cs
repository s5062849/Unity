using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFx : MonoBehaviour {

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
            source.PlayOneShot(hitSound, 1f);
        }
        
    }




}
