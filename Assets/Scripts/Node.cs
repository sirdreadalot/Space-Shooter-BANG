using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{

    Node[] PathNode;
    // Use this for instillation
    private void Start()
    {
        PathNode = GetComponentsInChildren<Node>();

        foreach(Node n in PathNode)
        {
            Debug.Log(n.name);
        }
    }

}
