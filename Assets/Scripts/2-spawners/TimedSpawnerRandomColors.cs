using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawnerRandomColors: MonoBehaviour {
    [SerializeField] Mover prefabToSpawn;
    [SerializeField] Vector3 velocityOfSpawnedObject;
    [Tooltip("Minimum time between consecutive spawns, in seconds")] [SerializeField] float minTimeBetweenSpawns = 1f;
    [Tooltip("Maximum time between consecutive spawns, in seconds")] [SerializeField] float maxTimeBetweenSpawns = 3f;
    [Tooltip("Maximum distance in X between spawner and spawned objects, in meters")] [SerializeField] float maxXDistance = 0.5f;
    Color[] colors = new Color[3];
    void Start() {
        colors[0] = Color.blue;
        colors[1] = Color.red;
        colors[2] = Color.yellow;
        this.StartCoroutine(SpawnRoutine());
    }

    private IEnumerator SpawnRoutine() {
        while (true) {
            float timeBetweenSpawns = Random.Range(minTimeBetweenSpawns, maxTimeBetweenSpawns);
            yield return new WaitForSeconds(timeBetweenSpawns);
            Vector3 positionOfSpawnedObject = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            GameObject newObject = Instantiate(prefabToSpawn.gameObject, positionOfSpawnedObject, Quaternion.identity);

            var newRend = newObject.GetComponent<Renderer>();
            Color c = colors[Random.Range(0, colors.Length)];
            newRend.material.color = c;
            if (c == Color.blue)
            {
                newObject.name = "blue";
            }
            else if (c == Color.red)
            {
                newObject.name = "red";
            }
            else if (c == Color.yellow)
            {
                newObject.name = "yellow";
            }
            newObject.GetComponent<Mover>().SetVelocity(velocityOfSpawnedObject);
        }
    }
}