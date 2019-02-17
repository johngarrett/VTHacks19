import serial
from pysndfx import AudioEffectsChain
from playsound import playsound
from librosa import load
rate = 9600
device_name = "/dev/cu.usbmodem14201"
port = serial.Serial(device_name, baudrate = rate, timeout = 3.0)

infile = "/Users/zeke/Programming/VTHacks19/Assets/Sounds/Good/Ping.wav"
file = "/Users/zeke/Programming/VTHacks19/Assets/Sounds/Good/play.wav"



fx = (
      AudioEffectsChain()
      .reverb()
      )
fx(infile,file)
playsound(file)

#while True:
#    recieved = port.read(32);
#    if "A" in recieved:
#        print("Button one was successfuly pushed sir.")
#        playsound("/Users/Zeke/Programming/VTHack19/Assets/Sounds/Good/Ping.wav")
#    elif "B" in recieved:
#        print("Button two was successfuly pushed madam.")
#    elif "C" in recieved:
#        print("Button threeeeee was successfuly pushed bruhhh!.")
#    elif "D" in recieved:
#        print("Button 1 & 2 recieved successfully")
