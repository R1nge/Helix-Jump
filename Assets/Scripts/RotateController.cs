using System.Collections.Generic;
using Platforms;
using UnityEngine;

public class RotateController : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float speed;
    [SerializeField] private List<Platform> platforms;
    private Camera _camera;

    private void Awake()
    {
        _camera = FindObjectOfType<Camera>();
    }

    private void Start()
    {
        for (int i = 0; i < FindObjectsOfType<Platform>().Length; i++)
        {
            platforms.Add(FindObjectsOfType<Platform>()[i]);
        }
    }

    private void Update()
    {
        if (!Input.GetMouseButton(0)) return;

        var screenPosMouse = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        var worldPosMouse = _camera.ScreenToWorldPoint(screenPosMouse);

        foreach (var platform in platforms)
        {
            platform.transform.RotateAround(
                target.transform.position,
                -target.transform.up,
                worldPosMouse.x
                * speed * Time.deltaTime);
        }
    }
}