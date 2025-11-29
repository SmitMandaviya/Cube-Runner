using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public Gamemanager gameManager;
     void OnTriggerEnter(Collider other) {
           gameManager.Completelevel();
    }
}
