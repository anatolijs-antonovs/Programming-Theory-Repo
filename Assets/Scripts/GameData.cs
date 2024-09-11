using UnityEngine;

public class GameData : MonoBehaviour {

    public static GameData Instance;

    public string playerName;

    private void Awake() {

        if (Instance != null) {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
