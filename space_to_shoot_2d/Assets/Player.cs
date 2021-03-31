using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    private float speed = 7f;
    private Rigidbody2D rb2d;
    public Transform firePoint;
    public GameObject bulletPrefab;
    private float bulletSpeed = 15f;
    private float cooldown = 0.1f;
    private float nextFire = 0f;

    void Start () {
      rb2d = GetComponent<Rigidbody2D> ();
    }
	
    void Update () {
      UpdateMotion();
      ProcessBulletSpawn();
    }

    private void UpdateMotion() {
        Vector3 pos = transform.position;

        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
        }

        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }

        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }

        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }

        transform.position = pos;
    }
    
    private void ProcessBulletSpawn() {
      if (Input.GetKey(KeyCode.UpArrow) && Time.time > nextFire) {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D re = bullet.GetComponent<Rigidbody2D>();
        re.velocity = firePoint.up * bulletSpeed;
        nextFire = Time.time + cooldown;
      }

      if (Input.GetKey(KeyCode.RightArrow) && Time.time > nextFire) {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D re = bullet.GetComponent<Rigidbody2D>();
        re.velocity = firePoint.right * bulletSpeed;
        nextFire = Time.time + cooldown;
      }

      if (Input.GetKey(KeyCode.DownArrow) && Time.time > nextFire) {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D re = bullet.GetComponent<Rigidbody2D>();
        re.velocity = -1 * firePoint.up * bulletSpeed;
        nextFire = Time.time + cooldown;
      }

      if (Input.GetKey(KeyCode.LeftArrow) && Time.time > nextFire) {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D re = bullet.GetComponent<Rigidbody2D>();
        re.velocity = -1 * firePoint.right * bulletSpeed;
        nextFire = Time.time + cooldown;
      }
    }
}
