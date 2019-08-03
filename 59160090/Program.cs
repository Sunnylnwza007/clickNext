using System;

namespace _59160090
{
    class Program
    {
        static String[] employee = {"A","B","C","D","E"};
        static int[] salary = {9000,12000,15000,18000,21000};
        static int total = 0;
        static void Main(string[] args)
        {
            // int num = 0;
            // String name = "Hello Wrold"
            // double money = 1.5;

            // if (num==0){

            // }else{

            // }

            // switch{
            //     case 0:

            //     break;
            //     default:

            //     break;
            // }

            // for (int i=1; i<=5;i++){

            // }

            // int[] num = new int [5];
            // int[] number = {1,2,3,4,5};
            // String[] name = {"A","B","C"};
            // Console.WriteLine(name[1]);

            // for (int i=0;i<5;i++){
            //     Console.WriteLine(number[i]);
            // }

            // Console.WriteLine("Hello World!");
                // Q1  
            // Console.WriteLine(sum(salary));
                // Q2
            // showSalary(employee,salary);
                // Q3
            showSalaryWithDeduct(employee,salary);
        }
        // Q1
        static int sum (int[] x){
            for (int i=0;i<x.Length;i++){
                total+= x[i];
            }
            return total;
        }

        // Q2
        static void showSalary(String[] employee,int[] salary){
            for (int i=0;i<employee.Length;i++){
                Console.WriteLine(employee[i]+" "+salary[i]);
            }
        }

        // Q3
        static void showSalaryWithDeduct (String[] employee,int[] salary){
            for (int i =0;i<employee.Length;i++){
                int deduct = 0;
                if (salary[i]<15000){
                    deduct = (salary[i]*5)/100;
                }else{
                    deduct = (15000*5)/100;
                }
            Console.WriteLine("Name: "+employee[i]+" Salary: "+salary[i]+" Deduct: "+deduct+" Net Income: "+(salary[i]-deduct));
            
            }
        }
    }

    
}
