using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour
{
    public GameObject nameInputField;

    public void StartGame() {
        Debug.Log("Star game pressed");
        GameData.Instance.PlayerName = nameInputField.GetComponent<TMP_InputField>().text;
        Debug.Log("Player name: " + GameData.Instance.PlayerName);
        SceneManager.LoadScene(1);
    }
}
