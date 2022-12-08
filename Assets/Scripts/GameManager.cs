using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text playerText;

    // Start is called before the first frame update
    void Start()
    {
        playerText.text = PlayerPrefs.GetString("playerName");    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
