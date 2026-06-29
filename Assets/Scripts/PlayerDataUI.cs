using UnityEngine;
using TMPro;

public class PlayerDataUI : MonoBehaviour
{
    public PlayerData playerData;      // reference to the Scriptable Object
    public TMP_Text displayText;       // reference to the UI text

    void Start()
    {
        if (playerData != null && displayText != null)
        {
            displayText.text =
                "SCRIPTABLE OBJECT DATA\n" +
                "Name: " + playerData.playerName + "\n" +
                "Level: " + playerData.playerLevel + "\n" +
                "Health: " + playerData.playerHealth;
        }
    }
}