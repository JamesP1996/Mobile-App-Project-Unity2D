using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Variables
    private Text score;

    // Start is called before the first frame update
    private void Start()
    {
        // Bind Score Variable to a Component of Type Text
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    private void Update()
    {
        // Display The Score and Wave In Top Left of Screen during Gameplay
        score.text = "Score: " + GameController.scoreValue + "\n" + "Wave: " + GameController.wave;
    }
}