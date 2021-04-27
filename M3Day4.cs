using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    

class P
{
    internal int x;
    public P()
    {
        x=10;
    }
}

class Q:P
{
    public int getP()
    {
        return x;
    }
}

class Program
{
    
    public static void Main()
    {
        P obj1 = new P();
        Q obj2 = new Q();
        Console.WriteLine("Value of x : "+obj2.getP());
        Console.ReadLine();
    }
}

}

---------------------------------------------------------------------------------------------



using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    

class product
{
    public string p_name;
    public double price;
    public int quant;
    public double total;
    
    public static void Main()
    {
        product soap = new product();
        
        soap.p_name="Dove";
        soap.price= 48.50;
        Console.WriteLine("Enter the Quantity : ");
        soap.quant= Convert.ToInt32(Console.ReadLine());
        soap.total = soap.price*soap.quant;
        
        Console.Write(soap.p_name+"\t");
        Console.Write(soap.price+"\t");
        Console.Write(soap.quant+"\t");
        Console.Write(soap.total+"\t");
        
        Console.ReadLine();
    }
}

}


--------------------------------------------------------------------------------------------------


using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Day_4
{
    class Class7
    {
        public int a;
        public int b;

        public void InputX()
        {
            Console.WriteLine("Enter a number, a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number, b=");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum = " + (a+b));

        }
        public static void Main()
        {
            Class7 obj = new Class7();
            //int exitkey = 1;
           for(; ; )
            {
                Console.WriteLine("You want to exit ? Y/N");
                string choice = Console.ReadLine();
                if (choice.ToLower() == "n")
                {
                    obj.InputX();
                    choice = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}


-----------------------------------------------------------------------------------------


using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Day_4
{
    class Class7
    {
       
        public static void Main()
        {
            int x=1;
            int y;
            try
            {
                y = x/0;
                Console.WriteLine(y);
            }
            catch
            {
                Console.WriteLine("There is an ERROR");
            }
            Console.ReadLine();
        }
    }
}


--------------------------------------------------------------------------------------


using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Day_4
{
    class Class7
    {
       
        public static void Main()
        {
            int x=1;
            int y=0 , z=0;
            int []a= new int[1];
            
            try
            {
                a[1]=1;
                //y = x/z;
                Console.WriteLine(y);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                 Console.WriteLine(ex.StackTrace);
                  Console.WriteLine("Error");
            }
            
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                 Console.WriteLine(ex.StackTrace);
                  Console.WriteLine("Error");
            }
            
            finally
            {
                Console.WriteLine("Blocked!");
            }
            Console.ReadLine();
        }
    }
}


------------------------------------------------------------------------------------------------------



using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Day_4
{
    class MyException:ApplicationException
    {
        public void MyDivideException()
        {
            Console.WriteLine("Exception occured, divisor should not be zero");
        }
    }
    
    class Class7
    {
       
        public static void Main()
        {
            int x=7;
            int y=0 , z;
        
            
            try
            {
                if(y==0)
                {
                    throw new MyException();
                }
            }
            catch(MyException ex)
            {
                ex.MyDivideException();
            }
            
            Console.ReadLine();
        }
    }
}



---------------------------------------------------------------------------------------------



using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Day_4
{
    class MyException:ApplicationException
    {
        public void MyDivideException()
        {
            Console.WriteLine("Exception occured, divisor should not be zero");
        }
    }
    
    class Class7
    {
       
        public static void Main()
        {
            int x=7;
            int y=0 , z;
            Class7 c= null;
        
            
            try
            {
                if(c==null)
                {
                    throw new MyException();
                }
            }
            catch(MyException ex)
            {
                ex.MyDivideException();
            }
            
            Console.ReadLine();
        }
    }
}


-----------------------------------------------------------------------------------------------------------



