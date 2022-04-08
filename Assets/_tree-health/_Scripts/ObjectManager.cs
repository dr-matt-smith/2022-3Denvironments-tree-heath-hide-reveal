using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
        public int score = 1;

        public GameObject object1;
        public GameObject object2;
        public GameObject object3;

        void Update()
        {
                // default - hide ALL of them
                // logic - decide which object to make visible
                switch(score)
                {
                        
                        case 3:
                                object1.SetActive(false);
                                object2.SetActive(false);
                                object3.SetActive(true);
                                break;
                        case 2:
                                object1.SetActive(false);
                                object2.SetActive(true);
                                object3.SetActive(false);
                                break;

                        // default - show object1
                        case 1:
                        default:
                                object1.SetActive(true);
                                object2.SetActive(false);
                                object3.SetActive(false);
                                break;
                                
                }
        }
}
