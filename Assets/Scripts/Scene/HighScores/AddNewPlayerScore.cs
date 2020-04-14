using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AddNewPlayerScore : MonoBehaviour
{
    // Variables Needed for Adding a New Player Score
    [SerializeField]
    private InputField initials = null;

    private string playerInitials;
    private int playerScore;
    private string sceneToLoad = "Main Menu";

    // Set the player Initials Variable to Typed in Initials. Get the Player Score from the Game Controller.
    // Then create a New Player Score Using the Initials Entered and the Player Score Got.
    // Add this new Player Score to the HighScore Board
    // Then Reset the Game Controller and Load to the Main Menu so the player can Exit/Start a New Game
    // Also see their score in comparison to to others
    public void EnterNewScore()
    {
        playerInitials = initials.text;
        playerScore = GameController.scoreValue;
        PlayerScore newPlayer = new PlayerScore(playerInitials, playerScore);
        HighScore.highScores.Add(newPlayer);
        Save.SaveHighScore(HighScore.highScores);
        GameController.ResetGameController();
        SceneManager.LoadScene(sceneToLoad);
    }
}