using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public InputField playerNameInput;
    private string playerName;

    private void Start()
    {
        playerNameInput.onValueChanged.AddListener(OnInputFieldValueChanged);
    }

    public void StartNew()
    {
        MainManager.Instance.newPlayerName = playerName;

        MainManager.Instance.SaveUserData();
        SceneManager.LoadScene(1);
    }

    public void OnInputFieldValueChanged(string value)
    {
        playerName = value;
    }

    public void Exit()
    {
        MainManager.Instance.SaveUserData();

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
