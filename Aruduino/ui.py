import tkinter as tk
from tkinter import font
from tkinter import *


master = tk.Tk()
master.title('Mukbang Soundboard')
master.configure(background='#355C7D')

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




w = Scale(master, from_=200, to=0, orient=VERTICAL)
w.grid(row=1, column=0)
w.set(100)

z = Scale(master, from_=200, to=0, orient=VERTICAL)
z.grid(row=1, column=2)
z.set(75)

def updateLeftScale(knobReading):
    w.set(knobReading/10)
    return

def updateRightScale(knobReading):
    z.set(knobReading/10)
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

def invokeButton2():
    button3.invoke()
    return

#exitButton = tk.Button(master, text='Exit', command=master.quit, height=5, width=20,fg = 'white', background='#F8B195').grid(row=0,column=3)


tk.mainloop()
