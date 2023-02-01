using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediateScripting
{
    public class ovr_FruitSalad : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            ovr_Apple myApple = new ovr_Apple();

            //Notice that the Apple version of the methods
            //override the fruit versions. Also notice that
            //since the Apple versions call the Fruit version with
            //the "base" keyword, both are called.
            myApple.SayHello();
            myApple.Chop();    

            //Overriding is also useful in a polymorphic situation.
            //Since the methods of the Fruit class are "virtual" and
            //the methods of the Apple class are "override", when we 
            //upcast an Apple into a Fruit, the Apple version of the 
            //Methods are used.
            ovr_Fruit myFruit = new ovr_Apple();
            myFruit.SayHello();
            myFruit.Chop();
        }
    }
}
