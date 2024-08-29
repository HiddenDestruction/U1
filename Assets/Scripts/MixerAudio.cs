using System.IO;
using UnityEngine;

public class MixerAudio : MonoBehaviour
{
    public static MixerAudio Instance { get; private set; }

    private float volume = 1f;  // Domyœlna wartoœæ g³oœnoœci (od 0 do 1)
    private const string VolumeFileName = "volume.txt";  // Nazwa pliku, w którym zapisujemy g³oœnoœæ

    public float Volume
    {
        get { return volume; }
        set
        {
            volume = Mathf.Clamp(value, 0f, 1f);
            Debug.Log("Volume set to: " + volume);
            UpdateVolume(); // Aktualizuj g³oœnoœæ we wszystkich AudioSource
            SaveVolume(); // Zapisz now¹ wartoœæ g³oœnoœci do pliku
        }
    }

    private void Awake()
    {
        // Upewnij siê, ¿e istnieje tylko jedna instancja MixerAudio
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Zachowaj ten obiekt podczas zmiany scen
            LoadVolume(); // Wczytaj wartoœæ g³oœnoœci przy uruchamianiu
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Metoda do aktualizacji g³oœnoœci we wszystkich AudioSource
    private void UpdateVolume()
    {
        AudioSource[] audioSources = FindObjectsByType<AudioSource>(FindObjectsSortMode.None);
        foreach (AudioSource audioSource in audioSources)
        {
            audioSource.volume = volume;
        }
    }

    // Metoda do zapisywania wartoœci g³oœnoœci do pliku
    private void SaveVolume()
    {
        string path = Path.Combine(Application.persistentDataPath, VolumeFileName);
        using (StreamWriter writer = new StreamWriter(path))
        {
            writer.WriteLine(volume);
        }
    }

    // Metoda do wczytywania wartoœci g³oœnoœci z pliku
    private void LoadVolume()
    {
        string path = Path.Combine(Application.persistentDataPath, VolumeFileName);
        if (File.Exists(path))
        {
            using (StreamReader reader = new StreamReader(path))
            {
                if (float.TryParse(reader.ReadLine(), out float loadedVolume))
                {
                    volume = Mathf.Clamp(loadedVolume, 0f, 1f);
                    Debug.Log("Loaded Volume: " + volume);
                }
            }
        }
        else
        {
            Debug.Log("No volume file found. Using default volume.");
        }
    }
}
