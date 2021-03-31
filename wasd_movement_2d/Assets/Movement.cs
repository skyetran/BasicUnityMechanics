using UnityEngine;

public class Movement : MonoBehaviour
{
    public KeyCode jumpKey;

    public float speed = 10f;

    void Update()
    {
        Vector3 pos = transform.position;

        // "w" can be replaced with any key
        // this section moves the character up
        if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow) || Input.GetKey("i"))
        {
            pos.y += speed * Time.deltaTime;
        }

        // "s" can be replaced with any key
        // this section moves the character down
        if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow) || Input.GetKey("k"))
        {
            pos.y -= speed * Time.deltaTime;
        }

        // "d" can be replaced with any key
        // this section moves the character right
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow) || Input.GetKey("l"))
        {
            pos.x += speed * Time.deltaTime;
        }

        // "a" can be replaced with any key
        // this section moves the character left
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("j"))
        {
            pos.x -= speed * Time.deltaTime;
        }

        transform.position = pos;
    }
}
