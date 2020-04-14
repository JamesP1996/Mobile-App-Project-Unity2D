using UnityEngine;

public class BigBirdSpawn : MonoBehaviour
{
    // Variables for the Hawk (BigBird)
    [SerializeField]
    private GameObject hawk = null;

    public float spawnRate = 8f;
    public float nextSpawn = 0.0f;

    // Update is called once per frame
    private void Update()
    {
        // If Time.Time > then The Next Spawn Time. Set a New Next Spawn Time in a Random Range and Spawn the Hawk Bird
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate + Random.Range(5, 15f);
            Instantiate(
                hawk, transform.position, Quaternion.identity);
        }
    }

    private void OnDrawGizmosSelected()
    {
        // Draw a white sphere at the transform's position
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(transform.position, 0.3f);
    }
}