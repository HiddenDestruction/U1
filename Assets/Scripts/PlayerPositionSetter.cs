using UnityEngine;

public class PlayerPositionSetter : MonoBehaviour
{
    void Start()
    {
        // Sprawd�, czy zapisane s� dane dotycz�ce pozycji gracza
        if (PlayerPrefs.HasKey("PlayerX") && PlayerPrefs.HasKey("PlayerY") && PlayerPrefs.HasKey("PlayerZ"))
        {
            float x = PlayerPrefs.GetFloat("PlayerX");
            float y = PlayerPrefs.GetFloat("PlayerY");
            float z = PlayerPrefs.GetFloat("PlayerZ");

            // Ustaw pozycj� gracza
            transform.position = new Vector3(x, y, z);
        }
    }
}
