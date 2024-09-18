using UnityEngine;

public class EnemySpawnController : MonoBehaviour
{
  [SerializeField]
  GameObject enemyPrefab;

  void Update()
  {
    Instantiate(enemyPrefab);
  }
}
