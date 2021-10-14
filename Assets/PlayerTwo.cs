using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwo : MonoBehaviour
{

    [Header(("Red"))]
    [SerializeField] Transform redOne;
    [SerializeField] Transform redTwo;
    [SerializeField] Transform redThree;
    [SerializeField] Transform redFour;

    [Header(("Green"))]
    [SerializeField] Transform greenOne;
    [SerializeField] Transform greenTwo;
    [SerializeField] Transform greenThree;
    [SerializeField] Transform greenFour;

    [Header(("Yellow"))]
    [SerializeField] Transform yellowOne;
    [SerializeField] Transform yellowTwo;
    [SerializeField] Transform yellowThree;
    [SerializeField] Transform yelloFour;

    [Header(("Blue"))]
    [SerializeField] Transform blueOne;
    [SerializeField] Transform blueTwo;
    [SerializeField] Transform blueThree;
    [SerializeField] Transform blueFour;

    Transform pos;
    int index;
    bool start = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            this.transform.position = Vector2.MoveTowards(this.transform.position,
            pos.position, Time.deltaTime * 3);
            if (this.transform.position == pos.position)
            {
                start = false;
            }
        }

    }

    public void OnClickPlayerTwoReal(Transform x)
    {
        start = true;
        pos = x;

    }
}
