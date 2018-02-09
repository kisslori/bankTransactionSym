# bankTransactionSym

This is a windows forms simple bank transactions symulation app focused on security measures:
- it holds bank accounts information in a Sql database
- the pasword is encrypted using AES-256 encryption
- login is done with phone message verification
- and transactions require a pin to complete
	
to use this app you must add a reference towards Microsoft.VisualBasic

you also need a Twilio account for sending verification messages 
