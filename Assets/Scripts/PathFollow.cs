using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollow : MonoBehaviour
{
    Node[] PathNode;
    public GameObject Follower;
    public float MoveSpeed;
    float Timer;
    static Vector3 CurrentPositionHolder;
    static Vector2 startPosition;
    int CurrentNode;

    //Use this for intialization
    private void Start()
    {
        PathNode = GetComponentsInChildren<Node> ();
        CheckNode();
    }

    //Check current node and move to it by saving node position to currentPositionHolder
    public void CheckNode()
    {
        startPosition = Follower.transform.position;
        Timer = 0;
        CurrentPositionHolder = PathNode[CurrentNode].transform.position;
    }


    //Update is called once per frame
    public void Update()
    {
        Timer += Time.deltaTime * MoveSpeed;
        if (Follower.transform.position != CurrentPositionHolder)
            {
                Follower.transform.position = Vector3.Lerp(startPosition, CurrentPositionHolder, Timer);
                //g.transform.position = Vector3.Lerp(g.transform.position, CurrentPositionHolder, Timer);
            }
        else
        {
            if (CurrentNode < PathNode.Length - 1)
            {
                CurrentNode++;
                CheckNode();
            }
        }
        
    }
}
