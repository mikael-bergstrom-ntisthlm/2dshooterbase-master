using UnityEngine;

public class EnemySpawnController : MonoBehaviour
{
  [SerializeField]
  GameObject enemyPrefab;

  [SerializeField]
  float timeBetweenSpawns = 1f;
  float timeSinceLastSpawn = 0;

  void Update()
  {
    timeSinceLastSpawn += Time.deltaTime;

    if (timeSinceLastSpawn > timeBetweenSpawns)
    {
      Instantiate(enemyPrefab);
      timeSinceLastSpawn = 0;
    }
  }
}
