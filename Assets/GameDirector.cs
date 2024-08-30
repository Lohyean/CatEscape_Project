using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // �� ������ ���� �ʿ��� ���ӽ����̽�

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;
    GameObject restartButton;

    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
        this.restartButton = GameObject.Find("restartButton");

        // ���� ���� �� Restart ��ư�� ��Ȱ��ȭ
        restartButton.SetActive(false);

        // Restart ��ư�� Ŭ�� �̺�Ʈ�� RestartGame �޼��� ����
        Button btn = restartButton.GetComponent<Button>();
        btn.onClick.AddListener(RestartGame);
    }

    public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;

        // ü���� 0�� �Ǿ����� Ȯ��
        if (this.hpGauge.GetComponent<Image>().fillAmount <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        // ������ ���߰� Restart ��ư�� Ȱ��ȭ
        Time.timeScale = 0;
        restartButton.SetActive(true);
    }

    public void RestartGame()
    {
        // ������ �ٽ� ���� (���� �ٽ� �ε��ϰ� ���� �ӵ��� ����ȭ)
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // ���� �� �ٽ� �ε�
    }
}
