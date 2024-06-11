using Godot;
using System;

public partial class Player : CharacterBody2D
{
	private const int cellsize = 64;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
		GD.Print("Do I print?");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public override void _Input(InputEvent @event)
	{
		if(@event is InputEventKey keyEvent && keyEvent.Pressed)
		{
			if(keyEvent.Keycode == Key.H)
			{
				this.Position = new Vector2(this.Position.X - cellsize, this.Position.Y);
				GD.Print("H");
			}
			if(keyEvent.Keycode == Key.J)
			{
				this.Position = new Vector2(this.Position.X, this.Position.Y + cellsize);
				GD.Print("J");
			}       
			if(keyEvent.Keycode == Key.K)
			{
				this.Position = new Vector2(this.Position.X, this.Position.Y - cellsize);
				GD.Print("K");
			}
			if(keyEvent.Keycode == Key.L)
			{
				this.Position = new Vector2(this.Position.X + cellsize, this.Position.Y);
				GD.Print("L");
			}
		}
		
	}
}
