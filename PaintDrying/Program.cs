using static System.Console;

namespace PaintDrying;

class Program
{
	static void Main(string[] args)
	{
		ShowMainMenu();
	}

	private static void ShowMainMenu()
	{
		Menu mainMenu = new Menu(
			"""
		          Main Menu!
		          Choose an option:
		          """, 
			["Play","Info","Exit"]);
		                       

		switch (mainMenu.Run())
		{
			case 0:
				ShowColorSelection();
				break;
			case 1:
				Info();
				break;
			case 2:
				Environment.Exit(0);
				break;
		}
	}

	private static void ShowColorSelection()
	{
		Menu colorSelection = new Menu(
			"""
		          Color selection!
		          Select a color: 
		          """,
			[
				"Red", 
				"Blue", 
				"Green",
				"Yellow",
				"Cyan",
				"Magenta",
				"Dark blue",
				"Dark red",
				"Dark green",
				"Dark magenta",
				"Dark yellow",
				"Dark cyan",
				"Dark gray",
				"Gray",
				"White",
				"Black"
			]);
		
		switch (colorSelection.Run())
		{
			case 0:
				ShowPaint(ConsoleColor.Red);
				break;
			case 1:
				ShowPaint(ConsoleColor.Blue);
				break;
			case 2:
				ShowPaint(ConsoleColor.Green);
				break;
			case 3:
				ShowPaint(ConsoleColor.Yellow);
				break;
			case 4:
				ShowPaint(ConsoleColor.Cyan);
				break;
			case 5:
				ShowPaint(ConsoleColor.Magenta);
				break;
			case 6:
				ShowPaint(ConsoleColor.DarkBlue);
				break;
			case 7:
				ShowPaint(ConsoleColor.DarkRed);
				break;
			case 8:
				ShowPaint(ConsoleColor.DarkGreen);
				break;
			case 9:
				ShowPaint(ConsoleColor.DarkMagenta);
				break;
			case 10:
				ShowPaint(ConsoleColor.DarkYellow);
				break;
			case 11:
				ShowPaint(ConsoleColor.DarkCyan);
				break;
			case 12:
				ShowPaint(ConsoleColor.DarkGray);
				break;
			case 13:
				ShowPaint(ConsoleColor.Gray);
				break;
			case 14:
				ShowPaint(ConsoleColor.White);
				break;
			case 15:
				ShowPaint(ConsoleColor.Black);
				break;
		}
	}

	private static void ShowPaint(ConsoleColor color)
	{
		BackgroundColor = color;
		Clear();
		WriteLine("""
		          
		          """);
		ResetColor();
		SetCursorPosition(0, WindowHeight - 1);
		Write("Press any key to go back to main menu...");
		CursorVisible = false;
		ReadKey();
		CursorVisible = true;
		ShowMainMenu();
	}

	private static void Info()
	{
		Clear();
		WriteLine(
			"""
			Info:
			In this game the objective is to watch paint dry.
			That's it!
			Press any key to go back...
			"""
		);
		ReadKey();
		ShowMainMenu();
	}
	
}