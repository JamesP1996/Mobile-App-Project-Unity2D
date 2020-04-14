using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Variables
    [SerializeField]
    private GameObject bullet = null;

    public float timeBetweenShots;
    public float nextShot = -1;
    public float maxBullets = 3;
    public float minBullets = 1;
    private AudioSource death;

    private void Start()
    {
        // Get a Audio Source
        death = GetComponent<AudioSource>();
        // Set up the enemies firing Rate Between a range
        nextShot = Random.Range(2, 18.0f);
        // Set up a time between shots in a random range
        timeBetweenShots = Random.Range(3, 20.5f);
    }

    // Update is called once per frame
    private void Update()
    {
        // Ensure That The Enemies don't overwelm player with bullets by adding a random range between pre-defined min and max bullet amounts.
        // If the amount of bullets does not exceed the random number chose and Time.Time is greater then the Last Shot's "nextShot"
        // Instantiate and Fire a New Bullet (In This Case our bullet is bird poop).

        if (GameObject.FindGameObjectsWithTag("enemyBullet").Length < Mathf.Abs(Random.Range(minBullets, maxBullets)))
        {
            if (Time.time > nextShot)
            {
                Instantiate(bullet, transform.position, Quaternion.identity);
                nextShot = Time.time + timeBetweenShots;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        // If the Player is hit with the Bird's Collider Box play the AudioSource Death Sound and Destroy Both Objects
        // And Set the Game Controller Boolean Player is Dead to True.
        if (col.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(death.clip, transform.position);
            Destroy(col.gameObject);
            Destroy(gameObject);
            GameController.playerDead = true;
        }
    }
}