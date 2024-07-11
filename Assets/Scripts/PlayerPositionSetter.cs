using UnityEngine;

public class PlayerPositionSetter : MonoBehaviour
{
    void Start()
    {
        // SprawdŸ, czy zapisane s¹ dane dotycz¹ce pozycji gracza
        if (PlayerPrefs.HasKey("PlayerX") && PlayerPrefs.HasKey("PlayerY") && PlayerPrefs.HasKey("PlayerZ"))
        {
            float x = PlayerPrefs.GetFloat("PlayerX");
            float y = PlayerPrefs.GetFloat("PlayerY");
            float z = PlayerPrefs.GetFloat("PlayerZ");

            // Ustaw pozycjê gracza
            transform.position = new Vector3(x, y, z);
        }
    }
}
