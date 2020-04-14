using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Variable Setup
    public GameObject theBullet;

    [SerializeField]
    private float fireRate = 0.3f;

    private AudioSource shootSound;

    private float nextFire;

    // Start is called before the first frame update
    private void Start()
    {
        // Get A Component of Type Audio Source
        shootSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void Update()
    {
        // If the Input is the "Jump"/<Space> Input Shoot when Time.time Is greater then nextFire
        if (Input.GetButtonDown("Jump") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            shootSound.Play();
            Instantiate(theBullet, transform.position, Quaternion.identity);
        }
    }

    // Shoot Bullet Method For The Shoot Button on Android
    public void ShootBullet()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            shootSound.Play();
            Instantiate(theBullet, transform.position, Quaternion.identity);
        }
    }
}