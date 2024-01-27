extends Node3D

var speed = 5;


func _process(delta):
	var direction = Vector3()  # Initialisez un vecteur pour le mouvement

	if Input.is_action_pressed("ui_up"):
		direction.z -= 1  # Déplacement vers l'avant
	if Input.is_action_pressed("ui_down"):
		direction.z += 1  # Déplacement vers l'arrière

	# Normalisez le vecteur pour éviter le mouvement plus rapide en diagonale
	direction = direction.normalized()

	# Appliquez le mouvement à la position du nœud
	translate(direction * speed * delta)
