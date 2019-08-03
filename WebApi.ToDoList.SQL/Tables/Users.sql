
CREATE TABLE  Users
  (
	
	id_user INT PRIMARY KEY IDENTITY (1, 1),
	cd_user VARCHAR(255) NOT NULL,
	nm_user VARCHAR(255),
	ds_user VARCHAR(255),
	createOnDate DATE,
	lastModifiedOnDate DATE
	
	
  
  );

