import serial

rate = 9600
device_name = "/dev/cu.usbmodem14101"
port = serial.Serial("COM4", baudrate = rate, timeout = 3.0)

while True:
    recieved = port.read(32)
    
