using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetObjectScore : MonoBehaviour
{
    public ObjectManager objectManager;

    public int newScore = 1;

    private void OnTriggerEnter(Collider other)
    {
        objectManager.score = newScore;
    }
}
