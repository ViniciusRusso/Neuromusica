using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GeniusManager : MonoBehaviour
{
    private string s = "";
    public string resposta = "";
    public TMPro.TextMeshProUGUI textDisplay;
    public TMPro.TextMeshProUGUI roundDisplay;

    private int points;

    public audioManager audiomanager;
    public AudioSource somGrosso;
    public Button soundButton;

    // Start is called before the first frame update
    void Start()
    {
        roundDisplay.text = points.ToString();
        RandomString();
        Debug.Log(s);
        PlaySound();
    }

    // Update is called once per frame
    void Update()
    {
        textDisplay.text = resposta;
        roundDisplay.text = points.ToString();
    }

    public void RandomString()
    {
        char[] chars = new char[2] { 'O', 'I' };
        s += chars[Random.Range(0, 2)];
        Debug.Log(s);
    }

    public void OButton()
    {
        resposta += 'O';
    }

    public void IButton()
    {
        resposta += 'I';
    }

    public void Confirma()
    {

        if (resposta.Equals(s))
        {
            Debug.Log("Acertou");
            points += 1;
            resposta = "";
        }
        else
        {
            Debug.Log("Errou");
            SceneManager.LoadScene("Genius");
        }

        RandomString();
        PlaySound();
    }

    public void Cancela()
    {
        resposta = "";
    }

    public void PlaySound()
    {
        StartCoroutine(PlaySoundCoroutine());
    }

    IEnumerator PlaySoundCoroutine()
    {

        soundButton.interactable = false;

        for (int i = 0; i < s.Length; i++)
        {
            bool thicc;

            if (s[i] == 'I')
            {
                thicc = false;
            }
            else
            {
                thicc = true;
            }

            audiomanager.playSound(thicc);
            yield return new WaitForSeconds(0.682f);
        }

        soundButton.interactable = true;

    }
}

