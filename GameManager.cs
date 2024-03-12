using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ScoreManager scoreManager; // ScoreManager ����
    public static GameManager instance;

    // ���� ����� �� ȣ��Ǵ� �Լ�
    public void RestartGame()
    {
        // ������ ����۵� �� ScoreManager�� �ı����� �ʵ��� ��
        DontDestroyOnLoad(scoreManager.gameObject);
        // �ٸ� �ʱ�ȭ �۾� ���� ����
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