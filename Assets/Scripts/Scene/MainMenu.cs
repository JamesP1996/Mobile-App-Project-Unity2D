using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Variables
    public string scenetoload = "Game";

    private bool isMute;

    private void Awake()
    {
        // Load HighScores In if File Exists
        Save.LoadSave();
    }

    // Start Game by Loading the "Game" Scene and Set TimeScale to Normal
    public void StartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(scenetoload);
    }

    // Toggle Audio of the Game
    public void ToggleSound()
    {
        isMute = !isMute;
        AudioListener.volume = isMute ? 0 : 1;
    }

    // Quit The Game (Only Works When Game is Built and Running, Not Through Editor)
    public void Quit()
    {
        Application.Quit();
    }
}