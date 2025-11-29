using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public GameObject lifePrefab;
    public Transform livesContainer;

    // To be set in the Inspector, but 3 is suggested
    public int initialLifeCount = 3;

    public GameObject HUD, GameOverMenu;

    // This is going to vary during the game
    // between 0 and initialLifeCount
    int lifeCount = 0;

    void Start()
    {
        // When level starts, player has max life points
        lifeCount = initialLifeCount;

        // If No Life Prefab Return Early
        if(lifePrefab == null)
        {
            return;
        }

        // Instantiate life prefabs in UI
        for (int i = 0; i < initialLifeCount; i++)
        {
            Instantiate(lifePrefab, livesContainer);
        }
    }

    public void LoseLifePoints(int amount)
    {
        lifeCount -= amount;
        // Do not go below zero
        lifeCount = Mathf.Clamp(lifeCount, 0, initialLifeCount);
        // Update UI
        for (int i = lifeCount; i < initialLifeCount; i++)
        {
            livesContainer.GetChild(i).gameObject.SetActive(false);
        }
        // If player has no more life points
        if (lifeCount == 0)
        {
            HUD.SetActive(false);
            GameOverMenu.SetActive(true);
        }
    }
}
