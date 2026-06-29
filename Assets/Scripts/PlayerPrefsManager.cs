using UnityEngine;
using TMPro;

public class PlayerPrefsManager : MonoBehaviour
{
    public TMP_Text prefsDisplayText;  

    private int saveCount = 0;

    void Start()
    {
        LoadData();  
    }

   
    public void SaveData()
    {
        saveCount++;

        // store three different data types
        PlayerPrefs.SetInt("Points", 100 * saveCount);
        PlayerPrefs.SetFloat("Volume", 0.5f * saveCount);
        PlayerPrefs.SetString("Username", "Joshua_" + saveCount);

        PlayerPrefs.Save();

        LoadData();  
    }

    
    public void LoadData()
    {
        int points = PlayerPrefs.GetInt("Points", 0);
        float volume = PlayerPrefs.GetFloat("Volume", 0f);
        string username = PlayerPrefs.GetString("Username", "None");

        if (prefsDisplayText != null)
        {
            prefsDisplayText.text =
                "PLAYERPREFS DATA\n" +
                "Points: " + points + "\n" +
                "Volume: " + volume + "\n" +
                "Username: " + username;
        }
    }
}