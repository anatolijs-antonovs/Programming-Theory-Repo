using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public GameObject nameInputField;
    public TMP_Text welcomeText;


    public void StartGame() {
        Debug.Log("Star game pressed");
        GameData.Instance.playerName = nameInputField.GetComponent<TMP_InputField>().text;
        Debug.Log("Player name: " + GameData.Instance.playerName);
        SceneManager.LoadScene(1);
    }

    private void Start() {
        welcomeText.text = $"Welcome, {GameData.Instance.playerName}!";
    }

}
