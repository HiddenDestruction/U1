using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public GameObject[] volumeLevels; // Tablica obiekt�w odpowiadaj�cych poziomom g�o�no�ci (0 - 10)
    public AudioSource audioSource; // Obiekt AudioSource
    private int currentVolumeLevel = 10; // Pocz�tkowy poziom g�o�no�ci (10 oznacza 100%)

    void Start()
    {
        // Na pocz�tku pokazujemy tylko najwy�szy poziom g�o�no�ci (10)
        UpdateVolumeVisibility();
        audioSource.volume = 1.0f; // G�o�no�� na 100%
    }

    void Update()
    {
        // Sprawdzanie strza�u
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
        audioSource.volume = level / 10.0f; // Przeliczanie na warto�� z zakresu 0.0 - 1.0
        UpdateVolumeVisibility();
    }

    // Funkcja aktualizuj�ca widoczno�� obiekt�w g�o�no�ci
    void UpdateVolumeVisibility()
    {
        for (int i = 0; i < volumeLevels.Length; i++)
        {
            // Tylko aktualny poziom g�o�no�ci jest widoczny
            volumeLevels[i].SetActive(i == currentVolumeLevel);
        }
    }
}
