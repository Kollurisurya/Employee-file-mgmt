using System;
using System.IO;

namespace filehandling
{
    class connectFile
    {
        
            public static void projectbyempID(string search, string filename, string filename2)
            {
                StreamReader reader = new StreamReader(filename2);
                string magID = null, line, temp = "";
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Substring(63, 3) == search)
                    {
                        // Console.WriteLine(line.Substring(63,3));
                        magID = line.Substring(63, 3);
                        temp = line;
                        break;
                    }
                }
                reader.Close();
                if (magID == null)
                {
                    Console.WriteLine("Employe ID is not present in the Project File");
                }
                else
                {
                    reader = new StreamReader(filename);
                    bool flag = true;
                    while ((line = reader.ReadLine()) != null)
                    {
                        //Console.WriteLine(line.Substring(40,3));
                        if (line.Substring(40, 3) == magID)
                        {
                            if (flag == true)
                            {
                                Console.WriteLine("Project Manager ID is {0}", magID);
                                Console.WriteLine("Employee Name".PadLeft(20) + " | " + "Employee ID".PadLeft(20) + " | " + "Department ID".PadLeft(20) +
                                                   " | " + "Email".PadLeft(20) + " | " + "Phone".PadLeft(20) +
                                                   " | " + "Pro ID".PadLeft(20) + " | " + "Pro Name".PadLeft(20) + " | " + "Mag ID".PadLeft(20));
                            }
                            flag = false;
                            Console.WriteLine(line + " | " + temp);
                        }
                    }
                    if (flag == true)
                    {
                        Console.WriteLine("Employee Id Not Matching with Manager ID");
                    }
                    reader.Close();
                }
            }
            public static void EmpInfobyDeptID(string search, string emppath, string deptpath)
            {
                StreamReader reader = new StreamReader(deptpath);
                string deptID = null, line, temp = "";
                while ((line = reader.ReadLine()) != null)
                {
                    //Console.WriteLine(line.Substring(17,3));
                    if (line.Substring(17, 3) == search)
                    {
                        temp = line;
                        deptID = line.Substring(17, 3);
                        break;
                    }
                }
                reader.Close();
                if (deptID == null)
                    Console.WriteLine("Department ID is not found in Department File");
                else
                {
                    reader = new StreamReader(emppath);
                    bool flag = true;
                    while ((line = reader.ReadLine()) != null)
                    {
                        //Console.WriteLine(line.Substring(63,3));
                        if (line.Substring(63, 3) == deptID)
                        {

                            if (flag == true)
                            {
                                Console.WriteLine("Department ID is {0}", deptID);
                                Console.WriteLine("Employee Name".PadLeft(20) + " | " + "Employee ID".PadLeft(20) + " | " + "Department ID".PadLeft(20) +
                                                   " | " + "Email".PadLeft(20) + " | " + "Phone".PadLeft(20) + " | " + "Dept ID".PadLeft(20) +
                                                   " | " + "Dept Name".PadLeft(20) + " | " + "No. of Proj".PadLeft(20));
                            }
                            flag = false;
                            Console.WriteLine(line + " | " + temp);
                            break;
                        }
                    }
                    if (flag == true)
                    {
                        Console.WriteLine("Department ID is not found in Employee file");
                    }
                    reader.Close();
                }
            }
            public static void searchbyDeptname(string search, string emppath, string deptpath)
            {
                StreamReader reader = new StreamReader(deptpath);
                string deptID = null, line, temp = "";
                while ((line = reader.ReadLine()) != null)
                {
                    //Console.WriteLine(line.Substring(23,20));
                    if (line.Substring(23, 20) == search.PadLeft(20))
                    {
                        temp = line;
                        deptID = line.Substring(17, 3);
                        //Console.WriteLine(deptID);
                        break;
                    }
                }
                reader.Close();
                if (deptID == null)
                    Console.WriteLine("Department Name is not found");
                else
                {
                    reader = new StreamReader(emppath);
                    bool flag = true;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Substring(63, 3) == deptID)
                        {
                            if (flag == true)
                            {
                                Console.WriteLine("Department Name {0}", search);
                                Console.WriteLine("Employee Name".PadLeft(20) + " | " + "Employee ID".PadLeft(20) + " | " + "Department ID".PadLeft(20) +
                                                   " | " + "Email".PadLeft(20) + " | " + "Phone".PadLeft(20) + " | " + "Dept ID".PadLeft(20) +
                                                   " | " + "Dept Name".PadLeft(20) + " | " + "No. of Proj".PadLeft(20));
                            }
                            flag = false;
                            Console.WriteLine(line + " | " + temp);
                            break;
                        }
                    }
                    if (flag == true)
                    {
                        Console.WriteLine("Department ID is not found in Employee file");
                    }
                    reader.Close();
                }
            }
        }
    }


