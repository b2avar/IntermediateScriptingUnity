using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediateScripting
{
    public class ovr_Fruit 
    {
        public ovr_Fruit()
        {
            Debug.Log("1st Fruit Constructor Called");
        }
        
        //These methods are virtual and thus can be overriden
        //in child classes
        public virtual void Chop ()
        {
            Debug.Log("The fruit has been chopped.");        
        }

        public virtual void SayHello ()
        {
            Debug.Log("Hello, I am a fruit.");
        }
    }
}
