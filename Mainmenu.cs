using UnityEngine;
using UnityEngine.SceneManagement; // Required for changing scenes

public class Mainmenu : MonoBehaviour
{
    public void PlayGame()
    {
        // Replace "CarSceneName" with the exact name of your car scene
        SceneManager.LoadScene("carscene"); 
    }

    public void QuitGame()
    {
        Debug.Log("Game Quit");
        Application.Quit(); // Only works in the actual build, not in the editor
    }
}
