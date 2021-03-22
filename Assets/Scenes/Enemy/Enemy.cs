using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GreenBird greenBird = collision.collider.GetComponent<GreenBird>();
        if (greenBird != null)
        {
            Destroy(gameObject);
        }
    }
}
