using UnityEngine;

public class Pipe : MonoBehaviour
{
    private GameManager _gameManager;

    private readonly float speed = -2f;

    private void Awake()
    {
        _gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void Update()
    {
        Moving();
    }

    private void Moving()
    {
        transform.Translate((speed - CalculateSpeedMultiplier()) * Time.deltaTime, 0, 0);

        if (gameObject.transform.position.x <= -12f)
        {
            gameObject.transform.position = new Vector3(PipeSpawner.CalculatePositionX(), PipeSpawner.CalculatePositionY(), 0);
            PipeSpawner.pipesOnMap.Remove(gameObject);
            PipeSpawner.pipesOnMap.Add(gameObject);
        }
    }

    private float CalculateSpeedMultiplier() => _gameManager.Score / 10f;
}
