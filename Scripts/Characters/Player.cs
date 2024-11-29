using Godot;
using System;

public partial class Player : Character
{

	// Exporter la propriété mouseSensivity pour qu'elle soit modifiable dans l'éditeur Godot
	// Utiliser PropertyHint.Range pour définir une plage de valeurs de 0.1 à 1.0
	[Export(PropertyHint.Range, "0.1,1.0")]
	float mouseSensivity = 0.3f;  // Sensibilité de la souris, valeur par défaut 0.3

	// Exporter la propriété minPitch pour qu'elle soit modifiable dans l'éditeur Godot
	// Utiliser PropertyHint.Range pour définir une plage de valeurs de -90 à 0 avec un pas de 1
	[Export(PropertyHint.Range, "-90,0,1")]
	float minPitch = -90f;  // Inclinaison minimale (pitch), valeur par défaut -90

	// Exporter la propriété maxPitch pour qu'elle soit modifiable dans l'éditeur Godot
	// Utiliser PropertyHint.Range pour définir une plage de valeurs de 0 à 90 avec un pas de 1
	[Export(PropertyHint.Range, "0,90,1")]
	float maxPitch = 90f;  // Inclinaison maximale (pitch), valeur par défaut 90

	[Export]Node3D cameraPivot;
	[Export]Camera3D camera;
	
	private string currentAnimation = "";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		/* Récupérer le noeud Camera3D et le noeud Node3D associé à la caméra au lancement du jeu */
		Input.MouseMode = Input.MouseModeEnum.Captured;
		animationPlayer.Play("Inactif");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if(Input.IsActionJustPressed("ui_cancel"))
		{
			/* Changer le mode de la souris entre Captured et Visible en appuyant sur echap */
			Input.MouseMode = Input.MouseMode == Input.MouseModeEnum.Captured ? Input.MouseModeEnum.Visible : Input.MouseModeEnum.Captured;
		}
	}

	public override void _Input(InputEvent @event)
	{
		if(@event is InputEventMouseMotion motionEvent)
		{
			/* Récupérer les mouvements de la souris pour orienter la caméra */
			Vector3 rotDeg = RotationDegrees;
			rotDeg.Y -= motionEvent.Relative.X * mouseSensivity;
			RotationDegrees = rotDeg;
			
			rotDeg = cameraPivot.RotationDegrees;
			rotDeg.X -= motionEvent.Relative.Y * mouseSensivity;
			rotDeg.X = Mathf.Clamp(rotDeg.X, minPitch, maxPitch);
			cameraPivot.RotationDegrees = rotDeg;
		}
	}

	public override void _PhysicsProcess(double delta)
	{
		HandleMovement(delta);
	}

	private async void HandleMovement(double delta) {
		Vector3 direction = new Vector3(0, 0, 0);

		if(Input.IsActionPressed("move_up")) {
			GD.Print("move_up");
			direction -= Transform.Basis.Z;
		}
		if(Input.IsActionPressed("move_down")) {
			GD.Print("move_down");
			direction += Transform.Basis.Z;
		}
		if(Input.IsActionPressed("move_left")) {
			GD.Print("move_left");
			direction -= Transform.Basis.X;
		}
		if(Input.IsActionPressed("move_right")) {
			GD.Print("move_right");
			direction += Transform.Basis.X;
		}

		// if(Input.IsActionPressed("run")) {
		// 	this.extraSpeed = 3f;
		// }else{
		// 	this.extraSpeed = 1f;
		// }

		direction = direction.Normalized();

		float accel = IsOnFloor() ? this.acceleration : this.airAcceleration;
		this.velocity = direction * this.speed * accel * this.extraSpeed;

		// if(this.bounce) {
		// 	yVelocity = this.jumpForce;
		// 	this.bounce = false;
		// }else{
		// 	if(IsOnFloor()) {
		// 		yVelocity = -0.01f;
		// 	}else{
		// 		yVelocity = Mathf.Clamp(yVelocity - this.gravity, -this.maxTerminalVelocity, this.maxTerminalVelocity);
		// 		// animationPlayer.Play("fall");
		// 	}
		// }

		// if(Input.IsActionJustPressed("jump") && IsOnFloor()) {
		// 	yVelocity = this.jumpForce;
		// }

		velocity.Y = yVelocity;
		Velocity = velocity;
		MoveAndSlide();

		// for(int i = 0; i < GetSlideCollisionCount(); i++) {
		// 	var collision = GetSlideCollision(i);
		// 	//GD.Print("Collided with: ", (Node)collision.GetCollider());
		// }

		if(direction != new Vector3(0,0,0) && IsOnFloor()) {
			animationPlayer.Play("Marche");
		}else if(direction == new Vector3(0, 0, 0) && IsOnFloor()) {
			animationPlayer.Play("Inactif");
		}
	}

	private void PlayerAnimation(string animationName) {
		if(currentAnimation == animationName && this.animationPlayer.IsPlaying()) {
			return;
		}

		currentAnimation = animationName;
		 // Joue directement l'animation en boucle
		animationPlayer.Play(animationName);
		// Force le mode de lecture en boucle
		animationPlayer.GetAnimation(animationName).LoopMode = Animation.LoopModeEnum.Linear;
	}
}
