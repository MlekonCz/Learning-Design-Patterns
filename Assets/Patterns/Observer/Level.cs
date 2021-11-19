using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Level : MonoBehaviour
{
    [SerializeField] private int pointsPerLevel = 200;
    private int experiencePoints = 0;

    public event Action onLevelUpAction;
    public event Action onExperienceChange;


    private void Start()
    {
        onExperienceChange?.Invoke();
    }

    public void GainExperience(int points)
    {
        int level = GetLevel();
        experiencePoints += points;
        onExperienceChange?.Invoke();
        if (GetLevel() > level)
        {
            onLevelUpAction?.Invoke();
        }
    }

    public int GetExperience()
    {
        return experiencePoints;
    }

    public int GetLevel()
    {
        return experiencePoints / pointsPerLevel;
    }
}
