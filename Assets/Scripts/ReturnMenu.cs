using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnMenu : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Sprawd�, czy wci�ni�to klawisz Escape, Spacja lub Enter
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return))
        {
            // Za�aduj scen� g��wn� (zmie� "MainMenu" na nazw� swojej sceny g��wnej)
            SceneManager.LoadScene("MainMenu");
        }
    }
}
