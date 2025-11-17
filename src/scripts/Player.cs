//* Libraries imports
using Godot;

namespace Game.Scripts;

public partial class Player : CharacterBody2D
{
	public const float Speed = 300.0f;

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
}
