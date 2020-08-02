using Godot;
using System;

//Полноэкранный режим на C# в Godot
//Full-screen mode in C# in Godot

public class Setting : Node2D
{
	public override void _Ready()
	{
  //Получаем Node
  //Getting Node
		GetNode("FullScreen").Connect("pressed", this, nameof(_FullScreen));
	}

	private void _FullScreen()
	{
  //Активируем метод фуллскрина (Автоматический режим (true/false)
  //Activating the fullscreen method (Automatic mode (true/false)
		OS.WindowFullscreen = !OS.WindowFullscreen;
	}
}


