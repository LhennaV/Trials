CREATE TABLE admin 
(
	id INT PRIMARY KEY IDENTITY (1,1),
	email VARCHAR(MAX) NULL, 
	username VARCHAR(MAX) NULL,
	passwrd VARCHAR(MAX) NULL,
	date_created DATE NULL
)

SELECT * FROM admin 

