using UnityEngine;
using System.Collections.Generic;

public class QuestManager : MonoBehaviour
{
    public List<string> dailyQuests = new List<string>();
    public List<string> weeklyQuests = new List<string>();
    public List<string> seasonQuests = new List<string>();

    void Start()
    {
        Debug.Log("QuestManager started.");
        GenerateDailyQuests();
        GenerateWeeklyQuests();
        GenerateSeasonQuests();
    }

    void GenerateDailyQuests()
    {
        Debug.Log("Generating daily quests...");
        dailyQuests.Add("Complete 3 levels");
        dailyQuests.Add("Achieve 5 combos");
        // Add more daily quest generation logic
    }

    void GenerateWeeklyQuests()
    {
        Debug.Log("Generating weekly quests...");
        weeklyQuests.Add("Collect 50 stars");
        weeklyQuests.Add("Use 10 special powers");
        // Add more weekly quest generation logic
    }

    void GenerateSeasonQuests()
    {
        Debug.Log("Generating season quests...");
        seasonQuests.Add("Reach level 20");
        seasonQuests.Add("Win 5 PVP matches");
        // Add more season quest generation logic
    }

    public void CompleteQuest(string questName)
    {
        Debug.Log($"Quest '{questName}' completed!");
        // Implement reward logic and quest removal
    }
}
