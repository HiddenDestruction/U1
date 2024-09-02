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
                StreamWriter sw = new StreamWriter(VolumeFileName);
                sw.WriteLine(volume.ToString());
                sw.Close();
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
    }

    // Metoda do aktualizacji g³oœnoœci w grze
    private void UpdateVolume()
    {
        // Tutaj mo¿esz dodaæ kod, który aktualizuje g³oœnoœæ w zale¿noœci od tego, co kontrolujesz.
    }

    // Metoda do wczytywania g³oœnoœci z pliku
    public void LoadVolume()
    {
        if (File.Exists(VolumeFileName))
        {
            try
            {
                StreamReader sr = new StreamReader(VolumeFileName);
                string volumeString = sr.ReadLine();
                sr.Close();

                if (float.TryParse(volumeString, out float loadedVolume))
                {
                    volume = loadedVolume;
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
            Debug.LogWarning("Plik z g³oœnoœci¹ nie istnieje.");
        }
    }
}
