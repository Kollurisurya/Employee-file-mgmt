using System;
using System.IO;

namespace filehandling
{
    class employee
    {
        public int EmpID, DeptId;
        public string EmpName, Email;
        public long Phone;

        public employee()
        {
            Console.WriteLine("Enter the EmpId");
            EmpID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the DeptId");
            DeptId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Employee Name");
            EmpName = Console.ReadLine();

            Console.WriteLine("Enter the Email");
            Email = Console.ReadLine();

            Console.WriteLine("Enter the Phone Number");
            Phone = long.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return (EmpName.PadLeft(20) + " | " + EmpID.ToString().PadLeft(20) + " | " + DeptId.ToString().PadLeft(20) +
               " | " + Email.PadLeft(20) + " | " + Phone.ToString().PadLeft(20));
        }
        internal bool checkDuplicate(string emppath)
        {
            string lines;
            StreamReader reader = new StreamReader(emppath);
            while ((lines = reader.ReadLine()) != null)
            {

                //if (lines.Substring(40, 3) == this.EmpID.ToString() || lines.Substring(69,20)==this.Email.ToString() || lines.Substring(92,20)==this.Phone.ToString())
                if (lines.Substring(40, 3) == this.EmpID.ToString())
                {
                    //Console.WriteLine(EmpID);
                    Console.WriteLine("enter valid employee id because it's already used!!!");
                    reader.Close();
                    return false;

                }
            }
            reader.Close();
            return true;
        }

    }
}
