using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private float spawnRate = 1.5f;
    [SerializeField] private float minYOffset = -2f;
    [SerializeField] private float maxYOffset = 2f;

    private float timer;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnRate)
        {
            SpawnPipe();
            timer = 0f;
        }
    }

    void SpawnPipe()
    {
        if (pipePrefab == null) return;

        float yOffset = Random.Range(minYOffset, maxYOffset);
        Vector3 spawnPosition = new Vector3(
            transform.position.x,
            transform.position.y + yOffset,
            transform.position.z);

        // Instantiate the double-pipe prefab.
        Instantiate(pipePrefab, spawnPosition, Quaternion.identity);
    }
}