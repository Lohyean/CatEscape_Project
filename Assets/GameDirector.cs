using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // 씬 관리를 위해 필요한 네임스페이스

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;
    GameObject restartButton;

    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
        this.restartButton = GameObject.Find("restartButton");

        // 게임 시작 시 Restart 버튼을 비활성화
        restartButton.SetActive(false);

        // Restart 버튼의 클릭 이벤트에 RestartGame 메서드 연결
        Button btn = restartButton.GetComponent<Button>();
        btn.onClick.AddListener(RestartGame);
    }

    public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;

        // 체력이 0이 되었는지 확인
        if (this.hpGauge.GetComponent<Image>().fillAmount <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        // 게임을 멈추고 Restart 버튼을 활성화
        Time.timeScale = 0;
        restartButton.SetActive(true);
    }

    public void RestartGame()
    {
        // 게임을 다시 시작 (씬을 다시 로드하고 게임 속도를 정상화)
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // 현재 씬 다시 로드
    }
}
