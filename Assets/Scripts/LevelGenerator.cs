using System.Collections.Generic;
using Platforms;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private List<Platform> platforms;
    [SerializeField] private int stagesAmount;

    private void Awake()
    {
        Generate();
    }

    private void Generate()
    {
        foreach (var platform in platforms)
        {
            for (int i = 1; i < stagesAmount + 1; i++)
            {
                Instantiate(platform, transform.position + new Vector3(0, -5 * i, -2), platform.transform.rotation);
            }
        }
    }
}