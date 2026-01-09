using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class MainMenuController : MonoBehaviour
{
    public VisualElement ui;

    public Button playButton;
    public Button settingsButton;
    public Button quitButton;

    private void Awake()
    {
        ui = GetComponent<UIDocument>().rootVisualElement;
    }

    private void OnEnable()
    {
        playButton = ui.Q<Button>("play-button");
        playButton.clicked += OnPlayButtonClicked;

        settingsButton = ui.Q<Button>("settings-button");
        settingsButton.clicked += OnSettingsButtonClicked;

        quitButton = ui.Q<Button>("quit-button");
        quitButton.clicked += OnQuitButtonClicked;
    }

    private void OnQuitButtonClicked()
    {
        Application.Quit();
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif
    }

    private void OnSettingsButtonClicked()
    {
        Debug.Log("Settings!");
    }

    private void OnPlayButtonClicked()
    {
        gameObject.SetActive(false);
    }
}
