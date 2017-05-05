using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleGrid : PlayerMovement
{

    //public Vector2 InvisGraphVec = new Vector2(0, 0);
    //public List<Vector2> InvisGraph;
    public GameObject Objectives;
    public Rigidbody Objective_RB;

    protected int RandNum = 0;
    protected int ObjectivesShown = 0;

    private Vector3 TargetPos1 = new Vector3(-31, -12, -60);
    private Vector3 TargetPos2 = new Vector3(-31, 12, -60);
    private Vector3 TargetPos3 = new Vector3(31, -12, -60);
    private Vector3 TargetPos4 = new Vector3(31, 12, -60);
    //private int XCount = 0;


    //public void GenGraph()
    //{
    //    if (InvisGraphVec.x < 1 || InvisGraphVec.y < 1)
    //    {
    //        if (InvisGraphVec.x != XCount)
    //        {
    //            if (InvisGraph.Contains(TargetPos1))
    //            {
    //                InvisGraph.Add(TargetPos3);
    //            }
    //            else
    //                InvisGraph.Add(TargetPos1);
    //            InvisGraphVec.x++;
    //        }
    //        if (InvisGraphVec.x == XCount)
    //        {
    //            if (InvisGraph.Contains(TargetPos2))
    //            {
    //                InvisGraph.Add(TargetPos4);
    //            }
    //            else
    //                InvisGraph.Add(TargetPos2);
    //            InvisGraphVec.y++;
    //            Objectives.transform.position = TargetPos1;
    //            Instantiate(Objectives);
    //        }
    //    }
    //}


    public void PlaceObjective()
    {
        if (RandNum == 0)
           RandNum = Random.Range(1, 4);
        if (RandNum == 1 && ObjectivesShown == 0)
        {
            Objectives.transform.position = TargetPos1;
            Instantiate(Objectives);
            ObjectivesShown++;
            Objectives.SetActive(true);
        }
        if (RandNum == 2 && ObjectivesShown == 0)
        {
            Objectives.transform.position = TargetPos2;
            Instantiate(Objectives);
            ObjectivesShown++;
            Objectives.SetActive(true);
        }
        if (RandNum == 3 && ObjectivesShown == 0)
        {
            Objectives.transform.position = TargetPos3;
            Instantiate(Objectives);
            ObjectivesShown++;
            Objectives.SetActive(true);
        }
        if (RandNum == 4 && ObjectivesShown == 0)
        {
            Objectives.transform.position = TargetPos4;
            Instantiate(Objectives);
            ObjectivesShown++;
            Objectives.SetActive(true);
        }
    }


 
	
	void Update ()
    {
        PlaceObjective();
	}
}
