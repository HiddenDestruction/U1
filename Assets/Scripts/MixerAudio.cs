using UnityEngine;

public class MixerAudio : MonoBehaviour
{
    public static MixerAudio Instance { get; private set; }

    private float volume = 1f;  // Domyœlna wartoœæ g³oœnoœci (od 0 do 1)

    public float Volume
    {
        get { return volume; }
        set
        {
            volume = Mathf.Clamp01(value); // Upewnij siê, ¿e wartoœæ jest miêdzy 0 a 1
            UpdateVolume();  // Aktualizuj g³oœnoœæ we wszystkich Ÿród³ach audio
        }
    }

    private void Awake()
    {
        // Upewnij siê, ¿e istnieje tylko jedna instancja MixerAudio
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

    // Metoda do aktualizacji g³oœnoœci we wszystkich AudioSource
    private void UpdateVolume()
    {
        // U¿yj FindObjectsByType zamiast FindObjectsOfType
        AudioSource[] audioSources = FindObjectsByType<AudioSource>(FindObjectsSortMode.None);
        foreach (AudioSource audioSource in audioSources)
        {
            audioSource.volume = volume;
        }
    }
}
