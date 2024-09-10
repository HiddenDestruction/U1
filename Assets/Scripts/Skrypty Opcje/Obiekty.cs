using UnityEngine;

public class Obiekty : MonoBehaviour
{
    public AudioSource explosion;
    public AudioSource KEKW;
    public float offset = 0f; 

    private void Update()
    {      
        UpdateAudioVolumes();
    }

    private void UpdateAudioVolumes()
    {
        if (MixerAudio.Instance != null)
        {
            explosion.volume = MixerAudio.Instance.Volume;
            KEKW.volume = MixerAudio.Instance.Volume;
        }
    }
}
