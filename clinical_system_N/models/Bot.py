import os
from pickle import TRUE
import telebot
import requests
import time
import json

bot_token = '5015441546:AAHDC-P2BFJojb-yiyCv8HXwssnzO3tspsk'

bot = telebot.TeleBot(token=bot_token)

#read

dic = {}
url = 'https://api.jsonbin.io/b/61e515400f639830851d8059'
headers = {
                'Content-Type': 'application/json',
                'secret-key': '$2b$10$BFTH2d2iRyCXMM/2SBG4TOOIBIQHF/qq9GzNfgj0j1YnYTOAkt1G6'
                }

data = {}

req = requests.get(url, json=data, headers=headers)
dic = str(req.text)
dic = json.loads(dic)

print(dic)

print("Your name is " + dic['ID']['PatientName'] + "your drug is " + dic['ID']["Prescription"] + "\n your prescribingDoctor is " + dic["ID"]['PrescribingDoctor'])

@bot.message_handler(commands=['Show'])
def greet(message):
	bot.reply_to(message, "Your name is " + dic['ID']['PatientName'] + "your drug is " + dic['ID']["Prescription"] + "\n your prescribingDoctor is " + dic["ID"]['PrescribingDoctor'])

while TRUE:
	try:
		bot.polling()
	except Exception:
		time.sleep(15)
