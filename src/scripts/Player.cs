//* Libraries imports
using Godot;

namespace Game.Scripts;

public partial class Player : CharacterBody2D
{
	[Export]
	public float Speed { get; set; } = 100.0f;

	[Export]
	public int Score { get; set; } = 0;

	public override void _Ready()
	{
		// add the player to the global group
		GetTree().Root.AddToGroup("Player");
	}

	public override void _PhysicsProcess(double delta)
	{
		// Get the input direction and handle the movement/deceleration.
		// As good practice, you should replace UI actions with custom gameplay actions.
		Vector2 direction = Input.GetVector(
			Controls.LEFT.ToString(),
			Controls.RIGHT.ToString(),
			Controls.UP.ToString(),
			Controls.DOWN.ToString()
		);

		Velocity = direction * Speed;

		MoveAndSlide();
	}

	public override void _Process(double delta)
	{
		// GD.Print("Score: " + Score);
	}

	public void AddScore(int value)
	{
		Score += value;
		GD.Print("Score: " + Score);
	}
}
