using UnityEngine;
using UnityEngine.UI;

public class UIGameMenu : MonoBehaviour
{
    [SerializeField] Button _mainMenu;
    [SerializeField] Button _nextScene;

    // Start is called before the first frame update
    void Start()
    {
        _mainMenu.onClick.AddListener(LoadMainMenu);
        _nextScene.onClick.AddListener(LoadNextScene);
    }

    private void LoadMainMenu()
    {
        ScenesManager.Instance.LoadMainMenu();
    }

    private void LoadNextScene()
    {
        ScenesManager.Instance.LoadNextScene();
    }
}
