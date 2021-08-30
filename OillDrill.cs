using System;

class Drill 
{  
  static void Main()
  {
    Console.WriteLine("Enter the Half Life constant H");
    String input1=Console.ReadLine();
	Console.WriteLine("Enter the D days taken as rate of  digging of one well by one drill");
    String input2=Console.ReadLine();
	Console.WriteLine("Enter the number Barrel produced by one well in one day");
    String input3= Console.ReadLine();
	
	//Convert the user input to Double
    Double H; //half life constant
    Double.TryParse(input1,out H);
    Double D;// Days to dig one well
    Double.TryParse(input2,out D);
    Double B; //BBL/Day
    Double.TryParse(input3,out B);
	
	
    int n=1; //n counter to calculate the number of wells dug, initilizad with 1 for one well dug condition
            // A single n can represent D days as it take D days to dig one well
   Double old_production=0.0;
   Double new_production=B; // First production rate Initiliazed with 1 well already dug after D days
   Double rate_Decay=D/H;
   while(old_production<new_production)
   {
       n++;
       old_production=new_production;
       new_production=B*((1-Math.Pow(.5,(n*rate_Decay))))/(1-Math.Pow(.5,rate_Decay));

       
       
   }
       Console.WriteLine("Maximum Porduction reached for the given sets of Input is : "+ old_production);
       Console.WriteLine("\n Time take to reach maximum production: " +n*D+" Days");

  }
}
