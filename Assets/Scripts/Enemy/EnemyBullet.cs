using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    // Variables for Enemey Bullet
    [SerializeField] public float bullet_speed = 15;

    private Rigidbody2D rigidBody;

    private AudioSource death;

    // Start is called before the first frame update
    private void Start()
    {
        // Get a Component of Type Audio Source
        death = GetComponent<AudioSource>();
        // Get a Component of Type RigidBody2D
        rigidBody = GetComponent<Rigidbody2D>();
        // Set the Velocity of the Rigidbody Heading Downwards Multiplied by the Speed Variable
        rigidBody.velocity = Vector2.down * bullet_speed;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        // If Bullet Collides with Bottom Barrier, Destroy It
        if (col.tag == "bottomBarrier")
        {
            Destroy(gameObject);
        }
        // Else if the Bullet Collides with a player, Destroy That Player with a Death Sound
        // Set the Time Scale of the game to 0 (Freeze the Game) and Set Player is Dead to True
        else if (col.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(death.clip, transform.position);
            Destroy(col.gameObject);
            Destroy(gameObject);
            Time.timeScale = 0f;
            GameController.playerDead = true;
        }
    }

    // Call This Incase There is Any Bugs With Lower Barrier and Bullet Leave's Play Space
    public void OnBecameInvisible()
    {
        //Debug.Log("'" + name + "' can *not* be seen anymore.");
        Destroy(gameObject);
    }
}