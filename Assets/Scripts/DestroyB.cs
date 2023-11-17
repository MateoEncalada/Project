using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyB : MonoBehaviour
{
    AudioSource source;
    Collider soundTrigger;
    void Awake(){
        source = GetComponent<AudioSource>();
        soundTrigger = GetComponent<Collider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bottle"))
        {
            FindAnyObjectByType<GameManager>().AddBottle();
            source.Play();
            Destroy (other.gameObject);
        }
    }

}
