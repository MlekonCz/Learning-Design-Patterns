using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
  [SerializeField] private Bullet bulletPrefab;

  private void Awake()
  {
      
  }

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space))
    {
        Instantiate(bulletPrefab);
    }
  }
}
