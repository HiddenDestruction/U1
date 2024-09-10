using UnityEngine;

public class OIryt : MonoBehaviour
{
    public AudioSource skok;
    public float offset = 0f;

    private void Update()
    {
        UpdateAudioVolumes();
    }

    private void UpdateAudioVolumes()
    {
        if (MixerAudio.Instance != null)
        {
            skok.volume = MixerAudio.Instance.Volume;

        }
    }
}
