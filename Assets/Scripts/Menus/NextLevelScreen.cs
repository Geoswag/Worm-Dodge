using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextLevelScreen : MonoBehaviour
{
    public GameObject nextLevelScreenUI;
    public GameObject hudContainerUI;
    public Text levelText;
    private string levelString;

    private void Start()
    {
        levelString = SceneManager.GetActiveScene().buildIndex.ToString();
        levelText.text = "Level " + levelString;
    }
    public void RetryLevel()
    {
        Debug.Log("RETRY!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        nextLevelScreenUI.SetActive(false);
        hudContainerUI.SetActive(true);
        Time.timeScale = 1f;
    }

    public void NextLevel()
    {
        Debug.Log("NEXTLEVEL!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        nextLevelScreenUI.SetActive(false);
        hudContainerUI.SetActive(true);
        Time.timeScale = 1f;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        Debug.Log("MENU!");
        SceneManager.LoadScene(0);
    }
}