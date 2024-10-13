using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class Farmer : INPC
    {
        public void Speak()
        {
            Debug.Log("You reap what you sow!");
        }
    }
}
