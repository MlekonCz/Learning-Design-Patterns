using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugger : MonoBehaviour
{
   private IEnumerator Start()
   {
      Health _health = GetComponent<Health>();
      Level level = GetComponent<Level>();
      while (true)
      {
         yield return new WaitForSeconds(1f);
         Debug.Log($"Exp: {level.GetExperience()}, level: {level.GetLevel()}, Health: {_health.GetHealth()}");

      }
   }
}
