using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediateScripting
{
    public class poly_Fruit
    {
        public poly_Fruit()
        {
            Debug.Log("1st Fruit Constructor Called");
        }

        public void Chop()
        {
            Debug.Log("The fruit has been chopped.");        
        }

        public void SayHello()
        {
            Debug.Log("Hello, I am a fruit.");
        }
    }
}
