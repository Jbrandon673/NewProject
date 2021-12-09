using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectCoin : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        CollectableControl.coinCount += 1;
        this.gameObject.SetActive(false);
        
    }

    public void Score()
    {
        //Restart the score for coins after game restarts
        
    }
}
