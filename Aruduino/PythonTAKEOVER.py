import serial

rate = 9600
device_name = "/dev/cu.usbmodem14201"
port = serial.Serial(device_name, baudrate = rate, timeout = 3.0)

while True:
	recieved = port.read(32);
	if "BTN 1" in recieved:
		print("Button one was successfuly pushed sir.")
	if "BTN 2" in recieved:
		print("Button two was successfuly pushed madam.")
	if "BTN 3" in recieved:
		print("Button threeeeee was successfuly pushed bruhhh!.")


