using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabManager : MonoBehaviour
{
    public Button roomsButton, amenitiesButton, settingsButton;
    public GameObject roomsTab, amenitiesTab, settingsTab;

    private void Awake() {
        roomsTab.SetActive(true);
        amenitiesTab.SetActive(false);
        settingsTab.SetActive(false);
    }

    public void roomsPressed() {
        roomsTab.SetActive(true);
        amenitiesTab.SetActive(false);
        settingsTab.SetActive(false);
    }

    public void amenitiesPressed() {
        roomsTab.SetActive(false);
        amenitiesTab.SetActive(true);
        settingsTab.SetActive(false);
    }

    public void settingsPressed() {
        roomsTab.SetActive(false);
        amenitiesTab.SetActive(false);
        settingsTab.SetActive(true);
    }
}
