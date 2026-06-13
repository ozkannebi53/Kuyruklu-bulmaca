using UnityEngine;

public class EconomyManager : MonoBehaviour
{
    public int scorpionTokens = 0; // Akrep Jetonu
    public int premiumCrystals = 0; // Premium Kristal

    // Akrep Jetonu
    public void AddScorpionTokens(int amount)
    {
        scorpionTokens += amount;
        Debug.Log($"{amount} Scorpion Tokens added. Total: {scorpionTokens}");
    }

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

    // Premium Kristal
    public void AddPremiumCrystals(int amount)
    {
        premiumCrystals += amount;
        Debug.Log($"{amount} Premium Crystals added. Total: {premiumCrystals}");
    }

    public bool SpendPremiumCrystals(int amount)
    {
        if (premiumCrystals >= amount)
        {
            premiumCrystals -= amount;
            Debug.Log($"{amount} Premium Crystals spent. Remaining: {premiumCrystals}");
            return true;
        }
        Debug.Log("Not enough Premium Crystals.");
        return false;
    }

    // Ekonomi Dengesi (Placeholder for complex balancing logic)
    public void BalanceEconomy()
    {
        Debug.Log("Balancing game economy (gain/spend rates, inflation control)...");
        // Implement complex economy balancing algorithms here
    }

    void Start()
    {
        Debug.Log("EconomyManager started.");
    }
}
