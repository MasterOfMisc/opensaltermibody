Okay... Firstly the file created by the USB export is named BODYDATA.TXT. This is the file that needs to be read in! - Im using a hex editor to read the stored data in the file.

Interestingly the application wipes the contents of this file once it has read the data in!

Makeup of the file:

  * Each users weight data takes up 18 bytes.<br>
<ul><li>Each user has 35 slots that they can take up.  The file is padded with empty slots.<br>></li></ul>

Example Data to be read from file<br>
<br>
Slot 		1 (done)<br>
Time/Date 	08:49:44 (done)<br>
Age		33 (done)<br>
Height		6'01" / 185cm (done)<br>
Weight		13:7.2 / 85.8kg / 189.2 (done)<br>
Body Fat	22.0 (done)<br>
Visceral Fat	9 (done)<br>
BMI		25.1 - (done) Calculated field off ( <a href='http://www.bbc.co.uk/health/healthy_living/your_weight/bmiimperial_index.shtml'>http://www.bbc.co.uk/health/healthy_living/your_weight/bmiimperial_index.shtml</a> )<br>
BMR		1949 - (done) Calculated off weight, height & age. (<a href='http://www.bmi-calculator.net/bmr-calculator/bmr-formula.php'>http://www.bmi-calculator.net/bmr-calculator/bmr-formula.php</a>)<br>
Muscle Mass	41.3<br>
Body Water 	57.1 - Calulated field not from scales.<br>


<hr />

Example User Data String = 07 da 01 01 08 31 2c a1 b9 00 03 5a 00 dc 00 01 9d 09<br>
<br>
<table><thead><th> Hex Value</th><th> Decimal Value </th><th> Comment </th></thead><tbody>
<tr><td>  </td><td>  </td><td>  </td></tr>
<tr><td>07</td><td>	7 </td><td>	YEAR in binary - 0111<br></td></tr>
<tr><td>da </td><td>	218 </td><td>	YEAR in binary - 11011010<br></td></tr>
<tr><td>01 </td><td>	1 </td><td>	MONTH<br></td></tr>
<tr><td>01 </td><td>	1 </td><td>	DAY<br></td></tr>
<tr><td>08 </td><td>	8 </td><td>	TIME<br></td></tr>
<tr><td>31 </td><td>	49 </td><td>	TIME<br></td></tr>
<tr><td>2c </td><td>	44 </td><td>	TIME<br></td></tr>
<tr><td>a1 </td><td>	161 </td><td>    Female/Male Setting & Age. 1st bit = male/female. If 0 then female, if 1 then male. Can only live upto 127<br></td></tr>
<tr><td>b9 </td><td>	185 </td><td>	Height in cm <br></td></tr>
<tr><td>00 </td><td>	0 </td><td>	Fitness Level (thanks Peter)<br></td></tr>
<tr><td>03 </td><td>	3 </td><td>	WEIGHT The MSB is not used.<br></td></tr>
<tr><td>5a </td><td>	90  </td><td>    WEIGHT <br></td></tr>
<tr><td>00 </td><td>	0 </td><td>	BODY FAT<br></td></tr>
<tr><td>dc </td><td>	220 </td><td>	BODY FAT<br></td></tr>
<tr><td>00 </td><td>	0 </td><td>	PADDING! - It seems like!<br></td></tr>
<tr><td>01 </td><td>	1 </td><td>	Muscle Mass<br></td></tr>
<tr><td>9d </td><td>	157 </td><td>	Muscle Mass<br></td></tr>
<tr><td>09 </td><td>	9 </td><td>	Visceral Fat<br></td></tr>
<tr><td>  </td><td>  </td><td>  </td></tr>