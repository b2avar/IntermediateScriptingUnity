using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediateScripting
{
    public class mh_Enemy : mh_Humanoid
    {
        //This hides the Humanoid version.
        new public void Yell()
        {
            Debug.Log ("Enemy version of the Yell() method");
        }
    }
}
