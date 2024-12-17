using UnityEngine;

public class EnemyController : MonoBehaviour
{
  [SerializeField]
  float speed = 7;

  [SerializeField]
  GameObject explosionPrefab;

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
    Instantiate(explosionPrefab, transform.position, Quaternion.identity);
    Destroy(this.gameObject);

    GameObject player = GameObject.FindGameObjectWithTag("Player");

    ShipController controller = player.GetComponent<ShipController>();

    controller.AddPoints(250);

    // GameObject.FindGameObjectWithTag("Player")
    //   .GetComponent<ShipController>()
    //   .AddPoints(250);

  }

}
