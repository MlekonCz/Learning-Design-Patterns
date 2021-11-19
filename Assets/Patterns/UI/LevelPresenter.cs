using System;
using UnityEngine;
using UnityEngine.UI;

namespace Patterns.UI
{
    public class LevelPresenter : MonoBehaviour
    {
        [SerializeField] private Level level;
        [SerializeField] private Text displayText;
        [SerializeField] private Text experienceText;
        [SerializeField] private Button increaseXPButton;

        private void OnEnable()
        {
            level.onExperienceChange += UpdateUI;
        }

        private void Start()
        {
            increaseXPButton.onClick.AddListener(GainExperience);
            UpdateUI();
        }

        private void GainExperience()
        {
            level.GainExperience(10);
        }

        private void UpdateUI()
        {
            displayText.text = $"Level: {level.GetLevel()}";
            experienceText.text = $"XP: {level.GetExperience()}";
        }

        private void OnDisable()
        {
            level.onExperienceChange -= UpdateUI;
        }
    }
}