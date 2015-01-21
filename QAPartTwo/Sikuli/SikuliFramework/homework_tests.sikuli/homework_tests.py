import unittest

bdLibPath=os.path.abspath(sys.argv[0]+"..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from functions import *

class googleTest(unittest.TestCase):
    def setUp(self):
        OpenApp("chrome", "google.com")

    def tearDown(self):
        CloseTab(self)

    def test_001_SearchTelerikAcademy(self):
        wait(Google.logo, 20) # Yes it is long, but my net speed was..."amazing" 
        type(Google.search_input, "telerik academy")
        sleep(1)
        type(Key.ENTER)
        sleep(3) 
        assert exists(Google.result, 2)

class dragAndDrop(unittest.TestCase):
    def  setUp(self):
        OpenApp("chrome", "http://www.dhtmlgoodies.com/scripts/drag-drop-custom/demo-drag-drop-3.html")


    def tearDown(self):
        CloseTab(self)

    def test_001_Capitals(self):
        dragDrop(Capitals.rome, Capitals.italy)
        dragDrop(Capitals.madrid, Capitals.spain)
        dragDrop(Capitals.copenhagen, Capitals.denmark)
        dragDrop(Capitals.seoul, Capitals.southKorea)
        dragDrop(Capitals.stockholm, Capitals.sweden)
        dragDrop(Capitals.washington, Capitals.unitedStates)
        dragDrop(Capitals.oslo, Capitals.norway)

        assert exists(Capitals.result, 1)

class minimizeThemAll(unittest.TestCase):
    def setUp(self):
        pass

    def tearDown(self):
        pass

    def test_001_MinimizeWindows(self):
        while exists(Minimize.minimize_button):
            try:
                click(Minimize.minimize_button)
            except Exception, e:
                pass
                break

class sendSkypeMessage(unittest.TestCase):
    def setUp(self):
        pass

    def tearDown(self):
        pass

    def test_001_SendMessage(self):
        doubleClick(Skype.icon)
        doubleClick(Skype.mutualChat)
        type("http://thecodinglove.com/post/49358754197/when-the-boss-wants-me-to-see-a-bug-in-our-app" + Key.ENTER)
        assert exists(Skype.result)

class sendFacebookMessage(unittest.TestCase):
    def setUp(self):
        OpenApp("chrome", "facebook.com")

    def tearDown(self):
        CloseTab(self)

    def test_001_SendMessage(self):
        wait(Facebook.chatIcon, 20)
        sleep(5)
        click(Facebook.chatIcon)
        click(Facebook.venci)
       # type("some spam you need, beer we should drink!" + Key.ENTER)
        assert exists(Facebook.result)

    def test_002_SendMultipleMessages(self):
        wait(Facebook.chatIcon, 20)
        sleep(5)
        type(Key.ALT, KeyModifier.SHIFT)
        click(Facebook.chatIcon)
        click(Facebook.venci)
        conversation = ["zapisa", "li", "se", "za", "whoden", "izpit", "be", "?"]
        for word in conversation:
            type(word + " " + Key.ENTER)

class windowsCalculator(unittest.TestCase):
    def setUp(self):
        OpenApp("calc")
        wait(Calculator.icon, 10)

    def tearDown(self):
        CloseApp("calc")

    def test_001_Addition(self):
        type( "3" + "+" + "8" + Key.ENTER)
        assert exists(Calculator.result11)

    def test_002_Subtraction(self):
        type("10" + "-" + "6" + Key.ENTER)
        assert exists(Calculator.result4)

    def test_003_Division(self):
        type("25" + "/" + "5" + Key.ENTER)
        assert exists(Calculator.result5)

    def test_004_Multiplication(self):
        type("25" + "*" + "6" + Key.ENTER)
        assert exists(Calculator.result150)

    def test_005_DivideByZero(self):
        type("2" + "/" + "0" + Key.ENTER)
        assert exists(Calculator.zeroDivision)

if __name__ == '__main__':
    test_clases = [googleTest, dragAndDrop,  minimizeThemAll, sendSkypeMessage, sendFacebookMessage, windowsCalculator] 
    loader = unittest.TestLoader()
    outfile = open("allreports.html", "w")
    suitesList = []
    for test_class in test_clases:
        suite = loader.loadTestsFromTestCase(test_class)
        suitesList.append(suite)

    allTests = unittest.TestSuite(suitesList)
    runner = HTMLTestRunner.HTMLTestRunner(stream=outfile, title='Sikuli Homework')
    runner.run(allTests)
outfile.close()

