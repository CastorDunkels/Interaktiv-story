using System.Threading;
using System;
void exitprogram(){             //en funktion/metod som man kan skriva istället för att skriva både cr och e.ex 
    Console.ReadLine();
    Environment.Exit(0);
}
Boolean repeat = true;     //ställer om första fråga om  man skrev något fel först och sen sa ja till andra frågan
while(repeat){                  
    Console.WriteLine("Do you want to interact with this program? yes or no:");

    string firstquestion = Console.ReadLine();

    firstquestion = firstquestion.ToLower();   //detta gör så att man kan skriva med stora eller små bokstäver

    if (firstquestion == "no"){
        Environment.Exit(0);
    }
    else if(firstquestion == "yes"){
        repeat = false;         //detta gör så att loopen slutar
    }
    else if(firstquestion != "yes" || firstquestion != "no"){
        Console.WriteLine("I said yes or no");    
        Console.WriteLine("Do you want to try again?");
        string repeatquestion = Console.ReadLine();   
        repeatquestion = repeatquestion.ToLower();  //detta gör så att man kan skriva med stora eller små bokstäver
        if(repeatquestion == "yes"){
        }
        else if(repeatquestion != "yes"){
            exitprogram();
        }
    }
}
Console.WriteLine("You wake up to notice that you are standing in the forest on a path that divides into two paths");
Boolean repeattwo = true;
while(repeattwo){               //ställer frågan igen om man skriver något som inte är det man ska skriva
    Console.WriteLine("Do you want to Walk left or right?");

    string direction = Console.ReadLine();

    direction = direction.ToLower();        //detta gör så att man kan skriva med stora eller små bokstäver
    if(direction == "right"){
        Console.WriteLine("Are you sure you want to go right? yes or no:");
        string confirm = Console.ReadLine();
        if(confirm == "yes"){
            Console.WriteLine("You decided to go right");
            repeattwo = false;        //detta gör så att loopen slutar
        }
        else if(confirm == "no"){
            Console.WriteLine("You decided to go left");
            repeattwo = false;      //detta gör så att loopen slutar
        }
    }

    else if(direction == "left"){
        Console.WriteLine("Are you sure you want to go left? yes or no:");
        string confirm = Console.ReadLine();
        confirm = confirm.ToLower();        //detta gör så att man kan skriva med stora eller små bokstäver
        if(confirm == "yes"){
            Console.WriteLine("You decided to go left");
            repeattwo = false;          //detta gör så att loopen slutar
        }
        else if(confirm == "no"){
            Console.WriteLine("Are you sure you don't want to go left? yes or no:");
            confirm = Console.ReadLine();
            confirm = confirm.ToLower();            //detta gör så att man kan skriva med stora eller små bokstäver
            if(confirm == "yes"){
                Console.WriteLine("You decided to go right");
                repeattwo = false;         //detta gör så att loopen slutar
            }
            else{
                Console.WriteLine("As you just stay still and contemplating wether or not to walk, you wake up and realise that it was just a dream");
                Console.WriteLine("The end");
                exitprogram();
            
            }            
        }

    }
}

Console.WriteLine("You notice that both paths lead to the same place which is a bench made of chicken nuggets");
Boolean benchrepeat = true;    //ställer frågan igen om man skriver något som man inte ska
while(benchrepeat){
    Console.WriteLine("Do you want to sit down? yes or no:");
    string benchchoice = Console.ReadLine();
    benchchoice = benchchoice.ToLower();        //detta gör så att man kan skriva med stora eller små bokstäver
    if(benchchoice == "yes"){
        Console.WriteLine("You sat on the bench made of chicken nuggets");
        Console.WriteLine("You slowly sink into the bench and become part of it");
        Console.WriteLine("The end:");
        benchrepeat = false;         //detta gör så att loopen slutar
    }
    if(benchchoice == "no"){
        Console.WriteLine("You decided to not sit on the bench");
        benchrepeat = false;        //detta gör så att loopen slutar
    }
}
Boolean threechoicesrepeat = true;  //ställer frågan igen om man skriver något man inte ska
while(threechoicesrepeat){
    Console.WriteLine("What do you want to do now? 1: to go back, 2: to go past the bench, 3: to destroy the bench");
    string secondbenchchoice = Console.ReadLine();
    if(secondbenchchoice == "1"){
        Console.WriteLine("You find that the path behind you has dissapeard and a dark purple chasm has taken its place");
        Console.WriteLine("You feel the need to jump in");
        Boolean jumprepeat = true;      //ställer frågan igen om man skriver något man inte ska
        while(jumprepeat){
            Console.WriteLine("Jump?");
            threechoicesrepeat = false;     //detta gör så att loopen slutar
            string jump = Console.ReadLine();
            jump = jump.ToLower();              //detta gör så att man kan skriva med stora eller små bokstäver
            if(jump == "jump" || jump == "yes" || jump == "yea" || jump == "sure" || jump == "ja" || jump == "yepp" || jump == "jeff" || jump == "hoppa" || jump == "ligma" || jump == "amogus"){
                Console.WriteLine("As you jump, you start to feel a force dragging you upward into a bright light where you hear people talking.");
                Console.WriteLine("You wake up just as a doctor is telling your family that you can't be saved.");
                Console.WriteLine("The end"); 
                jumprepeat = false;     //detta gör så att loopen slutar
            }
            if(jump == "no" || jump == "turn back" || jump == "nope" || jump == "nej" || jump == "noo" || jump == "nooo" || jump == "noooo" || jump == "do not jump"){
                Console.WriteLine("You turn back and realise that everything is completely black and you can't feel anything.");
                Console.WriteLine("As you try to move you, realise that you do not exist anymore, only your mind.");
                Console.WriteLine("You realise that you will be stuck in this state of existance forever");
                Console.WriteLine("The end");
                jumprepeat = false;         //detta gör så att loopen slutar
            }
        }
    }
    if(secondbenchchoice == "2"){
        Console.WriteLine("As you walk past the chair you feel what feels like a hand grab you.");
        Console.WriteLine("You die instantly from the immense force of the thing grabbing you");
        Console.WriteLine("The end");
        threechoicesrepeat = false;         //detta gör så att loopen slutar
    }
    if(secondbenchchoice == "3"){
        Console.WriteLine("As you try to kick the bench your foot gets stuck and pulls you into the bench which consumes you.");
        Console.WriteLine("You live for 10 seconds in excruciating pain");
        Console.WriteLine("The end");
        threechoicesrepeat = false;        //detta gör så att loopen slutar
    }
}
exitprogram();
