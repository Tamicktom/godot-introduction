using Godot;
using System;
using Game.Scripts;

namespace Game.Entities;

public partial class Coin : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void OnBodyEntered(Node2D body)
	{
		GD.Print("Body entered: " + body.Name);
		if (body.IsInGroup("Player"))
		{
			body.GetNode<Game.Scripts.Player>("Player").AddScore(1);
		}
	}
}
