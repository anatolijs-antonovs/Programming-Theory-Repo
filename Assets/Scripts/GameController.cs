using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public TMP_Text welcomeText;

    private void Start() {
        welcomeText.text = $"Welcome, {GameData.Instance.PlayerName}!";
    }

}
