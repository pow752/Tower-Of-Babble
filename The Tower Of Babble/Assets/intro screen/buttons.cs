using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons : MonoBehaviour
{
    public GameObject MainMenyou;
    public GameObject CreditsMenyou;
    public GameObject ContrsMenyou;
    public int nextlv = 0;

    public void StartGameBnt()
    {
        Application.LoadLevel(nextlv);
    }
    public void Restart()
    {
        Application.LoadLevel(1);
    }
    public void Mainmenyou()
    {
        Application.LoadLevel(0);
    }

    public void CreditsBnt()
    {
        MainMenyou.SetActive(false);
        CreditsMenyou.SetActive(true);
    }

    public void ControlesBnt()
    {
        ContrsMenyou.SetActive(true);
        MainMenyou.SetActive(false);
    }

    public void BackBnt()
    {
        CreditsMenyou.SetActive(false);
        ContrsMenyou.SetActive(false);
        MainMenyou.SetActive(true);
    }


}
