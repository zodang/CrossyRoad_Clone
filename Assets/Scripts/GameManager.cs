using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public bool isGameOver;
    
    // 게임 종료 시의 delegate
    // Event delegate로 다른 클래스에서의 호출 방지
    public delegate void EndGame();
    public static event EndGame OnEndGame;

    // Action delegate: void형의 event delegate
    public static event Action restartGame;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public void OnClickBtn()
    {
        isGameOver = !isGameOver;
        
        
        if (isGameOver)
        {
            // null 체크 후 delegate 실행
            OnEndGame?.Invoke();
        }
        else
        {
            restartGame?.Invoke();
        }
    }
}
