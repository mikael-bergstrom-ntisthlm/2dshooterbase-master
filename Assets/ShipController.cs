using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
  [SerializeField]
  float speed = 0.02f;

  [SerializeField]
  GameObject boltPrefab;

  [SerializeField]
  Transform gunPosition;

  void Start()
  {

  }

  void Update()
  {
    float xInput = Input.GetAxisRaw("Horizontal");
    float yInput = Input.GetAxisRaw("Vertical");

    Vector2 movement = new Vector2(xInput, yInput) * speed * Time.deltaTime;
    // Vector2 movementY = new Vector2(0, 1) * speed * yInput;

    transform.Translate(movement);

    Instantiate(boltPrefab, gunPosition.position, Quaternion.identity);


  }
}
