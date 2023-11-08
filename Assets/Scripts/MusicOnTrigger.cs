using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicOnTrigger : MonoBehaviour
{
    public AudioSource music;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            music.Pause();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            music.Play();
        }
    }
}
