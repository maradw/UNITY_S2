using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Management : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void LoadHome()
    {
        SceneManager.LoadScene("Home");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
