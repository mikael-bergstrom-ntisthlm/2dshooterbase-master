using UnityEngine;

public class EnemyController : MonoBehaviour
{
  [SerializeField]
  float speed = 7;

  void Start()
  {
    Vector2 position = new();
    position.y = Camera.main.orthographicSize + 1;

    position.x = Random.Range(-5f, 5f);

    transform.position = position;
  }

  void Update()
  {
    Vector2 movement = Vector2.down;

    transform.Translate(movement * speed * Time.deltaTime);

    if (transform.position.y < -Camera.main.orthographicSize - 1)
    {
      Destroy(this.gameObject);
    }
  }

  private void OnTriggerEnter2D(Collider2D other)
  {
    Destroy(this.gameObject);
  }

}
