using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public GameObject[] volumeLevels; // Tablica obiektów odpowiadaj¹cych poziomom g³oœnoœci (0 - 10)
    public AudioSource audioSource; // Obiekt AudioSource
    private int currentVolumeLevel = 10; // Pocz¹tkowy poziom g³oœnoœci (10 oznacza 100%)

    void Start()
    {
        // Na pocz¹tku pokazujemy tylko najwy¿szy poziom g³oœnoœci (10)
        UpdateVolumeVisibility();
        audioSource.volume = 1.0f; // G³oœnoœæ na 100%
    }

    void Update()
    {
        // Sprawdzanie strza³u
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
        audioSource.volume = level / 10.0f; // Przeliczanie na wartoœæ z zakresu 0.0 - 1.0
        UpdateVolumeVisibility();
    }

    // Funkcja aktualizuj¹ca widocznoœæ obiektów g³oœnoœci
    void UpdateVolumeVisibility()
    {
        for (int i = 0; i < volumeLevels.Length; i++)
        {
            // Tylko aktualny poziom g³oœnoœci jest widoczny
            volumeLevels[i].SetActive(i == currentVolumeLevel);
        }
    }
}
