using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject prefab;

    public float spawnRate = 1f;
    public float maxheight = 2f;
    public float minheight = -1f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawning), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawning));
    }

    private void Spawning()
    {
        GameObject pipes = Instantiate(prefab, transform.position, Quaternion.identity);

        pipes.transform.position += Vector3.up * Random.Range(minheight, maxheight);

    }
}