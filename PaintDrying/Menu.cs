using System.Diagnostics;
using static System.Console;

namespace PaintDrying;

public class Menu
{
	
	public ConsoleKey UpKey = ConsoleKey.UpArrow;
	public ConsoleKey DownKey = ConsoleKey.DownArrow;
	public ConsoleKey EnterKey = ConsoleKey.Enter;
	
	private string prompt;
	private string[] options;
	private int selectedIndex = 0;

	private int optionsStartAt = 0;
	public Menu(string prompt, string[] options)
	{
		this.prompt = prompt;
		this.options = options;
	}

	public int Run()
	{
		Display();
		CursorVisible = false;
		ConsoleKey pressedKey;
		do
		{
			int oldSelectedIndex = selectedIndex;
			pressedKey = ReadKey().Key;

			if (pressedKey == UpKey)
			{
				selectedIndex--;
				if (selectedIndex < 0)
				{
					selectedIndex = options.Length - 1;
				}
			}
			else if (pressedKey == DownKey)
			{
				selectedIndex++;
				if (selectedIndex > options.Length - 1)
				{
					selectedIndex = 0;
				}
			}

			DisplayOption(oldSelectedIndex);
			DisplayOption(selectedIndex);

		} while (pressedKey != EnterKey);

		CursorVisible = true;
		SetCursorPosition(0, optionsStartAt + options.Length);
		return selectedIndex;
	}

	private void Display()
	{
		Clear();
		WriteLine(prompt);
		optionsStartAt = GetCursorPosition().Top;
		for (int i = 0; i < options.Length; i++)
		{
			DisplayOption(i);
		}
	}

	private void DisplayOption(int optionIndex)
	{
		
		SetCursorPosition(0, optionsStartAt + optionIndex);
		if (optionIndex==selectedIndex)
		{
			ForegroundColor = ConsoleColor.Black;
			BackgroundColor = ConsoleColor.White;
		}
		else
		{
			ResetColor();
		}
		WriteLine($" << {options[optionIndex]} >> ");
		ResetColor();
	}

}