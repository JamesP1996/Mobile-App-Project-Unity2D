using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    // Variables
    private Transform player;

    [SerializeField]
    //Default Movement Speed is 15.0
    public float speed = 12;

    public float maxBound, minBound;
    public static bool buttonDownLeft, buttonDownRight;

    // Start is called before the first frame update
    private void Start()
    {
        // Get a Component that is of Transform
        player = GetComponent<Transform>();
    }

    // Fixed Update Needed for RigidBody Update.
    private void FixedUpdate()
    {
        //Input Horizontal being The Arrow Keys and WASD
        float horizontalMovement = Input.GetAxis("Horizontal");

        // If the player and he's horizontal movement is less then the coords of the minBound. Stop Moving.
        if (player.position.x < minBound && horizontalMovement < 0)
            horizontalMovement = 0;
        // If the player and he's horizntal movement is greater then the coords of the maxBound. Stop Moving.
        else if (player.position.x > maxBound && horizontalMovement > 0)
            horizontalMovement = 0;

        // Move the Player Posistion based on horizontal movement and Speed Variable
        player.position += Vector3.right * horizontalMovement * speed * Time.deltaTime;

        // Check if Boolean Button Down Left is True. If it is move player Left (Used for Mobile)
        if (buttonDownLeft == true)
        {
            player.position += Vector3.left * speed * Time.deltaTime;
        }
        // Check if Boolean Button Down Right is True. If it is move player Right (Used for Mobile)
        if (buttonDownRight == true)
        {
            player.position += Vector3.right * speed * Time.deltaTime;
        }
    }
}