namespace SemihWhileDögüsüÖdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* soru 1
	 
	 Console.WriteLine("pozitif bir sayi giriniz");
	 int sayi = int.Parse(Console.ReadLine());
	 int faktoriyel = 1;
	 
	 if(sayi<0)
	 {
	 Console.WriteLine("pozitif sayi giriniz");
	 }
	 
	 else{
	 while(sayi>0)
	 
	 {
	 
	 
	 faktoriyel *= sayi;
	 sayi--;
	 
	 }


        Console.WriteLine(faktoriyel);


  }
  soru 2
  Console.WriteLine("bir sayi giriniz");
  int sayi = int.Parse(Console.ReadLine());
  int faktoriyel = 1;
  
  do
  {
   faktoriyel*=sayi;
   sayi--;
  }
  
while(sayi>0);
Console.WriteLine(faktoriyel); 


soru 4;

  Console.WriteLine("bir sayi giriniz");
  int sayi = int.Parse(Console.ReadLine());
  
 
if(sayi>0)

{
 
 
    
	do
	
	{
    int  a = sayi*sayi;
    Console.WriteLine(a);
	
	}
 
 while(sayi>0);
 
 
 } 
 
 int [] sayilar = {2,5,7,8,9,6};
 


 
 int i = 0;
 
 while(i<sayilar.Length)
 {
 	
 	
 Console.WriteLine(sayilar[i]);
 i++;
 
 }  
			
			8.soru 



      int[] sayilar = {2,5,56,7,9, 90};
       int enbs = sayilar[0];
         int i = 0;
     while(i<sayilar.Length)
 
   {
   if(sayilar[i]>enbs)
   {
   enbs = sayilar[i];
   }
    i++;
 }
 	Console.WriteLine(enbs);

            5. soru

            int[] sayilar = { 2, 5, 56, 7, 9, 90 };
            
            int i = 0;
            int enbs = sayilar[i];
            while (i < sayilar.Length)

            {
                if (sayilar[i] %2==0)
                {
                    Console.WriteLine(sayilar[i]);
                }
                i++;
            } 

            9. soru

            int[] sayılar = { 1, 2, 3, 10, 23, 25, 22 };
            int i = 0;
            int toplam = 0;
            while(i < sayılar.Length)
            { 
                if (sayılar[i] % 2 == 0) 
                
                {
                    toplam += sayılar[i]; 
                 
                }
                
                i++;
            }
            Console.WriteLine(toplam);
            }   
            soru7
            int[] sayılar = { 5, 6, 9, 12, 13, 17 };
            int i = 0;
            int toplam = 0;
            while(i<sayılar.Length)
            {
                if (sayılar[i] % 2 == 1)
                {
                    toplam += sayılar[i];
                }
                i++;
            }


            Console.WriteLine(toplam);*/


            int[] sayılar = { 1, 2, 3, 9, 27, 52 };
            int toplam = 0;
            int i = 0;
            while (i < sayılar.Length) 
           {
                sayılar[i] % 2 == 1 ? toplam += sayılar[i] : .......... ;

                i++;
            }
            Console.WriteLine(toplam);

        }

    }
}