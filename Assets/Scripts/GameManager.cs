using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class GameManager : MonoBehaviour
{
    public GameObject _playerSquare;
    public Color newColor;
    [HeaderAttribute(" Life variables")]
    public Image greenLifeBar;
    float currentLife = 10;
    float maxLife = 10;
    float minLife = 0;

    [HeaderAttribute(" Time variables")]
    public TextMeshProUGUI _textTimer;
    float timer = 0;

    [HeaderAttribute(" Buttons")]
    public Button [] _butonColors = new Button [5];



    public SpriteRenderer spriteRenderer;


   
    void LifeInGame()
    {
       greenLifeBar.fillAmount = currentLife / maxLife;
    }


    public void CurrentLife(float enemyLifeNumb)
    {
        currentLife = currentLife - enemyLifeNumb;
    }
    void Update()
    {
        LifeInGame();

        timer += Time.deltaTime;
        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);
        _textTimer.text = minutes + ":" + seconds;

        State();
    }

    public void State()
    {
        if (currentLife <= 0)
        {
            SceneManager.LoadScene("Lose");
            //print("has muerto");
        }

    }
    public void LoadHome()
    {
        SceneManager.LoadScene("Home");
    }

}
