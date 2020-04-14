using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Setup Variables
    [SerializeField] public float speed = 30;

    private Rigidbody2D rigidBody;

    // Start is called before the first frame update
    private void Start()
    {
        // Get a Component of Type RigidBody2D
        rigidBody = GetComponent<Rigidbody2D>();
        // The Velocity of This Rigidbody will be made go in the upwards direction multiplied by Speed Variable
        rigidBody.velocity = Vector2.up * speed;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        // If the bullet collides with a Upper Barrier Destroy
        if (col.tag == "upperBarrier")
        {
            Destroy(gameObject);
        }
        // else if it collides with a enemy increase score by 100 and destroy Bullet & Bird.
        else if (col.tag == "Enemy")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            GameController.scoreValue += 100;
        }
        // else if it collides with a Hawk Increase the score by 1000 and destroy Bullet & The Hawk.
        else if (col.tag == "hawk")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            GameController.scoreValue += 1000;
        }
    }

    // If the Bullet Leaves the Camera Space and Has Become Invisible to the Player. Destroy it.
    public void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}