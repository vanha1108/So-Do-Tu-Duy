CREATE DATABASE MindMap
Go

USE MindMap
GO

CREATE TABLE PROJECT(
	idProject int not null PRIMARY KEY,
	note varchar(255),
	img image	
);
GO

CREATE TABLE DRAWOBJ (
	idObj int not null PRIMARY KEY,
	idParent int not null,
	idProject int not null,

	FOREIGN KEY (idParent) REFERENCES DRAWOBJ(IdObj)
);
GO

ALTER TABLE PROJECT
ADD CONSTRAINT FK_PROJECT_DRAWOBJ
FOREIGN KEY (idProject) 
REFERENCES DRAWOBJ(IdObj)
GO