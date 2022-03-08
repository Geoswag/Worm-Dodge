using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextLevelonTouch : MonoBehaviour
{
    public GameObject nextLevelScreenUI;
    public GameObject hudContainerUI;
    public Text endTime;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
            nextLevelScreenUI.SetActive(true);
            TimerController.instance.GetEndTime();
            string endTimeText = endTime.text;
            hudContainerUI.SetActive(false);
            Time.timeScale = 0f;
    }
}
