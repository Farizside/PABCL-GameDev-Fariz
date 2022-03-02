using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOver;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text scoreText2;
    [SerializeField] private AudioSource bgm;

    private float _time = 0f;
    public static GameManager _instance;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        _instance = this;
    }
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;
        scoreText.text = "" + Mathf.Round(_time).ToString();
        scoreText2.text = "Score : " + Mathf.Round(_time).ToString();
    }

    public void ShowGameOver()
    {
        Time.timeScale = 0f;
        gameOver.SetActive(true);
        bgm.Stop();
    }
     
    public void BtnRetry_OnClick()
    {
        Time.timeScale = 1f;
        gameOver.SetActive(false);
        SceneManager.LoadScene(0);
    }
}
