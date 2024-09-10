using UnityEngine;

public class VolumeInitializer : MonoBehaviour
{
    void Start()
    {
        // Upewnij si�, �e instancja `MixerAudio` istnieje
        if (MixerAudio.Instance != null)
        {
            // Wczytaj zapisane ustawienie g�o�no�ci
            MixerAudio.Instance.LoadVolume();
        }
        else
        {
            Debug.LogError("MixerAudio Instance nie jest dost�pny!");
        }
    }
}
