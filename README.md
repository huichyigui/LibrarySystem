# 
1. Kindly prepare the following items through downloading from their respective official website or download ALL of the .exe from google drive link provided. Guidance with picture explanation is included inside the google drive folder link as well.
  -SQL2019-SSEI-Express Version.exe
	-SQL Server Management Studio (SSMS) V 18.9.2.exe
	-SAP Crystal Reports for Visual Studio (SP30)

SQL Installation Youtube Video Reference: https://youtu.be/QsXWszvjMBM

Crystal Report Viewer Installation Youtube Video Reference: https://youtu.be/5r1l4uCSmtU


2. Open SQL Server Management Studio (SSMS) and locate the libraryDBMS.bacpac file inside the assignment folder. Then, kindly follow the YouTube links, starting from 3 minutes onward to import the database into your SSMS system.

Importing SQL Youtube Video Reference: https://youtu.be/XLzV_gagkZc
   
Click Tools -> Connect to Database... -> Under Server Name: -> Key in: (local)\SQLEXPRESS -> Under Connect to a database ->
                                                             -> select the database name: libraryDBMS you imported just now. 


3.  Click the left hand side Server Explorer and click the libraryDBMS, then right click it to show properties. 


4.  From the properties, locate Connection String, then click to select all of the connection string and paste it 
    inside the Connection.vb -> Sub opencon() module. 
