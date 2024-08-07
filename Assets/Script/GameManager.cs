using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int PlayerScoreL = 0;
    public int PlayerScoreR = 0;

    //Buat UI Text
    public TMP_Text txtPlayerScoreL;
    public TMP_Text txtPlayerScoreR;


    public Animator healthBarAnimatorL;
    public Animator healthBarAnimatorEnemy;

    public static GameManager instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        //Mengisikan nilai integer PlayerScore ke UI
        txtPlayerScoreL.text = PlayerScoreL.ToString();
        txtPlayerScoreR.text = PlayerScoreR.ToString();
    }

    public void ScoreCheck()
    {
        if (PlayerScoreL == 90)
        {
            Debug.Log("playerL win");
            this.gameObject.SendMessage("ChangeScene", "Player1WIN");

        }
        else if (PlayerScoreR == 90)
        {
            Debug.Log("playerR win");
            this.gameObject.SendMessage("ChangeScene", "Player2WIN");
        }
    }

    //Method penyeleksi untuk menambah score
    public void Score(string wallID)
    {
        if (wallID == "Player1Goal")
        {
            PlayerScoreR = PlayerScoreR + 10; //Menambah score
            healthBarAnimatorL.SetInteger("poin", PlayerScoreR);
            txtPlayerScoreR.text = PlayerScoreR.ToString();//Mengisikan nilai integer PlayerScore ke UI
            
            ScoreCheck();
        }
        else
        {
            PlayerScoreL = PlayerScoreL + 10;
            healthBarAnimatorEnemy.SetInteger("poin", PlayerScoreL);
            txtPlayerScoreL.text = PlayerScoreL.ToString();
            
            ScoreCheck();


        }
    }

}