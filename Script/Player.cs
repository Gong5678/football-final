using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textScore;
    [SerializeField] private TextMeshProUGUI textGoal;
    private StarterAssetsInputs starterAssetsInputs;
    private int myScore, otherScore;
    private float goalTextColorAlpha;


    public int OtherScore { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        starterAssetsInputs = GetComponent<StarterAssetsInputs>();
    }

    // Update is called once per frame
    void Update()
    {
        if (goalTextColorAlpha>0)
        {
            goalTextColorAlpha -= Time.deltaTime;
            textGoal.alpha = goalTextColorAlpha;
            textGoal.fontSize = 200 - (goalTextColorAlpha * 100);
        }

 
 
    }
    public void IncreaseMyScore()
    {
        myScore++;
        UpdateScore();
        
    }

    public void IncreaseOtherScore()
    {
        OtherScore++;
        UpdateScore();
    }

    private void UpdateScore()
    {
        textScore.text = "Score: " + myScore.ToString() + "-" + otherScore.ToString();
        goalTextColorAlpha = 1f;
    }

}
