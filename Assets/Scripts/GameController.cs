using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public TMP_Text welcomeText;
    public TMP_Text statsText;
    private Stats stats;

    void Start() {
        welcomeText.text = $"Welcome, {GameData.Instance.PlayerName}!";
        stats = new Stats();        
    }

    void Update() {
        statsText.text = $"Your stats are:<br>     Health: {stats.health.GetValue()}<br>     Stamina: {stats.stamina.GetValue()}";
    }

    public void LevelUp() {
        Debug.Log("LevelUp pressed");
        stats.health.Upgrade();
    }
}
