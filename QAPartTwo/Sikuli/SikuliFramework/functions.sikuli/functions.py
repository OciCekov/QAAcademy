import os
import sys
import HTMLTestRunner
from sikuli import *

bdLibPath = os.path.abspath(sys.argv[0] + "..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from uimap import *

def OpenApp(appName, optional =""):
    type("d", KEY_WIN)
    sleep(1)
    type("r", KEY_WIN)
    sleep(1)
    type(appName + " ")
    type(optional + Key.ENTER)
    type(Key.UP, KEY_WIN)
    sleep(2)

def CloseApp(appName):
    type(Key.F4, KEY_ALT)
  #  type("r", KEY_WIN)
  #  sleep(1)
  #  type("taskkill /F /IM " + appName + ".exe" + Key.ENTER)

# Sometimes chrome opens new tab, sometimes opens new window, that's whay it only close tab
# Sorry if you have some blank chrome windows opened
def CloseTab(self):
    type(Key.F4, KEY_CTRL)
