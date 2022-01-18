import os
from pickle import TRUE
import telebot
import requests
import time
import json

bot_token = '5015441546:AAHDC-P2BFJojb-yiyCv8HXwssnzO3tspsk'

bot = telebot.TeleBot(token=bot_token)

#read from database
dic = {}
url = 'https://api.jsonbin.io/b/61e6f8bfdbe5d130832808e2'
headers = {
                'Content-Type': 'application/json',
                'secret-key': '$2b$10$BFTH2d2iRyCXMM/2SBG4TOOIBIQHF/qq9GzNfgj0j1YnYTOAkt1G6'
                }
data = {}
req = requests.get(url, json=data, headers=headers)
dic = str(req.text)
dic = json.loads(dic)

#Data intialization
MedicineNames = []
Durations = []
Doses = []
Hows = []
ActiveIngredients = []
patientKey = ""
Email = ""
state = False
state1 = False
replyMessage = ""

#functions
def CheckEmail(Email):
	for key in dic:
		if dic[key]["MetaData"]["Email"].lower() == Email.lower():
			patientKey = key
			Email = dic[key]["MetaData"]["Email"].lower()
			return patientKey
		else:
			patientKey = ""
			return patientKey

#data from json 
def GetData(patientKey):
	for i in dic[patientKey]["ActivePerscription"]:
		MedicineNames.append(i["MedicineName"])
		Durations.append(i["Duration"])
		Doses.append(i["Dose"])
		Hows.append(i["How"])
		ActiveIngredients.append(i["ActiveIngredient"])

#rely messages
	replyMessage = "".join([str(MedicineNames[i] + "\n\t\t" + "Duration: " + Durations[i] + "\n\t\t" + "Dose: " + Doses[i] + "\n\t\t" + "How: " + Hows[i] + "\n\t\t" + "ActiveIngredients" + ActiveIngredients[i] + "\n\t") for i in range(len(MedicineNames))])
	return replyMessage

#Bot messages
@bot.message_handler(commands=['Start'])
def showData(message):
  bot.reply_to(message, "Welcome, input your email")
  
@bot.message_handler(regexp="^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$")
def echo_message(message):
  message_text = message.text
  global patientKey
  patientKey = CheckEmail(message.text)
  if patientKey == "":
    bot.reply_to(message, "Email is not found input please input the a valid email")
  else:
    bot.reply_to(message, "to see your prescription input /ShowPrescription \n to see your last diagnosis input /ShowDiagnosis \n to see your Account Details input /ShowData \n to see personal history input /ShowHistory \n to see your family history input /ShowFHistory \n to view last visit data input /ShowDate")
    replyMessage = GetData(patientKey)
    return patientKey


@bot.message_handler(commands=['ShowPrescription'])
def showPrescription(message):
  replyMessage = GetData(patientKey)
  bot.reply_to(message, "Your name is " + dic[patientKey]['MetaData']['PatientName'] + "\n" + "Your Prescribed Drugs Are \n\t" + replyMessage)

@bot.message_handler(commands=['ShowDiagnosis'])
def showDiagnosis(message):
  bot.reply_to(message, "Your last diagnosis is: \n\t" + dic[patientKey]["LastDiagnosis"])


  #needs more data
@bot.message_handler(commands=['ShowData'])
def showData(message):
  print(patientKey)
  bot.reply_to(message, "Your AccountDetails are: \n\t" + "ID: " + dic["key"]["MetaData"]["PatientId"] + "\n\t\t"
   + "Name: " + dic["key"]["MetaData"]["PatientName"] + "\n\t\t"
    + "Date of Birth: " + dic["key"]["MetaData"]["DoB"] + "\n\t\t"
	 + "Your National ID: " + dic["key"]["MetaData"]["NationalID"] + "\n\t\t"
	  + "Gender: " + str(dic["key"]["MetaData"]["Gender"]) + "\n\t\t"
	   + "Email: " + dic["key"]["MetaData"]["Email"] + "\n\t\t"
	    + "Phone: " + dic["key"]["MetaData"]["Phone"] + "\n\t\t"
		 + "Address: " + dic["key"]["MetaData"]["Address"] + "\n\t\t"
		  + "MaritialStatus: " + str(dic["key"]["MetaData"]["MaritialStatus"]) + "\n\t\t"
		   + "Proffession: " + dic["key"]["MetaData"]["Proffession"])

@bot.message_handler(commands=['ShowHistory'])
def showHistory(message):
  bot.reply_to(message, "Your Personal History is: \n\t" + dic[patientKey]["PersonalHistory"])

@bot.message_handler(commands=['ShowFHistory'])
def showFHistory(message):
  bot.reply_to(message, "Your Family History is: \n\t" + dic[patientKey]["FamilyHistory"])

@bot.message_handler(commands=['ShowDate'])
def showDate(message):
  bot.reply_to(message, "Last Visit Date is: \n\t" + dic[patientKey]["LastVisitDate"])

while TRUE:
	try:
		bot.polling()
	except Exception:
		time.sleep(15)