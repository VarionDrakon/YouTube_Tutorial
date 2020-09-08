using Godot;
using System;

public class GUI : Label
{

	public override void _Ready()
	{
		GetNode("Button_Menu").Connect("pressed", this, nameof(_on_Button_Menu_pressed));
			
	}

	private void _on_Button_Menu_pressed()
	{
		GetTree().ChangeScene("res://Scenes_Scripts/Main_menu.tscn");
	}
}
