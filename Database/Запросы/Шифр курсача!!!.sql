UPDATE Users
SET Name = CONVERT (varchar(64), HASHBYTES('MD5', Name), 2)

UPDATE Users
SET Password = CONVERT (varchar(64), HASHBYTES('MD5', Password), 2)

SELECT * FROM Users 

