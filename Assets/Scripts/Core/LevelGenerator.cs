using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class LevelGenerator : MonoBehaviour
    {
        [SerializeField] private List<GameObject> platforms;
        [SerializeField] private int platformsAmount;
        private bool _wasPreviousKill;

        private void Start() => Generate();

        private void Generate()
        {
            for (int i = 1; i < platformsAmount + 1; i++)
            {
                var platformIndex = SelectRandomPlatform(i);
                var instance = Instantiate(
                    platforms[platformIndex],
                    transform.position + new Vector3(0, -5 * i, 0),
                    platforms[platformIndex].transform.rotation);
                instance.transform.Rotate(0, 0, Random.Range(0f, 360f));
            }
        }

        private int SelectRandomPlatform(int platformPlace)
        {
            if (platformPlace == 1)
            {
                return 0;
            }
            
            var platform = Random.Range(0, platforms.Count);

            if (_wasPreviousKill)
            {
                _wasPreviousKill = false;
                return 0;
            }
            
            if (platform == 1)
            {
                _wasPreviousKill = true;
            }

            return platform;
        }
    }
}