﻿using System;
using System.Collections.Generic;
using CastleGrimtol.Game;

namespace CastleGrimtol
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Game.Game game = new Game.Game();
      Boolean playing = true;

      game.Setup();
      game.BuildRooms();
      Console.ForegroundColor = ConsoleColor.Cyan;
      System.Console.WriteLine($"{game.CurrentRoom.Name}:\n{game.CurrentRoom.Description}");
      Console.ForegroundColor = ConsoleColor.White;

      while (playing)
      {

        string userChoice = game.GetUserInput().ToLower();
        string[] userAction = userChoice.Split(' '); 
        Room nextRoom;
        game.CurrentRoom.Exits.TryGetValue(userAction[0], out nextRoom);

        if (userAction[0] == "l" || userAction[0] == "look")
        {
          System.Console.WriteLine("\n");
          game.Look(game.CurrentRoom);
        }
        else if (userAction[0] == "h" || userAction[0] == "help")
        {
          game.Help();
        }
        else if (userAction[0] == "t" || userAction[0] == "take" && userAction[1] != null)
        {
          System.Console.WriteLine(userAction[1]);
          game.UseItem(userAction[1]);
        }
        else if (userAction[0] == "i" || userAction[0] == "inventory")
        {
          System.Console.WriteLine("Inventory");
        }
        else if (userAction[0] == "q" || userAction[0] == "quit")
        {
          playing = game.Quit(playing);
        }
        else if (nextRoom != null)
        {
          game.CurrentRoom = nextRoom;
          System.Console.WriteLine("\n");
          game.Look(game.CurrentRoom);
        }
        else
        {
          System.Console.WriteLine("After attempting...you realize this is not the action you wanted to take. You should try again.\n");
        }
      }
    }
  }
}
