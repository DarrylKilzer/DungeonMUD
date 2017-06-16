using System;
using System.Collections.Generic;

namespace CastleGrimtol.Game
{
  public class Game : IGame
  {
    public Room CurrentRoom { get; set; }
    public Player CurrentPlayer { get; set; }
    public void Setup()
    {
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("\n-----------DungeonZ-----------\n");
      Console.WriteLine("Welcome to the warrens of Emirkol the Chaotic!\n");
      Console.ForegroundColor = ConsoleColor.White;
      CurrentPlayer = new Player();
      Help();
    }
    public string GetUserInput()
    {
      System.Console.WriteLine("What would you like to do?");
      string input = Console.ReadLine();
      return input;
    }
    public void Reset()
    {

    }
    public void UseItem(string itemName)
    {

    }
    public Boolean Quit()
    {
        Boolean playing;
      System.Console.WriteLine("Leave the game? All progress will be lost. Y/N");
      string input = Console.ReadLine().ToLower();
      if (input == "y" || input == "yes")
      {
        return playing = false;
      }
      else
      {
        System.Console.WriteLine("OK");
        return playing = true;
      }
    }
    public void Look(Room room)
    {
      Console.ForegroundColor = ConsoleColor.Cyan;
      System.Console.WriteLine($"{room.Name}:\n{room.Description}");
      Console.ForegroundColor = ConsoleColor.White;
    }
    public void Help()
    {
      System.Console.WriteLine("Valid actions are direction number of the exit.\nEX: East 1 or e1.\nLOOK or l: which allows you to search the room for treasure, but you may disturb something...\nHELP or h: which displays this help list.\nTAKE or t: which takes an item and adds it to your inventory. EX: Take Gold.\nINVENTORY or i: Views the items in your inventory.\nQUIT or q: leaves the game.\n");
    }
    public void BuildRooms()
    {

      Room room1 = new Room("Room 1", "Spirals of green stones cover the floor, A circle of tall stones stands in the east side of the room. Exits: East 1, East 2, South 1, South 2.\n");
      Room room2 = new Room("Room 2", "An altar of evil sits in the center of the room. You notice a pile of iron spikes lies in the north side of the room. Exits: West 1, East 1, East 2.\n");
      Room room3 = new Room("Room 3", "Someone has scrawled \"Run Away!\" in goblin runes on the north wall, Several pieces of trash are also strewn about the room. Exits: West 1, East 1, East 2, East 3, South 1.\n");
      Room room4 = new Room("Room 4", "You immediately notice the ceiling is covered in cob webs. The words \"Don't Sleep\" are etched into the East wall. Exits: West 1, West 2, East 1, South 1.\n");
      Room room5 = new Room("Room 5", "A chute descends from the room into a midden chamber below, it is too small to fit through, not that you want to. The scent of urine fills the room. Exits: East 1, South 1.\n");
      Room room6 = new Room("Room 6", "This room lacks any discernable features. Exits: West 1, East 1.\n");
      Room room7 = new Room("Room 7", "A group of draconic faces have been carved into the South wall. Near your feet you notice the words \"Kunarv was here\". Exits: West 1, South 1.\n");
      Room room8 = new Room("Room 8", "Some small piles of stone rubble ornament the floor. Exits: North 1, West 1, East 1, East 2, South 1, South 2.\n");
      Room room9 = new Room("Room 9", "The floor is smooth, but the walls of this room appear to be less worked and rough. Exits: East 1, East 2.\n");
      Room room10 = new Room("Room 10", "Several iron cages are scattered throughout the room. A pile of torn paper lies in the north-west corner of the room. Exits: West 1, East 1.\n");
      Room room11 = new Room("Room 11", "Dark moss partially covers the walls, even the air feels rather damp. Exits: North 1, North 2, West 1, West 2.\n");
      Room room12 = new Room("Room 12", "Dimly lit, and longer than most of the rooms, this one almost appears to be a slightly larger hallway. Exits: West 1, West 2, South 1.\n");
      Room room13 = new Room("Room 13", "Corpses, too badly decayed to discern what they once were, lay randomly about the room. Exits: North 1, East 1, South 1, West 1.\n");
      Room room14 = new Room("Room 14", "A tile labyrinth covers the floor, intricately and deliberatly installed. A shatter sword lies in ruin in the north-west corner. Exits: North 1.\n");
      Room room15 = new Room("Room 15", "The floor is covered in mud. Several sundered shields lay scattered about. Exits: East 1, East 2, South 1.\n");
      Room room16 = new Room("Room 16", "A set of frightening demonic war masks hang on the east wall. A rotting carpet and a small table sit in the west side of the room. Exits: North 1, North 2.\n");
      Room room17 = new Room("Room 17", "Someone has scrawled \"Twist the cog to reset the trap\" in dwarvish runes on the north wall. A corroded chain lies in the northwest corner of the room. Exits: North 1, West 1, South 1.\n");
      Room room18 = new Room("Room 18", "A magical statue in the south-west corner of the room answers questions with insults, A group of demonic faces have been carved into the east wall. Exits: West 1, South 1.\n");
      Room room19 = new Room("Room 19", "Empty, other than small splinters of wood. Exits: North 1, West 1, East 1.\n");
      Room room20 = new Room("Room 20", "A stone sarcophagus sits in the south-east corner of the room, A cold spot can be felt in the west side of the room. Exits: North 1, West 1, South 1, South 2.\n");
      Room room21 = new Room("Room 21", "A fountain of water sits against the west wall, The sound of drums fills the room. Exits: North 1, North 2.\n");
      Room room22 = new Room("Room 22", "Ugly paintings adorn the wall, the materials they are made out of is questionable. Exits: North 1, North 2, East 1, East 2, East 3.\n");
      Room room23 = new Room("Room 23", "A plain room, with a rather high ceiling. Exits: North 1, West 1, East 1, South 1.\n");
      Room room24 = new Room("Room 24", "Small ornamental tapestries decorate the walls in an unorganized manner. Exits: North 1, West 1, East 1.\n");
      Room room25 = new Room("Room 25", "The floor is flaked with odd spots of rust. Exits: North 1, East 1, East 2, South 1, South 2.\n");
      Room room26 = new Room("Room 26", "Spirals of red stones cover the floor, Someone has scrawled a crude drawing of a succubus on the west wall. Exits: North 1, West 1, West 2, East 1, East 2.\n");
      Room room27 = new Room("Room 27", "A torn paper reads, \"Has anyone seen my invisible cloak?\", Several pieces of rotten rope are scattered throughout the room. Exits: North 1, West 1, East 1, East 2, South 1, South 2.\n");
      Room room28 = new Room("Room 28", "A set of brittle and corroded armor leans against the east wall. Exits: West 1, West 2, South 1, South 2.\n");
      Room room29 = new Room("Room 29", "A ruined siege weapon sits in the north-east corner of the room, etchings read, \"The Legion of the Ring looted this place\" in orcish runes on the east wall. Exits: West 1, West 2, East 1, South 1.\n");
      Room room30 = new Room("Room 30", "Various torture devices are scattered throughout the room, strange writing covers most of the east wall. Exits: West 1, East 1, East 2, East 3, South 1, South 2.\n");
      Room room31 = new Room("Room 31", "A narrow shaft descends from the room into a natural cavern below, A toppled statue lies in the north side of the room. Exits: West 1, East 1, East 2, South 1.\n");
      Room room32 = new Room("Room 32", "A simple wooden table and stuffed beast sit in the south-east corner of the room, The ceiling is covered with bloodstains. Exits: North 1, West 1.\n");
      Room room33 = new Room("Room 33", "A small spring bubbles up from the north corner of the room making most of the floor slick. Exits: North 1, West 1, East 1, South 1.\n");
      Room room34 = new Room("Room 34", "An upright sarcophagus leans against the west wall. Exits: North 1, West 1, South 1.\n");
      Room room35 = new Room("Room 35", "The floor is covered in square tiles, alternating white and black, \"It's a trap\" is scribbled in draconic script on the west wall. Exits: North 1, West 1, South 1.\n");
      Room room36 = new Room("Room 36", "A set of demonic war masks hangs on the east wall, A large kiln and coal bin sit in the south side of the room. Exits: North 1, West 1, West 2, East 1.\n");
      Room room37 = new Room("Room 37", "This room once had severl wood and iron doors, all of them now completely smashed about the room. Exits: North 1, West 1, West 2.\n");
      Room room38 = new Room("Room 38", "A stair ascends to a very unstable wooden platform in the east side of the room, A set of demonic war masks hangs on the east wall. Exits: North 1, East 1, South 1.\n");
      Room room39 = new Room("Room 39", "Lit candles are scattered across the floor, Someone has scrawled an arcane symbol on the east wall. Exits: North 1.\n");
      Room room40 = new Room("Room 40", "The south and west walls have been engraved with incoherent labyrinths, A shallow pool of oil lies in the east side of the room. Exits: North 1, West 1.\n");

      room1.AddDoor("east 1", room2);
      room1.AddDoor("east 2", room7);
      room1.AddDoor("south 1", room16);
      room1.AddDoor("south 2", room9);
      room2.AddDoor("west 1", room1);
      room2.AddDoor("east 1", room3);
      room2.AddDoor("east 2", room24);
      room3.AddDoor("west 1", room2);
      room3.AddDoor("east 1", room4);
      room3.AddDoor("east 2", room6);
      room3.AddDoor("east 3", room8);
      room3.AddDoor("south 1", room14);
      room4.AddDoor("west 1", room3);
      room4.AddDoor("west 2", room6);
      room4.AddDoor("south 1", room8);
      room4.AddDoor("east 1", room8);
      room5.AddDoor("east 1", room11);
      room5.AddDoor("south 1", room11);
      room6.AddDoor("west 1", room3);
      room6.AddDoor("east 1", room4);
      room7.AddDoor("west 1", room1);
      room7.AddDoor("south 1", room17);
      room8.AddDoor("north 1", room4);
      room8.AddDoor("west 1", room3);
      room8.AddDoor("east 1", room4);
      room8.AddDoor("east 2", room10);
      room8.AddDoor("south 1", room13);
      room8.AddDoor("south 2", room13);
      room9.AddDoor("east 1", room1);
      room9.AddDoor("east 2", room12);
      room10.AddDoor("west 1", room8);
      room10.AddDoor("east 1", room11);
      room11.AddDoor("north 1", room5);
      room11.AddDoor("north 2", room5);
      room11.AddDoor("west 1", room10);
      room11.AddDoor("west 2", room15);
      room11.AddDoor("south 1", room22);
      room12.AddDoor("west 1", room9);
      room12.AddDoor("west 2", room16);
      room12.AddDoor("south 1", room19);
      room13.AddDoor("north 1", room8);
      room13.AddDoor("east 1", room8);
      room13.AddDoor("south 1", room20);
      room13.AddDoor("west 1", room21);
      room14.AddDoor("north 1", room3);
      room15.AddDoor("east 1", room11);
      room15.AddDoor("east 2", room18);
      room15.AddDoor("south 1", room22);
      room16.AddDoor("north 1", room1);
      room16.AddDoor("north 2", room12);
      room17.AddDoor("north 1", room7);
      room17.AddDoor("west 1", room19);
      room17.AddDoor("south 1", room23);
      room18.AddDoor("east 1", room15);
      room18.AddDoor("south 1", room22);
      room19.AddDoor("north 1", room12);
      room19.AddDoor("east 1", room17);
      room19.AddDoor("west 1", room25);
      room20.AddDoor("north 1", room13);
      room20.AddDoor("south 1", room26);
      room20.AddDoor("south 2", room26);
      room20.AddDoor("west 1", room21);
      room21.AddDoor("north 1", room13);
      room21.AddDoor("north 2", room20);
      room22.AddDoor("north 1", room15);
      room22.AddDoor("north 2", room18);
      room22.AddDoor("east 1", room11);
      room22.AddDoor("east 2", room37);
      room22.AddDoor("east 3", room37);
      room23.AddDoor("north 1", room17);
      room23.AddDoor("east 1", room24);
      room23.AddDoor("west 1", room25);
      room23.AddDoor("south 1", room27);
      room24.AddDoor("north 1", room2);
      room24.AddDoor("east 1", room26);
      room24.AddDoor("west 1", room23);
      room25.AddDoor("north 1", room19);
      room25.AddDoor("east 1", room23);
      room25.AddDoor("east 2", room27);
      room25.AddDoor("south 1", room31);
      room25.AddDoor("south 2", room32);
      room26.AddDoor("north 1", room20);
      room26.AddDoor("east 1", room20);
      room26.AddDoor("east 2", room28);
      room26.AddDoor("west 1", room24);
      room26.AddDoor("west 2", room27);
      room27.AddDoor("north 1", room23);
      room27.AddDoor("east 1", room26);
      room27.AddDoor("east 2", room29);
      room27.AddDoor("south 1", room31);
      room27.AddDoor("south 2", room35);
      room27.AddDoor("west 1", room25);
      room28.AddDoor("south 1", room33);
      room28.AddDoor("south 2", room34);
      room28.AddDoor("west 1", room26);
      room28.AddDoor("west 2", room30);
      room29.AddDoor("east 1", room30);
      room29.AddDoor("south 1", room39);
      room29.AddDoor("west 1", room27);
      room29.AddDoor("west 2", room35);
      room30.AddDoor("east 1", room28);
      room30.AddDoor("east 2", room33);
      room30.AddDoor("east 3", room36);
      room30.AddDoor("south 1", room40);
      room30.AddDoor("south 2", room36);
      room30.AddDoor("west 1", room29);
      room31.AddDoor("east 1", room32);
      room31.AddDoor("east 2", room27);
      room31.AddDoor("south 1", room38);
      room31.AddDoor("west 1", room25);
      room32.AddDoor("west 1", room31);
      room32.AddDoor("north 1", room25);
      room33.AddDoor("north 1", room28);
      room33.AddDoor("east 1", room34);
      room33.AddDoor("south 1", room36);
      room33.AddDoor("west 1", room30);
      room34.AddDoor("north 1", room28);
      room34.AddDoor("west 1", room33);
      room34.AddDoor("south 1", room37);
      room35.AddDoor("north 1", room29);
      room35.AddDoor("south 1", room40);
      room35.AddDoor("west 1", room38);
      room36.AddDoor("north 1", room33);
      room36.AddDoor("east 1", room37);
      room36.AddDoor("west 1", room30);
      room36.AddDoor("west 2", room30);
      room37.AddDoor("north 1", room34);
      room37.AddDoor("west 1", room36);
      room37.AddDoor("west 2", room22);
      room38.AddDoor("north 1", room31);
      room38.AddDoor("east 1", room35);
      room38.AddDoor("south 1", room35);
      room39.AddDoor("north 1", room29);
      room40.AddDoor("north 1", room30);
      room40.AddDoor("west 1", room35);
      CurrentRoom = room1;
    }
  }
}