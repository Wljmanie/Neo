using Godot;
using System;

public partial class Player : CharacterBody2D
{
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
				GD.Print("H");
			}
			if(keyEvent.Keycode == Key.J)
			{
				GD.Print("J");
			}       
			if(keyEvent.Keycode == Key.K)
			{
				GD.Print("K");
			}
			if(keyEvent.Keycode == Key.L)
			{
				GD.Print("L");
			}
		}
		
	}
}
