import tkinter as tk
from tkinter import font
from tkinter import *
import serial
from pysndfx import AudioEffectsChain
import pygame as pg
import time
import ui
from librosa import load

master = tk.Tk()
master.title('Mukbang Soundboard')
master.configure(background='#355C7D')

rate=1
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




w = Scale(master, from_=10, to=0, orient=VERTICAL)
w.grid(row=1, column=0)
w.set(0)

z = Scale(master, from_=10, to=0, orient=VERTICAL)
z.grid(row=1, column=2)
z.set(0)

def updateLeftScale(knobReading):
    w.set(int(knobReading/102.4))
    return

def updateRightScale(knobReading):
    z.set(int(knobReading/102.4))
    return


#buttonImg1 = tk.PhotoImage(file="assets/button3.jpg")
#buttonImg2 = tk.PhotoImage(file="assets/button4.jpg")
#buttonImg3 = tk.PhotoImage(file="assets/button5.jpg")


def doNothing():
    return

button1 = tk.Button(master, text='s n a r e', font = buttonFont, command=doNothing, height=3, width=20, fg = 'white', justify=tk.LEFT, background='#F67280')
button1.grid(row=2,column=0)


button2 = tk.Button(master, text='k i c k', font = buttonFont, command=doNothing, height=3, width=20, fg = 'white', background='#C06C84')
button2.grid(row=2,column=1)


button3 = tk.Button(master, text='h a t', font = buttonFont, command=doNothing, height=3, width=20, fg = 'white', justify=tk.RIGHT, background='#6C5B7B')
button3.grid(row=2,column=2)

def invokeButton1():
    button1.invoke()
    return

def invokeButton2():
    button2.invoke()
    return

def invokeButton3():
    button3.invoke()
    return

#exitButton = tk.Button(master, text='Exit', command=master.quit, height=5, width=20,fg = 'white', background='#F8B195').grid(row=0,column=3)

a = 0
b = 0
c = 0
d = 0
while True:
    master.update()

    recieved = port.read(8).decode('utf_8');
    if "A" in recieved:
        a = a + 1
        if a % 3 == 0:
            print("Button one was successfuly pushed sir.")
            invokeButton1()
            a1.stop()
            a1.play()
            time.sleep(.3)
            a = 0
    elif "B" in recieved:
        b = b + 1
        if b % 3 == 0:
            print("Button two was successfuly pushed madam.")
            invokeButton2()
            a2.stop()
            a2.play()
            time.sleep(.3)
            b = 0
    elif "C" in recieved:
        c = c + 1
        if c % 3 == 0:
            print("Button threeeeee was successfuly pushed bruhhh!.")
            invokeButton3()
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
        recieved = recieved.replace("X",'')
        recieved = recieved.replace("Z",'')
        recieved = recieved.replace("\r", '')
        recieved = recieved.replace("\n", '')
        recieved = recieved.replace(':', '')
        recieved.strip()
        if len(recieved) > 0:
            print(int(int(recieved) / 102.4))
            updateRightScale(float(recieved))
    elif "Z" in recieved:
        recieved = recieved.replace("Z",'')
        recieved = recieved.replace("X",'')
        recieved = recieved.replace("\r", '')
        recieved = recieved.replace("\n", '')
        recieved = recieved.replace(':', '')
        recieved.strip()
        if len(recieved) > 0:
            updateLeftScale(float(recieved))
            print(int(int(recieved) / 102.4))
