using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject pipe;
    public float spawnInterval = 2f;
    public float pipeMinHeight = -2f;
    public float pipeMaxHeight = 2f;
    public float pipeSpawnPositionX = 10f;

    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnPipe();
            timer = 0f;
        }
    }

    private void SpawnPipe()
    {
        float randomHeight = Random.Range(pipeMinHeight, pipeMaxHeight);
        Vector3 spawnPosition = new Vector3(pipeSpawnPositionX, randomHeight, 0f);

        Instantiate(pipe, spawnPosition, Quaternion.identity);
    }
}
