using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnMenu : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // SprawdŸ, czy wciœniêto klawisz Escape, Spacja lub Enter
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return))
        {
            // Za³aduj scenê g³ówn¹ (zmieñ "MainMenu" na nazwê swojej sceny g³ównej)
            SceneManager.LoadScene("MainMenu");
        }
    }
}
