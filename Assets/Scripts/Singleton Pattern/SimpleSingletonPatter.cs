using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSingletonPatter : MonoBehaviour
{
   private static SimpleSingletonPatter instance = null;

   private void Awake()
   {
      if (instance == null)
      {
         DontDestroyOnLoad(this);
         instance = this;
      }
      else if (instance != this)
      {
         Destroy(gameObject);
      }
   }

   public void SomeCodeLogic()
   {
      // Do something
   }
}
