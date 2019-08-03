
CREATE TABLE Tasks
  (
    id_task INT PRIMARY KEY IDENTITY (1, 1),
	cd_task VARCHAR(255) NOT NULL,
	title_task VARCHAR(255) NOT NULL,
	ds_task VARCHAR(255) NULL,
	status_task VARCHAR(255) NOT NULL,
	cd_user VARCHAR(255) NULL,
	createOnDate DATETIME,
	lastModifiedOnDate DATETIME
	
	
  );

