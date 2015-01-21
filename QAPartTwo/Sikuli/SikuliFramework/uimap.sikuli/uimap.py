from sikuli import *

class Google:
    search_input="google/search_input.png"
    result="google/search_result.png"
    logo="google/logo.png"

class Capitals:
    italy= "capitals/italy.png"    #rome
    spain=    "capitals/spain.png" #madrid
    norway=   "capitals/norway.png"  #Oslo
    denmark= "capitals/denmark.png"   #copenhagen
    southKorea= "capitals/southKorea.png" #seoul
    sweden=      "capitals/sweden.png"  #stockholm
    unitedStates =  "capitals/us.png"   #washington
    rome = "capitals/rome-1.png"
    madrid ="capitals/madrid.png" 
    oslo ="capitals/oslo.png"
    copenhagen = "capitals/copenhagen.png"
    seoul = "capitals/seoul.png"
    stockholm = "capitals/stockholm.png"
    washington = "capitals/washington.png"
    result = "capitals/result-1.png"

class Minimize:
    minimize_button = Pattern("minimize_button.png").similar(0.80)

class Skype: 
    icon = "skype/icon.png"
    mutualChat = "skype/mutualChat.png"
    result = "skype/result.png"

class Facebook:
    chatIcon = "facebook/chatIcon.png"
    venci = "facebook/venci.png"
    result = "facebook/result.png"
    
class Calculator:
    icon = "calculator/icon.png"
    result11 = "calculator/result11.png"
    result4 = "calculator/result4.png"
    result5 = "calculator/result5.png"
    result150="calculator/result150.png"
    zeroDivision = "calculator/zeroDivision.png"