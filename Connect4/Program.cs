using System;
using System.Text.RegularExpressions;

namespace TikTak;

public class drawboad{


public static void Main(string[] args){


int[,] Intarr = {{2,2,0}, {1,0,0}, {0,1,0}};

drawboad Ndrawboard = new drawboad();

bool keepPlaying = true;
while(true)
{
Ndrawboard.drawfullboard(Intarr);
Ndrawboard.play(Intarr, 1);
Ndrawboard.win(Intarr);
Ndrawboard.drawfullboard(Intarr);
Ndrawboard.play(Intarr, 2);
Ndrawboard.win(Intarr);
}
    
}


public void drawfullboard(int[,] arr){


/*
   1     2     3
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
     0    1     2
       |     |     
0   {0}  |  {1}  |  {2}  
  _____|_____|_____
       |     |     
1   {3}  |  {4}  |  {5}  
  _____|_____|_____
       |     |     
2   {6}  |  {7}  |  {8}  
       |     |     
""", Result(a1), Result(a3), Result(a3), Result(b1), Result(b2), Result(b3), Result(c1), Result(c2), Result(c3));




}

public bool win(int[,] arr)
{



      //won in a row
      if (arr[0,0] == arr[0,1] && arr[0,0] == arr[0,2] && arr[0,0] != 0){Console.WriteLine("Player {0} wins!", arr[0,0]); return true;} 
      if (arr[1,0] == arr[1,1] && arr[0,0] == arr[1,2] && arr[1,0] != 0){Console.WriteLine("Player {0} wins!", arr[1,0]); return true;} 
      if (arr[2,0] == arr[2,1] && arr[0,0] == arr[2,2] && arr[2,0] != 0){Console.WriteLine("Player {0} wins!", arr[2,0]); return true;} 
      
      //won in a colomn
      if (arr[0,0] == arr[1,0] && arr[0,0] == arr[2,0] && arr[0,0] != 0){Console.WriteLine("Player {0} wins!", arr[0,0]); return true;} 
      if (arr[0,1] == arr[1,1] && arr[0,1] == arr[2,1] && arr[0,1] != 0){Console.WriteLine("Player {0} wins!", arr[0,1]); return true;} 
      if (arr[0,2] == arr[1,2] && arr[0,2] == arr[2,2] && arr[0,2] != 0){Console.WriteLine("Player {0} wins!", arr[0,2]); return true;} 

      //diagonal win
      if (arr[0,0] == arr[1,1] && arr[0,0] == arr[2,2] && arr[0,0] != 0){Console.WriteLine("Player {0} wins!", arr[0,0]); return true;} 
      if (arr[0,2] == arr[1,1] && arr[0,2] == arr[2,0] && arr[0,2] != 0){Console.WriteLine("Player {0} wins!", arr[0,2]); return true;} 
      
      //if none are true
      return false;

}
public int[,] play(int[,] arr, int PID)
{    
      bool validInput = false;
      while(validInput == false)
      try{
            /*
            Regex regex = new Regex(@"/d/d");
            string playerInput = Console.ReadLine(); 
            int row = int.Parse(playerInput[0]);
            int colomn = int.Parse(playerInput[1]);
            */
            Console.WriteLine("Input Row:");
            int row    = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Input Colum:");
            int colomn = int.Parse(Console.ReadLine()!);

            if(arr[row,colomn] == 0)
            {
                  arr[row,colomn] = PID;
                  return arr;
            }
            else throw(Exception e)
      }
      catch(Exception e)
      {
            Console.WriteLine("Bad input try RoWColomn. Example: 11 or 22");

      }


}

public string Result(int a){
if(a==1)
return "X";
if(a==2)
return "O";

return "-";

}



}