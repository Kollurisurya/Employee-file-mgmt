using System;
using System.IO;

namespace filehandling
{
    class Department
    {
        public int DeptId, NoofProj;
        public string DeptName;

        public Department()
        {
            Console.WriteLine("Enter the DeptID");
            DeptId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Dept Name");
            DeptName = Console.ReadLine();

            Console.WriteLine("Enter the Number of Projects");
            NoofProj = int.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return (DeptId.ToString().PadLeft(20) + " | " + DeptName.PadLeft(20) + " | " + NoofProj.ToString().PadLeft(20));
        }
        internal bool checkDuplicate1(string depPath)
        {
            string lines;
            StreamReader reader = new StreamReader(depPath);
            while ((lines = reader.ReadLine()) != null)
            {
                if (lines.Substring(17, 3) == this.DeptId.ToString())
                {
                    //Console.WriteLine(EmpID);
                    Console.WriteLine("enter valid department id because it's already used!!!");
                    reader.Close();
                    return false;

                }
            }
            reader.Close();
            return true;
        }

    }
}
