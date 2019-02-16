import serial

baudrate = 115200
device_name = "dev/tty.usbserial"
port = serial.Serial(device_name, baudrate = rate, timeout = 3.0)

while True:
    recieved = port.read(10)
    print("We read: " + recieved)
    #print(port.readline())
