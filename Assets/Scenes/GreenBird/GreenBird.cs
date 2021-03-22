using UnityEngine;
using UnityEngine.SceneManagement;

public class GreenBird : MonoBehaviour
{
    private Vector3 _initial_position;
    private bool _get_hit;
    private float _time_get_hit;

    [SerializeField] private float _launch_force = 250;

    private void Awake()
    {
        _initial_position = transform.position;
    }

    private void Update()
    {
        if (_get_hit)
        {
            _time_get_hit += Time.deltaTime;
            if (_time_get_hit > 5) SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _get_hit = true;
    }


    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
    }

    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().color = Color.white;

        Vector2 _launch_direction = _initial_position - transform.position; 
        GetComponent<Rigidbody2D>().AddForce(_launch_direction * _launch_force);
        GetComponent<Rigidbody2D>().gravityScale = 1;
    }

    private void OnMouseDrag()
    {
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(newPosition.x, newPosition.y);
    }
}
