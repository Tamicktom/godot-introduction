extends Node2D;

var score: int = 0;

var country_name:String = "Britania";
var population:int = 234_123;
var highest_altitude:float = 1_234.34;
var land_locket:bool = false;

var dict: Dictionary = {
	"banana": "banana"
};

func _ready():
	print(score);
	print(country_name);
	print(population);
	print(highest_altitude);
	print(land_locket);
	print(dict);
	score += 10;
	print(score);
	if(score > 10):
		print("score é maior do que 10");
