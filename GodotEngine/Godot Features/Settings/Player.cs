//Управление персонажа
//Character Management
using Godot;
using System;

public class Player : KinematicBody2D
{
	[Export]
	public int speed = 150;
	public int gravity = 400;
	public int jump = 400;

	Vector2 velocity;

	public override void _PhysicsProcess(float delta)
	{

		var animatedplayer = GetNode<AnimatedSprite>("AnimatedSprite");

		if (Input.IsActionPressed("ui_left"))
		{
			animatedplayer.Animation = "Run";
			animatedplayer.FlipH = true;
			velocity.x = -speed;			
		}
		else if (Input.IsActionPressed("ui_right"))
		{
			animatedplayer.Animation = "Run";
			animatedplayer.FlipH = false;
			velocity.x = speed;
		}
		else
		{
			velocity.x = 0;
		}

		velocity = MoveAndSlide(velocity, new Vector2(0, -1));

		velocity.y += gravity * delta;

		if (Input.IsActionPressed("ui_up") && IsOnFloor())
		{
			velocity.y -= jump;
		}
	}
}
