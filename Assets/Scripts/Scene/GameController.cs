using UnityEngine;

public class GameController : MonoBehaviour
{
    // Numerous Variables for the Games Score/Player/Enemy Mechanics.

    [SerializeField]
    public static float enemySpeed = 0.25f;

    [SerializeField]
    public static float hawkSpeed = 3f;

    [SerializeField]
    public static bool playerDead = false;

    [SerializeField]
    public static int scoreValue = 0;

    [SerializeField]
    public static int wave = 1;

    // Variable to Reset Score,Player and Enemy Variables back to their Original State
    public static void ResetGameController()
    {
        enemySpeed = 0.15f;
        hawkSpeed = 3f;
        playerDead = false;
        scoreValue = 0;
        wave = 1;
    }
}