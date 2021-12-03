using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVars : MonoBehaviour
{
    public static float time = 0.0f;
    public static int score = 0;
    public static int lives = 3;

    public static List<int> bestScore;

    public static bool inGame = true;
    // Start is called before the first frame update
    void Start()
    {
        bestScore = new List<int>(5);

        for(int i = 0; i < 5; i++)
        {
            bestScore[i] = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (inGame)
            time += Time.deltaTime;

        if (lives == 0)
        {
            //TODO game over screen
            inGame = false;
            lives = 3;
        }
    }
}
