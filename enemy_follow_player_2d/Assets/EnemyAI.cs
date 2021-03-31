using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public GameObject player;
    private float speed = 7f;
    private float elapsed = 0f;
    private float nextReset = 5f;

    private void Update()
    {
        if (Vector2.Distance(transform.position, player.transform.position) > 0.7f)
        {
            float step = speed * Time.deltaTime * Random.Range(1f, 2f);
            elapsed += Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position * Random.Range(1f, 2f), step);

            if (elapsed > nextReset)
            {
                float random = Random.Range(0f, 260f);
                Vector2 newEnemyPosition = new Vector2(Mathf.Cos(random), Mathf.Sin(random)) * Random.Range(-5f, 5f);
                transform.position = newEnemyPosition;
                nextReset += 5f;
            }
        }
    }
}
