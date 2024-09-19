using UnityEngine;

public class VolumeInitializer : MonoBehaviour
{
    public AudioManager audioManager;

    void Start()
    {
        if (MixerAudio.Instance != null)
        {
            // Za³aduj ustawienia g³oœnoœci
            MixerAudio.Instance.LoadVolume();

            // Przeka¿ g³oœnoœæ do AudioManager
            if (audioManager != null)
            {
                audioManager.SetVolumes(MixerAudio.Instance.Volume);
            }
        }
        else
        {
            Debug.LogError("MixerAudio Instance nie jest dostêpny!");
        }
    }
}
