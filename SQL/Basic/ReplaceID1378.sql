select unique_id, name
from Employees
left join EmployeeUNI USING (id);
