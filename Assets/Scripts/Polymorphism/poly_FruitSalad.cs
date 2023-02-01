using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediateScripting
{
    public class poly_FruitSalad : MonoBehaviour
    {
        private void Start()
        {
            //Notice here how the variable "myFruit" is of type
            //Fruit but is being assigned a reference to an Apple. This
            //works because of Polymorphism. Since an Apple is a Fruit,
            //this works just fine. While the Apple reference is stored
            //in a Fruit variable, it can only be used like a Fruit
            poly_Fruit myFruit = new poly_Apple();

            Debug.Log("-Fruit-");
            myFruit.SayHello();
            myFruit.Chop();

            //This is called downcasting. The variable "myFruit" which is 
            //of type Fruit, actually contains a reference to an Apple. Therefore,
            //it can safely be turned back into an Apple variable. This allows
            //it to be used like an Apple, where before it could only be used
            //like a Fruit.
            poly_Apple myApple = (poly_Apple)myFruit;

            Debug.Log("-Apple-");
            myApple.SayHello();
            myApple.Chop(); 
        }
    }
}
