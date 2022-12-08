using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public InputField inputField;
    string playerName;
     
    void Start()
    {
        
    }

     
    void Update()
    {
        
    }

    public void StartGame()
    {
        playerName = inputField.text.ToString();
        PlayerPrefs.SetString("playerName", playerName);
        Debug.Log(playerName);

        SceneManager.LoadScene("Main");
    }
}
