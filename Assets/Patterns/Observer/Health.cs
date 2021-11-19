using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
 [SerializeField] private float fullHealth = 100f;
 [SerializeField] private float drainPerSecond = 2f;
 private float _currentHealth = 0f;

 public event Action onHealthChange;
 private void Awake()
 {
  ResetHealth();
  StartCoroutine(HealthDrain());
 }


 public float GetHealth()
 {
  return _currentHealth;
 }

 public float GetMaxHealth()
 {
  return fullHealth;
 }

 private void ResetHealth()
 {
  _currentHealth = fullHealth;
  onHealthChange?.Invoke();
 }

 private IEnumerator HealthDrain()
 {
  while (_currentHealth > 0)
  {
   _currentHealth -= drainPerSecond;
   onHealthChange?.Invoke();
   yield return new WaitForSeconds(1f);
  }
 }

 private void OnEnable()
 {
  GetComponent<Level>().onLevelUpAction += ResetHealth;
 }
 private void OnDisable()
 {
  GetComponent<Level>().onLevelUpAction -= ResetHealth;
 }
}
