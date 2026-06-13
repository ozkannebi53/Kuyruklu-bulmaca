using UnityEngine;

public class EconomyManager : MonoBehaviour
{
    public int scorpionTokens = 0; // Akrep Jetonu (Oyun içi para)

    // Akrep Jetonu Ekleme
    public void AddScorpionTokens(int amount)
    {
        scorpionTokens += amount;
        Debug.Log($"{amount} Scorpion Tokens added. Total: {scorpionTokens}");
    }

    // Akrep Jetonu Harcama
    public bool SpendScorpionTokens(int amount)
    {
        if (scorpionTokens >= amount)
        {
            scorpionTokens -= amount;
            Debug.Log($"{amount} Scorpion Tokens spent. Remaining: {scorpionTokens}");
            return true;
        }
        Debug.Log("Not enough Scorpion Tokens.");
        return false;
    }

    // Gerçek para ile ilgili tüm metodlar (Premium Kristal vb.) geçici olarak kaldırıldı.

    void Start()
    {
        Debug.Log("EconomyManager started (Internal Currency Only).");
    }
}
