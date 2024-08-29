using UnityEngine;

public class VolumeControl : MonoBehaviour
{
    public GameObject[] volumeLevels; // Tablica obiekt�w odpowiadaj�cych poziomom g�o�no�ci (0 - 10)
    private int currentVolumeLevel = 10; // Pocz�tkowy poziom g�o�no�ci (10 oznacza 100%)

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
        // Na pocz�tku ukryjemy tarcz� 10 i poka�emy pozosta�e
        UpdateVolumeVisibility();
        SetVolume(currentVolumeLevel);
    }

    void Update()
    {
        // Sprawdzanie klikni�cia
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Przej�cie przez wszystkie poziomy g�o�no�ci i sprawdzenie trafienia
                for (int i = 0; i < volumeLevels.Length; i++)
                {
                    if (hit.transform.gameObject == volumeLevels[i])
                    {
                        // Ustawienie nowej g�o�no�ci
                        SetVolume(i);
                        break;
                    }
                }
            }
        }
    }

    // Funkcja aktualizuj�ca poziom g�o�no�ci
    void SetVolume(int level)
    {
        currentVolumeLevel = level;
        // Ustaw globaln� g�o�no�� poprzez MixerAudio
        MixerAudio.Instance.Volume = level / 10.0f;
        UpdateVolumeVisibility();
    }

    // Funkcja aktualizuj�ca widoczno�� obiekt�w g�o�no�ci
    void UpdateVolumeVisibility()
    {
        // P�tla przechodz�ca przez wszystkie tarcze w tablicy volumeLevels
        for (int i = 0; i < volumeLevels.Length; i++)
        {
            // Ustaw ka�d� tarcz� na aktywn� (widoczn�)
            volumeLevels[i].SetActive(true);
        }
    }



}
