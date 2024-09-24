using UnityEngine;

public class ResolutionScaler : MonoBehaviour
{
    void Start()
    {
        // Sprawdza proporcje ekranu (aspect ratio)
        float aspectRatio = (float)Screen.width / (float)Screen.height;

        // Przyk�ad dostosowania obiekt�w w zale�no�ci od proporcji ekranu
        if (aspectRatio > 1.6f) // np. dla proporcji 16:9
        {
            Debug.Log("Ekran w proporcji szerokoekranowej (16:9).");
            // Tutaj mo�esz doda� kod do zmiany skali, pozycji lub innych w�a�ciwo�ci obiekt�w
            // np. transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        }
        else
        {
            Debug.Log("Ekran w innej proporcji ni� 16:9.");
            // Dostosuj skalowanie, pozycj� lub inne w�a�ciwo�ci do innej rozdzielczo�ci
        }
    }
}
