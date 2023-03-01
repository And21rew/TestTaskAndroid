using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] pipePrefab;

    private static readonly float maxPositionY = 3f;
    private static readonly float distanceBetweenPipes = 6f;
    public static List<GameObject> pipesOnMap;

    private readonly int maxPipesCount = 10;

    private void Awake()
    {
        GeneratePipesOnMap();
    }

    private void GeneratePipesOnMap()
    {
        pipesOnMap = new List<GameObject>();

        for (int i = 0; i < maxPipesCount; i++)
        {
            var positionX = distanceBetweenPipes * i + distanceBetweenPipes;
            var positionY = CalculatePositionY();
            pipesOnMap.Add(Instantiate(pipePrefab[PlayerPrefs.GetInt("PipeSkin")], new Vector3(positionX, positionY, 0), Quaternion.identity));
        }
    }

    public static float CalculatePositionX() => pipesOnMap[^1].transform.position.x + distanceBetweenPipes;

    public static float CalculatePositionY() => Random.Range(-maxPositionY, maxPositionY);
}
