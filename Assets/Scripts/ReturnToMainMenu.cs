using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMainMenu : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Sprawd�, czy wci�ni�to klawisz Escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Za�aduj scen� g��wn� (zmie� "MainMenu" na nazw� swojej sceny g��wnej)
            SceneManager.LoadScene("MainMenu");
        }
    }
}
