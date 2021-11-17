using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   [SerializeField] private Vector3 speed;

   private void Update()
   {
      transform.position += speed * Time.deltaTime;
   }

   private void OnBecameInvisible()
   {
      Destroy(gameObject);
   }
}
