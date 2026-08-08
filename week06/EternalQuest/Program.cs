using System;

//For extra creativity: Added a "Show Statistics" menu option to display
//goal completion progress in order to motivate users to complete their goals.

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();

    }
}