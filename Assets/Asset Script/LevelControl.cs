using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    public Button l2btn, l3btn, l4btn, l5btn, l6btn;
    int levelPassed;
    // Start is called before the first frame update
    void Start()
    {
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
        l2btn.interactable = false;
        l3btn.interactable = false;
        l4btn.interactable = false;
        l5btn.interactable = false;
        l6btn.interactable = false;

        switch (levelPassed)
        {
            case 1:
                l2btn.interactable = true;
                break;
            case 2:
                l2btn.interactable = true;
                l3btn.interactable = true;
                break;
            case 3:
                l2btn.interactable = true;
                l3btn.interactable = true;
                l4btn.interactable = true;
                break;
            case 4:
                l2btn.interactable = true;
                l3btn.interactable = true;
                l4btn.interactable = true;
                l5btn.interactable = true;
                break;
            case 5:
                l2btn.interactable = true;
                l3btn.interactable = true;
                l4btn.interactable = true;
                l5btn.interactable = true;
                l6btn.interactable = true;
                break;
        }
    }

     public void levelToLoad (int level)
    {
        SceneManager.LoadScene(level);
    }

    public void resetPlayerPrefers()
    {
        l2btn.interactable = false;
        l3btn.interactable = false;
        l4btn.interactable = false;
        l5btn.interactable = false;
        l6btn.interactable = false;
        PlayerPrefs.DeleteAll();
    }
   
}
