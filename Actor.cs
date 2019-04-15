using System;
namespace WarriorsOfTheZodiac
{
    public class Actor
    {

        AttackInterface attackInterface;

        public Actor()
        {
        }

        public void performAttack()
        {
            attackInterface.Attack();
        }
    }
}
