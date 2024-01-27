extends Sprite3D

var speed = 5

func _process(delta):
	var input_z = Input.get_action_strength("ui_left") - Input.get_action_strength("ui_right")
	var input_h = Input.get_action_strength("ui_down") - Input.get_action_strength("ui_up")
	
	
	translate(Vector3(input_h, 0, input_z) * delta * speed)
