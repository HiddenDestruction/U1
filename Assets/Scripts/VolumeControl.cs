using UnityEngine;

public class VolumeControl : MonoBehaviour
{
    public GameObject[] volumeLevels; // Tablica obiektów odpowiadaj¹cych poziomom g³oœnoœci (0 - 10)
    private int currentVolumeLevel = 10; // Pocz¹tkowy poziom g³oœnoœci (10 oznacza 100%)

    public GameObject target0;
    public GameObject target1;
    public GameObject target2;
    public GameObject target3;
    public GameObject target4;
    public GameObject target5;
    public GameObject target6;
    public GameObject target7;
    public GameObject target8;
    public GameObject target9;
    public GameObject target10; 

    void Start()
    {
        // Na pocz¹tku ukryjemy tarczê 10 i poka¿emy pozosta³e
        UpdateVolumeVisibility();
        SetVolume(currentVolumeLevel);
    }

    void Update()
    {
        // Sprawdzanie klikniêcia
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Przejœcie przez wszystkie poziomy g³oœnoœci i sprawdzenie trafienia
                for (int i = 0; i < volumeLevels.Length; i++)
                {
                    if (hit.transform.gameObject == volumeLevels[i])
                    {
                        // Ustawienie nowej g³oœnoœci
                        SetVolume(i);
                        break;
                    }
                }
            }
        }
    }

    // Funkcja aktualizuj¹ca poziom g³oœnoœci
    void SetVolume(int level)
    {
        currentVolumeLevel = level;
        // Ustaw globaln¹ g³oœnoœæ poprzez MixerAudio
        MixerAudio.Instance.Volume = level / 10.0f;
        UpdateVolumeVisibility();
    }

    // Funkcja aktualizuj¹ca widocznoœæ obiektów g³oœnoœci
    void UpdateVolumeVisibility()
    {
        // Pêtla przechodz¹ca przez wszystkie tarcze w tablicy volumeLevels
        for (int i = 0; i < volumeLevels.Length; i++)
        {
            // Ustaw ka¿d¹ tarczê na aktywn¹ (widoczn¹)
            volumeLevels[i].SetActive(true);
        }
    }



}
