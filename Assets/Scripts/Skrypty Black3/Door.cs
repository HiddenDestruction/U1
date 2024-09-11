using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject door;  // Referencja do drzwi, kt�re zostan� zniszczone
    public GameObject rock;  // Referencja do kamienia, kt�ry si� pojawi
    public GameObject key;   // Referencja do klucza, kt�ry gracz podnosi

    private void Start()
    {
        // Kamie� jest niewidoczny na pocz�tku
        rock.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Sprawdzenie, czy obiekt, kt�ry wszed� w trigger, to gracz
        if (collision.GetComponent<granpa>() != null)
        {
            // Klucz znika (niszczony)
            Destroy(key);

            // Drzwi znikaj� (niszczone)
            Destroy(door);

            // Kamie� pojawia si� (ustawiamy go jako aktywny)
            rock.SetActive(true);

            Debug.Log("Klucz podniesiony, drzwi znikaj�, kamie� pojawia si�.");
        }
    }
}
