using System;

namespace FRI_FEB_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator e = new Elevator();
            e.setup();
            e.TraverseList();
        }
    }

    class Node
    {
        public Node() { }
        public Node elevatorUp;
        public string FloorNumber;
    }

    class Department
    {
        public Department aDepartment;

    }

    class Elevator
    {
        Node Head;
        Node FirstFloor;
        Node SecondFloor;
        Node ThirdFloor;
        Node FourthFloor;

        public void setup()
        {
            FirstFloor = new Node();
            SecondFloor = new Node();
            ThirdFloor = new Node();
            FourthFloor = new Node();
            Head = FirstFloor;
            FirstFloor.FloorNumber = "First Floor";
            FirstFloor.elevatorUp = SecondFloor;
            SecondFloor.FloorNumber = "Second Floor";
            SecondFloor.elevatorUp = ThirdFloor;
            ThirdFloor.FloorNumber = "Third Floor";
            ThirdFloor.elevatorUp = FourthFloor;
            FourthFloor.FloorNumber = "Fourth Floor";
            FourthFloor.elevatorUp = null;
        }

        public void TraverseList()
        {
            Node temp;
            temp = Head;

            // where am I going to start?

            while (temp != null)
            {
                Console.WriteLine(temp.FloorNumber);
                temp = temp.elevatorUp;

            }

        }
    }
}