using UnityEngine;

public class Bird : MonoBehaviour
{
    private readonly float force = 5f;

    private Rigidbody2D _rigidbody;
    private GameManager _gameManager;
    private AudioManager _audioManager;

    private void Awake()
    {
        _gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        _audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _audioManager.PlayWingClip();
            Moving();
        }
    }

    private void Moving() => _rigidbody.velocity = Vector2.up * force;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            _audioManager.PlayHitClip();
            gameObject.SetActive(false);
            _gameManager.StopTimeInGame();
            _gameManager.GameEnd();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Score"))
        {
            _audioManager.PlayScoreClip();
            _gameManager.UpdateScore();
        }
    }
}
