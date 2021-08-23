using Godot;
using System;

public class Lantern : Spatial
{
	private float time = 0.0f;
	private OmniLight light = null;
	[Export] public float scale = 4.0f;
	[Export] public float energy = 6.0f;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		light = GetNode<OmniLight>("CSGCylinder/OmniLight");
		RandomNumberGenerator rng = new RandomNumberGenerator();
		rng.Randomize();
		time = rng.Randfn();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(float delta)
	{
		light.LightEnergy = energy + scale * Mathf.Sin(time * 4f);
		time += delta;

	}
}
