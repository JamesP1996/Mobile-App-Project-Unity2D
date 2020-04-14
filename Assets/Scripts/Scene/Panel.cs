using UnityEngine;

public class Panel : MonoBehaviour
{
    // Variables for the Panel
    public GameObject panel;

    // Start is called before the first frame update
    private void Start()
    {
        // On Game Start, Set the Game Over Panel to Not Active.
        panel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        // Run Function ShowHide();
        ShowHide();
    }

    private void ShowHide()
    {
        // If Player is Dead Show the Game Over Panel. Else Don't.
        if (GameController.playerDead == false)
        {
            panel.gameObject.SetActive(false);
        }
        else if (GameController.playerDead == true)
        {
            panel.gameObject.SetActive(true);
        }
    }
}