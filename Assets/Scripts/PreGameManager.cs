using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PreGameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Pontos", 0);
        PlayerPrefs.SetInt("Round", 1);
        SceneManager.LoadScene("MSTT");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
