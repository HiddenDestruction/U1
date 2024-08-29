using System.IO;
using UnityEngine;

public class MixerAudio : MonoBehaviour
{
    public static MixerAudio Instance { get; private set; }

    private float volume = 1f;  // Domy�lna warto�� g�o�no�ci (od 0 do 1)
    private const string VolumeFileName = "volume.txt";  // Nazwa pliku, w kt�rym zapisujemy g�o�no��

    public float Volume
    {
        get { return volume; }
        set
        {
            volume = Mathf.Clamp(value, 0f, 1f);
            Debug.Log("Volume set to: " + volume);
            UpdateVolume(); // Aktualizuj g�o�no�� we wszystkich AudioSource
            SaveVolume(); // Zapisz now� warto�� g�o�no�ci do pliku
        }
    }

    private void Awake()
    {
        // Upewnij si�, �e istnieje tylko jedna instancja MixerAudio
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Zachowaj ten obiekt podczas zmiany scen
            LoadVolume(); // Wczytaj warto�� g�o�no�ci przy uruchamianiu
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Metoda do aktualizacji g�o�no�ci we wszystkich AudioSource
    private void UpdateVolume()
    {
        AudioSource[] audioSources = FindObjectsByType<AudioSource>(FindObjectsSortMode.None);
        foreach (AudioSource audioSource in audioSources)
        {
            audioSource.volume = volume;
        }
    }

    // Metoda do zapisywania warto�ci g�o�no�ci do pliku
    private void SaveVolume()
    {
        string path = Path.Combine(Application.persistentDataPath, VolumeFileName);
        using (StreamWriter writer = new StreamWriter(path))
        {
            writer.WriteLine(volume);
        }
    }

    // Metoda do wczytywania warto�ci g�o�no�ci z pliku
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
