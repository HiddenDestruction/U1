using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject door;  // Referencja do drzwi, które zostan¹ zniszczone
    public GameObject rock;  // Referencja do kamienia, który siê pojawi
    public GameObject key;   // Referencja do klucza, który gracz podnosi

    private void Start()
    {
        // Kamieñ jest niewidoczny na pocz¹tku
        rock.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Sprawdzenie, czy obiekt, który wszed³ w trigger, to gracz
        if (collision.GetComponent<granpa>() != null)
        {
            // Klucz znika (niszczony)
            Destroy(key);

            // Drzwi znikaj¹ (niszczone)
            Destroy(door);

            // Kamieñ pojawia siê (ustawiamy go jako aktywny)
            rock.SetActive(true);

            Debug.Log("Klucz podniesiony, drzwi znikaj¹, kamieñ pojawia siê.");
        }
    }
}
