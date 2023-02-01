using UnityEngine;

namespace IntermediateScripting
{
    public class ovr_Apple : ovr_Fruit
    {
        public ovr_Apple()
        {
            Debug.Log("1st Apple Constructor Called");
        }

        public override void Chop()
        {
            base.Chop();
            Debug.Log("The apple has been chopped."); 
        }

        public override void SayHello()
        {
            base.SayHello();
            Debug.Log("Hello, I am an apple.");
        }
    }
}
