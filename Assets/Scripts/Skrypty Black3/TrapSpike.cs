using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrapSpike : MonoBehaviour
{
    public Transform teleportDestination;
    public AudioSource Spike;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<granpa>() != null)
        {
            if (MixerAudio.Instance != null)
            {
                Spike.volume = MixerAudio.Instance.Volume; 
            }
            collision.transform.position = teleportDestination.position;
            Debug.Log("Knock");
            Spike.Play();
        }
    }
}
