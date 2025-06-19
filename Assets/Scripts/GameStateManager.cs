using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public static GameStateManager Instance;

    public GameState gameState;

    private void Start()
    {
        Instance = this;
    }
}

// TODO: sollte eigendlich in eine seperate Datei...
public enum GameState
{
    InExploreMode,
    InCutScene,
};