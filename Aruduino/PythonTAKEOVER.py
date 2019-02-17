import serial
from pysndfx import AudioEffectsChain
<<<<<<< HEAD
from playsound import playsound
rate = 9600
#device_name = "/dev/cu.usbmodem14201"
#port = serial.Serial(device_name, baudrate = rate, timeout = 3.0)

infile = "/Users/johngarrett/Documents/VTHack19/Assets/Sounds/Good/Pop.wav"
file = "Users/johngarrett/Documents/VTHack19/Assets/Sounds/Good/play.wav"
=======
import pygame as pg
import time
import ui
from librosa import load
rate = 30
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
>>>>>>> 181e15ebeadd4692cebb7b976920d212bd81f071

#

a = 0
b = 0
c = 0
d = 0

while True:
    recieved = port.read(8).decode('utf_8');
    if "A" in recieved:
        a = a + 1
        if a % 3 == 0:
            print("Button one was successfuly pushed sir.")
            ui.invokeButton1()
            a1.stop()
            a1.play()
            time.sleep(.3)
            a = 0
    elif "B" in recieved:
        b = b + 1
        if b % 3 == 0:
            print("Button two was successfuly pushed madam.")
            ui.invokeButton2()
            a2.stop()
            a2.play()
            time.sleep(.3)
            b = 0
    elif "C" in recieved:
        c = c + 1
        if c % 3 == 0:
            print("Button threeeeee was successfuly pushed bruhhh!.")
            ui.invokeButton3()
            a3.stop()
            a3.play()
            time.sleep(.3)
            c = 0
    elif "D" in recieved:
        d = d + 1
        if d % 3 == 0:
            print("Button 1 & 2 recieved successfully")
            a1.play()
            a3.play()
            time.sleep(.6)
            d = 0
    elif "X" in recieved:
        print(recieved[3:6])
        try:
            ui.updateRightScale(int(recieved[3:6]))
        except:
            ui.updateLeftScale()
    elif "Y" in recieved:
        ui.updateRightScale()


