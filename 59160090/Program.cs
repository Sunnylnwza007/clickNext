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
            // showSalary();
                // Q3
            // showSalaryWithDeduct();
                // Q4
            //showSalaryWithDeductNet();
                // Q5
            //showSalaryWithDeductAndBonus();
                // Q6
            //showFund();
                // Q7
            //showFund2();
                // Q8
            showFund3();


        }
        // Q1
        static int sum (int[] x){
            for (int i=0;i<x.Length;i++){
                total+= x[i];
            }
            return total;
        }

        // Q2
        static void showSalary(){
            for (int i=0;i<employee.Length;i++){
                Console.WriteLine(employee[i]+" "+salary[i]);
            }
        }

        // Q3
        static void showSalaryWithDeduct (){
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

        // Q4
        static void showSalaryWithDeductNet (){
            int netDeduct = 0;
            for (int i =0;i<employee.Length;i++){
                int deduct = 0;
                int deductCompany = 0;
                if (salary[i]<15000){
                    deduct = (salary[i]*5)/100;
                }else{
                    deduct = (15000*5)/100;
                }
                deductCompany = deduct;
                Console.WriteLine("Name: "+employee[i]+" Salary: "+salary[i]+" Deduct: "+deduct+" CompanyDeduct: "+deduct);
                netDeduct+= deduct+deductCompany;
            }
            Console.WriteLine("Net: "+netDeduct);
        }

        // Q5
        static void showSalaryWithDeductAndBonus (){
            for (int i =0;i<employee.Length;i++){
                int Bonus = salary[i]/2;
                int deduct = 0;
                if (salary[i]<15000){
                    deduct = (salary[i]*5)/100;
                }else{
                    deduct = (15000*5)/100;
                }
                int income = (salary[i]+Bonus)-deduct;
            Console.WriteLine("Name: "+employee[i]+" Salary: "+salary[i]+" Deduct: "+deduct+" Bonus: "+Bonus+" Income: "+income);
            }
        }

        // Q6
        static void showFund(){
            for (int i =0;i<employee.Length;i++){
                int deduct = 0;
                double empfund= 0;
                double compfund = 0;
                if (salary[i]<15000){
                    deduct = (salary[i]*5)/100;
                }else{
                    deduct = (15000*5)/100;
                }
                int sumSalary = salary[i]-deduct;
                empfund = sumSalary*0.05;
                compfund = sumSalary*0.02;
                
                Console.WriteLine("Name: "+employee[i]+" Salary: "+sumSalary+" Empfund: "+empfund+" Comfund: "+compfund);
        
            }
        }
        // Q7
        static void showFund2 (){
            for (int i =0;i<employee.Length;i++){
                int deduct = 0;
                double empfund= 0;
                if (salary[i]<15000){
                    deduct = (salary[i]*5)/100;
                }else{
                    deduct = (15000*5)/100;
                }
                int sumSalary = salary[i]-deduct;
                empfund = sumSalary*0.05;
                double income = (double)sumSalary - empfund;
                
                Console.WriteLine("Name: "+employee[i]+" Salary: "+salary[i]+" Deduct: "+deduct+" Deduct2: "+empfund+" NetIncome: "+income);
        
            }
        }

        // Q8
        static void showFund3 (){
            for (int i =0;i<employee.Length;i++){
                int deduct = 0;
                double empfund= 0;
                if (salary[i]<15000){
                    deduct = (salary[i]*5)/100;
                }else{
                    deduct = (15000*5)/100;
                }
                int sumSalary = salary[i]-deduct;
                double income = 0;
                if (employee[i].Equals("A") || employee[i].Equals("C") ||employee[i].Equals("E")){
                    income = (double) sumSalary;
                }else{
                    empfund = sumSalary*0.05;
                    income = (double)sumSalary - empfund;
                }
                Console.WriteLine("Name: "+employee[i]+" Salary: "+salary[i]+" Deduct: "+deduct+" Deduct2: "+empfund+" NetIncome: "+income);
        
            }
        }

    
    }
}
