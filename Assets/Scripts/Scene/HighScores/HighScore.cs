using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class HighScore : MonoBehaviour
{
    // Make a List of Player Scores called highscores.
    // This is the Universal Highscore Table and is Seralizeable by the System so it can be saved and loaded into.
    public static List<PlayerScore> highScores = new List<PlayerScore>();
}