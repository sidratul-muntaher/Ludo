using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reds : MonoBehaviour
{
    [SerializeField] RoadMap redRoad;
    int roll;
    bool startPlayerOne = true;
    bool startPlayerTwo = false;
    bool startPlayerThree = false;
    bool startPlayerFour = false;
    GameObject playerOne;
    GameObject playerTwo;
    GameObject playerThree;
    GameObject playerFour;

    [SerializeField] GameObject blueRoller;
    [SerializeField] GameObject redRoller;
    [SerializeField] GameObject greenRoller;
    [SerializeField] GameObject yellowRoller;

    List<Transform> points;
   public static int currentIndexOne = 0;
    public static int currentIndexTwo = 0;
    public static int currentIndexThree = 0;
    public static int currentIndexFour = 0;

    public static bool validOne = false;
    public static bool validTwo = false;
    public static bool validThree = false;
    public static bool validFour = false;
  public static  bool canGo = false;
    // Start is called before the first frame update
    void Start()
    {
        playerOne = GetComponentInChildren<PlayerOne>().gameObject;
        playerTwo = GetComponentInChildren<PlayerTwo>().gameObject;
        playerThree = GetComponentInChildren<PlayerThree>().gameObject;
        playerFour = GetComponentInChildren<PlayerFour>().gameObject;

        points = redRoad.GetWayPoints();
    }

    // Update is called once per frame
    void Update()
    {
        if (roll == 6 && startPlayerOne)
        {
            if (!canGo)
            {
                return;
            }
            validOne = true;
            playerOne.transform.position = points[0].position;
            startPlayerOne = false;
            startPlayerTwo = true;
            startPlayerThree = true; startPlayerFour = true;
            roll = 5;
            canGo = false;
        }


    }
    public void roller()
    {
        roll = Random.Range(1, 7);
        canGo = true;
        Blues.canGo = false;
        Greens.canGo = false;
        Yellows.canGo = false;
        greenRoller.SetActive(true);
        blueRoller.SetActive(false);
        redRoller.SetActive(false);
        yellowRoller.SetActive(false);
        Debug.Log(roll);
    }
    public void OnClickPlayerOne()
    {
        if (!validOne)
        {
            return;
        }
        if (!canGo)
        {
            return;
        }
        if (currentIndexOne == 56)
        {
            return;
        }

        var index = currentIndexOne;
        currentIndexOne = currentIndexOne + roll;

        Debug.Log(currentIndexOne);
        try
        {
         playerOne.GetComponent<PlayerOne>().OnClickPlayerOneReal(points[currentIndexOne]);

        }
        catch (System.Exception)
        {

            currentIndexOne = index;
            canGo = true;
            return;
        }
        Debug.LogWarning("Under cstch");
        canGo = false;
    }
    public void OnClickPlayerTwo()
    {
        if (roll == 6 && startPlayerTwo)
        {
            if (!canGo)
            {
                return;
            }
            validTwo = true;
            playerTwo.transform.position = points[0].position;
            startPlayerTwo = false;
            roll = 4;
            canGo = false;
        }
        if (!validTwo)
        {
            return;
        }
        if (!canGo)
        {
            return;
        }
        if (currentIndexTwo == 56 )
        {
            return;
        }
        var index = currentIndexTwo;
        currentIndexTwo = currentIndexTwo + roll;

        Debug.Log(currentIndexTwo);
        try
        {
        playerTwo.GetComponent<PlayerTwo>().OnClickPlayerTwoReal(points[currentIndexTwo]);

        }
        catch (System.Exception)
        {

            currentIndexTwo = index;
            canGo = true;
            return;
        }
        canGo = false;
    }

    public void OnClickPlayerThree()
    {
        if (roll == 6 && startPlayerThree)
        {
            if (!canGo)
            {
                return;
            }
            validThree = true;
            playerThree.transform.position = points[0].position;
            startPlayerThree = false;
            canGo = false;
            roll = 3;
        }
        if (!validThree)
        {
            return;
        }
        if (!canGo)
        {
            return;
        }


        Debug.Log(currentIndexThree);
        if (currentIndexThree == 56)
        {
            return;
        }
        var index = currentIndexThree;
        currentIndexThree = currentIndexThree + roll;

        try
        {
        playerThree.GetComponent<PlayerThree>().OnClickPlayerThreeReal(points[currentIndexThree]);

        }
        catch (System.Exception)
        {

            currentIndexThree = index;
            canGo = true;
            return;
        }
        canGo = false;
    }

    public void OnClickPlayerFour()
    {
        if (roll == 6 && startPlayerFour)
        {
            if (!canGo)
            {
                return;
            }
            validFour = true;
            playerFour.transform.position = points[0].position;
            startPlayerFour = false;
            roll = 3;
            canGo = false;
        }
        if (!validFour)
        {
            return;
        }
        if (!canGo)
        {
            return;
        }
        if (currentIndexFour == 56)
        {
            return;
        }
        var index = currentIndexFour;
        currentIndexFour = currentIndexFour + roll;

        Debug.Log(currentIndexFour);
        try
        {
        playerFour.GetComponent<PlayerFour>().OnClickPlayerFourReal(points[currentIndexFour]);

        }
        catch (System.Exception)
        {

            currentIndexFour = index;
            canGo = true;
            return;
        }
        canGo = false;
    }
}
