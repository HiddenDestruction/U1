using UnityEngine;

public class MixerAudio : MonoBehaviour
{
    public static MixerAudio Instance { get; private set; }

    private float volume = 1f;  // Domy�lna warto�� g�o�no�ci (od 0 do 1)

    public float Volume
    {
        get { return volume; }
        set
        {
            volume = Mathf.Clamp01(value); // Upewnij si�, �e warto�� jest mi�dzy 0 a 1
            UpdateVolume();  // Aktualizuj g�o�no�� we wszystkich �r�d�ach audio
        }
    }

    private void Awake()
    {
        // Upewnij si�, �e istnieje tylko jedna instancja MixerAudio
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Zachowaj ten obiekt podczas zmiany scen
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Metoda do aktualizacji g�o�no�ci we wszystkich AudioSource
    private void UpdateVolume()
    {
        // U�yj FindObjectsByType zamiast FindObjectsOfType
        AudioSource[] audioSources = FindObjectsByType<AudioSource>(FindObjectsSortMode.None);
        foreach (AudioSource audioSource in audioSources)
        {
            audioSource.volume = volume;
        }
    }
}
