using System;
using UnityEngine;
using UnityEngine.UI;

namespace Patterns.UI
{
    public class HealthPresenter : MonoBehaviour
    {
        [SerializeField] private Health health;
        [SerializeField] private Image healthBar;

        private void OnEnable()
        {
            health.onHealthChange += UpdateUI;
        }

        private void Start()
        {
            UpdateUI();
        }

        private void UpdateUI()
        {
            healthBar.fillAmount = health.GetHealth() / health.GetMaxHealth();
        }
        private void OnDisable()
        {
            health.onHealthChange -= UpdateUI;
        }
    }
}