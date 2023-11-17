using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyG : MonoBehaviour
{
    AudioSource source;
    Collider soundTrigger;
    void Awake(){
        source = GetComponent<AudioSource>();
        soundTrigger = GetComponent<Collider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Glass"))
        {
            source.Play();
            Destroy (other.gameObject);
        }
    }

}
