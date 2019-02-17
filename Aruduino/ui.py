import ui
import time
import serial
import pygame as pg
import tkinter as tk
from tkinter import *
from tkinter import font
from librosa import load
from pysndfx import AudioEffectsChain

master = tk.Tk()
master.title('Mukbang Soundboard')
master.configure(background='#355C7D')

rate=30
device_name = "/dev/cu.usbmodem14201"
port = serial.Serial(device_name, baudrate = rate, timeout = 3.0)

pg.mixer.init()
pg.init()

a1 = pg.mixer.Sound("/Users/zeke/Programming/VTHacks19/Assets/Sounds/Good/longDrums.wav")
a2 = pg.mixer.Sound("/Users/zeke/Programming/VTHacks19/Assets/Sounds/Good/Ping.wav")
a3 = pg.mixer.Sound("/Users/zeke/Programming/VTHacks19/Assets/Sounds/Good/guitar.wav")

choice = tk.IntVar()
titleFont = font.Font(family="Helvetica", size=18, weight = 'bold')
buttonFont = font.Font(family="Helvetica", size=12, weight = 'bold')

tk.Label(master,
        text="M U K B A N G   S O U N D   B O A R D",
        justify = tk.CENTER,
        fg = 'white',
        padx = 00, background='#355C7D',
        font = titleFont).grid(row=0, column=1)

logo = tk.PhotoImage(file="assets/musicBackground.png")
logo = logo.subsample(7)
logoImg = tk.Label(master, image=logo).grid(row=1, column=1)

z = Scale(master, from_=10, to=0, orient=VERTICAL)
z.grid(row=1, column=0)
z.set(0)

def updateLeftScale(knobReading):
    z.set(int(knobReading))
    if knobReading != 0:
        print(4900 - int(44100 * (1.0/knobReading)))
        pg.mixer.pre_init(1, 1, 1, 1)
    return

def doNothing():
    return

button1 = tk.Button(master, text='s n a r e', font = buttonFont, command=doNothing, height=3, width=30, justify=tk.LEFT, bg='#F67280')
button1.grid(row=3,column=0)


button2 = tk.Button(master, text='k i c k', font = buttonFont, command=doNothing, height=3, width=30, bg='#C06C84')
button2.grid(row=3,column=1)


button3 = tk.Button(master, text='h a t', font = buttonFont,activebackground = 'black', command=doNothing, height=3, width=30, justify=tk.RIGHT, bg='#6C5B7B')
button3.grid(row=3,column=2)

def invokeButton1():
    button1.invoke()
    return

def invokeButton2():
    button2.invoke()
    return

def invokeButton3():
    button3.invoke()
    return

a = 0
b = 0
c = 0
d = 0
i = 1
previousValue = 0

while True:
    master.update()

    recieved = port.read(8).decode('utf_8');
    if "A" in recieved:
        a = a + 1
        if a % 6 == 0:
            print("Button one was successfuly pushed sir.")
            invokeButton1()
            a1.stop()
            a1.play()
            time.sleep(.3)
            a = 0
    elif "B" in recieved:
        b = b + 1
        if b % 6 == 0:
            print("Button two was successfuly pushed madam.")
            invokeButton2()
            a2.stop()
            a2.play()
            time.sleep(.3)
            b = 0
    elif "C" in recieved:
        c = c + 1
        if c % 6 == 0:
            print("Button threeeeee was successfuly pushed bruhhh!.")
            invokeButton3()
            a3.stop()
            a3.play()
            time.sleep(.3)
            c = 0
    elif "D" in recieved:
        d = d + 1
        if d % 6 == 0:
            print("Button 1 & 2 recieved successfully")
            a1.play()
            a3.play()
            time.sleep(.6)
            d = 0
    elif "X" in recieved:
        recieved = recieved.replace("X",'')
        recieved = recieved.replace("Z",'')
        recieved = recieved.replace("\r", '')
        recieved = recieved.replace("\n", '')
        recieved = recieved.replace(':', '')
        recieved.strip()
        if len(recieved) > 0:
            if (i % 2):
                i = 0
            else:
                i = i + 1
            currentValue = int(int(recieved) / 102.4)
            delta_x = abs(previousValue - int(int(recieved) / 102.4))
            if delta_x > 1:
                currentValue = max(currentValue, previousValue)
                previousValue = max(currentValue, previousValue)
                continue
            updateLeftScale(currentValue)
            previousValue = int(int(recieved) / 102.4)
