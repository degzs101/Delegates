/*
RESULT
======
Adding two values: 16
Subtracting two values: 6
*/
 
void Main()
{
        //creating the class which contains the methods 
	//that will be assigned to delegate objects
	var mc = new MyClass();
	
	//creating delegate objects and assigning appropriate methods
	//having the EXACT signature of the delegate
	var callingAdd = new Calculate(mc.add);
	var callingSubtract = new Calculate(mc.sub);
	
	//using the delegate objects to call the assigned methods 
	Console.WriteLine("Adding two values: " + callingAdd(10, 6));
	Console.WriteLine("Subtracting two values: " + callingSubtract(10,4));
	
}
 
//defining the delegate 
public delegate int Calculate (int value1, int value2);
 
//the class which contains the methods 
//that will be assigned to delegate objects
public class MyClass
{
    //a method, that will be assigned to delegate objects
    //having the EXACT signature of the delegate
    public int add(int value1, int value2)
    {
        return value1 + value2;            
    }
 
    //a method, that will be assigned to delegate objects
    //having the EXACT signature of the delegate
    public int sub( int value1, int value2)
    {
        return value1 - value2;            
    }
}
