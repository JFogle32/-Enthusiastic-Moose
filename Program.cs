﻿using System;

Main();

void Main()
{
    magicMoose();
//     Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
//     Console.WriteLine("--------------------------------------------");
//     Console.WriteLine();

//     // Let the moose speak!
//     MooseSays("H I, I'M  E N T H U S I A S T I C !");
//     MooseSays("I really am enthusiastic");

//     // As a question
//     CanadaQuestion();
//     EnthusiasticQuestion();
//     LoveCSharpQuestion();
//     SecretQuestion();
// }
}
// void ifElse(bool question,string mTrue,string mFalse){
//  if(question){
//      MooseSays(mTrue);
//  }
//  else{
//      MooseSays(mFalse);
//  }
// }
// As a question
// void CanadaQuestion()
// {
//     bool isTrue = MooseAsks("Is Canada real?");
//     ifElse(isTrue,"Really? It seems very unlikely.","I  K N E W  I T !!!");
// }

// void EnthusiasticQuestion()
// {
//     bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
//     ifElse(isEnthusiastic,"Yay!","You should try it!");
// }

// void LoveCSharpQuestion()
// {
//     bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
//     ifElse(doesLoveCSharp,"Good job sucking up to your instructor!","You will...oh, yes, you will..."); 
// }

// void SecretQuestion()
// {
//     bool wantsSecret = MooseAsks("Do you want to know a secret?");
//     ifElse(wantsSecret,"ME TOO!!!! I love secrets...tell me one!","Oh, no...secrets are the best, I love to share them!");
// }


void MooseSays(string message)
{
    Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

// bool MooseAsks(string question)
// {
//     Console.Write($"{question} (Y/N): ");
//     string answer = Console.ReadLine().ToLower();

//     while (answer != "y" && answer != "n")
//     {
//         Console.Write($"{question} (Y/N): ");
//         answer = Console.ReadLine().ToLower();
//     }

//     if (answer == "y")
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }


void magicMoose(){
    Console.Write("Ask me a question:");
    string question=Console.ReadLine().ToLower();
    string[] answersArr= {"As I see it, yes.","Ask again later.","Better not tell you now.","Cannot predict now.","Concentrate and ask again.","Don’t count on it.","Don’t count on it.","It is decidedly so.","Most likely.","My reply is no.","My sources say no.","Outlook not so good.","Outlook good.","Reply hazy, try again.","Signs point to yes.","Very doubtful.","Without a doubt.","Yes.","Yes – definitely.","You may rely on it."};
    if(question !="")
    {
        int arrPosition=new Random().Next(0,20);
        MooseSays(answersArr[arrPosition]);
        magicMoose();
    }

}