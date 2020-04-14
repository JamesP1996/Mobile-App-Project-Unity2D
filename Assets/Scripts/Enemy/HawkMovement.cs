using UnityEngine;

public class HawkMovement : MonoBehaviour
{
    // Variable Setup
    private Transform hawk;

    // Start is called before the first frame update
    private void Start()
    {
        // Hawk = Transform of This Hawk
        hawk = this.transform;
    }

    // Update is called once per frame
    private void Update()
    {
        // Move the Hawk Towards the Left, Dictated by GameControllers Hawk Speed Variable Multiplied by Time.deltaTime
        hawk.transform.position += Vector3.left * GameController.hawkSpeed * Time.deltaTime;
    }

    // If the Hawk Collides with a Collideable Object with the Tag Left Barrier, Destroy It.
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "leftBarrier")
        {
            Destroy(gameObject);
        }
    }
}