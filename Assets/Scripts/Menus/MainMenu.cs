using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static bool boolArrowsMove = true;
    public static bool boolSpaceJump = true;
    public static bool boolFullscreen = true;
    public GameObject arrowsTick;
    public GameObject WASDTick;
    public GameObject spaceTick;
    public GameObject shiftTick;
    public GameObject fullscreenTick;
    public GameObject windowedTick;
    public GameObject controlsMenuUI;

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ControlsMenu()
    {
        controlsMenuUI.SetActive(true);
        if (boolArrowsMove)
        {
            arrowsTick.SetActive(true);
            WASDTick.SetActive(false);
        }
        else
        {
            arrowsTick.SetActive(false);
            WASDTick.SetActive(true);
        }
        if (boolSpaceJump)
        {
            spaceTick.SetActive(true);
            shiftTick.SetActive(false);
        }
        else
        {
            spaceTick.SetActive(false);
            shiftTick.SetActive(true);
        }
        controlsMenuUI.SetActive(true);
        if (boolFullscreen)
        {
            fullscreenTick.SetActive(true);
            windowedTick.SetActive(false);
        }
        else
        {
            fullscreenTick.SetActive(false);
            windowedTick.SetActive(true);
        }
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadLevel3()
    {
        SceneManager.LoadScene(3);
    }
    public void LoadLevel4()
    {
        SceneManager.LoadScene(4);
    }

    public void FullScreen()
    {
        Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
        boolFullscreen = true;
    }

    public void Windowed()
    {
        Screen.fullScreenMode = FullScreenMode.Windowed;
        boolFullscreen = false;
    }

    public void ArrowsOn()
    {
        boolArrowsMove = true;
    }

    public void ArrowsOff()
    {
        boolArrowsMove = false;
    }

    public void SpaceOn()
    {
        boolSpaceJump = true;
    }

    public void SpaceOff()
    {
        boolSpaceJump = false;
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
