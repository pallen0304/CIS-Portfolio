--List the names of pilots who have flown the most miles.
SELECT P.EMP_LNAME, P.EMP_FNAME, SUM(CHAR_DISTANCE) AS DISTANCE
FROM [DW].[PilotDimension] P INNER JOIN [DW].[Fact] F ON P.[PilotID] = F.[PilotID]
GROUP BY F.PilotID, P.EMP_LNAME, P.EMP_FNAME
HAVING SUM(CHAR_DISTANCE) = (SELECT TOP 1 SUM(CHAR_DISTANCE)
								FROM [DW].[PilotDimension] P INNER JOIN [DW].[Fact] F ON P.[PilotID] = F.[PilotID]
								GROUP BY F.PilotID, P.EMP_LNAME, P.EMP_FNAME
								ORDER BY SUM(CHAR_DISTANCE) DESC
								);
--List the revenue by model and month in ascending order.
SELECT P.EMP_LNAME, P.EMP_FNAME, T.CHAR_DATE, SUM(REVENUE) AS REVENUE
FROM [DW].[PilotDimension] P INNER JOIN [DW].[Fact] F ON P.[PilotID] = F.[PilotID]
	INNER JOIN [DW].[TimeDimension] T ON F.TimeID = T.TimeID
GROUP BY F.PilotID, F.TimeID, P.EMP_LNAME, P.EMP_FNAME, T.CHAR_DATE