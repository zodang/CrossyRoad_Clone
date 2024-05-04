using TMPro;
using UnityEngine;

public class GameOverPanel : MonoBehaviour
{
    public TextMeshProUGUI BtnText; 
    private void Start()
    {
        gameObject.SetActive(false);
    
        // 종료 패널 활성화/비활성화 메서드 할당
        GameManager.OnEndGame += ActiveGameOverPanel;
        GameManager.restartGame += InActiveGameOverPanel;
    }

    public void ActiveGameOverPanel()
    {
        BtnText.text = "Restart";
        gameObject.SetActive(true);
    }

    public void InActiveGameOverPanel()
    {
        BtnText.text = "Stop";
        gameObject.SetActive(false);
    }
}
