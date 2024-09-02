using UnityEngine;

public class VolumeInitializer : MonoBehaviour
{
    void Start()
    {
        // Upewnij siê, ¿e instancja `MixerAudio` istnieje
        if (MixerAudio.Instance != null)
        {
            // Wczytaj zapisane ustawienie g³oœnoœci
            MixerAudio.Instance.LoadVolume();
        }
        else
        {
            Debug.LogError("MixerAudio Instance nie jest dostêpny!");
        }
    }
}
