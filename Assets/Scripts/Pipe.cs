using UnityEngine;

public class Pipe : MonoBehaviour
{
    private readonly float speed = -2f;

    private void Update()
    {
        Moving();
    }

    private void Moving()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);

        if (gameObject.transform.position.x <= -12f)
        {
            gameObject.transform.position = new Vector3(PipeSpawner.CalculatePositionX(), PipeSpawner.CalculatePositionY(), 0);
            PipeSpawner.pipesOnMap.Remove(gameObject);
            PipeSpawner.pipesOnMap.Add(gameObject);
        }
    }
}
