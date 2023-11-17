using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    AudioSource source;
    Collider soundTrigger;
    void Awake(){
        source = GetComponent<AudioSource>();
        soundTrigger = GetComponent<Collider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Organics"))
        {
            FindAnyObjectByType<GameManager>().AddOrganic();
            source.Play();
            Destroy (other.gameObject);
        }
    }
    
}
