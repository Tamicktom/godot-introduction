using Godot;
using System;

namespace Game.Entities;

public partial class Player : CharacterBody2D
{
	[Export]
	public int Speed { get; set; } = 10;

	[Export]
	public int Score { get; set; } = 0;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		int number = Conversor.SafeToInt("123");
		GD.Print("Number: " + number);
	}

	// Called every physics frame. 'delta' is the elapsed time since the previous frame.
	public override void _PhysicsProcess(double delta)
	{
		// Position = new Vector2((this.Position.X + 1) * (float)delta, this.Position.Y);
		// GD.Print("Position: " + this.Position, "Delta: " + delta);

		// this.Velocity = new Vector2(1, 0) * Speed;
		// this.MoveAndSlide();

		Vector2 direction = new(1, 1);
		Position += direction * Speed * (float)delta;

		GD.Print("Position: " + this.Position, "Delta: " + delta);
	}

	public override void _Process(double delta)
	{
		GD.Print("Score: " + Score);
	}

	public void AddScore(int value)
	{
		Score += value;
		GD.Print("Score: " + Score);
	}
}
