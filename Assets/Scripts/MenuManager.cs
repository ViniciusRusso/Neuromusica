using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{

    public GameObject MenuWrapper;
    public GameObject TestWrapper;
    public GameObject GameWrapper;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }

    public void TestMenu(){
        if(MenuWrapper.activeSelf){
            MenuWrapper.SetActive(false);
            TestWrapper.SetActive(true);
        }else{
            MenuWrapper.SetActive(true);
            TestWrapper.SetActive(false);
        }
    }

    public void GameMenu(){
        if(MenuWrapper.activeSelf){
            MenuWrapper.SetActive(false);
            GameWrapper.SetActive(true);
        }else{
            MenuWrapper.SetActive(true);
            GameWrapper.SetActive(false);
        }
    }
}
