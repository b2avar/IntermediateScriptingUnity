using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediateScripting
{
    public class mh_Warband : MonoBehaviour
    {
        void Start () 
        {
            mh_Humanoid human = new mh_Humanoid();
            mh_Humanoid enemy = new mh_Enemy();
            mh_Humanoid orc = new mh_Orc();

            //Notice how each Humanoid variable contains
            //a reference to a different class in the
            //inheritance hierarchy, yet each of them
            //calls the Humanoid Yell() method.
            human.Yell();
            enemy.Yell();
            orc.Yell();
        }
    }
}
