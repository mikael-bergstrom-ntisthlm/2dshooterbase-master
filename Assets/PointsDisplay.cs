using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsDisplay : MonoBehaviour
{
  [SerializeField]
  TMP_Text pointsText;

  void Start()
  {
    pointsText.text = ShipController.points.ToString();
    // ShipController.points

  }
}
