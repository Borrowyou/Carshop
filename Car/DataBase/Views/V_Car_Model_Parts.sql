Create view V_Car_Model_Part
as
select C.Car_Model, M.Model_Name, P.Part_ID, P.Part_Name, P.Part_price, P.Part_details, P.Part_Manuf, C.Car_ID, M.Model_ID
from Cars C 
inner join Models M On (C.Car_ID=M.Car_ID)
inner join Parts P On (P.Model_ID=M.Model_ID)