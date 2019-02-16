var angle = 0;
var slider;

function setup() {
	var win = window;
	var doc = document;
	var element = doc.documentElement;
	var body = doc.getElementsByTagName('body')[0];
	
	var width = win.innerWidth || element.clientWidth || body.clientWidth;
	var height = win.innerHeight || element.clientHeight || body.clientHeight;

	createCanvas(width, height);
	draw();	

	button = createButton('Incriment');
	button.position(800, 65);
	button.mousePressed(incriment);
}

function draw() {
	var length = (height / 100) * 30;

	background(51);
	stroke(255);
	translate(width / 2, height);
	branch(length);
}

function incriment(){
	var angle = 3.14/2;
	push();
	rotate(angle);
	branch(200);
	pop();
	push();
	rotate(-angle);
	branch(1 * 0.67);
	pop();
}

function branch(length) {
	line(0, 0, 0, -length);
	translate(0, -length);
}