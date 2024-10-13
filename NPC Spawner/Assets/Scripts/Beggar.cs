using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class Beggar : INPC
    {

        public void Speak()
        {
            Debug.Log("Do you have some change to spare?");
        }
    }
}
