import sys
sys.path.append('C:/Users/super/AppData/Local/Programs/Python/Python36-32/Lib/sklearn')
sys.path.append('C:/Users/super/AppData/Local/Programs/Python/Python36-32/Lib');
from sklearn import tree
import requests
from requests.auth import HTTPDigestAuth
import json
import collections;
from datetime import datetime as dt
from datetime import datetime
#py C:\Users\super\OneDrive\Documenten\GitHub\Project78\TamTamSuggestions\TamTamTracker\WebAPI\PythonScripts\machine_learning.py
def GenerateSuggestion():
		# get list of beacon data
		response = requests.get("http://localhost:50798/api/suggestions/GetDataBeacons")
		data = response.json() # get data
		s1 = json.dumps(data)
		x = json.loads(str(s1))
		i = 0;
		features = []
		labels = []
		
		while i < len(x):
			module = (x[i]["module"])
			if module == 'lunch':
				# module 1 = lunch
				module = 1
			else:
				module = 2
			dt_created = (x[i]["dt_created"])
			file = (x[i]["file"])
			school_holiday = (x[i]["school_holiday"])
			amount_of_people = (x[i]["amount_of_people"])
			new_date = dt_created.replace('T', ' ') #remove char T in datetime string for converting
			
			date = dt.strptime(new_date,"%Y-%m-%d %H:%M:%S")
			millisec = date.timestamp() * 1000

			features.append([millisec , file ,school_holiday , module])
			labels.append(amount_of_people);
			i += 1
		
		#print("****************** FEATURES *****************")
		#print(features)
		#print("****************** LABELS *****************")
		#print(labels)

		clf = tree.DecisionTreeClassifier()
		clf = clf.fit(features,labels);
		#print("****************** PREDICT *****************")
		print(clf.predict([[1229422500000.0,1,1 ,1]]));
		

GenerateSuggestion();

#input of today
#

#numpy  > C:\Users\super\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Python 3.6>py.exe -m pip install numpy
#scipy  > ZElfde links als hierboven alleen ipv numpy /scipy
#sklearn  pip install -U scikit-learn
# Install-Package IronPython
# 
#  Install-Package IronPython.StdLib