using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class LevelGenerator : MonoBehaviour
    {
        [SerializeField] private List<GameObject> platforms;
        [SerializeField] private int platformsAmount;

        private void Start() => Generate();

        private void Generate()
        {
            foreach (var platform in platforms)
            {
                for (int i = 1; i < platformsAmount + 1; i++)
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
}