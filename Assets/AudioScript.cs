using UnityEngine;

public class AudioScript : MonoBehaviour
{
    [Header("---------- Audio Source ----------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("---------- Audio Clip ----------")]
    public AudioClip shot;
    public AudioClip explosion;
    public AudioClip Kekw;
    public AudioClip death;
}
