using UnityEngine;

public class GameData : MonoBehaviour {

    public static GameData Instance;

    private string playerName = "Guest";

    // ENCAPSULATION
    public string PlayerName {
        get {
            return playerName;
        }
        set {
            if (!string.IsNullOrEmpty(value)) {
                playerName = value;
            }
        }
    }

    private void Awake() {

        if (Instance != null) {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
