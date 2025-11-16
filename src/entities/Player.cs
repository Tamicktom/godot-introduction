using Godot;
using System;

namespace Game.Entities;

public partial class Player : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		int number = Conversor.SafeToInt("123");
		GD.Print("Number: " + number);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// this.Position = new Vector2(this.Position.X + 1, this.Position.Y);
		// GD.Print("Position: " + this.Position, "Delta: " + delta);w
	}
}
