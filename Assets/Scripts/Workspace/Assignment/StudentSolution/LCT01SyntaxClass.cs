using UnityEngine;


namespace Assignment.StudentSolution.LCT01
{
    public class Car
    {
        public string Name;
        public float  Speed;
        public string Color;

        public void Move()
        {
            Debug.Log("Car is moving");
        }

        public void Turn()
        {
            Debug.Log("Car is turning");
        }
    }

    public class LCT01SyntaxClass
    {
        public void Start()
        {
            // Student code start HERE ...
            Car carl = new Car();
            Debug.Log(carl.Name);
            carl.Move();
            carl.Turn();

            Car car2 = new();
            car2.Name = "Toyata";
            Debug.Log(car2.Name);

            // Student code ends HERE 
        }
    }
}
