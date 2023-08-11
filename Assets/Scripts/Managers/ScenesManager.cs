using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public static ScenesManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void LoadScene(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }

    public void LoadNewGame()
    {
        SceneManager.LoadScene(Scene.Level1.ToString());
    }

    public void LoadNextScene()
    {
        var activeScene = SceneManager.GetActiveScene();
        if (activeScene.buildIndex < Enum.GetNames(typeof(Scene)).Length - 1)
            SceneManager.LoadScene(activeScene.buildIndex + 1);
        else
            Debug.LogError($"CUSTOM ERROR: Attempt to load a scene that does not exist after: {activeScene.name}, enum index: {activeScene.buildIndex}. from ScenesManager.cs   LoadNextScene()");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(Scene.MainMenu.ToString());
    }

    // Whenever new scenes are added to the game, the new scene needs to be added to the enum in the same order as Unity's build settings.
    // To get to the build settings in Unity, go to File > Build Settings (Ctrl+Shift+B)
    public enum Scene
    {
        MainMenu,
        Level1,
        Level2
    }
}
