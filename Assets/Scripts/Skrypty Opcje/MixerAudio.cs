using System.IO;
using UnityEngine;
using System;

public class MixerAudio : MonoBehaviour
{
    public static MixerAudio Instance { get; private set; }

    private float volume = 1f;  // Domyœlna wartoœæ g³oœnoœci (od 0 do 1)
    private const string VolumeFileName = "Test.txt";  // Nazwa pliku, w którym zapisujemy g³oœnoœæ

    public float Volume
    {
        get { return volume; }
        set
        {
            volume = Mathf.Clamp(value, 0f, 1f);
            Debug.Log("Volume set to: " + volume);

            try
            {
                // Zapisz aktualn¹ wartoœæ g³oœnoœci do pliku
                File.WriteAllText(VolumeFileName, volume.ToString());
            }
            catch (Exception e)
            {
                Debug.LogError("Exception: " + e.Message);
            }
            finally
            {
                Debug.Log("Executing finally block.");
            }

            UpdateVolume(); // Aktualizuj g³oœnoœæ w grze
        }
    }

    // Inicjalizacja singletona
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        // Wczytaj zapisane ustawienia dŸwiêkowe przy starcie
        LoadVolume();
    }

    // Metoda do aktualizacji g³oœnoœci w grze
    private void UpdateVolume()
    {
        // Aktualizuj g³oœnoœæ globaln¹, np. dla AudioListener
        AudioListener.volume = volume;
        Debug.Log("Global volume updated to: " + volume);
    }

    // Metoda do wczytywania g³oœnoœci z pliku
    public void LoadVolume()
    {
        if (File.Exists(VolumeFileName))
        {
            try
            {
                string volumeString = File.ReadAllText(VolumeFileName);

                if (float.TryParse(volumeString, out float loadedVolume))
                {
                    volume = Mathf.Clamp(loadedVolume, 0f, 1f);
                    Debug.Log("Volume loaded: " + volume);
                    UpdateVolume(); // Aktualizuj g³oœnoœæ po wczytaniu
                }
                else
                {
                    Debug.LogWarning("Nie uda³o siê przekonwertowaæ wartoœci g³oœnoœci.");
                }
            }
            catch (Exception e)
            {
                Debug.LogError("Exception podczas wczytywania g³oœnoœci: " + e.Message);
            }
        }
        else
        {
            Debug.LogWarning("Plik z g³oœnoœci¹ nie istnieje. U¿ywana wartoœæ domyœlna: " + volume);
        }
    }
}
