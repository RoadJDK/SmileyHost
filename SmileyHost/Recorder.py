import pyautogui
import shutil
import time
import sys
import os

if(os.path.isdir('images/')):
    shutil.rmtree('images/')
    os.mkdir('images/')
else:
    os.mkdir('images/')

t_end = time.time() + 30
counter = 0
while time.time() < t_end:
    screenshot = pyautogui.screenshot(region=(int(sys.argv[1]),int(sys.argv[2]),int(sys.argv[3]),int(sys.argv[4])))
    n = str(counter).zfill(4)
    path = ('images/' + n + '.png')
    screenshot.save(path)
    counter += 1
