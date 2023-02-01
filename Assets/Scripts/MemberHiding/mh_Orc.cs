using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediateScripting
{
    public class mh_Orc : mh_Enemy
    {
        new public void Yell()
        {
            Debug.Log ("Orc version of the Yell() method");
        }
    }
}
