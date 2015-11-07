Create view V_Cars_Models as
select Distinct C.CAR_ID, C.Car_Model, M.Model_name, M.Model_ID
from Cars C 
Inner join Models M on (M.Car_ID=C.Car_ID)