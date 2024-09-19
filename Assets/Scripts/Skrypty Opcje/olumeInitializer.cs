using UnityEngine;

public class VolumeInitializer : MonoBehaviour
{
    public AudioManager audioManager;

    void Start()
    {
        if (MixerAudio.Instance != null)
        {
            // Za�aduj ustawienia g�o�no�ci
            MixerAudio.Instance.LoadVolume();

            // Przeka� g�o�no�� do AudioManager
            if (audioManager != null)
            {
                audioManager.SetVolumes(MixerAudio.Instance.Volume);
            }
        }
        else
        {
            Debug.LogError("MixerAudio Instance nie jest dost�pny!");
        }
    }
}
