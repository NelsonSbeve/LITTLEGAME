using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;


class Caracter{

public string name{get; set;}
public string gender{get; set;}
public int health{get; set;}
public Caracter(string name, string gender, int health = 100){

    this.name = name;
    this.gender = gender;
    this.health = health;
}
}

class Combat{
 
    public int attack{get; set;}
    public int defend{get; set;}
    

    public Combat(int attack, int defend){
        var rand = new Random();
        this.attack =  rand.Next(10);
        this.defend =  rand.Next(5);
        
    }
    
    public int Damage(int hp){
        if(attack == 0){
            return defend;
        }else{

            hp = hp-attack;
            return hp;
        }
    }

}





class Game
{
    static void Main(string[] args)
    {   


        void SlowPrint(string msg, int delay) {
	    foreach (char c in msg.ToCharArray()) {
		        Console.Write(c);
		        Thread.Sleep(delay);
            }
	        Console.WriteLine();
        }

      string name;
      string gender;
      Console.WriteLine("Enter your name: ");
      name = Console.ReadLine();
      Console.WriteLine("Enter your Gender: ");
      gender = Console.ReadLine();

      Caracter Hero = new Caracter(name, gender);
      
      SlowPrint("Caracter sucessfully Created\nWelcome "+ name, 120);
      Thread.Sleep(700);
      Console.Clear();
      SlowPrint("Welcome to Battlemania "+name+", you will face enemys, you can attack or defend good luck", 120);
      Thread.Sleep(700);
      Console.Clear();
      SlowPrint("First combat starts!!!!", 120);
      Thread.Sleep(700);
      Console.Clear();

    }
}