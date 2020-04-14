using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class Save
{
    // Setup a Persistant Path for Every Device
    private static string path = Application.persistentDataPath + "/HighScore.hs";

    // Use a Binary Formatter to Save the File at the Path Location and Seralize a Type of List<PlayerScore> to the File
    // Afterwards Close the Stream.
    // All of this is relevant to HighScores
    public static void SaveHighScore(List<PlayerScore> highscore)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        FileStream stream = new FileStream(path, FileMode.Create);

        formatter.Serialize(stream, HighScore.highScores);
        stream.Close();
    }

    // Load the Previously Saved Binary Formatted and Seralized Game Save File
    // Do This by Deserializing it and then loading the data back into the Highscore variable names highscores
    // Which contains a list of PlayerScores
    // After this Close the Stream

    // If The Save File Does Not Exist. Do Nothing except post Error To Console for Developer to Read.
    public static void LoadSave()
    {
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            List<PlayerScore> data = formatter.Deserialize(stream) as List<PlayerScore>;
            HighScore.highScores = data;
            stream.Close();
        }
        else
        {
            Debug.Log("No Save Data Exists.");
        }
    }
}