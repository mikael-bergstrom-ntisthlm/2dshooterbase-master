using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltController : MonoBehaviour
{
  [SerializeField]
  float speed = 5;

  void Update()
  {
    Vector2 movement = Vector2.up;

    transform.Translate(movement * speed * Time.deltaTime);

    if (transform.position.y > Camera.main.orthographicSize + 1)
    {
      Destroy(this.gameObject);
    }
  }

  private void OnTriggerEnter2D(Collider2D other)
  {
    if (other.gameObject.tag == "Enemy")
    {
      Destroy(this.gameObject);
    }
  }
}
