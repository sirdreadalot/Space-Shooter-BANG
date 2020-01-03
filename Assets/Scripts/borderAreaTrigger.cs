using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class borderAreaTrigger : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D hit)
    {
        warningEngine.instance.enterArea(); 
    }

    private void OnTriggerExit2D(Collider2D hit)
    {
        warningEngine.instance.exitArea();
    }

}
