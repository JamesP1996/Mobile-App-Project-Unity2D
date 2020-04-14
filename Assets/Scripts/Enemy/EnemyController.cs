using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    private Transform enemyHolder;
    private AudioSource flap;

    // Start is called before the first frame update
    private void Start()
    {
        // Invoke Repeating Move Enemy Function
        InvokeRepeating("MoveEnemy", 0.1f, 0.3f);
        // Get a Transform and Bind it to Variable Called Enemy Holder
        enemyHolder = GetComponent<Transform>();
        // Get a Audio Source and Bind it to the Variable Flap
        flap = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void MoveEnemy()
    {
        //Play Flapping
        flap.Play();
        //Move Enemy Holder Posistion to the Right by Their Speed
        enemyHolder.position += Vector3.right * GameController.enemySpeed;
        // For Each Enemy in the EnemyHolder
        foreach (Transform enemy in enemyHolder)
        {
            // If their posistion on X-Axis is less then -8 or great then 8
            if (enemy.position.x < -8 || enemy.position.x > 8)
            {
                // Reverse their direction and Move Them Down
                GameController.enemySpeed = -GameController.enemySpeed;
                enemyHolder.position += Vector3.down * 0.5f;
                return;
            }
        }
        // If the Enemy Holder Contains Less Than or Equal to 3 Birds.
        // Invoke the Movement of The Enemy Holder to be Faster.
        if (enemyHolder.childCount <= 3)
        {
            CancelInvoke();
            InvokeRepeating("MoveEnemy", 0.1f, 0.25f);
        }

        // If There are no enemies left. Stop the Flapping Sounds. Increase the Wave Numbers, Enemy Speed and Hawk Speed
        // And Then Reload the Scene with the increased variables ( This will cause the flap sound to start again but
        // the birds will be faster and harder to beat ) .
        if (enemyHolder.childCount == 0)
        {
            flap.Stop();
            GameController.wave += 1;

            if (GameController.enemySpeed < 1.50f)
            {
                GameController.enemySpeed = Mathf.Abs(GameController.enemySpeed);
                GameController.enemySpeed += 0.25f;
            }
            if (GameController.hawkSpeed < 6f)
            {
                GameController.hawkSpeed += 1f;
            }

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}