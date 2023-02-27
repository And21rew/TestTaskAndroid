using UnityEngine;

public class Bird : MonoBehaviour
{
    private readonly float force = 4f;

    private Rigidbody2D _rigidbody;
    private GameManager _gameManager;

    private void Awake()
    {
        _gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Moving();
    }

    private void Moving() => _rigidbody.velocity = Vector2.up * force;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            gameObject.SetActive(false);
            _gameManager.StopTimeInGame();
            _gameManager.GameEnd();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Score"))
        {
            _gameManager.UpdateScore();
        }
    }
}
