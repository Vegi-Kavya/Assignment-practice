/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [TheaterId]
      ,[TheaterName]
      ,[TheaterCity]
      ,[MovieNames]
      ,[ListOfScreens]
      ,[ManagerName]
  FROM [MovieTicket].[dbo].[Tbl_Theater]
  select * from Tbl_Theater