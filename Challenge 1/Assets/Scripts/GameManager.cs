using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public Animator card1;
    public int clickNum1 = 1;

    [SerializeField] public Animator card2;
    public int clickNum2 = 1;

    [SerializeField] public Animator card3;
    public int clickNum3 = 1;

    [SerializeField] public Animator card4;
    public int clickNum4 = 1;

    public bool card1Selected;
    public bool card2Selected;
    public bool card3Selected;
    public bool card4Selected;

    public void Clicked1()
    {
        clickNum1++;

        if (clickNum1 % 2 == 0)
        {
            card1.SetBool("Click", true);
            card1Selected = true;
            clickNum3 = 1;
            clickNum2 = 1;
            card2Selected = false;
            card3Selected = false;
            card2.SetBool("Click", false);
            card3.SetBool("Click", false);
        }
        else
        {
            card1.SetBool("Click", false);
            card1Selected = false;
        }
    }

    public void Clicked2()
    {
        clickNum2++;

        if (clickNum2 % 2 == 0)
        {
            card2.SetBool("Click", true);
            card2Selected = true;
            clickNum1 = 1;
            clickNum3 = 1;
            card1Selected = false;
            card3Selected = false;
            card1.SetBool("Click", false);
            card3.SetBool("Click", false);
        }
        else
        {
            card2.SetBool("Click", false);
            card2Selected = false;
        }
    }

    public void Clicked3()
    {
        clickNum3++;

        if (clickNum3 % 2 == 0)
        {
            card3.SetBool("Click", true);
            card3Selected = true;
            clickNum1 = 1;
            clickNum2 = 1;
            card2Selected = false;
            card1Selected = false;
            card1.SetBool("Click", false);
            card2.SetBool("Click", false);
        }
        else
        {
            card3.SetBool("Click", false);
            card3Selected = false;
        }
    }

    public void Clicked4()
    {
        clickNum4++;

        if (clickNum4 % 2 == 0)
        {
            card4.SetBool("Click", true);
            card4Selected = true;
        }
        else
        {
            card4.SetBool("Click", false);
            card4Selected = false;
        }
    }
}