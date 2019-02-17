from pysndfx import AudioEffectsChain
from playsound import playsound

fx = (
	  AudioEffectsChain()
	  .highshelf()
	  .reverb()
	  .phaser()
	  .delay()
	  .lowshelf()
)

infile = '/Users/johngarrett/Documents/VTHack19/Assets/Sounds/Synth Sounds/713__elmomo__orientflute.mp3'
outfile = 'test.ogg'

# Apply phaser and reverb directly to an audio file.
fx(infile, outfile)

# Apply the effects and return the results as a ndarray.
y = fx(infile)

# Apply the effects to a ndarray but store the resulting audio to disk.
fx(x, outfile)

playsound(outfile)
