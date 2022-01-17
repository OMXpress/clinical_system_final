import sys
import requests
import glob
import json

def Create(f):
    lis = []
    for name in glob.glob(f+'/' + '*'):
        lis.append(name)
        for i in lis:
            for name2 in glob.glob(f + '/' + i + '/' + '*'):
                url = 'https://api.jsonbin.io/b'
                headers = {
                'Content-Type': 'application/json',
                'secret-key': '$2b$10$BFTH2d2iRyCXMM/2SBG4TOOIBIQHF/qq9GzNfgj0j1YnYTOAkt1G6'
                }
                data = json.load(f+i+name2)
                req = requests.put(url, json=data, headers=headers)
                
filePath = sys.argv[1]
Create(filePath)