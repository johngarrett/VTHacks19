import serial

rate = 9600
device_name = "/dev/cu.usbmodem14201"
port = serial.Serial(device_name, baudrate = rate, timeout = 3.0)

while True:
    recieved = port.read(32)
    print(recieved)
