using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    // Variables for a String Builder and a UI Text Component called ScoreBoard
    private Text scoreboard;

    private StringBuilder scoreBoardText = new StringBuilder();

    private void Start()
    {
        try
        {
            // Try to Get a Component of type text and then use the Update Scores Function to Update it.
            scoreboard = GetComponent<Text>();
            scoreboard.text = "";
            UpdateScores();
        }
        catch (NullReferenceException ex)
        {
            // If You Fail To Get the Component of Score Board.
            // Post Message to Developer letting them know it's not binded in the inspector.
            Debug.Log("Score Board Not Found in Inspector \n" + ex);
        }
    }

    private void UpdateScores()
    {
        // Create a Sorted List of Highscores by using the Linq Class and Order Them by their Scores in Reverse (Highest to Lowest)
        List<PlayerScore> SortedList = HighScore.highScores.OrderBy(hs => hs.score).Reverse().ToList();
        foreach (PlayerScore ps in SortedList.Take(8))
        {
            //Append Each Score to the scoreBoardText String Builder Variable
            scoreBoardText.Append(ps.playerName + "     |     " + ps.score + "\n");
        }
        // Then Throw all of the String Builder String into the UI Text
        scoreboard.text = "Player           Score\n" + scoreBoardText.ToString();
    }
}