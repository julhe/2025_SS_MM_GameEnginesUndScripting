using UnityEngine;
using UnityEngine.Playables;

public class Cutscene : MonoBehaviour
{
    public PlayableDirector director;

    private void Start()
    {
        director.stopped += OnPlayableDirectorStopped;
    }
    public void StartCutScene()
    {
        GameStateManager.Instance.gameState = GameState.InCutScene;

        director.Play();
    }


    void OnPlayableDirectorStopped(PlayableDirector aDirector)
    {
        GameStateManager.Instance.gameState = GameState.InExploreMode;
    }

    private void OnDestroy()
    {
        director.stopped -= OnPlayableDirectorStopped;
    }

}
