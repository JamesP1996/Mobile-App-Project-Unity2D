using UnityEngine;
using UnityEngine.UI;

public class GameOverScore : MonoBehaviour
{
    private Text score;

    // Start is called before the first frame update
    private void Start()
    {
        // Get a Component of Type Text
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    private void Update()
    {
        // Display your Score onto the Text ( To Be used on Game Over Panel)
        score.text = "Your Score was:\n" + GameController.scoreValue;
    }
}