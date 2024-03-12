using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ScoreManager scoreManager; // ScoreManager 참조
    public static GameManager instance;

    // 게임 재시작 시 호출되는 함수
    public void RestartGame()
    {
        // 게임이 재시작될 때 ScoreManager를 파괴하지 않도록 함
        DontDestroyOnLoad(scoreManager.gameObject);
        // 다른 초기화 작업 수행 가능
    }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}