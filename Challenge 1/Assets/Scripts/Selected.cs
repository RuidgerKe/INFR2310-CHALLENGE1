using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Selected : MonoBehaviour
{
    [SerializeField] string sceneName;
    GameManager gameManager;
    public Animator anim;
    [SerializeField] GameObject menu;
    [SerializeField] GameObject settings;
    [SerializeField] GameObject gameOver;
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    public void FinalSelection()
    {
        if (gameManager.card1Selected)
        {
            gameManager.clickNum1++;
            anim.gameObject.SetActive(true);
            anim.SetTrigger("Fade");
            gameManager.card1Selected = false;
            gameManager.card1.SetBool("Click", false);
            StartCoroutine(Wait());
        }

        else if (gameManager.card2Selected)
        {
            gameManager.clickNum2++;
            gameManager.card2Selected = false;
            gameManager.card2.SetBool("Click", false);
            gameManager.card2.gameObject.GetComponent<Transform>().TransformPoint(0, 0, 0);
            settings.SetActive(true);
            menu.SetActive(false);
        }

        else if (gameManager.card3Selected)
        {
            gameManager.clickNum3++;
            gameManager.card3Selected = false;
            gameManager.card3.SetBool("Click", false);
            gameOver.SetActive(true);
            menu.SetActive(false);
        }

        else if (gameManager.card4Selected)
        {
            gameManager.clickNum4++;
            gameManager.card4Selected = false;
            gameManager.card4.SetBool("Click", false);
            gameManager.card4.gameObject.GetComponent<Transform>().TransformPoint(0, 0, 0);
            menu.SetActive(true);
            settings.SetActive(false);
        }
    }

    IEnumerator Wait()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            SceneManager.LoadScene(sceneName);
        }
    }
}