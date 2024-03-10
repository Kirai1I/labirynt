using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField]
    int timeToEnd = 0;

    bool gamePaused = false;

    private bool endGame = false;

    public bool Won = false;

    public int points = 0;

    public int RedKeysCount;
    public int GreenKeysCount;
    public int BlueKeysCount;
    void Start()
    {
    if(Instance == null)
        {
            Instance = this;
        }

        InvokeRepeating(nameof(stopper), 2, 1);
        if(timeToEnd <= 0)
            timeToEnd = 100;
    }

    public void AddPoints(int Points)
    {
       
        if (endGame == false) { points = Points; }
    }

    public void AddTime(int timetoAdd)
    {
        if (endGame == false)
        {
            timeToEnd += timetoAdd;
        }
       
    }
    public void FreezeTime(int timetoFreeze)
    {
        if(endGame == false)
        {
            CancelInvoke(nameof(stopper));
            InvokeRepeating(nameof(stopper), timetoFreeze, 1);
        }
       
    }
    public void AddKey(KeyColor color)
    {
        if (endGame)
            return;
        if (color == KeyColor.Red) 
            RedKeysCount++;
        else if (color == KeyColor.Green)
            GreenKeysCount++;
         else if (color == KeyColor.Blue) 
            BlueKeysCount++;
    }
    
    
    void Update()
    {
        PauseCheck();   
    }
    void stopper()
    {
        timeToEnd--;
        print("Time: " + timeToEnd);

        if(timeToEnd <= 0 )
        {
            timeToEnd = 0;
            endGame = true;
        }
        if(endGame)
        { 
        EndGame();
        }
    }
    void PauseGame()
    {
        print("Pause game");
        Time.timeScale = 0;
        gamePaused = true;
    }
    void ResumeGame()
    {
        print("Resume game");
        Time.timeScale = 1;
        gamePaused = false;
    }
    void PauseCheck()
    {
        if(Input.GetKeyUp(KeyCode.P))
        {
            if (gamePaused)
                ResumeGame();
            else
                PauseGame();
                
        }
    }
    void Statistics()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            print("Time To End:" + timeToEnd + "s");
            print("POINTS: " + points);
            print($"Red keys: {RedKeysCount}, GreenKeys: {GreenKeysCount}, BlueKeys: {BlueKeysCount}");
        }
    }
    void EndGame()
    {
        CancelInvoke(nameof(stopper));
        if (Won)
        {
            print("Wygrana");
        } else
            print("Przegrana");
    }

   
}
public enum KeyColor
{
    Red, Green, Blue
}
