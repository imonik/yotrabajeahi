﻿/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO Users (UserName, Email, [Password])
VALUES ('monik', 'mk.santb@gmail.com', '123')

INSERT INTO Users (UserName, Email, [Password])
VALUES ('fcmendoza', 'fcmendoza@gmail.com', '123')