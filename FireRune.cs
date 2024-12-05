using Godot;
using System;

public class FireRune : Node3D
{
	public Color ElementColor = new Color(1f, 0.4f, 0f); // Couleur rouge-orange.

	public void ApplyEffect(Node3D spell)
	{
		// Récupérer le Particles3D du sort.
		var particles = spell.GetNode<Particles3D>("Particles3D");
		var material = (ParticlesMaterial)particles.ProcessMaterial;

		// Modifier le dégradé de couleur.
		var gradient = new Gradient();
		gradient.Colors = new[] { ElementColor, new Color(0, 0, 0) };
		material.ColorRamp = gradient;
	}
}
