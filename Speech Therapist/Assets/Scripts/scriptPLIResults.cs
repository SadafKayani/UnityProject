
using UnityEngine;
using UnityEngine.UI;
public class scriptPLIResults : MonoBehaviour
{

    public Text level;
    public Text rec;
    public Text exp;

    private int hearingNum = 2;
    private int talkingNum = 3;

    private int receptiveTime = 35;
    private int receptiveScore = 5;
    private int expressiveScore = 7;

    private string receptive;
    private string expressive;

    private string issueLevel;

    private string receptive1;

    void Start()
    {
        
        if (receptiveTime <= 60 && receptiveScore > 6)
            receptive1 = "mild";
        else if (receptiveTime < 60 && (receptiveScore >=4 && receptiveScore <6))
            receptive1 = "moderate";
        else if (receptiveTime < 60 && receptiveScore < 4)
            receptive1 = "moderate";
        else if (receptiveTime > 60 && receptiveScore > 6)
            receptive1 = "mild";
        else if (receptiveTime > 60 && (receptiveScore >= 4 && receptiveScore < 6))
            receptive1 = "acute";
        else
            receptive1 = "acute";

        if (receptive1.Equals("mild") && hearingNum < 3)
            receptive = "Mild";
        else if (receptive1.Equals("mild") && hearingNum == 3)
            receptive = "Mild";
        else if (receptive1.Equals("mild") && hearingNum > 3)
            receptive = "Moderate";
        else if (receptive1.Equals("moderate") && hearingNum < 3)
            receptive = "Moderate";
        else if (receptive1.Equals("moderate") && hearingNum == 3)
            receptive = "Moderate";
        else if (receptive1.Equals("moderate") && hearingNum > 3)
            receptive = "Acute";
        else
            receptive = "Acute";

        rec.text = receptive;

        if (talkingNum < 3 && expressiveScore > 10)
            expressive = "Mild";
        else if (talkingNum == 3 && expressiveScore > 10)
            expressive = "Mild";
        else if (talkingNum > 3 && expressiveScore > 10)
            expressive = "Moderate";
        else if (talkingNum < 3 && (expressiveScore < 10 && expressiveScore > 8))
            expressive = "Mild";
        else if (talkingNum == 3 && (expressiveScore < 10 && expressiveScore > 8))
            expressive = "Moderate";
        else if (talkingNum > 3 && (expressiveScore < 10 && expressiveScore > 8))
            expressive = "Acute";
        else if (talkingNum < 3 && (expressiveScore < 8))
            expressive = "Moderate";
        else
            expressive = "Acute";

        exp.text = expressive;

        if (receptive.Equals("mild") && expressive.Equals("mild"))
            issueLevel = "Mild";
        else if (receptive.Equals("moderate") && expressive.Equals("mild"))
            issueLevel = "Mild";
        else if (receptive.Equals("acute") && expressive.Equals("mild"))
            issueLevel = "Moderate";
        else if (receptive.Equals("mild") && expressive.Equals("moderate"))
            issueLevel = "Mild";
        else if (receptive.Equals("mild") && expressive.Equals("acute"))
            issueLevel = "Moderate";
        else if (receptive.Equals("moderate") && expressive.Equals("moderate"))
            issueLevel = "Moderate";
        else if (receptive.Equals("moderate") && expressive.Equals("acute"))
            issueLevel = "Acute";
        else if (receptive.Equals("acute") && expressive.Equals("moderate"))
            issueLevel = "Acute";
        else
            issueLevel = "Acute";

        level.text = issueLevel + " Level";


    }

}
