using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GreenBird greenBird = collision.collider.GetComponent<GreenBird>();
        if (greenBird != null)
        {
            Destroy(gameObject);
            return;
        }

        Enemy enemy = collision.collider.GetComponent<Enemy>();
        if (enemy != null)
        {
            return;
        }

        if (collision.contacts[0].normal.y <= -0.5)
        {
            Destroy(gameObject);
            return;
        }
    }
}
