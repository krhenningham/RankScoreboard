using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI candyCountText;
    [SerializeField] TextMeshProUGUI rankText;
    

    int candy = 34;
    // Start is called before the first frame update
    void Start()
    {
        UpdateRankAndCandyDisplay(); 
    }

    // Update is called once per frame
    void UpdateRankAndCandyDisplay()
    {
        if (candy > 0 && candy < 10)
        {
            rankText.text = "Rank F";
        }
        else if (candy >= 10 && candy < 20)
        {
            rankText.text = "Rank D";
        }
        else if (candy >= 20 && candy < 30)
        {
            rankText.text = "Rank C";
        }
        else if (candy >= 30 && candy < 40)
        {
            rankText.text = "Rank B";
        }
        else if (candy >= 40 && candy < 50)
        {
            rankText.text = "Rank A";
        }
        else if (candy >= 50)
        {
            rankText.text = "Rank S";
        }

         candyCountText.text = candy.ToString() + " PIECES OF CANDY";
    }

    void Update()
    {

    }

    public void MainMenu()
    {
        SceneManager.LoadSceneAsync("Main Menu");
    }
}
