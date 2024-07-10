using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMainMenu : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // SprawdŸ, czy wciœniêto klawisz Escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Za³aduj scenê g³ówn¹ (zmieñ "MainMenu" na nazwê swojej sceny g³ównej)
            SceneManager.LoadScene("MainMenu");
        }
    }
}
