public class drawboad{

public static void Main(string[] args){


int[,] Intarr = {{2,2,0}, {1,0,0}, {0,1,0}};

drawboad Ndrawboard = new drawboad();
Ndrawboard.drawfullboard(Intarr);
    
}


public void drawfullboard(int[,] arr){


/*
   a     b     c
      |     |     
1  -  |  -  |  -  
 _____|_____|_____
      |     |     
2  -  |  -  |  -  
 _____|_____|_____
      |     |     
3  -  |  -  |  -  
      |     |     

*/

int a1 = arr[0,0];
int a2 = arr[0,1];
int a3 = arr[0,2];
int b1 = arr[1,0];
int b2 = arr[1,1];
int b3 = arr[1,2];
int c1 = arr[2,0];
int c2 = arr[2,1];
int c3 = arr[2,2];



Console.WriteLine
("""
             
      |     |     
   {0}  |  {1}  |  {2}  
 _____|_____|_____
      |     |     
   {3}  |  {4}  |  {5}  
 _____|_____|_____
      |     |     
   {6}  |  {7}  |  {8}  
      |     |     
""", Result(a1), Result(a3), Result(a3), Result(b1), Result(b2), Result(b3), Result(c1), Result(c2), Result(c3));




}

public string Result(int a){

if(a==1)
return "X";
if(a==2)
return "O";

return "-";

}

}