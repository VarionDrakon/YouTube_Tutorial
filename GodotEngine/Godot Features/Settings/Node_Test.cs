using Godot;
using System;

public class Node_Test : Node
{
	private void _on_Button_Show_pressed()
	{
		GetNode<Control>("Button_Show").Hide();
		GetNode<Control>("Button_Hide").Show();

		var Animated = GetNode<AnimationPlayer>("AnimationPlayer");
		Animated.Play("Playing");
	}


	private void _on_Button_Hide_pressed()
	{
		GetNode<Control>("Button_Show").Show();
		GetNode<Control>("Button_Hide").Hide();

		var Animated = GetNode<AnimationPlayer>("AnimationPlayer");
		Animated.Play("Backed");
	}
}



