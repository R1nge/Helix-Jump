using System.Collections.Generic;
using Platforms;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private List<Platform> platforms;
    [SerializeField] private int stagesAmount;

    private void Awake() => Generate();

    private void Generate()
    {
        foreach (var platform in platforms)
        {
            for (int i = 1; i < stagesAmount + 1; i++)
            {
                var instance = Instantiate(
                    platform, 
                    transform.position + new Vector3(0, -5 * i, 0),
                    platform.transform.rotation);
                instance.transform.Rotate(0, 0, Random.Range(0f, 360f));
            }
        }
    }
}