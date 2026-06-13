using UnityEngine;
using System.Collections.Generic;

public class LevelManager : MonoBehaviour
{
    public int currentLevel = 1;
    public int totalLevels = 100; // 100+ bölüm başlangıç
    public int starsCollected = 0;

    // Bölüm kilit açma
    public bool IsLevelUnlocked(int levelNumber)
    {
        Debug.Log($"Checking if level {levelNumber} is unlocked.");
        // Implement level unlock logic (e.g., based on stars collected or previous level completion)
        return levelNumber <= currentLevel; // Simple example: all previous levels are unlocked
    }

    // Yıldız sistemi
    public void AwardStars(int levelNumber, int stars)
    {
        Debug.Log($"Awarding {stars} stars for level {levelNumber}.");
        starsCollected += stars;
        // Save stars to player profile
    }

    // Zorluk algoritması
    public float GetLevelDifficulty(int levelNumber)
    {
        Debug.Log($"Calculating difficulty for level {levelNumber}.");
        // Implement difficulty scaling based on level number
        return 1.0f + (levelNumber * 0.1f); // Simple linear scaling
    }

    void Start()
    {
        Debug.Log("LevelManager started.");
    }
}
