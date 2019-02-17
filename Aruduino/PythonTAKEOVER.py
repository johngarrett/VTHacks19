import serial
from pysndfx import AudioEffectsChain
import pygame as pg
import time
from librosa import load
rate = 9600
device_name = "/dev/cu.usbmodem14201"
port = serial.Serial(device_name, baudrate = rate, timeout = 3.0)

pg.mixer.init()
pg.init()

a1 = pg.mixer.Sound("/Users/zeke/Programming/VTHacks19/Assets/Sounds/Good/longDrums.wav")
a2 = pg.mixer.Sound("/Users/zeke/Programming/VTHacks19/Assets/Sounds/Good/Ping.wav")
a3 = pg.mixer.Sound("/Users/zeke/Programming/VTHacks19/Assets/Sounds/Good/guitar.wav")
#fx = (
#      AudioEffectsChain()
#      .reverb()
#      )

#
while True:
    recieved = port.read(32).decode('utf_8');
    print(recieved)
    if "A" in recieved:
        print("Button one was successfuly pushed sir.")
        a1.play()
        time.sleep(.5)
    elif "B" in recieved:
        print("Button two was successfuly pushed madam.")
        a2.play()
        time.sleep(.5)
    elif "C" in recieved:
        print("Button threeeeee was successfuly pushed bruhhh!.")
        a3.play()
        time.sleep(.5)
    elif "D" in recieved:
        print("Button 1 & 2 recieved successfully")
        a1.play()
        a3.play()
        time.sleep(1)

